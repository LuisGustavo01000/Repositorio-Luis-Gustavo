using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    public class Octagono : Forma
    {
        public double LadoOct { get; set; }

        public Octagono(double ladooct) : base("Octágono")
        {
            LadoOct = ladooct;
        }

        public override double CalcularArea()
        {
            return 2 * (1 + Math.Sqrt(2)) * LadoOct * LadoOct;
        }
        public override double CalcularPerimetro()
        {
            return 8 * LadoOct;
        }

        public override void Mostrar()
        {
            base.Mostrar();

        }
    }
}
