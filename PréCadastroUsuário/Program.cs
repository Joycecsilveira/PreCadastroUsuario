using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PréCadastroUsuário
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, seja bem-vindo(a)!");
            Console.WriteLine("\n");

            Console.WriteLine("Digite o seu nome e sobrenome: ");
            string Name = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Digite a sua idade: ");
            UInt16 Age = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Documento: ");
            string Doc = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("De qual estado você é? ");
            string State = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Informe o seu gênero. Pressione F para feminino, M para masculino, ou O para outros");
            string Gender = Console.ReadKey(true).KeyChar.ToString();
            Console.WriteLine("\n");

            Console.WriteLine("Olá " + Name);
            Console.WriteLine("Você tem " + Age  + " anos de idade");
            Console.WriteLine("O número do seu documento é: " + Doc);
            Console.WriteLine("O nome do seu Estado é:  " + State);
            Console.WriteLine("O seu gênero é: " + Gender);
            Console.WriteLine("\n");

            Console.WriteLine("Cadastro efetuado com sucesso. Pressione qualquer tecla para encerrar.");
            Console.ReadKey();
        }
    }
}
