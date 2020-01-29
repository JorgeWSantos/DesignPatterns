using System;
using Project1;
using Project1.data;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection mysql = new MySqlConnection();
            SqlServerConnnection sqlServer = new SqlServerConnnection();

            var sgbd = mysql;
            // var sgbd = sqlServer;

            ReservationReport reservationReport = new ReservationReport(sgbd);
            reservationReport.reportGeneration();

            ReservationService reservationService = new ReservationService(sgbd);
            reservationService.createReservation();

            RoomService roomService = new RoomService(sgbd);
            roomService.roomVerification();
        }
    }
}
