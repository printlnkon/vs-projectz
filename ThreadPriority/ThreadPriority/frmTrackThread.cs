using System.Runtime.InteropServices;
using System.Threading;
namespace ThreadPriority
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Thread? threadA, threadB, threadC, threadD;

            Console.WriteLine("- Thread Starts -");

            threadA = new Thread(new ThreadStart(MyThreadClass.Thread1));

            threadB = new Thread(new ThreadStart(MyThreadClass.Thread2));

            threadC = new Thread(new ThreadStart(MyThreadClass.Thread1));

            threadD = new Thread(new ThreadStart(MyThreadClass.Thread2));

            threadA.Name = "Thread A Process";
            threadA.Priority = System.Threading.ThreadPriority.Highest;

            threadB.Name = "Thread B Process";
            threadB.Priority = System.Threading.ThreadPriority.Normal;

            threadC.Name = "Thread C Process";
            threadC.Priority = System.Threading.ThreadPriority.AboveNormal;

            threadD.Name = "Thread A Process";
            threadD.Priority = System.Threading.ThreadPriority.BelowNormal;

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            Console.WriteLine("- End of Thread -");
            lblName.Text = "- End of Thread -";
            lblName.AutoSize = true;
            lblName.Left = (this.ClientSize.Width - lblName.Width) / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

    }
}
