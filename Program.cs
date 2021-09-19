using System;

namespace Exercicio_GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            double celsius, fahrenheit;


            Console.Write("\nDigite o valor em graus celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = celsius* 1.8 + 32;
            
            Console.WriteLine($"\n{celsius}° é equivalente à {fahrenheit}°F\n");
            
        }

    }
}
