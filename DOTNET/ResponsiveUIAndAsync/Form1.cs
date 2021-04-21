using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResponsiveUIAndAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Approach 1
        //private void btnProcessFile_Click(object sender, EventArgs e)

        //Approach 2
        //using async keyworkto make the program wait until the count character method has executed.
        private async void btnProcessFile_ClickAsync(object sender, EventArgs e)

        //Approach 3
        //private void btnProcessFile_ClickAsync(object sender, EventArgs e)
        {
            // Approach 1
            //int count = 0;
            //lblCharCount.Text = "Processing File ...";
            //count = CountCharacters();
            //lblCharCount.Text = "File processed and total number of characters are " + count.ToString();

            /*
             * There are two issue with the above approach 1
             * 1. The UI will be blocked and we will not be able to resize the window.
             * 2. The first status method will not appear.*
             */

            // Approach 2 - using the task with async and await keyword
            int count = 0;
            Task<int> myTask = new Task<int>(CountCharacters);
            lblCharCount.Text = "Processing File ...";
            myTask.Start();
            count = await myTask;
            lblCharCount.Text = "FIle processed. Total number of characters in the files are: " + count.ToString();

            //Aproach 3 - using thread
            //int count = 0;
            //Thread T = new Thread(() =>
            //{
            //    count = CountCharacters();
            //    //the below line is unethical. it will work in this case , but it just a blind luck.
            //    // this will also give a runtime exception saying that cross thread operations are not valid
            //    //lblCharCount.Text = "FIle processed. Total number of characters in the files are: " + count.ToString();

            //});
            //lblCharCount.Text = "Processing File ...";
            //T.Start();

            //T.Join();
            //lblCharCount.Text = "FIle processed. Total number of characters in the files are: " + count.ToString();

            /*
             * the approach 3 causes the main thread to wait until the thread T is completed.
             * The blocking of main thread cause UI to be unresponsive as Main thread is the one handlng the UI.
             * 
             * We can however make it may be working using the below code snippet, but it is not advisable as,
             * the basic rule of thumb is to make sure a thread is modifying its own properties not the properties of
             * a diferent thread. This is just easy to debug and and a good programming practice.
             * 
             * Hence the Aproach 2 is the best approach. Task must be while dealing with asynchronous activities.
             */

        }


        private int CountCharacters()
        {
            int count = 0;
            using (StreamReader sr = new StreamReader(@"D:\GitHUB\Practice\DOTNET\ResponsiveUIAndAsync\Test\Data.txt"))
            {
                string content = sr.ReadToEnd();
                count = content.Length;
                Thread.Sleep(10000);
            }
            return count;
        }
    }
}
