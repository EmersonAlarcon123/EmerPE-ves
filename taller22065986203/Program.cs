using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller22065986203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Que operacion quiere realizar?");
                Console.WriteLine("1. Hallar Area de un triangulo");
                Console.WriteLine("2. Hallar Area de un rectangulo"); 
                Console.WriteLine("3. Hallar Area de un circulo");
                Console.WriteLine("4. Salir");
                string option = Console.ReadLine();
                switch(option)
                {
                    case "1":
                        Console.WriteLine("Ingrese la base del triangulo");
                        float a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la altura del triangulo");
                        float b = float.Parse(Console.ReadLine());
                        triangulo t = new triangulo(a, b);
                        Console.WriteLine("El area del triangulo es: " + t.Area());
                        break;
                    case "2":
                        Console.WriteLine("Ingrese la base del rectangulo");
                        float c = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la altura del rectangulo");
                        float d = float.Parse(Console.ReadLine());
                        rectangulo r = new rectangulo(c, d);
                        Console.WriteLine("El area del rectangulo es: " + r.Area());
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el radio del circulo");
                        float e = float.Parse(Console.ReadLine());
                        circulo c1 = new circulo(e);
                        Console.WriteLine("El area del circulo es: " + c1.Area());
                        break;
                    case "4":
                        continueFlag = false;
                        break;
                        default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }
    }
}
