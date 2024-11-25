using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using MySql.Data.MySqlClient;
//using System.Security.Cryptography.X509Certificates;


namespace WindowsFormsApp2_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();       }
        
        private void button2_Click(object sender, EventArgs e)
        {

            String loginUser = loginField.Text;
            String passUser = passwordField.Text;

            DBase dBase = new DBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("select * from login where login_user = @uL and password_user = @uP", dBase.getConnection());
            
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Yes");
            } else
            {
                MessageBox.Show("No");
            }


            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\WindowsFormsApp2_OOP\testDataBase.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

            //SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Table where Пользователь = '" + textBox1.Text + "' and Пароль = '" + textBox2.Text + "'", con);
            //DataTable dataTable = new DataTable();
            //sda.Fill(dataTable);


            //if (dataTable.Rows[0][0].ToString() == "1")
            //{
            //    this.Hide();
            //    Form2 f2 = new Form2();
            //f2.Show();

            //}
            //else
            //{
            //    MessageBox.Show("Соединение не установлено");
            //}



        }
    }
}
