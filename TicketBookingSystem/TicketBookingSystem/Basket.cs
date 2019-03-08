using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem
{
     abstract class Basket
    {
        double basketTotal;
        int cost, quantity;
        string play, user;
        DateTime date;
        public abstract void AddToOrder(string user, string play, int cost, int qauntity, DateTime date, string ticketType);
        public abstract void RemoveFromBasket();
    }

    class ChosenPlays : Basket
    {

        public override void AddToOrder(string user, string play, int cost, int quantity, DateTime date, string ticketType)
        {

            //id = customerID;
            //add = address;

            //needs to write to database 
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = C:\Users\user\Desktop\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

            OleDbConnection myConnection = new OleDbConnection(connString);

            OleDbCommand myCommand = new OleDbCommand("INSERT INTO Basket (UserID, PlayChosen, Price, Quantity, PlayDate, TicketType) VALUES (?, ?, ?, ?, ?, ?)", myConnection);

            myCommand.Parameters.AddWithValue("@UserID", user);
            myCommand.Parameters.AddWithValue("@PlayChosen", play);
            myCommand.Parameters.AddWithValue("@Price", cost);
            myCommand.Parameters.AddWithValue("@Quantity", quantity);
            myCommand.Parameters.AddWithValue("@PlayDate", date);
            myCommand.Parameters.AddWithValue("@TicketType", ticketType);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();

        }

        public void DisplayCurrentTotal()
        {

        }

        public void Checkout()
        {

        }

        public void SelectSeats()
        {

        }

        public void ReserveSeats()
        {

        }

        public void AddToBasket()
        {


            for (int i = 0; i < basketItems.Count; i++)
            {
                /* if the item is already in the list
                if (basketItems[i]. == playName)
                {
                    basketItems[i].UpdateShoppingBasketList(ticketsInBasket, basketTotal);
                    return;
                }*/
            }
            



        }

        public void RemoveFromBasket()
        {

        }

        public void ApplyDiscounts()
        {

        }



    }
}
