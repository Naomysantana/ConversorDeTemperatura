using System;

namespace ConversorTemperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para o usuario digitar a temperatura em celsius fahrenheit e kelvin.
            double c, f, k;

            Console.WriteLine("### CONVERSOR DE TEMPERATURAS ###"); 
            Console.Write("Insira a temperatura em Celcius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            // Calculo para fahrenheit (c * 9 / 5) + 32 = F

            f = (c * 9 / 5) + 32;

            // Calculo para Kelvin: c + 273,15

            k = c + 273.15;

            Console.WriteLine( c + " graus celcius = " + f + " graus fahrenheit");
            Console.WriteLine( c + " graus celcius = " + k + " graus kelvin");
            Console.WriteLine("------------------------------");
            Console.ReadKey();
        }
    }
}
