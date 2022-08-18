namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            int num1 =  Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite um valor: ");
            int num2 =  Convert.ToInt16(Console.ReadLine());

            Verificar(num1,num2);
        }


        static void Verificar(int num1, int num2){
            if(num1 > num2){
                Console.WriteLine("Maior: " + num1 + "\nMenor: " + num2);      
            } else if(num2 > num1){
                Console.WriteLine("Maior: " + num2 + "\n Menor: " + num1);
            } else{
                Console.WriteLine("Os números são iguais");
            }


        }

        
    }
}