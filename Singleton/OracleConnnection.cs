using System;

namespace Singleton
{
    public class OracleConnnection : IConnectionDb
    {
        private static OracleConnnection _instance;
        
        public void close(){

            Console.WriteLine("close oracle connection");
        }

        public void open(){

            Console.WriteLine("open oracle connection");
        }

        public static OracleConnnection getInstance(){

            if (_instance == null)
                _instance = new OracleConnnection();

            return _instance;
        }
    }
}