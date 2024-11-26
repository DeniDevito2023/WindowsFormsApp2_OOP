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


namespace WindowsFormsApp2_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            forma2 = new Form2();
            forma3 = new Form3();
        }

        Form2 forma2;
        Form3 forma3;
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
                MessageBox.Show("Подключение установлено, идентификация пройдена!");
                
                forma2.ShowDialog(this);

            } else
            {
                
                MessageBox.Show("Идентификация не пройдена, проверьте логин и пароль!");
               
                
            }
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            forma3.ShowDialog(this);
        }
    }
}
