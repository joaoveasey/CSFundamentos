//valores var e char

Console.WriteLine("Atribuindo valores para bool e char");
Console.WriteLine();

bool ativo = true;
Boolean inativo = false;

Console.WriteLine(ativo);
Console.WriteLine(inativo);

Console.WriteLine(10 == 15); //retorna falso
Console.WriteLine(10 == 10); //retorna verdadeiro

int x = 10;
int y = 15;
Console.WriteLine(x > y); //10 > 15??

char letra1 = 'A';
char letra2 = '\u0041'; //formato UNICODE, basta pesquisar https://symbl.cc/pt/unicode/table/ para achar os codigos

Console.WriteLine(letra1);
Console.WriteLine(letra2);


Console.ReadLine();
