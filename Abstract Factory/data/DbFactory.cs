namespace Design_Patterns.data
{
    public abstract class DbFactory
    {
        public abstract DbConnection createDbConnection();
        public abstract DbCommands createCommands();
    }
}