using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    public class Octagono : Forma
    {
        public double Lado { get; set; }

        public Octagono(double lado) : base("Octágono")
        {
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return 2 * (1 + Math.Sqrt(2)) * Lado * Lado;
        }
        public override double CalcularPerimetro()
        {
            return 8 * Lado;
        }

        public override void Mostrar()
        {
            base.Mostrar();
           
        }
    }
}
