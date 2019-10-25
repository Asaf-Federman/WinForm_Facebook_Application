using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UI.Forms;




// $G$ THE-001 (-20) your grade on diagrams document - 80 please see comments inside the document. (50% of your grade).


namespace UI
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormFacebookLogin());
        }
    }
}
