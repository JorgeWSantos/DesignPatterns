using System;
using Project1.data;

namespace Project1
{
    public class ReservationService
    {
        private readonly Connection con;
        public ReservationService(Connection con)
        {
            this.con = con;
        }
        public void createReservation(){
            
            con.connect();
            Console.WriteLine("create reservation\n");
        }
    }
}