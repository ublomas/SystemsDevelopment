using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem
{
    abstract class User
    {

        public int ID;
        public string userName;
        public string password;
        public string forName;
        public string surName;


        //public abstract User(int id, string user, string pass, string forname, string surname);

        public abstract void Login();
        //public abstract void Logout();
        public abstract void AddUser(int id, string user, string pass, string forname, string surname);
        public abstract void DeleteUser();
        public abstract void DisplayProfile();
        public abstract void GetUserInfo();
        //public abstract void BrowsePlays();

    }



    class Customer : User
    {
        int customerID;

        string address;
        int phoneNumber;
        string email;

        string add;

        public override void AddUser(int id, string user, string pass, string forname, string surname)
        {

            id = customerID;
            //add = address;
            add = "";

            //needs to write to database 

        }

        public override void DeleteUser()
        {
            //delete row from database
        }

        public override void DisplayProfile()
        {
            //show details from database or local variables
        }

        public override void Login()
        {
            //search database for password and username 
        }

        public override void GetUserInfo()
        {
            //read from database 
        }

        public void ViewOrderHistory()
        {

        }

        public void EditPersonalDetails()
        {

        }

    }

    class Staff : User
    {
        int staffID;



        public override void AddUser(int id, string user, string pass, string forname, string surname)
        {
            id = staffID;
        }

        public override void DeleteUser()
        {

        }

        public override void DisplayProfile()
        {

        }

        public override void GetUserInfo()
        {

        }

        public override void Login()
        {

        }

        public void DeleteReviews()
        {

        }

        public void AddPlay()
        {

        }

        public void EditPlay()
        {

        }

        public void DeletePlay()
        {

        }


    }
}
