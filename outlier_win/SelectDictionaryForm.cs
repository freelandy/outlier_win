using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Outlier;

namespace outlier_win
{
    public partial class SelectDictionaryForm : DevExpress.XtraEditors.XtraForm
    {
        public List<string> UserDictionary = new List<string>();

        public SelectDictionaryForm()
        {
            InitializeComponent();
        }

        private void SelectDictionaryForm_Load(object sender, EventArgs e)
        {
            Processor p = new Processor();
            List<string> dics = p.GetDictionaryNames();

            foreach(string s in dics)
            {
                DevExpress.XtraEditors.Controls.CheckedListBoxItem item = new DevExpress.XtraEditors.Controls.CheckedListBoxItem();
                item.Value = s;  
                if(this.UserDictionary.Contains(s))
                {
                    item.CheckState = CheckState.Checked;
                }

                this.checkedListBoxControl.Items.Add(item);
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            this.checkedListBoxControl.SelectAll();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string dic = string.Empty;
            foreach(DevExpress.XtraEditors.Controls.CheckedListBoxItem item in this.checkedListBoxControl.Items)
            {
                if(item.CheckState == CheckState.Checked)
                {
                    dic += (item.Value + ";");
                }
            }

            dic = dic.Length == 0 ? string.Empty: dic.Substring(0, dic.Length - 1); // remove ; at tail

            // save
            Utils.ConfigurationMgr.WriteAppSettings("userDictionary", dic);

            // show in main form
            MainForm mainForm = (MainForm)this.Owner;
            mainForm.UserDictionaryNames = dic.Split(new char[] { ';' }).ToList<string>();
            mainForm.ApplyDictionary();

            this.Close();
        }
    }
}