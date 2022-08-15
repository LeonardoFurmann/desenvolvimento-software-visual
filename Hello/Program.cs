using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {

            double largura = 0;
            double altura = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Digite uma largura:");
                    largura = Convert.ToDouble(Console.ReadLine());
                    break;

                }
                catch (Exception erro)
                {
                    // Console.WriteLine(erro.Message);
                    Console.WriteLine("Largura inválida");
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Digite uma altura:");
                    altura = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception erro)
                {
                    Console.WriteLine("Altura inválida");
                }

            }

            Console.WriteLine("A area é " + CalculaArea(largura, altura));
        }

        static public double CalculaArea(double largura, double altura)
        {
            return largura * altura;
        }
    }
}



