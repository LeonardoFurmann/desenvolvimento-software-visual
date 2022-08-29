using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double real = 0;
            Console.WriteLine("Digite um valor em real: ");
            real = Convert.ToDouble(Console.ReadLine());

            ConverterDolar(real);
            ConverterPeso(real);
            ConverterEuro(real);


            static void ConverterDolar(double real)
            {
                Console.Write("\nConversão para Euro: " + (real / 6.14));
            }

            static void ConverterPeso(double real)
            {
                Console.Write("\nConversão para Peso: " + (real / 0.65));
            }

            static void ConverterEuro(double real)
            {
                Console.Write("\nConversão para Dolar: " + (real / 5.17));
            }
        }
    }
}