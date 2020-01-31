using System;

namespace DesignPatterns.Project2
{
    public class GridContainer : Container
    {
        // Component[,] comp;
        Component[,] comp;
        int rowsLimit;
        int columnsLimit;
        int currentRow;
        int currentColumn;
        public GridContainer(int rows, int columns){
            rowsLimit = rows;
            columnsLimit = columns;
            currentColumn = 0;
            currentRow = 0;
            comp = new Component[rows, columns];
        }

        public override void addComponent(Component component){
            
            if (currentColumn==columnsLimit && currentRow == rowsLimit){

                Console.WriteLine("you dont be able do add news components");
            }

            else{

                //case between limit of columns
                if (currentColumn<columnsLimit)
                {   
                    comp[currentRow, currentColumn] = component;
                    currentColumn++;//add a new column
                }

                //case overflow limit of columns
                else{
                    currentRow++;//add a new row
                    currentColumn = 0;//resete columns
                    comp[currentRow, currentColumn] = component;
                    currentColumn++;
                }
            }
        }

        public override void removeComponent(Component c){

            for (int i = 0; i < rowsLimit; i++)
            {
                for (int j = 0; j < columnsLimit; j++)
                {
                    if (comp[i,j]==c) {

                        comp[i,j] = null;
                    }
                }
            }
        }

        public override void doLayout() {
            Console.WriteLine("----------");
            Console.WriteLine("Grid Container");
            foreach (var row in comp)
            {
                Console.WriteLine(row);
            }
            this.dispose();
            Console.WriteLine("----------\n");
        }
    }
}