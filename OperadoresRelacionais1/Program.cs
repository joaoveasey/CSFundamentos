Console.WriteLine("Operadores Relacionais \n");

//com valores inteiros
int x = 10;
int y = 20;

Console.WriteLine($"Valor de x {x}");
Console.WriteLine($"Valor de y {y}");

Console.WriteLine(x == y); // --> armazena true ou false
Console.WriteLine(x > y);
Console.WriteLine(x < y);
Console.WriteLine(x >= y);
Console.WriteLine(x <= y);
Console.WriteLine(x != y);

//com valores string 
string a = "curso";
string b = "Curso";

Console.WriteLine($"Valor de a = {a}");
Console.WriteLine($"Valor de b = {b}");

Console.WriteLine(a.Equals(b)); // --> mesma coisa que (a == b)

Console.ReadKey();