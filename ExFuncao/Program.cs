using System;

namespace ExFuncao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite quantos números deseja calcular: ");
            int quant = int.Parse(Console.ReadLine());

           double[] numeros = new double[quant];

           for(int i = 0; i < numeros.Length ; i++){
               Console.WriteLine("Digite um número: ");
               numeros[i] = double.Parse(Console.ReadLine());
           }

            Console.Write("A média é:" + calculaMedia(numeros));
            calculaMediana(numeros);
            calculaModa(numeros);


        }

        static double calculaMedia(double[] numeros){
        double soma = 0;

        foreach(int n in numeros){
                soma += n;
        }

        // for(int i = 0; i < numeros.Length; i++){
        //         soma += numeros[i];
        // }

        return soma / numeros.Length;
    }

    static void calculaMediana(double[] numeros){

        Array.Sort(numeros);
        double mediana = 0;

        if(numeros.Length % 2 == 0){
            mediana = numeros[(numeros.Length / 2)] + numeros[(numeros.Length / 2 - 1)];
            mediana = mediana /2;
        }else {
            mediana = numeros[((numeros.Length / 2))];
        }

        Console.WriteLine("\nA mediana é " + mediana);
    }

    static async void calculaModa(double[] numeros){
        double[] contador = new double[numeros.Length];

        for(int i = 0; i < numeros.Length; i++){
            contador[i] = 0;

            for(int j = 0; j < numeros.Length; j++){

                if( numeros[i] == numeros[j]){
                    contador[i]++;
                }
            }   
    }

        int maior = 0;
        for(int i = 0; i< numeros.Length; i++){
            if(contador[i] > contador[maior]){
                    maior = i;
                }
        }

     Console.WriteLine("A moda é: " + numeros[maior]);

    } 
}
}
