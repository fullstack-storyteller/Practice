using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueRealTimeExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPrintToken_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "There are " + QueueToken.TokenQueue.Count + " customers before you in the queue.";
            QueueToken.LastToken += 1;
            QueueToken.TokenQueue.Enqueue(QueueToken.LastToken);
            AddItemsToTheListBox();



        }
        private void AddItemsToTheListBox()
        {
            listBoxCustomerQueue.Items.Clear();
            foreach (int i in QueueToken.TokenQueue)
            {
                listBoxCustomerQueue.Items.Add(i.ToString());
            }
        }

        private void buttonCounter1_Click(object sender, EventArgs e)
        {
            ServeCustomer(textCounter1, 1);
        }

        private void ServeCustomer(TextBox TxtBox, int CounterNum)
        {
            int CurrentFirstToken;
            if (QueueToken.TokenQueue.Count == 0)
            {
                TxtBox.Text = "No Customer is in the queue";
                lblMessage.Text = "No Customer is in the queue";
                lblStatus.Text = "";
            }
            else
            {
                CurrentFirstToken = QueueToken.TokenQueue.Dequeue();
                TxtBox.Text = CurrentFirstToken.ToString();
                lblStatus.Text = "Token #" + CurrentFirstToken + ", please go to counter #"+CounterNum.ToString();
                AddItemsToTheListBox();
                lblMessage.Text = "Currently serving Customer Token #" + CurrentFirstToken + " at Counter #"+CounterNum.ToString();
                lblMessage.Text += "\nPlease Click on Print Token button to generate your new token.";
            }
        }

        private void buttonCounter2_Click(object sender, EventArgs e)
        {
            ServeCustomer(textCounter2, 2);
        }

        private void buttonCounter3_Click(object sender, EventArgs e)
        {
            ServeCustomer(textCounter3, 3);
        }
    }
}
