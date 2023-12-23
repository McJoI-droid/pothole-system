using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace PotholeSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closee()
        {
            Form1 main = new Form1();
            main.Close();
        }


        
        



        private void button1_Click(object sender, EventArgs e)
        {
        

            databaseu();
            
          
               



        }


        private void databaseu()
        {

            string username = userna.Text;
            string password = passwo.Text;

            string connectionstring = "server=localhost;uid=root;password='';database=potholedb";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connectionstring;
            con.Open();

            // Check user table
            string userQuery = "SELECT COUNT(*) FROM user WHERE USERNAME = @username AND PASSWORD = @password";
            using (MySqlCommand userCommand = new MySqlCommand(userQuery, con))
            {
                userCommand.Parameters.AddWithValue("@username", username);
                userCommand.Parameters.AddWithValue("@password", password);

                int userCount = Convert.ToInt32(userCommand.ExecuteScalar());

                if (userCount > 0)
                {
                    // User login successful
                    MessageBox.Show("User login successful!");
                    dashbr user = new dashbr();
                    con.Close();
                    user.Show();
                    closee();

                    
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {
            CreateAcc create = new CreateAcc();
            create.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            databasea();
            

        }

        private void databasea()
        {

            string username = userna.Text;
            string password = passwo.Text;

            string connectionstring = "server=localhost;uid=root;password='';database=potholedb";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connectionstring;
            con.Open();

            // Check user table
            string adminQuery = "SELECT COUNT(*) FROM admin WHERE USERNAME = @username AND PASSWORD = @password";
            using (MySqlCommand userCommand = new MySqlCommand(adminQuery, con))
            {
                userCommand.Parameters.AddWithValue("@username", username);
                userCommand.Parameters.AddWithValue("@password", password);

                int adminCount = Convert.ToInt32(userCommand.ExecuteScalar());

                if (adminCount > 0)
                {
                    // User login successful
                    AdminDashboard admin = new AdminDashboard();
                    admin.Show();
                    con.Close();
                    closee();
                }
                else {
                    MessageBox.Show("Invalid username or password.");
                }
            }


        }

     
        }
    }
