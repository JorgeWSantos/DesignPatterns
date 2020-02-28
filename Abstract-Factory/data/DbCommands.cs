namespace Design_Patterns.data
{
    //abstract product
    public abstract class DbCommands
    {
        public abstract bool save();
        public abstract bool delete();
        public abstract bool update();
    }
}