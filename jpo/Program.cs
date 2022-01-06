using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jpo
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmJPO());
        }

        public static string dbPatch = @"..\..\..\..\jpo.accdb";

        public static void WriteError(string msg, string Infor)
        {
            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter("ErrorLog.txt", true);
                file.WriteLine(">>> " + DateTime.Now.ToString() + " INFOR: [" + Infor + "]\n{");
                file.WriteLine(msg);
                file.WriteLine("}\n\n");
                file.Close();
            }
            catch { }
        }
       
       
    }
}
