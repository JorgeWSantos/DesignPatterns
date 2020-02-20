using System;
using Design_Patterns.data;

namespace Abstract_Factory.data.oracle
{
    public class OracleCommands : DbCommands
    {
        public override bool delete(){

            Console.WriteLine("delete oracle");
            return true;
        }

        public override bool save(){

            Console.WriteLine("save oracle");
            return true;
        }

        public override bool update(){
            
            Console.WriteLine("update oracle");
            return true;
        }
    }
}