using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
   public  class Quadrado : Forma
    {
        public double Lado { get; set; }

        public Quadrado(double lado) : base("Quadrado")
        {
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return Lado* Lado;
        }
        public override double CalcularPerimetro()
        { 
            return 4 * Lado;
        }
        public override void Mostrar()
        {
            base.Mostrar();
        }
    }
}
 