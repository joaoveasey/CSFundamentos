//tipos de referência : pré-definidos

Console.WriteLine("Definindo variáveis do tipo string, object e dynamic");
Console.WriteLine();

string nome = "Curso C#";
string titulo = "Curso C# Essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);

string valor = "Isto é uma string"; //"Isto é uma string" seria limpado pelo garbage collector por não ser usado

valor = "Isto é uma string alterada";


dynamic nota = 10;
dynamic valor1 = 8.55m;
dynamic nome1 = "Maria";
dynamic ativa = true;
dynamic letra = 'A';

Console.WriteLine(nota);
Console.WriteLine(valor1);
Console.WriteLine(nome1);
Console.WriteLine(ativa);
Console.WriteLine(letra);

Console.ReadLine();
