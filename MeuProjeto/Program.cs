using System.Threading.Channels;

Console.WriteLine("Declarando variáveis numéricas: ");
Console.WriteLine();

byte valor1 = 255;
sbyte valor2 = -127;
int valor3 = -2147483647;
uint valor4 = 2147483647;
long valor5 = 21474836489;

const int valor6 = 100; //valor não pode ser alterado (const)
//valor6 = 101;

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);
Console.WriteLine(valor5);
Console.WriteLine(valor6);

Console.ReadLine();