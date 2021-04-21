using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels; //for TCP
using System.Runtime.Remoting.Channels.Tcp;

namespace HelloRemotingServiceClient
{
    public partial class Form1 : Form
    {
        IHelloRemotingService.IHelloRemotingService client;
        public Form1()
        {
            InitializeComponent();
            TcpChannel tcpChannel = new TcpChannel();
            ChannelServices.RegisterChannel(tcpChannel);
            client = (IHelloRemotingService.IHelloRemotingService) Activator.GetObject(typeof(IHelloRemotingService.IHelloRemotingService),
                "tcp://localhost:8080/GetMessage"); //make sure to have the same port number
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text=  client.GetMessage(textBox1.Text);
        }
    }
}
