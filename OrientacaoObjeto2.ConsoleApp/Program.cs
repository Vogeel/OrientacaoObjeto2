using System;

namespace OrientacaoObjeto2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GrausFahrenheit conversao = new GrausFahrenheit();
            conversao.F = 20;
            Console.WriteLine($"{conversao.F}° Em Fahrenheit é a mesma coisa que {conversao.Convertido():F2}° graus Celcius");
            Console.ReadKey();
        }
    }
}
