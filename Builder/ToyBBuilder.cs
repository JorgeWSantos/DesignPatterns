namespace Builder
{
    //concrete builder
    public class ToyABuilder : IToyBuilder
    {
        private Toy toy;

        public ToyABuilder(){

            this.toy = new Toy();
        }

        public Toy getToy(){

            return toy;
        }

        public void setBody(){

            toy.body = "Steel";
        }

        public void setHead(){

            toy.head = "1";
        }

        public void setLegs(){

            toy.legs = "4";
        }

        public void setLimbs(){

            toy.limbs = "4";
        }

        public void setModel(){
            
            toy.model = "A";
        }
    }
}