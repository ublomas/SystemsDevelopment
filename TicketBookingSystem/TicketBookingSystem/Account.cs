﻿using System;
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            string LoginUsername = textBox13.Text;
            string LoginPassword = textBox14.Text;
            bool staff = false;


            Customer customer = new Customer();
            customer.Login(LoginUsername, LoginPassword, staff);

            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("SELECT * FROM [User] WHERE [Username] = @Username ,  [Password] = @LoginPassword ,  [Staff] = @Staff", myConnection);

            myCommand.Parameters.AddWithValue("@Username", LoginUsername);
            myCommand.Parameters.AddWithValue("@Password", LoginPassword);
            myCommand.Parameters.AddWithValue("@Staff", staff);
            //myCommand.ExecuteNonQuery();
            
            OleDbDataReader re = myCommand.ExecuteReader();

            
            //staff = re.GetBoolean(3);
           // MessageBox.Show("" + staff);

            if (re.Read() == true)
            {
                MessageBox.Show("Account Found");
            }
            else
            {
                MessageBox.Show("Account not found");
            }

            myConnection.Close();
            
           ;

        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            RegisterPanel.Visible = true;
            LoginPanel.Visible = false;


        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text;
            string Password = textBox2.Text;
            string Fname = textBox3.Text;
            string Sname = textBox4.Text;
            string Address = textBox5.Text;
            string PhoneNum = textBox6.Text;
            string Email = textBox7.Text;


            Customer customer = new Customer();
            customer.AddUser(Username, Password, Fname, Sname, Address, PhoneNum, Email);
            MessageBox.Show("Account Created");

            string CurrentUsername = "";
            CurrentUsername = Username;
            label11.Text = CurrentUsername;

        }

       
    }
}
