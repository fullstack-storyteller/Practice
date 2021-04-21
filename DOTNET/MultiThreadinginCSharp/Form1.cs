using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadinginCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoTimeConsumingWork_Click(object sender, EventArgs e)
        {
            btnDoTimeConsumingWork.Enabled = false;
            btnPrintNumbers.Enabled = false;
            //DoTimeConsumingWork(); //calling this long timetaking method in main thread
            //causes the UI to be unresponsive.
            //Hence we are going to call it in its own thread.

            Thread workerThread = new Thread(DoTimeConsumingWork);
            workerThread.Start(); // Thus the job of doing this time consuming task is now offloaded to a worker thread.

            btnDoTimeConsumingWork.Enabled = true;
            btnPrintNumbers.Enabled = true;
        }

        private void DoTimeConsumingWork()
        {
            Thread.Sleep(5000);
        }
        private void PrintNumber()
        {
            listBoxNumbers.Items.Clear();
            for (int i = 0; i < 20; i++)
                listBoxNumbers.Items.Add((i + 1).ToString());
        }

        private void btnPrintNumbers_Click(object sender, EventArgs e)
        {
            PrintNumber();
        }
    }
}
