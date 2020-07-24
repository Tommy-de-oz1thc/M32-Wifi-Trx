using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using M32_Server.Bots;


namespace M32_Server
{
    public partial class Server : Form
    {
        private int recv;
        private byte[] data = new byte[1024];
        private Mopp mopp = new Mopp();
        private IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 7373);

        private Socket newsock = new Socket(AddressFamily.InterNetwork,
                        SocketType.Dgram, ProtocolType.Udp);
        private IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
        private EndPoint Remote;
        private Thread run_Server;
        private bool isConnected = false;
        private string m32_call = "oz1thc";
   
      
        string status_text = "";
        private static Bots.Bots bots;
        public Server()
        {
            InitializeComponent();
            run_Server = new Thread(new ThreadStart(Start_Server));
           

        }

       

        private void Start_Server()
        {
            
           
            AppendTextBox("Waiting for a client...\r\n");
            try
            {
                newsock.Bind(ipep);
                Remote = (EndPoint)(sender);
               
                
            }
            catch { }
            Loop_Start();
          
        }
        
        private void Loop_Start()
        {
            bots = new Bots.Bots();
            while (true)
            {
                data = new byte[1024];
                string read = "";
                recv = newsock.ReceiveFrom(data, ref Remote);
                read = mopp.Read_Mopp_Word(data);
                
                if (read == "qrl?")
                {
                    AppendTextBox("M32: " + read + "\r\n");
                    string text = "k";
                    string[] sent = text.Split(' ');
                    foreach (var t in sent)
                    {
                        data = mopp.Sent_Mopp_Word(t);
                        newsock.SendTo(data, data.Length, SocketFlags.None, Remote);
                    }
                    AppendTextBox("Server: " + text + "\r\n");
                    
                    Loop_Bots();
                    break;
                }
                else if (read == "echo?")
                {
                    AppendTextBox("M32: " + read + "\r\n");
                    string text = "k";
                    string[] sent = text.Split(' ');
                    foreach (var t in sent)
                    {
                        data = mopp.Sent_Mopp_Word(t);
                        newsock.SendTo(data, data.Length, SocketFlags.None, Remote);
                    }
                    AppendTextBox("Server: " + text + "\r\n");

                    Loop_Repeat();
                    break;
                }
                else if (read == "talk?")
                {
                    AppendTextBox("M32: " + read + "\r\n");
                    string text = "k";
                    string[] sent = text.Split(' ');
                    foreach (var t in sent)
                    {
                        data = mopp.Sent_Mopp_Word(t);
                        newsock.SendTo(data, data.Length, SocketFlags.None, Remote);
                    }
                    AppendTextBox("Server: " + text + "\r\n");

                    Loop_Small_Talk();
                    break;
                }

            }
        }
        private string Get_CQ_Call()
        {
            string read = "";
            string read_tx = "";
            string response = "";
            

            while (true)
            {

                data = new byte[1024];
                read = "";
                recv = newsock.ReceiveFrom(data, ref Remote);
                read = mopp.Read_Mopp_Word(data);
                if ((read != "k")&&(read!="<sk>"))
                {
                    if (read == "*")
                    {
                        read_tx = read_tx.Trim();
                        for (var a = read_tx.Length - 1; a > 0; a--)
                        {
                            if (read_tx[a] != ' ')
                            {
                                read_tx =read_tx.Remove(a);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        read_tx += read + " ";
                    }
                }
                    if ((read == "<sk>")|| (read == "k"))
                {
                    AppendTextBox("Client: " + read_tx + " "+ read + "\r\n");
                    if (read_tx.Contains("cq de "))
                    {
                        string toBeSearched = "cq de ";
                        string m32_call_R = read_tx.Substring(read_tx.IndexOf(toBeSearched) + toBeSearched.Length).Trim();
                       
                        string[] m32_call_a = m32_call_R.Split(' ');
                        int call_nr = 0;
                        m32_call = m32_call_a[0];
                        foreach(var c in m32_call_a)
                        {
                            call_nr = 0;
                            string ca = c;
                            foreach(var cb in m32_call_a)
                            {
                                if(cb==ca)
                                { call_nr++; }
                                if(call_nr>1)
                                { m32_call = cb; break; }
                            }
                        }
                        response = bots.Talk_Whit_Bot(m32_call, read_tx, "F");
                        string response_s = response.Replace("<kn>", "$");
                        string[] response_s1 = response_s.Split(' ');
                        read_tx = "";
                        foreach (var s1 in response_s1)
                        {
                           
                            data = mopp.Sent_Mopp_Word(s1);
                            newsock.SendTo(data, data.Length, SocketFlags.None, Remote);
                           // string text = mopp.Read_Mopp_Word(data);
                           // AppendTextBox("sent: " + text + "\r\n");
                        }
                        AppendTextBox("Server: "+ response + "\r\n");
                        QSO(response);
                    }
                    if(read=="<sk")
                    {
                        response = "bye <sk>";
                        string response_s = response.Replace("<sk>", "@");
                        string[] response_s1 = response_s.Split(' ');
                       
                        foreach (var s1 in response_s1)
                        {

                            data = mopp.Sent_Mopp_Word(s1);
                            newsock.SendTo(data, data.Length, SocketFlags.None, Remote);
                            
                        }
                        AppendTextBox("Server: " + response + "\r\n");
                        Loop_Start();
                    }
                    break;
                }
            }
            return read;
        }

        private void QSO(string callsign)
        {
            string read_tx = "";
            string response = "";
            while (true)
            {
                data = new byte[1024];
                recv = newsock.ReceiveFrom(data, ref Remote);
                string read = mopp.Read_Mopp_Word(data);
                if ((read != "<kn>") || (read != "<sk>"))
                {

                    if (read == "*")
                    {
                        read_tx = read_tx.Trim();
                        for (var a = read_tx.Length - 1; a > 0; a--)
                        {
                            if (read_tx[a] != ' ')
                            {
                                read_tx = read_tx.Remove(a);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        read_tx += read + " ";
                    }
                }
                if(read=="<kn>")
                {
                    AppendTextBox("Client: " + read_tx + "\r\n");
                    response = "";
                    response = bots.Talk_Whit_Bot(m32_call, read_tx, "M");
                    response = response.Replace("<kn>", "");
                    response += " <kn>";
                    read_tx = "";
                    string response_r = response.Replace("<kn>", "$");
                    string[] response_s = response_r.Split(' ');
                    foreach(var w in response_s)
                    {
                        data = mopp.Sent_Mopp_Word(w);
                        newsock.SendTo(data, data.Length, SocketFlags.None, Remote);
                    }
                    
                    AppendTextBox("Server: " + response + "\r\n");
                }
                if(read=="<sk>")
                {
                    AppendTextBox("Client: " + read_tx + "\r\n");
                    response = callsign + "tnx fer nice qso 73 73 " + callsign + "<sk>";
                    response = response.Replace("<kn>", "");
                    string response_r = response.Replace("<sk>", "@");
                    string[] response_s = response_r.Split(' ');
                    foreach (var w in response_s)
                    {
                        data = mopp.Sent_Mopp_Word(w);
                        newsock.SendTo(data, data.Length, SocketFlags.None, Remote);
                    }
                    AppendTextBox("Server: " + response + "\r\n");
                    Loop_Start();
                    break;
                }
               
            }
            
        }
        private void Loop_Bots()
        {
            string text = "";
            
            while (true)
            {
                string read = Get_CQ_Call();
                
                if (read == "<sk>")
                {
                    text = "bye <sk>";
                    string text_tx = text.Replace("<sk>", "@");
                    string[] tx = text_tx.Split(' ');
                    foreach (var w in tx)
                    {
                        data = mopp.Sent_Mopp_Word(w);
                        newsock.SendTo(data, data.Length, SocketFlags.None, Remote);
                    }
                    AppendTextBox("Server: " + text + "\r\n");
                    Loop_Start();
                    break;
                }
            }
           
            
        }


        private void Loop_Repeat()
        {
            string text_r = "";
            while (true)
            {
                data = new byte[1024];
                string read = "";
                recv = newsock.ReceiveFrom(data, ref Remote);

                read = mopp.Read_Mopp_Word(data);

                string read_s = read.Replace("<kn>", "$");
                read_s = read_s.Replace("<sk>", "@");
                if (read == "*")
                {
                    text_r = text_r.Trim();
                    for (var a = text_r.Length - 1; a > 0; a--)
                    {
                        if (text_r[a] != ' ')
                        {
                            text_r = text_r.Remove(a);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    text_r += read + " ";
                }
               

                // Uses the IPEndPoint object to determine which of these two hosts responded.
                if ((read == "<kn>") || (read == "qrl?") || (read == "<sk>"))
                {
                    AppendTextBox("Client: " + text_r + "\r\n");
                    AppendTextBox("Server: " + text_r + "\r\n");
                    text_r = text_r.Replace("<sk>", "@");
                    text_r = text_r.Replace("<kn>", "$");
                    string[] m_text = text_r.Split(' ');
                    foreach(var s in m_text)
                    {
                        data = mopp.Sent_Mopp_Word(s);
                        newsock.SendTo(data, data.Length, SocketFlags.None, Remote);
                    }
                   
                    
                    text_r = "";
                    if (read == "<sk>")
                    {
                        string s_text = "bye <sk>";
                        s_text = s_text.Replace("<sk>","@");
                        string[] tx = s_text.Split(' ');
                        foreach (var w in tx)
                        {
                            
                            data = mopp.Sent_Mopp_Word(w);
                            newsock.SendTo(data, data.Length, SocketFlags.None, Remote);
                        }
                        AppendTextBox("Server: bye <sk>\r\n");
                        Loop_Start();  break; 
                    }
                   
                      
                      
                   
                    

                }


                string text = read;





            }
        }
        private void Loop_Small_Talk()
        {

            string text_r = "";
            while (true)
            {
                data = new byte[1024];
                string read = "";
                recv = newsock.ReceiveFrom(data, ref Remote);

                read = mopp.Read_Mopp_Word(data);

                string read_s = read.Replace("<kn>", "$");
                read_s = read_s.Replace("<sk>", "@");
                if (read == "*")
                {
                    text_r = text_r.Trim();
                    for(var a = text_r.Length-1;a>0;a--)
                    {
                        if(text_r[a]!=' ')
                        { 
                            text_r = text_r.Remove(a); 
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    text_r += read + " ";
                }


                // Uses the IPEndPoint object to determine which of these two hosts responded.
                if ((read == "<kn>") ||  (read == "<sk>"))
                {
                    AppendTextBox("Client: " + text_r + "\r\n");
                    text_r = text_r.Replace("<kn>","");
                    string answer = bots.Bot_Answer(text_r, "Call");
           
                    answer += " <kn>";
                    string[] m_text = answer.Split(' ');
                    foreach (var s in m_text)
                    {
                        data = mopp.Sent_Mopp_Word(s);
                        newsock.SendTo(data, data.Length, SocketFlags.None, Remote);
                    }

                    AppendTextBox("Server: " + answer +  "\r\n");
                    text_r = "";
                    if (read == "<sk>")
                    {
                        string s_text = "bye <sk>";
                        s_text = s_text.Replace("<sk>", "@");
                        string[] tx = s_text.Split(' ');
                        foreach (var w in tx)
                        {

                            data = mopp.Sent_Mopp_Word(w);
                            newsock.SendTo(data, data.Length, SocketFlags.None, Remote);
                        }
                        AppendTextBox("Server: bye <sk>\r\n");
                        Loop_Start(); break;
                    }






                }


                string text = read;





            }
        }
        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            DateTime date = DateTime.UtcNow;
            txtStatusText.Text = value + txtStatusText.Text;
           
            using (System.IO.StreamWriter file =
           new System.IO.StreamWriter("Log.txt", true))
            {
                file.WriteLine("UTC: " + date + ": " + value);
            }
        }

       
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                run_Server.Start();
            }
            catch { Start_Server(); }
        }

       

      

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            newsock.Close();
            run_Server.Abort();
            Application.Exit();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            newsock.Close();
            run_Server.Abort();
            Application.Exit();
        }

        private void btnSent_Click(object sender, EventArgs e)
        {

            string sentText = "";
            sentText = txtSentText.Text;
            sentText = sentText.Replace("<kn>", "$");
            sentText = sentText.Replace("<sk>", "@");
            if (sentText != "")
            {
                AppendTextBox("Server: " + sentText + "\r\n");

                txtSentText.Text = "";

                if (sentText != "")
                {   //This code is for testing the sent up it is Mopp correct
                    string[] tx = sentText.Split(' ');
                    string read_tx = "";
                    if (Remote != null)
                    {
                        foreach (var t in tx)
                        {
                            byte[] SentBytes = mopp.Sent_Mopp_Word(t);
                            newsock.SendTo(SentBytes, SentBytes.Length, SocketFlags.None, Remote);
                            string read = mopp.Read_Mopp_Word(SentBytes);
                            read_tx += read + " ";
                        }
                        AppendTextBox(read_tx + "\r\n");
                    }
                    else
                    {
                        MessageBox.Show("You have to have a client connect before you can sent a text!");
                    }
                }
                

            }
            else
            {
                MessageBox.Show("You can not sent a emty text!");
            }
        }
    }
}
