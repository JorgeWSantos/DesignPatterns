using System;

namespace Prototype2
{
    //concrete prototype
    public class Car : Vehicle
    {
        public Car(string model, string brand, string year)
            :base(model, brand, year)
        {
            
        }

        #region Metodos de clonagem

        //shallow copy
        public override Car clone(){

            return (Car)this.MemberwiseClone();
        }

        //deep copy
        public override Car copy(){

            Car copyCar = (Car)this.MemberwiseClone();

            return new Car(copyCar.model, copyCar.brand, copyCar.year);
        }

        #endregion

    }
}