using Atividade02;
using System;

Aluno aluno1 = new Aluno( 1234, "Silvana Pereira", new DateOnly(2005,11,03), "silvana.pereira@gmail.com");

Aluno aluno2 = new Aluno(1835, "Marcos Pereira", new DateOnly(2006,04,22), "marcos.pereira@gmail.com");

Aluno aluno3 = new Aluno(2238, "Alice Silva", new DateOnly(2007,10,07), "alice.silva@gmail.com");

Console.WriteLine("A aluna " + aluno1.Nome + " possui o RM " + aluno1.RM + ", nasceu em " + aluno1.Nascimento + " e o E-mail é " + aluno1.Email);

Console.WriteLine("O aluno " + aluno2.Nome + " possui o RM " + aluno2.RM + ", nasceu em " + aluno2.Nascimento + " e o E-mail é " + aluno2.Email);

Console.WriteLine("A aluna " + aluno3.Nome + " possui o RM " + aluno3.RM + ", nasceu em " + aluno3.Nascimento + " e o E-mail é " + aluno3.Email);

Console.ReadKey();