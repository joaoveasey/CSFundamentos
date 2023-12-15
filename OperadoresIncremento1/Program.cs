Console.WriteLine("Operadores de incremento e decremento");

//pós-incremento --> primeiro resolve depois incrementa
int x = 0;
Console.WriteLine($"x = {x}");

int resultado1 = x++ + 10;

Console.WriteLine($"pós-incremento ==> {resultado1}");
Console.WriteLine($"valor de x ==> {x} \n");

//pré-incremento --> primeiro incrementa depois resolve
int y = 0;
Console.WriteLine($"y = {y}");
int resultado2 = ++y + 10;

Console.WriteLine($"pré-incremento ==> {resultado2}");
Console.WriteLine($"valor de y ==> {y}");

Console.ReadKey();