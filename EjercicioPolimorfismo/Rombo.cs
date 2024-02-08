using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    internal class Rombo : Forma
    {
        public double DMayor { get; set; }
        public double DMenor { get; set; }
        public double Longitud { get; set; }

        public override double Area()
        {
            return (DMayor / DMenor) * 2;
        }

        public override double Perimetro()
        {
            return 4 * Longitud;
        }
    }
}
