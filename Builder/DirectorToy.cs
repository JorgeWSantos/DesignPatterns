namespace Builder
{
    public class DirectorToy
    {
        private IToyBuilder _toybuilder;

        public DirectorToy(IToyBuilder toyBuilder){

            this._toybuilder = toyBuilder;
        }

        public void construct(){
            
            _toybuilder.setBody();
            _toybuilder.setHead();
            _toybuilder.setLegs();
            _toybuilder.setLimbs();
            _toybuilder.setModel();
        }

        public Toy getToy(){

            return _toybuilder.getToy();
        }
    }
}