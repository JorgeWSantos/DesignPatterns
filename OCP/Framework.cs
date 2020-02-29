using System;
namespace OCP
{
    public abstract class FormaGeometrica
    {
        public abstract double calcularArea();
    }
    public class Retangulo : FormaGeometrica
    {
        public double altura { get; set; }
        public double largura { get; set; }

        public override double calcularArea()
        {
            return altura * largura;
        }
    }

    public class Circulo : FormaGeometrica
    {
        public double raio { get; set; }

        public override double calcularArea()
        {
            return raio * raio * Math.PI;
        }
    }

    //independente de quantas formas geometricas eu adicionar
    //a classe AreaCalc não ira mudar
    public class AreaCalc
    {
        public double calcularArea(FormaGeometrica[] formas){

            double area = 0;
            
            foreach (var forma in formas)
                area = area + forma.calcularArea();

            return area;
        }
    }
}