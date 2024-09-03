using System;
using System.IO;
using System.Windows.Forms;

namespace Payazob
{
    static class Program
    {
        static System.Threading.Mutex _mutex = new System.Threading.Mutex(false, "payazob");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static int selectindexnamedevice = 0;
        public static int selectindexnodevice = 0;
        public static int selectindexnameset1 = 0;
        public static int selectindexnameset2 = 0;
        public static int selectindexnameobject = 0;
        public static int selectindexnamelocation = 0;
        public static int selectedindexset3 = 0;
        [STAThread]
        static void Main()
        {
  


                if (!_mutex.WaitOne(1000, false))
                {
                    MessageBox.Show("نرم افزار هم اکنون در حال اجرا می باشد", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                frmLogin frm = new frmLogin();
                frm.ShowDialog();
                if (frm.EnterSuccess)
                {
                    // new FRM.ExitPermit.frmExitPermit("MN").ShowDialog(); 
                    //crsPerFoodToken
                    Application.Run(new Main());
                }
            
        }

    }
}
