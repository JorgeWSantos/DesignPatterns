using System;
using Project1.data;

namespace Project1
{
    public class RoomService
    {
        private readonly Connection con;
        public RoomService(Connection con)
        {
            this.con = con;
        }
        public void roomVerification(){

            con.connect();
            Console.WriteLine("room verification\n");
        }
    }
}