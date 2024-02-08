// See https://aka.ms/new-console-template for more information
using EjercicioPolimorfismo;
using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("EjercicioPolimorfismo");

        Trapecio trapecio = new Trapecio();
        Pentagono pentagono = new Pentagono();
        Hexagono hexagono = new Hexagono();

        int menu()
        {

            int opcion;
            Console.WriteLine("************************************");
            Console.WriteLine("*             MENU                 *");
            Console.WriteLine("* 1. Area del Pentagono            *");
            Console.WriteLine("* 2. Perímetro del Pentagono       *");
            Console.WriteLine("* 3. Area del Hexagono             *");
            Console.WriteLine("* 4. Perímetro del Hexagono        *");
            Console.WriteLine("* 5. Area del Trapecio             *");
            Console.WriteLine("* 6. Perímetro del Trapecio        *");
            Console.WriteLine("* 7. Salir                         *");
            Console.WriteLine("************************************");
            Console.WriteLine("Escoja la opción:");
            opcion = int.Parse(Console.ReadLine());
            return opcion;
        }


        void AreaPentagono()
        {
            Console.WriteLine("********************************************************");
            Console.WriteLine("*                  AREA DEL Pentagono                  *");
            Console.WriteLine("********************************************************");
            Console.WriteLine("Ingrese la Longitud:");
            pentagono.Longitud = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Altura:");
            pentagono.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Lado");
            pentagono.Lado = double.Parse(Console.ReadLine());
            Console.WriteLine($"El área del triángulo es: {pentagono.Area()}");
        }

        void PerimetroPentagono()
        {
            Console.WriteLine("********************************************************");
            Console.WriteLine("*                PERIMETRO DEL Pentagono               *");
            Console.WriteLine("********************************************************");
            Console.WriteLine("Ingrese la Longitud:");
            pentagono.Longitud = double.Parse(Console.ReadLine());
            Console.WriteLine($"El perímetro del triángulo es: {pentagono.Perimetro()}");
        }

        void AreaHexagono()
        {
            Console.WriteLine("********************************************************");
            Console.WriteLine("*                  AREA DEL Hexagono                   *");
            Console.WriteLine("********************************************************");
            Console.WriteLine("Ingrese la base:");
            hexagono.Metro = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura:");
            hexagono.Longitud = double.Parse(Console.ReadLine());
            Console.WriteLine($"El área del rectángulo es: {hexagono.Area()}");
        }

        void PerimetroHexagono()
        {
            Console.WriteLine("********************************************************");
            Console.WriteLine("*               PERIMETRO DEL Hexagono                 *");
            Console.WriteLine("********************************************************");
            Console.WriteLine("Ingrese la base:");
            hexagono.Metro = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado:");
            hexagono.Longitud = double.Parse(Console.ReadLine());
            Console.WriteLine($"El perímetro del triángulo es: {hexagono.Perimetro()}");
        }

        void AreaTrapecio()
        {
            Console.WriteLine("********************************************************");
            Console.WriteLine("*                    AREA DEL Trapecio                 *");
            Console.WriteLine("********************************************************");
            Console.WriteLine("Ingrese el radio:");
            trapecio.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el radio:");
            trapecio.BMayor = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el radio:");
            trapecio.BMenor = double.Parse(Console.ReadLine());
            Console.WriteLine($"El área del círculo es: {trapecio.Area()}");
        }

        void PerimetroTrapecio()
        {
            Console.WriteLine("********************************************************");
            Console.WriteLine("*                 PERIMETRO DEL CIRCULO                *");
            Console.WriteLine("********************************************************");
            Console.WriteLine("Ingrese el Lado Mayor:");
            trapecio.LMayor = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Lado Menor:");
            trapecio.LMenor = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el BMayor:");
            trapecio.BMayor = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el BMenor:");
            trapecio.BMenor = double.Parse(Console.ReadLine());
            Console.WriteLine($"El perímetro del círculo es: {trapecio.Perimetro()}");
        }

        int opcion = menu();
        do
        {
            switch (opcion)
            {
                case 1:
                    AreaPentagono();
                    break;
                case 2:
                    PerimetroPentagono();
                    break;
                case 3:
                    AreaHexagono();
                    break;
                case 4:
                    PerimetroHexagono();
                    break;
                case 5:
                    AreaTrapecio();
                    break;
                case 6:
                    PerimetroTrapecio();
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

            opcion = menu();

        } while (opcion != 7);
    }
}