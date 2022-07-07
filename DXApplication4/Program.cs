using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.Xpo;
using SistemaLibreria;
using ModeloDatos.ORM;
using MySql.Data;
using SistemaLibreria.UIUI;
using SistemaLibreria.UI;

namespace SistemaLibreria.UIUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            XpoDefault.DataLayer = XpoDefault.GetDataLayer(
                 ConnectionHelper.ConnectionString,
                 DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login dlg = new Login();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new SistemaLibreria.UI.Principal());
            }
        } 
    }
}
