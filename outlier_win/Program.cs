using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;

namespace outlier_win
{
    static class Program
    {
        static bool? isTablet = null;
        public static bool IsTablet
        {
            get
            {
                if (isTablet == null)
                {
                    isTablet = Utils.DeviceDetector.IsTablet;
                }
                return isTablet.Value;
            }
        }

        public static MainForm MainForm
        {
            get;
            private set;
        }

        public static void SetupAsTablet()
        {
            MainForm.FormBorderStyle = FormBorderStyle.None;
            MainForm.WindowState = FormWindowState.Maximized;
            DevExpress.XtraEditors.WindowsFormsSettings.PopupMenuStyle = DevExpress.XtraEditors.Controls.PopupMenuStyle.RadialMenu;
            DevExpress.Utils.TouchHelpers.TouchKeyboardSupport.EnableTouchKeyboard = true;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                DateTime dt = Utils.InternetDateTime.GetCurrentTime();

                if (dt > new DateTime(2018, 10, 31))
                {
                    MessageBox.Show("试用期已过，谢谢。");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("获取试用时间出错，请检查Internet连接。\n" + ex.Message);
                return;
            }

            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();

            DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins();
            DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = DevExpress.XtraEditors.ScrollUIMode.Touch;

            //float fontSize = 11f;
            //DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new System.Drawing.Font("Segoe UI", fontSize);
            //DevExpress.XtraEditors.WindowsFormsSettings.DefaultMenuFont = new System.Drawing.Font("Segoe UI", fontSize);



            MainForm = new MainForm();

            if (Program.IsTablet)
            {
                //SetupAsTablet();
            }
            Application.Run(MainForm);
        }

        private static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            try
            {
                return Utils.DllLoader.LoadDll(args.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载DLL出错，请重新安装程序。\n" + ex.Message);
                return null;
            }
        }
    }
}
