namespace Builder
{
    //concrete builder
    public class ToyBBuilder : IToyBuilder
    {
        private Toy toy;

        public ToyBBuilder(){

            this.toy = new Toy();
        }

        public Toy getToy(){

            return toy;
        }

        public void setBody(){

            toy.body = "Wood";
        }

        public void setHead(){

            toy.head = "1";
        }

        public void setLegs(){

            toy.legs = "2";
        }

        public void setLimbs(){

            toy.limbs = "4";
        }

        public void setModel(){
            
            toy.model = "B";
        }
    }
}