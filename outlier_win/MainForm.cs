using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Outlier;
using System.Text.RegularExpressions;

namespace outlier_win
{
    public partial class MainForm : BaseForm
    {
        private Processor processor;
        private int numOutliers = 0;
        public List<string> UserDictionaryNames = new List<string>();

        // 标记配置
        public bool StopwordMarking { set; get; } = false; // I, is, to, the, ...
        public bool PunctuationMarking { set; get; } = false; // ,, ., ?, ...
        public bool CardinalNumberMarking { set; get; } = false; // 120, 11,000, twenty-four
        public bool ComparativeMarking { set; get; } = false; // shorter
        public bool SuperlativeMarking { set; get; } = false; // shortest
        public bool AbbreviationMarking { set; get; } = false; // I'd, don't, you're, ...


        private string templateFilePath = "template\\result_template.html";
        private string templatePlaceHolderString = "[[placeholder]]";

        public MainForm()
        {
            InitializeComponent();

            BaseForm.defaultLookAndFeel.LookAndFeel.SkinName = "Visual Studio 2013 Light";

            try
            {
                this.processor = new Processor();
            }
            catch(Exception ex)
            {
                MessageBox.Show("加载字典文件出错，请检查edu文件夹。\n" + ex.Message);
                Application.Exit();
            }

            this.processor.ComparativeMarking = false;
            this.processor.SuperlativeMarking = false;
        }


        private void InitializeControl()
        {
            
        }

        private void btnCheck_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(this.memoSource.EditValue == null || this.memoSource.EditValue.ToString().Trim() == string.Empty)
            {
                return;
            }

            this.splashScreenManager1.ShowWaitForm();


            

            HashSet<string> words = this.processor.Process(this.memoSource.EditValue.ToString());

            // render results
            this.numOutliers = words.Count;
            this.webBrowser.DocumentText = this.RenderResultText(this.memoSource.EditValue.ToString(), words);
            this.lblResult.Text = this.numOutliers.ToString() + " instances w/o case ignored.";

            this.splashScreenManager1.CloseWaitForm();
        }





        private string RenderResultText(string sourceText, HashSet<string> words)
        {
            string htmlText = this.templatePlaceHolderString;
            if (System.IO.File.Exists(this.templateFilePath))
            {
                htmlText = System.IO.File.ReadAllText(this.templateFilePath, Encoding.UTF8);
            }

            string temp = sourceText;
            temp = temp.Replace("\r\n", "<br />");

            foreach (string w in words)
            {
                string pattern = string.Format(@"\b{0}\b", w);
                temp = Regex.Replace(temp, pattern, "<span style='color:Crimson'>" + w + "</span>", RegexOptions.None);
            }

            htmlText = htmlText.Replace(this.templatePlaceHolderString, temp);

            return htmlText;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // read in local dictionaries
            string configValue = Utils.ConfigurationMgr.ReadAppSettings("userDictionary");
            this.UserDictionaryNames = configValue.Split(new char[] { ';' }).ToList<string>();
            this.ApplyDictionary();

            // read in configurations
            this.ComparativeMarking = bool.Parse(Utils.ConfigurationMgr.ReadAppSettings("markComparativesAndSuperlatives"));
            this.SuperlativeMarking = bool.Parse(Utils.ConfigurationMgr.ReadAppSettings("markComparativesAndSuperlatives"));
            this.CardinalNumberMarking = bool.Parse(Utils.ConfigurationMgr.ReadAppSettings("markCardinalNumbers"));
            this.PunctuationMarking = bool.Parse(Utils.ConfigurationMgr.ReadAppSettings("markPunctuations"));
            this.StopwordMarking = bool.Parse(Utils.ConfigurationMgr.ReadAppSettings("markStopwords"));

            this.ApplySettings();
        }

        private void btnMarkSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.Owner = this;
            settingForm.ShowDialog();
        }

        private void btnDic_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SelectDictionaryForm dicForm = new SelectDictionaryForm();
            dicForm.Owner = this;
            dicForm.UserDictionary = this.UserDictionaryNames;

            dicForm.ShowDialog();
        }

        public void ApplySettings()
        {
            this.processor.AbbreviationMarking = this.AbbreviationMarking;
            this.processor.CardinalNumberMarking = this.CardinalNumberMarking;
            this.processor.ComparativeMarking = this.ComparativeMarking;
            this.processor.SuperlativeMarking = this.SuperlativeMarking;
            this.processor.PunctuationMarking = this.PunctuationMarking;
            this.processor.StopwordMarking = this.StopwordMarking;
        }

        public void ApplyDictionary()
        {
            string dic = string.Empty;
            for(int i=0;i<this.UserDictionaryNames.Count;i++)
            {
                dic += (this.UserDictionaryNames[i] + ";");
            }
            dic = dic.Length == 0 ? string.Empty : dic.Substring(0, dic.Length - 1); // remove ; at tail
            this.lblDic.Text = dic;

            this.processor.UserDictionaryNames = this.UserDictionaryNames;
            this.processor.InitializeUserDictionary();
        }

        private void btnClear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.memoSource.EditValue = string.Empty;
            this.webBrowser.DocumentText = string.Empty;
            this.lblResult.Text = string.Empty;
        }

        private void btnPaste_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Declares an IDataObject to hold the data returned from the clipboard.
            // Retrieves the data from the clipboard.
            IDataObject iData = Clipboard.GetDataObject();

            // Determines whether the data is in a format you can use.
            if (iData.GetDataPresent(DataFormats.Text))
            {
                // Yes it is, so display it in a text box.
                this.btnClear_ItemClick(sender, null);
                this.memoSource.EditValue = (String)iData.GetData(DataFormats.Text);
            }
        }

        private void btnOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Environment.CurrentDirectory;
            dlg.Filter = "文本文件（*.txt） | *.txt";
            if(dlg.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
