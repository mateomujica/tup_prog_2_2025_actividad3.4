using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1.Models
{
    internal class Cilindro : Figura
    {
        public double Radio { get; set; }

        public Cilindro(double radio, double altura) : base (altura)
        {
           this.Radio = radio;
        }

        public override string Describir()
        {
            return $"{Radio}-{Altura}-Vol: {CalcularVolumen()}";
        }

        public override double CalcularVolumen()
        {
            return Math.PI * Math.Pow(Radio, 2) * Altura;
        }
    }
}
