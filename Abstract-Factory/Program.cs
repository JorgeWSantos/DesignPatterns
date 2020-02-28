using Abstract_Factory.data.oracle;
using Design_Patterns.data;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            DbFactory db = new OracleFactory();
            var con = db.createDbConnection();
            con.open();
            con.close();
            var commands = db.createCommands();
            commands.delete();
            commands.save();
            commands.update();
        }
    }
}
