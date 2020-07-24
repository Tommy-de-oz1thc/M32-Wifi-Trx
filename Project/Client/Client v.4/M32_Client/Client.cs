using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;

namespace M32_Client
{
    public partial class Client : Form
    {
        private int recv;
        private static Mopp mopp = new Mopp();
        int receiverPort = 7373;
        Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
ProtocolType.Udp);
        private string ip;
        private IPEndPoint sender; 
        private EndPoint Remote;
        private Thread run_Client;
        private UdpClient udpClient = new UdpClient();
        public Client()
        {
            InitializeComponent();
            ip = comboIpAddress.Text;
            sender = new IPEndPoint(IPAddress.Parse(ip), 7373);
            
            Remote = (EndPoint)(sender);
            run_Client = new Thread(new ThreadStart(ListenToData));
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
           
            try
            {

                udpClient.Connect(ip, 7373);
                run_Client.Start();
                //This constructor arbitrarily assigns the local port number.

               

                txtStatusText.Text += "Waiting for Connect...\r\n";

                // Sends a message to the host to which you have connected.
                byte[] SentBytes = mopp.Sent_Mopp_Word("try to connect");
                newsock.SendTo(SentBytes, SentBytes.Length, SocketFlags.None, Remote);


                //IPEndPoint object will allow us to read datagrams sent from any source.







            }
            catch 
            {
                
            }
        }

        private void btnDisConnect_Click(object sender, EventArgs e)
        {
            
            udpClient.Close();
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            run_Client.Abort();
            udpClient.Close();
            Application.Exit();

        }

        private void btnSent_Click(object sender, EventArgs e)
        {

            string sentText = "";
            
            sentText = txtSent.Text;
            if (sentText != "")
            {
                AppendTextBox("Client: " + sentText + "\r\n");
              
                txtSent.Text = "";
                sentText = sentText.Replace("<kn>", "$");
                sentText = sentText.Replace("<sk", "@");
                //This code is for testing the sent up it is Mopp correct
                string[] s = sentText.Split(' ');
                string send = "";
                foreach (var w in s)
                {
                    byte[] SentBytes = mopp.Sent_Mopp_Word(w);
                    newsock.SendTo(SentBytes, SentBytes.Length, SocketFlags.None, Remote);
                    string read = mopp.Read_Mopp_Word(SentBytes);
                   // send += read + "\r\n";
                }
             // txtStatusText.Text +="Client: " + send + "\r\n";
            }
            else
            {
                MessageBox.Show("You can not sent a emty text!");
            }
        }

        private void ListenToData()
        {
            byte[] data = new byte[1024];
            string text_r = "";
            string read = "";
            while (true)
            {
                try
                {
                    data = new byte[1024];
                    read = "";
                    recv = newsock.ReceiveFrom(data, ref Remote);
                    read = mopp.Read_Mopp_Word(data);

                    text_r +=  read + " ";
                    
                    // Uses the IPEndPoint object to determine which of these two hosts responded.
                    if ((read == "<kn>")||(read=="k")||(read=="<sk>"))
                    {
                        AppendTextBox("Server: " + text_r + "\r\n");
                        text_r = "";
                    }
                }
                catch
                {
                    int tal = 0;
                }
            }
        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            txtStatusText.Text =  value + txtStatusText.Text;
        }

    }
}



