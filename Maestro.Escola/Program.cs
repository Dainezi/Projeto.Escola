using Maestro.Escola.Context;
using System;

namespace Maestro.Escola
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EscolaContext();

            foreach(var aluno in context.Alunos)
            {
                Console.WriteLine(aluno.NomeAluno);
            }
            Console.WriteLine("Banco criado");
            Console.ReadKey();
        }
    }
}
