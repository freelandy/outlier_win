namespace outlier_win
{
    partial class SelectDictionaryForm
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
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.checkedListBoxControl = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(344, 301);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // checkedListBoxControl
            // 
            this.checkedListBoxControl.CheckOnClick = true;
            this.checkedListBoxControl.Location = new System.Drawing.Point(12, 49);
            this.checkedListBoxControl.Name = "checkedListBoxControl";
            this.checkedListBoxControl.Size = new System.Drawing.Size(407, 231);
            this.checkedListBoxControl.TabIndex = 2;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(12, 301);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 4;
            this.btnSelectAll.Text = "Select all";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // SelectDictionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 336);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.checkedListBoxControl);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectDictionaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select dictionarys";
            this.Load += new System.EventHandler(this.SelectDictionaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControl;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll;
    }
}