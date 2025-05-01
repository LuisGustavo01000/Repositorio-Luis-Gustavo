using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    class Circulo : Forma
    {
        public double Raio { get; set; }

        public Circulo(double raio) : base("Círculo")
        {
            Raio = raio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }
        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }

        public override void Mostrar()
        {
            base.Mostrar();
        }
    }
}

