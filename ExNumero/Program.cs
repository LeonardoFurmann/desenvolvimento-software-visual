// Escreva uma algoritmo que receba uma string representando um númerointeiro e devolva um valor do tipo int que corresponda a este número.Exemplo: se a entrada for a string “13”, o algoritmo deve retornar o número 13.Lembre-se de que: (1) uma string é um array de valores do tipo char, podendoser percorrida por um laço; (2) um número em base decimal equivale à soma decada um de seus dígitos multiplicados pela potência de dez correspondente àcasa em que tal dígito se encontra, por exemplo:1987 = 1000 + 900 + 80 + 7 = 1×10³ + 9×10² + 8×10¹ + 7×10⁰


using System;

namespace Ex2
{
  class Program
  {
    static void Main(string[] args)
    {
      
        double soma =0 ;
        Console.WriteLine("Digite um número: ");
        String numero = Console.ReadLine();

        char[] n = numero.ToCharArray();

        for (int i = n.Length; i >- 0 ; i++)
        {
        
        for (int j = 0; j < n.Length; j++)
        {
          
        
          switch(n[i]){
            case '1':
            soma += 1 * (Math.Pow(10,i));
            break;
            case '2':
            soma += 2 * (Math.Pow(10,i));
            break;
            case '3':
            soma += 3 * (Math.Pow(10,i));
            break;
            case '4':
            soma += 4 * (Math.Pow(10,i));
            break;
            case '5':
            soma += 5 * (Math.Pow(10,i));
            break;
            case '6':
            soma += 6 * (Math.Pow(10,i));
            break;
            case '7':
            soma += 7 * (Math.Pow(10,i));
            break;
            case '8':
            soma += 8 * (Math.Pow(10,i));
            break;
            case '9':
            soma += 9 * (Math.Pow(10,i));
            break;
            case '0':
            soma += (Math.Pow(10,i));
            break;
            }
           }
        }

    Console.WriteLine(soma);

    }
  }
}