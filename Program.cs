using System;
using System.Collections.Generic;

namespace Desafio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            var alunos = new List<Aluno>();
            InserirDadosDeAlunos(alunos);
            var somaDeNotas = SomaNotas(alunos);
        }

        private static double SomaNotas(List<Aluno> alunos)
        {
            double somaDeNotas = 0;
            foreach (var aluno in alunos)
            {
                somaDeNotas += aluno.Nota;
            }

            return somaDeNotas;
        }

        private static void InserirDadosDeAlunos(List<Aluno> alunos)
        {
            while (true)
            {
                Console.WriteLine("Insira o nome do aluno:");
                var nomeAluno = Console.ReadLine();
                Console.WriteLine("Insira a idade do aluno:");
                var idadeAluno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira a nota do aluno:");
                var notaAluno = Convert.ToDouble(Console.ReadLine());
                var aluno = new Aluno(nomeAluno, idadeAluno, notaAluno);
                alunos.Add(aluno);
                Console.WriteLine("Deseja adicionar mais alunos?");
                Console.WriteLine("1 para sim e 2 para não.");
                var final = Convert.ToInt32(Console.ReadLine());
                if (final == 2)
                {
                    break;
                }
            }
        }
    }
}
