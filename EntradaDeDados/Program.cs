Console.WriteLine("Entrada de dados\n");

Console.WriteLine("\n----Informe seu nome: \n");
string nome = Console.ReadLine();

Console.WriteLine("\n----Informe sua idade: \n");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nO seu nome é {nome}");
Console.WriteLine($"e você tem {idade} anos");

Console.ReadKey(); //método usado para segurar a tela

