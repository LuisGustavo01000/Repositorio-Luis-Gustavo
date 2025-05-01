using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    public class Pentagono : Forma
    {
        public double Lado { get; set; }

        public Pentagono(double lado) : base("Pentágono")
        {
            Lado = lado;
        }

        public override double CalcularArea() { 
           return (5 * Lado * Lado) / (4 * Math.Tan(Math.PI / 5));
            }
        public override double CalcularPerimetro()
        {
            return 5 * Lado;
        }

        public override void Mostrar()
        {
            base.Mostrar();
                }
    }
}