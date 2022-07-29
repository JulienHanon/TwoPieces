using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading; 

namespace DashboardApp
{
    public partial class Form3 : Form
    {
        public string SendedMessage = ""; 
        public string ReceivedMessage = "";
        public Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public Thread Receive; 

        public Form3()
        {
            InitializeComponent();
            String HostName = Dns.GetHostName();
            IPAddress IpAdress = Dns.GetHostByName(HostName).AddressList[0];
            IPEndPoint ipe = new IPEndPoint(IpAdress, 23);
            s.Connect(ipe);
            flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp; 
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoScroll = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadSend();
            Receive = new Thread(new ThreadStart(this.ThreadReceive)); 
            Receive.IsBackground = true;
            Receive.Start(); 
        }
        private bool LoginCheck()
        {
            if (textBox1.Text == "JulienHanon")
            {
                return true; 
            }
            else
            {
                return false;
            }
           
        }

        private bool PassWordCheck()
        {
            if(textBox2.Text == "Fuecoco")
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }
        private void ThreadSend()
        {
                
                
                if (LoginCheck() && PassWordCheck())
                {

                    try
                    {
                        
                        if (s.Connected)
                        {
                            MessageBox.Show("Connected"); 
                        }
                        else
                        {
                            MessageBox.Show("Connection lost");
                        }
                    }
                    catch (ArgumentNullException ae)
                    {
                        Console.WriteLine("ArgumentNullException : {0}", ae.ToString());
                    }
                    catch (SocketException se)
                    {
                        Console.WriteLine("SocketException : {0}", se.ToString());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Unexpected exception : {0}", ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Login or Password incorrect ! Access denied !");
                }


                if (textBox3.Text != "")
                {
                    byte[] msg = Encoding.UTF8.GetBytes(textBox3.Text);
                    s.Send(msg, SocketFlags.None);
                    Label newLbl = new Label();
                    newLbl.ForeColor = Color.Blue;
                    newLbl.AutoSize = true; 
                    newLbl.Text = Encoding.UTF8.GetString(msg);
                     flowLayoutPanel1.Controls.Add(newLbl);
                    flowLayoutPanel1.Controls.SetChildIndex(newLbl, 0);
                    flowLayoutPanel1.ScrollControlIntoView(newLbl);
                     ModifiyText("", textBox3);
                }

        }

        private void ThreadReceive()
        {
            byte[] rcv = new byte[256];
            s.Receive(rcv); 
            if(Encoding.UTF8.GetString(rcv) != "")
            {
                Label newLbl = new Label();
                newLbl.ForeColor = Color.Red;
                newLbl.AutoSize = true; 
                newLbl.Text = Encoding.UTF8.GetString(rcv);
                ReceivedMessage = Encoding.UTF8.GetString(rcv);
                 flowLayoutPanel1.Invoke((Action)(() =>
                 {
                     flowLayoutPanel1.Controls.Add(newLbl);
                     flowLayoutPanel1.Controls.SetChildIndex(newLbl, 0);
                     flowLayoutPanel1.ScrollControlIntoView(newLbl); 
                 }));

            }
            ThreadReceive();
        }

        private void ModifiyText(string str, TextBox txtBox)
        {
            txtBox.Text = str; 
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
