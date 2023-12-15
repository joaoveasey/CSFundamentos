Console.WriteLine("Operadores aritméticos\n");

Console.WriteLine("----Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("----Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A soma de {x} e {y} é {x + y}");
Console.WriteLine($"A subtração de {x} e {y} é {x - y}");
Console.WriteLine($"A multiplicação de {x} e {y} é {x * y}");
Console.WriteLine($"A divisão de {x} e {y} é {x / y}");
Console.WriteLine($"O módulo de {x} e {y} é {x % y}");

Console.WriteLine($"\nRaíz quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"\nPotência de x elevado a y = {Math.Pow(x, y)}");
Console.WriteLine($"\nValor mínimo de x e y = {Math.Min(x, y)}");
Console.WriteLine($"\nValor máximo de x e y = {Math.Max(x, y)}");
Console.WriteLine($"\nCosseno de x = {Math.Cos(x)}");
Console.WriteLine($"\nSeno de x = {Math.Sin(x)}");
Console.WriteLine($"\nExponencial de x = {Math.Exp(x)}");

Console.ReadKey();