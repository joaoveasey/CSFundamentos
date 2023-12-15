Console.WriteLine("Operadores de atribuição\n");

//usando operadores atribuição com tipos numericos
float x = 13.40f;
x = 20;
Console.WriteLine($"Valor inicial de x = {x}");
Console.WriteLine($"x += 5 = {x += 5}");
Console.WriteLine($"x -= 5 = {x -= 5}");
Console.WriteLine($"x *= 5 = {x *= 5}");
Console.WriteLine($"x /= 5 = {x /= 5}");
Console.WriteLine($"x %= 5 = {x %= 5}\n");

//usando + e += com strings
string y = "123";
Console.WriteLine($"Valor inicial de y = {y}");

y += "456";

Console.WriteLine($"y += \"456\" ==> {y}");

Console.ReadLine();