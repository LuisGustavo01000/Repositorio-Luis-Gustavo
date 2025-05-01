using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
   public  class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura) : base("Retângulo")
        {
            Largura = largura;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return Largura* Altura;
        }
        public override double CalcularPerimetro()
        {
             return 2 * (Largura + Altura);
        }

        public override void Mostrar()
        {
            base.Mostrar();
        }
    }
}
