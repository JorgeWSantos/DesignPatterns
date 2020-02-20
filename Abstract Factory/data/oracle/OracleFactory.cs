using Design_Patterns.data;

namespace Abstract_Factory.data.oracle
{
    public class OracleFactory : DbFactory
    {
        public override DbCommands createCommands()
        {
            return new OracleCommands();
        }

        public override DbConnection createDbConnection()
        {
            return new OracleConnection();
        }
    }
}