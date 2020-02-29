using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            var ret1 = new Retangulo() {altura=10, largura=15};
            var ret2 = new Retangulo() {altura=5, largura=13};
            Retangulo[] rets = {ret1, ret2};
            var calc = new AreaCalc();
            var calculo = calc.calcularArea(rets);
            Console.WriteLine(calculo);
        }
    }
}
