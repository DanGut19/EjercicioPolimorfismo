using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    internal class Pentagono : Forma
    {
        public double Longitud { get; set; }

        public double Lado { get; set; }

        public double Altura { get; set; }

        public override double Area()
        {
            return Lado * Altura / 2 + Lado * Altura / 2 + Lado * Altura / 2 + Lado * Altura / 2 + Lado * Altura / 2;
        }

        public override double Perimetro()
        {
            return 6 * Longitud;
        }
    }
}
