namespace Singleton
{
    //concrete creator
    public class SqlServerCreator : CreatorDb
    {
        public IConnectionDb createInstance()
        {
            return SqlServerConnection.getInstance();
        }
    }
}