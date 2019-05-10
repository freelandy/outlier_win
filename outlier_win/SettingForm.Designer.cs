namespace outlier_win
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkStopwords = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chkComparativesAndSuperlatives = new DevExpress.XtraEditors.CheckEdit();
            this.chkNumbers = new DevExpress.XtraEditors.CheckEdit();
            this.chkPunctuations = new DevExpress.XtraEditors.CheckEdit();
            this.btnApply = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.chkStopwords.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkComparativesAndSuperlatives.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNumbers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPunctuations.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chkStopwords
            // 
            this.chkStopwords.Location = new System.Drawing.Point(17, 47);
            this.chkStopwords.Name = "chkStopwords";
            this.chkStopwords.Properties.Caption = "Mark stopwords";
            this.chkStopwords.Size = new System.Drawing.Size(121, 19);
            this.chkStopwords.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chkComparativesAndSuperlatives);
            this.groupControl1.Controls.Add(this.chkNumbers);
            this.groupControl1.Controls.Add(this.chkPunctuations);
            this.groupControl1.Controls.Add(this.chkStopwords);
            this.groupControl1.Location = new System.Drawing.Point(12, 75);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(477, 180);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Mark";
            // 
            // chkComparativesAndSuperlatives
            // 
            this.chkComparativesAndSuperlatives.EditValue = true;
            this.chkComparativesAndSuperlatives.Location = new System.Drawing.Point(17, 131);
            this.chkComparativesAndSuperlatives.Name = "chkComparativesAndSuperlatives";
            this.chkComparativesAndSuperlatives.Properties.Caption = "Mark comparatives && superlatives";
            this.chkComparativesAndSuperlatives.Size = new System.Drawing.Size(206, 19);
            this.chkComparativesAndSuperlatives.TabIndex = 3;
            // 
            // chkNumbers
            // 
            this.chkNumbers.Location = new System.Drawing.Point(17, 89);
            this.chkNumbers.Name = "chkNumbers";
            this.chkNumbers.Properties.Caption = "Mark cardinal numbers";
            this.chkNumbers.Size = new System.Drawing.Size(149, 19);
            this.chkNumbers.TabIndex = 2;
            // 
            // chkPunctuations
            // 
            this.chkPunctuations.Location = new System.Drawing.Point(249, 47);
            this.chkPunctuations.Name = "chkPunctuations";
            this.chkPunctuations.Properties.Caption = "Mark punctuations";
            this.chkPunctuations.Size = new System.Drawing.Size(121, 19);
            this.chkPunctuations.TabIndex = 1;
            this.chkPunctuations.Visible = false;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(307, 274);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(414, 274);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 315);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkStopwords.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkComparativesAndSuperlatives.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNumbers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPunctuations.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit chkStopwords;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit chkPunctuations;
        private DevExpress.XtraEditors.CheckEdit chkNumbers;
        private DevExpress.XtraEditors.CheckEdit chkComparativesAndSuperlatives;
        private DevExpress.XtraEditors.SimpleButton btnApply;
        private DevExpress.XtraEditors.SimpleButton btnOK;
    }
}