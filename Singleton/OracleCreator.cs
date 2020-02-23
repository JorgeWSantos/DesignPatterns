namespace Singleton
{
    public class OracleCreator : CreatorDb
    {
        public IConnectionDb createInstance()
        {
            return OracleConnnection.getInstance();
        }
    }
}