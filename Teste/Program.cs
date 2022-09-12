using System;

namespace Trabalho
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				var baseUsuarios = new BaseUsuarios("users.txt");
				
				baseUsuarios.Limpar();
				
				Console.WriteLine("limpei a base de usuarios:");
				Console.WriteLine(baseUsuarios.Serializar());
								
				var x = new Usuario("Huguinho", "huguinho@email.com", "senha123"  );
				var y = new Usuario("Zezinho" , "zezinho@email.com" , "senha321"  );
				var z = new Usuario("Luizinho", "luizinho@email.com", "minhaSenha");
				
				baseUsuarios.AdicionarUsuario(x);
				baseUsuarios.AdicionarUsuario(y);
				baseUsuarios.AdicionarUsuario(z);
				
				Console.WriteLine("adicionei huguinho, zezinho e luizinho:");
				Console.WriteLine(baseUsuarios.Serializar());
				
				var huguinho = baseUsuarios.BuscarPorEmail("huguinho@email.com");
				baseUsuarios.RemoverUsuario(huguinho);
				
				Console.WriteLine("removi huguinho:");
				Console.WriteLine(baseUsuarios.Serializar());
								
				var zezinho = baseUsuarios.BuscarPorEmail("luizinho@email.com");
				zezinho.SetNome("Luizao");
				baseUsuarios.AtualizarUsuario(zezinho);
				
				Console.WriteLine("atualizei nome do luizinho:");
				Console.WriteLine(baseUsuarios.Serializar());
				
				baseUsuarios.Salvar();
			}
			catch(Exception erro)
			{
				Console.WriteLine(erro.Message);
			}
		}
	}
}
