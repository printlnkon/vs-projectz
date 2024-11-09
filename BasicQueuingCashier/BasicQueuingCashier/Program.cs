using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new QueuingForm());

            QueuingForm QF = new QueuingForm();
            CashierWindowQueueForm cwqf = new CashierWindowQueueForm();
            QF.Show();
            cwqf.Show();
            Application.Run();

            //var qf = new QueuingForm();
            //var cwqf = new CashierWindowQueueForm();
            //qf.Show();
            //Application.Run(cwqf);
        }
    }
}
