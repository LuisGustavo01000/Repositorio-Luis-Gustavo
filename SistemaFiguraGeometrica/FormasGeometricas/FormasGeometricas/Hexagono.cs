using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    class Hexagono : Forma
    {
        public double Lado { get; set; }

        public Hexagono(double lado) : base("Hexágono")
        {
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return ((3 * Math.Sqrt(3)) / 2) * Lado * Lado;
        }
        public override double CalcularPerimetro()
        { 
             return 6 * Lado;
        }
        public override void Mostrar()
        {
            base.Mostrar();
           
        }
    }
}