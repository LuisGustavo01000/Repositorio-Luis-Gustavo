using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    public class Pentagono : Forma
    {
        public double LadoPent { get; set; }

        public Pentagono(double ladopent) : base("Pentágono")
        {
            LadoPent = ladopent;
        }

        public override double CalcularArea()
        {
            return (5 * LadoPent * LadoPent) / (4 * Math.Tan(Math.PI / 5));
        }
        public override double CalcularPerimetro()
        {
            return 5 * LadoPent;
        }

        public override void Mostrar()
        {
            base.Mostrar();
        }
    }
}