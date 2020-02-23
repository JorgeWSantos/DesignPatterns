namespace Singleton
{
    //creator
    public interface CreatorDb
    {
        IConnectionDb createInstance();
    }
}