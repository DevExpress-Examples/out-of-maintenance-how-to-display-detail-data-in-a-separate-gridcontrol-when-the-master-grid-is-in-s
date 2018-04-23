using System;
using DevExpress.Xpo;
using DevExpress.Skins;
using DevExpress.Xpo.DB;
using System.Windows.Forms;

namespace Q248298 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SkinManager.EnableFormSkins();
            XpoDefault.ConnectionString = AccessConnectionProvider.GetConnectionString(@"..\..\nwind.mdb");
            Application.Run(new MainForm());
        }
    }
}