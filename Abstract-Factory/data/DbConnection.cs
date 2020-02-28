using System;

namespace Design_Patterns.data
{
    //abstract product
    public abstract class DbConnection
    {
        public abstract void open();
        public abstract void close();
    }
}