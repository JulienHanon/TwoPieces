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
    public class GetDBConnection : DbConnection
    {
        public GetDBConnection()
        {
             
        }
    }

    public partial class FormLogincs : Form
    {
        public Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public FormLogincs()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {   
            if(LoginCheck())
            {
                String HostName = Dns.GetHostName();
                IPAddress IpAdress = Dns.GetHostByName(HostName).AddressList[0];
                IPEndPoint ipe = new IPEndPoint(IpAdress, 23);
                 s.Connect(ipe);
                if (s.Connected == true)
                {
                    this.label3.Visible = false;
                    this.Hide();
                    FormMessagerie f = new FormMessagerie(this.textBox1.Text);
                    f.Show();
                }
                else
                {
                    this.label3.Text = "Erreur Connexion Interrompue";
                    this.label3.Visible = true;
                }
                
            }
            else
            {
                this.label3.Text = "Mot de Passe ou Login Incorrect Veuillez Reessayer.";
                this.label3.Visible = true;
                ResetTextBox();
            }
          
        }

        private bool LoginCheck()
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
                    command.CommandText = "select login, password from Employee where login = @Currentlogin and password = @Currentpassword";
                    command.Parameters.Add("@Currentlogin", System.Data.SqlDbType.NVarChar).Value = this.textBox1.Text;
                    command.Parameters.Add("@Currentpassword", System.Data.SqlDbType.NVarChar).Value = this.textBox2.Text;
                     reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if(reader[0].ToString() != "" && reader[1].ToString() != "")
                        {
                            Console.WriteLine(reader[0].ToString()); 
                            Console.WriteLine(reader[1].ToString()); 
                            return true; 
                        }
                        else
                        {
                            return false; 
                        }
                    }
                }
                return false; 
            }
        }

        private void ResetTextBox()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";

        }
    }
}
