Console.WriteLine("Conversão de tipos (toString)\n");

int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 12.4567m;

string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);

//usando a classe Convert
//toBoolean();
//toChar();
//toDouble();
//toInt16();
//toInt32();
//toString();

int valorInt1 = 10;
double valorDouble1 = 5.35;
bool valorBool1 = false;

Console.WriteLine(Convert.ToString(valorInt1));
Console.WriteLine(Convert.ToDouble(valorInt1));
Console.WriteLine(Convert.ToString(valorBool1));
Console.WriteLine(Convert.ToInt32(valorDouble1));

//CUIDADO com converções de estreitamento pois acaba acontecendo a perda de dados, um OverflowException
//int inteiro = 10000;
//Console.WriteLine(Convert.ToByte(inteiro)); --> ocorre um erro em tempo de execução

Console.ReadLine();