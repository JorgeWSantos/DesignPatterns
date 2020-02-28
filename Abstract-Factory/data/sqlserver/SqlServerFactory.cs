namespace Design_Patterns.data.sqlserver
{
    
    //concrete factory
    public class SqlServerFactory : DbFactory
    {
        public override DbCommands createCommands(){
            
            return new SqlServerCommands();
        }

        public override DbConnection createDbConnection(){

            return new SqlServerConnection();
        }
    }
}