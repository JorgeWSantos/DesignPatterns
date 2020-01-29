using System;
using Project1.data;

namespace Project1
{
    public class ReservationReport
    {
        private readonly Connection con;

        public ReservationReport(Connection con)
        {
            this.con = con;
        }
        public void reportGeneration(){

            con.connect();
            Console.WriteLine("reservation created\n");
        }
    }
}