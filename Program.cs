// Exercício NomeCompleto
/*Receba o nome e o sobrenome do usuário separadamente. Exiba o nome completo no formato padrão Nome Sobrenome e no formato de catálogo SOBRENOME, Nome.

Exemplo:

Digite seu primeiro nome: Diego
Digite seu sobrenome: Neri

Nome completo: Diego Neri
Nome de catálogo: NERI, Diego*/
Console.WriteLine("Digite seu primeiro nome:");
String nome = Console.ReadLine();
Console.WriteLine("Digite seu sobrenome:");
String sobrenome = Console.ReadLine();

Console.WriteLine($"Seu nome e sobrenome:  {nome} {sobrenome}");
Console.WriteLine($"Seu nome de catálogo:  {sobrenome.ToUpper()}, {nome}");






