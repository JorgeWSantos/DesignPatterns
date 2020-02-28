using System;
using Design_Patterns.data;

namespace Abstract_Factory.data.oracle
{
    //concrete product
    public class OracleConnection : DbConnection
    {
        public override void close()
        {
            Console.WriteLine("oracle connection closed");
        }

        public override void open()
        {
            Console.WriteLine("oracle connection is open");
        }
    }
}