using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlier;

namespace outlier_win_simple
{
    public partial class SelectDictionaryForm : Form
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

            foreach (string s in dics)
            {
                bool itemCheked = this.UserDictionary.Contains(s);
                this.checkedListBox1.Items.Add(s, itemCheked);
            }
        } 
        
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string dic = string.Empty;
            foreach (object item in this.checkedListBox1.CheckedItems)
            {
                dic += (item.ToString() + ";");
            }

            dic = dic.Length == 0 ? string.Empty : dic.Substring(0, dic.Length - 1); // remove ; at tail

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