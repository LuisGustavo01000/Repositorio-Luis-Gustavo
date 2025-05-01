using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    public class Triangulo : Forma
    {
        public double BaseT { get; set; }
        public double Altura { get; set; }
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }

        public Triangulo(double baseT, double altura, double lado1, double lado2) : base("Triângulo")
        {
            BaseT = baseT;
            Altura = altura;
            Lado1 = lado1;
            Lado2 = lado2;
        }

        public override double CalcularArea()
        {
           return (BaseT * Altura) / 2;
        }
        public override double CalcularPerimetro()
        {
            return BaseT + Lado1 + Lado2;
        }

        public override void Mostrar()
        {
            base.Mostrar();
                }
    }
}