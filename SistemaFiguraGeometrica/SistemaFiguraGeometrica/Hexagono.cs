using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    class Hexagono : Forma
    {
        public double LadoHex { get; set; }

        public Hexagono(double ladohex) : base("Hexágono")
        {
            LadoHex = ladohex;
        }

        public override double CalcularArea()
        {
            return ((3 * Math.Sqrt(3)) / 2) * LadoHex * LadoHex;
        }
        public override double CalcularPerimetro()
        {
            return 6 * LadoHex;
        }
        public override void Mostrar()
        {
            base.Mostrar();

        }
    }
}