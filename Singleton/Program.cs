using System;

namespace Singleton
{
    class Program
    {
        //client
        static void Main(string[] args)
        {
            //com factory method
            Console.WriteLine("\n---with factory---");
            CreatorDb creator = new OracleCreator();
            IConnectionDb oracleCon = creator.createInstance();
            oracleCon.open();

            CreatorDb createSQlServer = new SqlServerCreator();
            IConnectionDb sqlServerCon = createSQlServer.createInstance();
            sqlServerCon.open();

            //sem o factory method
            Console.WriteLine("\n---without factory---");
            var con = OracleConnnection.getInstance();
            con.open();

            var con2 = SqlServerConnection.getInstance();
            con2.open();

        }
    }
}
