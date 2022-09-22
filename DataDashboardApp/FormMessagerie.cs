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
using DashboardApp.Db;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardApp
{
    public partial class FormMessagerie : Form
    {
        public string SendedMessage = "";
        public string ReceivedMessage = "";
        public Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public Thread Receive;
        public List<String> JulienList;
        public List<String> LucasList;
        public List<String> CurrentList;
        public string CurrentConv = "";
        public string MyName; 

        public FormMessagerie(string nameLogger)
        {
            InitializeComponent();
            String HostName = Dns.GetHostName();
            IPAddress IpAdress = Dns.GetHostByName(HostName).AddressList[0];
            IPEndPoint ipe = new IPEndPoint(IpAdress, 23);
            s.Connect(ipe);
            
            JulienList = new List<String>();
            LucasList = new List<String>();
            CurrentList = new List<string>(); 
            Receive = new Thread(new ThreadStart(this.ThreadReceive));
            Receive.IsBackground = true;
            Receive.Start();
            MyName = nameLogger;
            FillDiscussionChoice(); 
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.AutoScroll = true; 
        }
        private void button1_Click(object sender, EventArgs e)
        {

            ThreadSend();
        }
        private void ThreadSend()
        {


            if (textBox3.Text != "")
            {
                byte[] msg = Encoding.UTF8.GetBytes(textBox3.Text);
                s.Send(msg, SocketFlags.None);
                Button newLbl = new Button();
                newLbl.ForeColor = Color.Blue;
                newLbl.MaximumSize = new Size(900, 3000);
                //newLbl.AutoSize = true;
                newLbl.Text = Encoding.UTF8.GetString(msg);
                this.listBox1.Items.Add("Me : " + newLbl.Text);
                SendMessageToDataBase(MyName + " : " + newLbl.Text); 
                CurrentList.Add("Me : " + newLbl.Text); 
                ModifiyText("", textBox3);
            }

        }

        private void ThreadReceive()
        {
            byte[] bytesrcv = new byte[256];
            int bytes = 0;
            bytes = s.Receive(bytesrcv, bytesrcv.Length, 0);
            ReceivedMessage = Encoding.ASCII.GetString(bytesrcv, 0, bytes);
            if (Encoding.UTF8.GetString(bytesrcv) != "")
            {
                RichTextBox newLbl = new RichTextBox();
                newLbl.ForeColor = Color.Red;
                Console.WriteLine(ReceivedMessage);
                newLbl.Text = ReceivedMessage;
                newLbl.Anchor = AnchorStyles.Right;
                newLbl.MaximumSize = new Size(900, 3000);

                this.listBox1.Invoke((Action)(() =>
                {
                    SuspendLayout();
                    this.listBox1.Items.Add(CurrentConv + " : " + newLbl.Text);
                    SendMessageToDataBase(CurrentConv + " : " +newLbl.Text); 
                    CurrentList.Add(CurrentConv + " : " + newLbl.Text); 
                    ResumeLayout();
                }));

            }
            ThreadReceive();
        }

        private void ModifiyText(string str, TextBox txtBox)
        {
            txtBox.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChangeConversationJulien(object sender, EventArgs e)
        {
            Console.WriteLine("Julien"); 
            if(CurrentConv != "Julien")
            {
                for (int i = 0; i < CurrentList.Count; i++)
                {
                    LucasList.Add(CurrentList[i]); 
                }
                CurrentList.Clear(); 
                this.listBox1.Items.Clear();
                CurrentConv = "Julien";
                for (int i = 0; i < JulienList.Count; i++)
                {
                    listBox1.Items.Add(JulienList[i]);
                }
            }
            else
            {
                // rien ne se passe on est deja sur la bonne conversation
            }
        }
        private void ChangeConversationLucas(object sender, EventArgs e)
        {
            Console.WriteLine("Lucas");
            if (CurrentConv != "Lucas")
            {
                for (int i = 0; i < CurrentList.Count; i++)
                {
                    JulienList.Add(CurrentList[i]);
                }
                CurrentList.Clear();
                this.listBox1.Items.Clear();
                CurrentConv = "Lucas";
                for (int i = 0; i < LucasList.Count; i++)
                {
                    listBox1.Items.Add(LucasList[i]);
                }
            }
            else
            {
               // rien ne se passe on est deja sur la bonne conversation
            }
        }

        private void ChangeConversation(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            Button tmp = (Button)sender;
            CurrentConv = tmp.Text;
            Console.WriteLine(CurrentConv);
            GetDBConnection DbConnection = new GetDBConnection();
            using (var connection = DbConnection.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "select Conversation from Messagerie where Employee1 = @loggerName and Employee2 = @Destinataire";
                    command.Parameters.Add("@loggerName", System.Data.SqlDbType.NVarChar).Value = MyName;
                    command.Parameters.Add("@Destinataire", System.Data.SqlDbType.NVarChar).Value = CurrentConv;
                    reader = command.ExecuteReader();
                    Console.WriteLine("On change de conv");
                    string[] stringSeparators = new string[] { "/##/" };
                    while (reader.Read())
                    {
                        string[] messages = reader[0].ToString().Split(stringSeparators, StringSplitOptions.None); 
                        foreach(var message in messages)
                        {
                            this.listBox1.Items.Add(message); 
                        }
                    }
                }
            }
        }

        private bool SendMessageToDataBase(string Message)
        {
            GetDBConnection DbConnection = new GetDBConnection();
            using (var connection = DbConnection.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    Console.WriteLine("Création Nouvelle Conv");
                    SqlDataReader reader;
                    string OlderMessage = "";
                    command.Connection = connection;

                    command.CommandText = "select count(Id) from Messagerie";
                    reader = command.ExecuteReader();
                    int CurrentCount = 0;
                    while (reader.Read())
                    {
                        CurrentCount = Int32.Parse(reader[0].ToString());
                    }
                    reader.Close();

                    
                    command.CommandType = CommandType.Text;
                    command.CommandText = "select Conversation from Messagerie where Employee1 = @loggerName and Employee2 = @Destinataire";
                    command.Parameters.Add("@loggerName", System.Data.SqlDbType.NVarChar).Value = MyName;
                    command.Parameters.Add("@Destinataire", System.Data.SqlDbType.NVarChar).Value = CurrentConv;
                    reader = command.ExecuteReader();
                    
                      
                    while (reader.Read())
                    {
                        Console.WriteLine("Ajout BDD");
                        OlderMessage = reader[0].ToString() + "/##/" + Message;
                        command.CommandText = "UPDATE Messagerie SET Conversation = @newValue where Employee1 = @loggerName2 AND Employee2 = @Destinataire2";
                        command.Parameters.Add("@loggerName2", System.Data.SqlDbType.NVarChar).Value = MyName;
                        command.Parameters.Add("@Destinataire2", System.Data.SqlDbType.NVarChar).Value = CurrentConv;
                        command.Parameters.Add("@newValue", System.Data.SqlDbType.Text).Value = OlderMessage;
                        reader.Close();
                        command.ExecuteNonQuery();
                        return true; 


                    }
                    Console.WriteLine("Création Nouvelle Conv");
                    command.CommandText = "INSERT INTO Messagerie(Id, Employee1, Employee2, Conversation) VALUES (@CurrentId, @loggerName3, @Destinataire3, @ValueMessage)";
                    command.Parameters.Add("@loggerName3", System.Data.SqlDbType.NVarChar).Value = MyName;
                    command.Parameters.Add("@Destinataire3", System.Data.SqlDbType.NVarChar).Value = CurrentConv;
                    command.Parameters.Add("@ValueMessage", System.Data.SqlDbType.Text).Value = Message;
                    command.Parameters.Add("@CurrentId", System.Data.SqlDbType.Int).Value = CurrentCount + 1 ;
                    reader.Close(); 
                    command.ExecuteNonQuery();
                    return true; 
                }
                return false; 
            }
        }

        private void FillDiscussionChoice()
        {
            GetDBConnection DbConnection = new GetDBConnection();
            using (var connection = DbConnection.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "select EmployeeName from Employee where EmployeeName != @loggerName";
                    command.Parameters.Add("@loggerName", System.Data.SqlDbType.NVarChar).Value = MyName;
                    reader = command.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0].ToString()); 
                        Button tmpButton = new Button();
                        tmpButton.Text = reader[0].ToString();
                        tmpButton.Click += new System.EventHandler(this.ChangeConversation);
                        flowLayoutPanel1.Controls.Add(tmpButton);
                    }
                }
            }
        }
    }
}
