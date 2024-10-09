using Atividade03;

Produto p1 = new Produto(8745, "Copo Rosa", 40.20, 5);

Produto p2 = new Produto(8247, "Copo Verde", 47.20, 8);

Produto p3 = new Produto(9437, "Copo Azul", 45.20, 5);

Console.WriteLine("O " + p1.Nome + " é R$" + p1.Preço + " reais,\nseu código é " + p2.Codigo + "\nEstá disponível no estoque:");
p1.valorEstoque();
Console.WriteLine("\nO " + p2.Nome + " é R$" + p2.Preço + " reais,\nseu código é " + p2.Codigo + "\nEstá disponível no estoque: ");
p2.valorEstoque();
Console.WriteLine("\nO " + p3.Nome + " é R$" + p3.Preço + " reais, \nseu código é " + p3.Codigo + "\nEstá disponível no estoque: ");
p3.valorEstoque();
Console.ReadKey();


