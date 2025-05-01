using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    public abstract class Forma
    {
        public string Nome { get; set; }

        public Forma(string nome)
        {
            Nome = nome;
        }

        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();

        public virtual void Mostrar()
        {
            Console.WriteLine($"Forma: {Nome}");
            Console.WriteLine($"Área: {CalcularArea():F2}");
            Console.WriteLine($"Perímetro: {CalcularPerimetro():F2}");
        }
    }
}