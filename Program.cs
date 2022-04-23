using System;
using System.Collections.Generic;
using System.IO;

namespace Desafio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            var alunos = new List<Aluno>();
            InserirDadosDeAlunos(alunos);
            var somaDeNotas = SomaNotas(alunos);
            EscreverCSV(alunos, somaDeNotas);
            Console.WriteLine("csv gerado com sucesso");
        }

        private static void EscreverCSV(List<Aluno> alunos, double somaDeNotas)
        {
            var linhas = new List<string>();
            var cabecalho = "nome,idade,nota";
            foreach (var aluno in alunos)
            {
                var linha = aluno.Name + "," + aluno.Idade + "," + aluno.Nota;
                linhas.Add(linha);
            }

            using StreamWriter arquivo = new("Alunos.csv");
            arquivo.WriteLine(cabecalho);

            foreach (string line in linhas)
            {
                arquivo.WriteLine(line);
            }

            arquivo.WriteLine(somaDeNotas);
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
                var notaAlunoString = Console.ReadLine();
                var notaAluno = Math.Round(Convert.ToDouble(notaAlunoString), 2);
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
