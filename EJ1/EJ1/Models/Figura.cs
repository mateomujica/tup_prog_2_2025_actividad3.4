using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1.Models
{
    abstract class Figura : IComparable
    {
        public double Altura { get; set; }

        public Figura (double altura)
        {
            this.Altura = altura;
        }

        public abstract string Describir();


        public virtual double CalcularVolumen()
        {
            return 0;
        }

        public override string ToString()
        {
            return Describir();
        }

        public int CompareTo(object obj)
        {
            Figura otra = obj as Figura;

            if (otra != null)
            {
                return this.CalcularVolumen().CompareTo(otra.CalcularVolumen());
            }
            return -1;
        }
            
        
      
        

        
    }
}
