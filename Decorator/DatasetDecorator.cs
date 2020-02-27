using System;
namespace Decorator
{
    //decorator
    public class DatasetDecorator : DatasetBase
    {
        protected DatasetBase datasetBase;

        public void setDataset(DatasetBase datasetBase){

            this.datasetBase = datasetBase;
        }
        public override void write(){

            datasetBase.write();
        }
    }
}