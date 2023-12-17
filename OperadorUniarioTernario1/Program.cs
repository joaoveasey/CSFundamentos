Console.WriteLine("Operador Uniário e Ternário");

//uniario
Console.WriteLine("Informe o valor: \n");
var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O negativo de {n} é {-n}");

//ternario 
//avalia uma expressão booleana e retorna o resultado de uma das duas expressões dependendo se a expressão retorna true ou false
//sintaxe:
//condição ? expressao_se_True : expressao_se_False

Console.WriteLine("\nInforme a temperatura (em celsius):");
var temp = Convert.ToDouble(Console.ReadLine());

var resultado = temp > 27 ? "Quente" : "Normal";

Console.WriteLine($"O tempo está {resultado}");

//aninhando ternarios
Console.WriteLine("Informe o valor: \n");
var x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor: \n");
var y = Convert.ToInt32(Console.ReadLine());

var resultado1 = x > y ? "primeiro valor maior" :
                 x < y ? "segundo valor maior" :
                 x == y ? "valores iguais" : "sem resultado";

Console.WriteLine(resultado1);

Console.ReadKey();