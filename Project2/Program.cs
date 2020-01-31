using System;

namespace DesignPatterns.Project2
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            //components
=======
>>>>>>> 41dec0514f94c627bca1d508c6df6ddcfd90328d
            Component checkBox = new Component("CheckBox");
            Component radioButton = new Component("radioButton");
            Component comboBox = new Component("comboBox");
            Component textBox = new Component("textBox");

<<<<<<< HEAD
            //borders
            // BorderSolid borderSolid = new BorderSolid();

=======
>>>>>>> 41dec0514f94c627bca1d508c6df6ddcfd90328d
            FlowContainer flowContainer = new FlowContainer();
            flowContainer.addComponent(checkBox);
            flowContainer.addComponent(radioButton);
            flowContainer.addComponent(textBox);
<<<<<<< HEAD
            Border borderSolid = new BorderSolid(flowContainer);
            borderSolid.generateBorder();

            FlowContainer flowContainer2 = new FlowContainer();
            flowContainer2.addComponent(checkBox);
            flowContainer2.addComponent(radioButton);
            flowContainer2.addComponent(textBox);
            Border borderEtched = new EtchedBorder(flowContainer2);
            borderEtched.generateBorder();
            
=======
            flowContainer.removeComponent(checkBox);
            flowContainer.doLayout();
>>>>>>> 41dec0514f94c627bca1d508c6df6ddcfd90328d

            GridContainer gridContainer = new GridContainer(2,2);
            gridContainer.addComponent(checkBox);
            gridContainer.addComponent(textBox);
            gridContainer.addComponent(comboBox);
            gridContainer.addComponent(radioButton);
<<<<<<< HEAD
            // gridContainer.removeComponent(textBox);
            borderEtched.setContainer(gridContainer);
            borderEtched.generateBorder();
            
=======
            gridContainer.removeComponent(textBox);
            gridContainer.doLayout();
>>>>>>> 41dec0514f94c627bca1d508c6df6ddcfd90328d
        }
    }
}
