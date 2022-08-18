﻿namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor : ");
            int num = Convert.ToInt16(Console.ReadLine());


         Fibonacci(num);

        }

        static void Fibonacci(int num){

            int[] fibonacci = new int[num + 2];

             fibonacci[0] = 0;
             fibonacci[1] = 1;
             

             for(int i = 2; i < num ; i++){
                    fibonacci[i] = fibonacci[i-1] + fibonacci[i -2];

                    if(fibonacci[i] <= num){
                    Console.WriteLine(fibonacci[i]);        
                    } else {
                        break;
                    }


             }          

        }
    }
}