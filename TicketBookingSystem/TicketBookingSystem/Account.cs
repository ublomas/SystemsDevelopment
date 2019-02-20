using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TicketBookingSystem
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {
            LoginPanel.Visible = true;
            RegisterPanel.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterPanel.Visible = true;
            LoginPanel.Visible = false;

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text;
            string Password = textBox2.Text;
            string Fname = textBox3.Text;
            string Sname = textBox4.Text;
            string Address = textBox5.Text;
            string PhoneNum = textBox6.Text;
            string email = textBox7.Text;

            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

            OleDbConnection myConnection = new OleDbConnection(connString);
            

            //string myQuery = "INSERT INTO Customer( Forename, Surname, Username, Password, PhoneNumber, Address, Email) VALUES (?, ?, ?, ?, ?, ?, ?)";
             //('" + Fname + "' , '" + Sname + "' , '" + Username + "' , '" + Password + "' , '" + PhoneNum + "' , '" + Address + "' , '" + email + "')";

            

            OleDbCommand myCommand = new OleDbCommand("INSERT INTO Customer (Forename, Surname, Username, [Password], PhoneNumber, Address, Email) VALUES (?, ?, ?, ?, ?, ?, ?)", myConnection);

            myCommand.Parameters.AddWithValue("@Forname", Fname);
            myCommand.Parameters.AddWithValue("@Surname", Sname);
            myCommand.Parameters.AddWithValue("@Username", Username);
            myCommand.Parameters.AddWithValue("@Password", Password);
            myCommand.Parameters.AddWithValue("@PhoneNumber", PhoneNum);
            myCommand.Parameters.AddWithValue("@Address", Address);
            myCommand.Parameters.AddWithValue("@Email", email);

            myConnection.Open();
            myCommand.ExecuteNonQuery();

            myConnection.Close();



            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("author saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception in DBHandler" + ex);
            }
            finally
            {
                myConnection.Close();
            }


        }
    }
}
