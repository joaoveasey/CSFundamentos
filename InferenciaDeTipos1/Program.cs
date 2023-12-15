Console.WriteLine("Inferência de tipos (var)\n");

var idade = 15;
var nome = "Maria";
var salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e recebe {salario} reais");

//var limitações:
//var salario1 = null; --> valor nulo
//var titulo; --> não atribuir um valor
//var n1, n2; --> criar + que 1 na mesma linha

var num = 10;
num = num + 20;
// num = "Teste"; --> não pode mudar o tipo após inicialização

//podemos criar um método com var
var teste = new Teste();
teste.MeuMetodo();

Console.ReadKey();
class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Meu teste");
    }
}

//podemos usar o tipo var para declarar variáveis anônimas; em laços de repetição. sendo um "sugar syntax"