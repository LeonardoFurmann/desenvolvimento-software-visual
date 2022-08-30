using System;
using System.IO;
using System.Security.Cryptography;

namespace ExCadastro
{
    class Program
    {

        static void cadastrar(String username, String password){

            String usuarios = File.ReadAllText("cadastro.txt");

            
                if(usuarios.Contains(username)){
                    Console.WriteLine("Usuário já cadastrado");
                 } else {

             usuarios += "/n" + username + " = "  + password;

            File.WriteAllText("cadastro.txt", usuarios);

          //  File.AppendAllText("cadastro.txt", usuarios + "=" + password);
                   
                 }
       
        }

    static void logar(){
        Console.WriteLine("Digite um nome de usuário");
        String username = Console.ReadLine();
        Console.WriteLine("Digite uma senha");
        String password = Console.ReadLine();

         String usuarios = File.ReadAllText("cadastro.txt");

            
                if(usuarios.Contains(username) && usuarios.Contains(password)){
                    Console.WriteLine("Entrou!");
                 } else {
                    Console.WriteLine("Usuário não encontrado");
        }

    }
        static void Main(string[] args)
        {
            Console.WriteLine("Olá");
            Console.WriteLine("Digite 1 para cadastrar");
            Console.WriteLine("Digite 2 para logar");
            Console.WriteLine("Digite 3 para sair");
                bool sair = false;

                var sha = SHA256.Create();
                // Byte[] hash = sha.ComputeHash("");
                // String h = BitConverter.ToString(hash);

                while(!sair){
                    
                    int opcao =0;

                    try{

                     opcao = int.Parse(Console.ReadLine());
                    }
                    catch(Exception e){

                    }
                    

                    switch(opcao){

                        case 1:
                            Console.WriteLine("Digite um nome de usuário");
                            String username = Console.ReadLine();
                            Console.WriteLine("Digite uma senha");
                            String password = Console.ReadLine();
                            // TODO reforçar senha
                            Console.WriteLine("Confirma a senha");
                            String confirmacao = Console.ReadLine();

                            if(password != confirmacao){
                                Console.WriteLine("A senha não confere");
                            } else{

                            cadastrar(username, password);
                            }

                        break;

                        case 2:

                           logar();

                        break;

                        case 3:
                        sair = true;
                        break;

                        default:
                        Console.WriteLine("Opção invalida, digite novamente");
                        break;
                    }
                }


        }
    }
}
