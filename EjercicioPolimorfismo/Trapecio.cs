using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    internal class Trapecio : Forma
    {
        public double BMayor { get; set; }
        public double BMenor { get; set; }
        public double Altura { get; set; }
        public double LMayor { get; set; }
        public double LMenor { get; set; }

        public override double Area()
        {
            return BMayor + BMenor * Altura / 2;
        }

        public override double Perimetro()
        {
            return BMayor + BMenor + LMayor + LMenor;
        }
    }
}
