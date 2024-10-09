namespace Atividade01
{
    public class Livro
    {
        public string Titulo { get; set; }

        public string Autor { get; set;}
       
        public string Editora { get; set; }

        public string Anodelançamento { get; set; }

        public Livro(string titulo, string autor, string editora, string anodelancamento)
        {
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            Anodelançamento = anodelancamento;
        }
    }
}
