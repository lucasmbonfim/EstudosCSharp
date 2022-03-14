using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = RetornaNomeEIdade("Lucas", "Bonfim");
            Console.WriteLine(nome);

            MeuMetodo();

            RetornaIdade();
        }

        static string RetornaNomeEIdade(
            string nome,
            string sobrenome,
            int idade = 20)
        {
            // Retorna o nome e sobrenome
            return nome + " " + sobrenome + " tem " + idade;
        }

        static void MeuMetodo()
        {
            Console.WriteLine("C# é legal!");
        }

        static void RetornaIdade()
        {
            Console.WriteLine("Idade: " + 25);
        }
    }
}
