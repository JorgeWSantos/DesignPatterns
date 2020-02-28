namespace Design_Patterns.data
{
    //abstract factory
    public abstract class DbFactory
    {
        public abstract DbConnection createDbConnection();
        public abstract DbCommands createCommands();
    }
}