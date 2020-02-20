using System;

namespace Design_Patterns.data
{
    public abstract class DbConnection
    {
        public abstract void open();
        public abstract void close();
    }
}