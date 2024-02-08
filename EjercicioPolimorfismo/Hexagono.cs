using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    internal class Hexagono : Forma
    {

        public double Longitud { get; set; }
        public double Metro { get; set; }
        
        public override double Area()
        {
            return Metro * 5 / 2;
        }

        public override double Perimetro()
        {
            return Longitud * 6;
        }
    }
}
