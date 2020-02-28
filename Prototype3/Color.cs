namespace Prototype3
{
    public class Color : PrototypeColor
    {
        public int red;
        public int blue;
        public int green;

        public Color(int red, int green, int blue){

            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public override Color clone(){

            return (Color)this.MemberwiseClone();
        }
    }
}