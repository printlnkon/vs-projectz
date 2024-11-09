using FrmBasicThread;
using System.Runtime.InteropServices;

namespace BasicThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread? ThreadA, ThreadB;

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("- Before Starting Thread -");
            ThreadStart threadStart = new ThreadStart(MyThreadClass.Thread1);
            ThreadA = new Thread(threadStart);
            ThreadA.Name = "Thread A Process";

            ThreadB = new Thread(threadStart);
            ThreadB.Name = "Thread B Process";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            lblName.Text = "- End of Thread -";
            Console.WriteLine("- End of Thread -");
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
