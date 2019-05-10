using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace outlier_win_simple
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
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
            catch (Exception ex)
            {
                MessageBox.Show("获取试用时间出错，请检查Internet连接。\n" + ex.Message);
                return;
            }

            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainForm());
        }

        private static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            try
            {
                return Utils.DllLoader.LoadDll(args.Name);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("加载DLL出错，请重新安装程序。\n" + ex.Message);
                return null;
            }
        }
    }
}
