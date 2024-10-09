using Atividade01;

Livro livro1 = new Livro("A rainha vermelha", "Victoria Aveyard", "Grupo Editorial Record", "10 de fevereiro de 2015");

Livro livro2 = new Livro("Teto para dois", "Beth O’Leary", "Intrínseca", "9 de setembro de 2019");

Livro livro3 = new Livro("Quincas Borba", "Machado de Assis", " Fundação Editora Unesp", "1891");

Console.WriteLine("O primeiro exemplo de livro é: " + livro1.Titulo + " escrito por " + livro1.Autor + "e lançado no em " + livro1.Anodelançamento + " pela editora " + livro1.Editora);

Console.WriteLine("O segundo exemplo de livro é: " + livro2.Titulo + " escrito por " + livro2.Autor + "e lançado no em " + livro2.Anodelançamento + " pela editora " + livro2.Editora);

Console.WriteLine("O terceiro exemplo de livro é: " + livro3.Titulo + " escrito por " + livro3.Autor + "e lançado no em " + livro3.Anodelançamento + " pela editora " + livro3.Editora);

Console.ReadKey();


