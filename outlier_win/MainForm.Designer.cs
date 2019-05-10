namespace outlier_win
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnOpen = new DevExpress.XtraBars.BarButtonItem();
            this.btnPaste = new DevExpress.XtraBars.BarButtonItem();
            this.btnCheck = new DevExpress.XtraBars.BarButtonItem();
            this.btnDic = new DevExpress.XtraBars.BarButtonItem();
            this.btnMarkSettings = new DevExpress.XtraBars.BarButtonItem();
            this.btnHelp = new DevExpress.XtraBars.BarButtonItem();
            this.btnAbout = new DevExpress.XtraBars.BarButtonItem();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.btnClear = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::outlier_win.WaitForm1), true, true);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.memoSource = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblDic = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblResult = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoSource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnOpen,
            this.btnPaste,
            this.btnCheck,
            this.btnDic,
            this.btnMarkSettings,
            this.btnHelp,
            this.btnAbout,
            this.barListItem1,
            this.btnClear});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(893, 147);
            // 
            // btnOpen
            // 
            this.btnOpen.Caption = "Open";
            this.btnOpen.Id = 1;
            this.btnOpen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.ImageOptions.Image")));
            this.btnOpen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOpen.ImageOptions.LargeImage")));
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOpen_ItemClick);
            // 
            // btnPaste
            // 
            this.btnPaste.Caption = "Paste";
            this.btnPaste.Id = 2;
            this.btnPaste.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPaste.ImageOptions.Image")));
            this.btnPaste.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPaste.ImageOptions.LargeImage")));
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPaste_ItemClick);
            // 
            // btnCheck
            // 
            this.btnCheck.Caption = "Check";
            this.btnCheck.Id = 3;
            this.btnCheck.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCheck.ImageOptions.Image")));
            this.btnCheck.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCheck.ImageOptions.LargeImage")));
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCheck_ItemClick);
            // 
            // btnDic
            // 
            this.btnDic.Caption = "Add Dictrioary";
            this.btnDic.Id = 4;
            this.btnDic.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDic.ImageOptions.Image")));
            this.btnDic.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDic.ImageOptions.LargeImage")));
            this.btnDic.Name = "btnDic";
            this.btnDic.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnDic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDic_ItemClick);
            // 
            // btnMarkSettings
            // 
            this.btnMarkSettings.Caption = "Mark";
            this.btnMarkSettings.Id = 5;
            this.btnMarkSettings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMarkSettings.ImageOptions.Image")));
            this.btnMarkSettings.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMarkSettings.ImageOptions.LargeImage")));
            this.btnMarkSettings.Name = "btnMarkSettings";
            this.btnMarkSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMarkSettings_ItemClick);
            // 
            // btnHelp
            // 
            this.btnHelp.Caption = "Help";
            this.btnHelp.Id = 6;
            this.btnHelp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.ImageOptions.Image")));
            this.btnHelp.Name = "btnHelp";
            // 
            // btnAbout
            // 
            this.btnAbout.Caption = "About";
            this.btnAbout.Id = 7;
            this.btnAbout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.ImageOptions.Image")));
            this.btnAbout.Name = "btnAbout";
            // 
            // barListItem1
            // 
            this.barListItem1.Caption = "barListItem1";
            this.barListItem1.Id = 8;
            this.barListItem1.Name = "barListItem1";
            // 
            // btnClear
            // 
            this.btnClear.Caption = "Clear";
            this.btnClear.Id = 9;
            this.btnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.Image")));
            this.btnClear.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.LargeImage")));
            this.btnClear.Name = "btnClear";
            this.btnClear.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClear_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "HOME";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnOpen);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPaste);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnClear);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "File && Edit";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCheck);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDic);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Check";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "SETTINGS";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnMarkSettings);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Settings";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnHelp);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnAbout);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Help";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 147);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.memoSource);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.webBrowser);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(893, 433);
            this.splitContainerControl1.SplitterPosition = 431;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // memoSource
            // 
            this.memoSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoSource.Location = new System.Drawing.Point(5, 85);
            this.memoSource.Margin = new System.Windows.Forms.Padding(10);
            this.memoSource.MenuManager = this.ribbonControl1;
            this.memoSource.Name = "memoSource";
            this.memoSource.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.memoSource.Properties.Appearance.Options.UseFont = true;
            this.memoSource.Size = new System.Drawing.Size(422, 343);
            this.memoSource.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.lblDic);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(5, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelControl1.Size = new System.Drawing.Size(422, 80);
            this.panelControl1.TabIndex = 0;
            // 
            // lblDic
            // 
            this.lblDic.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblDic.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.lblDic.Appearance.Options.UseFont = true;
            this.lblDic.Appearance.Options.UseForeColor = true;
            this.lblDic.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDic.Location = new System.Drawing.Point(0, 29);
            this.lblDic.Name = "lblDic";
            this.lblDic.Size = new System.Drawing.Size(422, 41);
            this.lblDic.TabIndex = 2;
            this.lblDic.Text = "[lblDic]";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Dictionaries:";
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(5, 85);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(446, 343);
            this.webBrowser.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.lblResult);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(5, 5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 12);
            this.panelControl2.Size = new System.Drawing.Size(446, 80);
            this.panelControl2.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.panelControl3.Appearance.BackColor2 = System.Drawing.Color.Crimson;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Location = new System.Drawing.Point(59, 9);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(20, 20);
            this.panelControl3.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(0, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Outlier";
            // 
            // lblResult
            // 
            this.lblResult.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblResult.Appearance.Options.UseFont = true;
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblResult.Location = new System.Drawing.Point(0, 49);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 19);
            this.lblResult.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 580);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OUTLIER CHECKER";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoSource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnOpen;
        private DevExpress.XtraBars.BarButtonItem btnPaste;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnCheck;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnDic;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.MemoEdit memoSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblResult;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.WebBrowser webBrowser;
        private DevExpress.XtraBars.BarButtonItem btnMarkSettings;
        private DevExpress.XtraBars.BarButtonItem btnHelp;
        private DevExpress.XtraBars.BarButtonItem btnAbout;
        private DevExpress.XtraBars.BarListItem barListItem1;
        private DevExpress.XtraBars.BarButtonItem btnClear;
        private DevExpress.XtraEditors.LabelControl lblDic;
    }
}

