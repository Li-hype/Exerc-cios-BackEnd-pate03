namespace Atividade02
{
    public class Aluno
    {
        public int RM { get; set; }

        public string Nome { get; set; }

        public DateOnly Nascimento { get; set; }

        public string Email { get; set; }

        public Aluno(int rm, string nome, DateOnly nascimento, string email)
        {
            RM = rm;
            Nome = nome;
            Nascimento = nascimento;
            Email = email;

        }
    }
}
