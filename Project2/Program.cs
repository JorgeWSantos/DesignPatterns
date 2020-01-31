using System;

namespace DesignPatterns.Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Component checkBox = new Component("CheckBox");
            Component radioButton = new Component("radioButton");
            Component comboBox = new Component("comboBox");
            Component textBox = new Component("textBox");

            FlowContainer flowContainer = new FlowContainer();
            flowContainer.addComponent(checkBox);
            flowContainer.addComponent(radioButton);
            flowContainer.addComponent(textBox);
            flowContainer.removeComponent(checkBox);
            flowContainer.doLayout();

            GridContainer gridContainer = new GridContainer(2,2);
            gridContainer.addComponent(checkBox);
            gridContainer.addComponent(textBox);
            gridContainer.addComponent(comboBox);
            gridContainer.addComponent(radioButton);
            gridContainer.removeComponent(textBox);
            gridContainer.doLayout();
        }
    }
}
