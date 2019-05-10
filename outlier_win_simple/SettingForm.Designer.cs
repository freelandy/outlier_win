namespace outlier_win_simple
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkComparativesAndSuperlatives = new System.Windows.Forms.CheckBox();
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.chkStopwords = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 80);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkComparativesAndSuperlatives);
            this.groupBox1.Controls.Add(this.chkNumbers);
            this.groupBox1.Controls.Add(this.chkStopwords);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 183);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mark";
            // 
            // chkComparativesAndSuperlatives
            // 
            this.chkComparativesAndSuperlatives.AutoSize = true;
            this.chkComparativesAndSuperlatives.Checked = true;
            this.chkComparativesAndSuperlatives.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkComparativesAndSuperlatives.Location = new System.Drawing.Point(28, 101);
            this.chkComparativesAndSuperlatives.Name = "chkComparativesAndSuperlatives";
            this.chkComparativesAndSuperlatives.Size = new System.Drawing.Size(216, 16);
            this.chkComparativesAndSuperlatives.TabIndex = 2;
            this.chkComparativesAndSuperlatives.Text = "Mark comparatives && superlatives";
            this.chkComparativesAndSuperlatives.UseVisualStyleBackColor = true;
            // 
            // chkNumbers
            // 
            this.chkNumbers.AutoSize = true;
            this.chkNumbers.Location = new System.Drawing.Point(28, 66);
            this.chkNumbers.Name = "chkNumbers";
            this.chkNumbers.Size = new System.Drawing.Size(150, 16);
            this.chkNumbers.TabIndex = 1;
            this.chkNumbers.Text = "Mark cardinal numbers";
            this.chkNumbers.UseVisualStyleBackColor = true;
            // 
            // chkStopwords
            // 
            this.chkStopwords.AutoSize = true;
            this.chkStopwords.Location = new System.Drawing.Point(28, 31);
            this.chkStopwords.Name = "chkStopwords";
            this.chkStopwords.Size = new System.Drawing.Size(108, 16);
            this.chkStopwords.TabIndex = 0;
            this.chkStopwords.Text = "Mark stopwords";
            this.chkStopwords.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(309, 283);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 314);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingForm";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkStopwords;
        private System.Windows.Forms.CheckBox chkComparativesAndSuperlatives;
        private System.Windows.Forms.CheckBox chkNumbers;
        private System.Windows.Forms.Button btnOK;
    }
}