using System;

namespace Ex6{
    class Program
    {
    static void Main(string[] args)
    {

    int[] numeros = { 230, 45, 345, 4, 324, 90, 76, 34, 67, 11, 7 };
        foreach(int numero in numeros){
            Console.Write(numero + " ");
        }

Console.Write("\n");


        int[] arrayOrdenado = IntArrayQuickSort(numeros);
            foreach (int numero in arrayOrdenado){
                Console.Write(numero + " ");
            }
    }


     public static int[] IntArrayQuickSort(int[] data)
        {
            var resultado = IntArrayQuickSort(data, 0, data.Length - 1);
            return resultado;
        }
    public static int[] IntArrayQuickSort(int[] data, int l, int r)
        {
            int i, j;
            int x;
            i = l;
            j = r;

            x = data[(l + r) / 2]; /* acha o item pivot */
            
            while (true)
            {
                while (data[i] < x)
                    i++;
                while (x < data[j])
                    j--;
                if (i <= j)
                {
                    TrocarValores(data, i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (l < j)
                IntArrayQuickSort(data, l, j);
            if (i < r)
                IntArrayQuickSort(data, i, r);
            return data;
        }

        public static int[] TrocarValores(int[] arrayDados, int m, int n)
        {
            int temp;
            temp = arrayDados[m];
            arrayDados[m] = arrayDados[n];
            arrayDados[n] = temp;
            return arrayDados;
        }
    }
}

