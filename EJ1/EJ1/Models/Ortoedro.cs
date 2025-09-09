using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1.Models
{
    internal class Ortoedro : Figura 
    {
        public double Ancho { get; set; }
        public double Largo { get; set; }

        public Ortoedro (double ancho, double largo, double alto) : base (alto)
        {
            Ancho = ancho;
            Largo = largo;
        }

        public override string Describir()
        {
            return $"{Ancho}-{Largo}-{Altura} Vol {CalcularVolumen()}";
        }

        public override double CalcularVolumen()
        {
            return Ancho * Largo * Altura;
        }
    }
}
