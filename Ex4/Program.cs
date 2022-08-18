namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor : ");
            int idade = Convert.ToInt16(Console.ReadLine());


         VerificarIdade(idade);

        }

    static void VerificarIdade(int idade){
        
        if(idade <= 13 && idade >= 0)  {
            Console.WriteLine("Criança ");
        } else if(idade > 13 && idade <18){
             Console.WriteLine("Adolescente ");
        }else if(idade > 18 && idade > 60){
             Console.WriteLine("Adulto ");
        }else if(idade > 60 && idade <= 12){
             Console.WriteLine("Idoso ");
        }else {
             Console.WriteLine("idade inválida");
        }
    }


    }
}