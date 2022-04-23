namespace Desafio_05
{
    public class Aluno
    {
        public Aluno(string name, int idade, double nota)
        {
            Name = name;
            Idade = idade;
            Nota = nota;
        }

        public string Name { get; set; }
        public int Idade { get; set; }
        public double Nota { get; set; }
    }

}