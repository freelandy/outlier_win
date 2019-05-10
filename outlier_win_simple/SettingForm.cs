using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace outlier_win_simple
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            this.chkComparativesAndSuperlatives.Checked = bool.Parse(Utils.ConfigurationMgr.ReadAppSettings("markComparativesAndSuperlatives"));
            this.chkNumbers.Checked = bool.Parse(Utils.ConfigurationMgr.ReadAppSettings("markCardinalNumbers"));
            //this.chkPunctuations.Checked = bool.Parse(Utils.ConfigurationMgr.ReadAppSettings("markPunctuations"));
            this.chkStopwords.Checked = bool.Parse(Utils.ConfigurationMgr.ReadAppSettings("markStopwords"));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.btnApply_Click(sender, e);
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Utils.ConfigurationMgr.WriteAppSettings("markComparativesAndSuperlatives", this.chkComparativesAndSuperlatives.Checked.ToString());
            Utils.ConfigurationMgr.WriteAppSettings("markCardinalNumbers", this.chkNumbers.Checked.ToString());
            //Utils.ConfigurationMgr.WriteAppSettings("markPunctuations", this.chkPunctuations.Checked.ToString());
            Utils.ConfigurationMgr.WriteAppSettings("markStopwords", this.chkStopwords.Checked.ToString());

            MainForm mainForm = (MainForm)this.Owner;
            mainForm.CardinalNumberMarking = this.chkNumbers.Checked;
            mainForm.ComparativeMarking = this.chkComparativesAndSuperlatives.Checked;
            mainForm.SuperlativeMarking = this.chkComparativesAndSuperlatives.Checked;
            //mainForm.PunctuationMarking = this.chkPunctuations.Checked;
            mainForm.StopwordMarking = this.chkStopwords.Checked;

            mainForm.ApplySettings();
        }
    }
}