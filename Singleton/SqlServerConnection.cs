using System;

namespace Singleton
{
    //concrete product
    public class SqlServerConnection : IConnectionDb
    {
        private static SqlServerConnection _instance;

        private SqlServerConnection(){

        }

        public void close(){

            Console.WriteLine("sqlserver close connection");
        }

        public void open(){

            Console.WriteLine("sqlserver open connection");
        }

        public static SqlServerConnection getInstance(){

            if (_instance == null)
                _instance = new SqlServerConnection();

            return _instance;
        }
    }
}