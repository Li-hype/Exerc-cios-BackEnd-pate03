using Atividade04;

Carro c1 = new Carro("Porsche", "718 Boxster Style Edition", 275, 165); 

Carro c2 = new Carro("Porsche", "718 Cayman GT4 RS", 315, 205); 

Carro c3 = new Carro("Porsche", "911 Carrera Cabriolet", 291, 118);

Console.WriteLine("A marca do carro é: " + c1.Marca + ", o modelo é:" + c1.Modelo); 
c1.Acelerar();
c1.Desacelerar1();


Console.WriteLine("\nA marca do carro é: " + c2.Marca + ", o modelo é:" + c2.Modelo);
c2.Acelerar();
c1.Desacelerar1();


Console.WriteLine("\nA marca do carro é: " + c3.Marca + ", o modelo é:" + c3.Modelo);
c3.Acelerar();
c1.Desacelerar1();

Console.ReadKey();