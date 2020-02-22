namespace Builder
{
    //builder
    public interface IToyBuilder
    {
        void setModel();
        void setHead();
        void setLimbs();
        void setBody();
        void setLegs();
        Toy getToy();
    }
}