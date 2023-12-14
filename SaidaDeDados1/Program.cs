Console.WriteLine("Saída de dados : formatação");

int idade = 25;
string nome = "Maria";
Console.Write(idade);
Console.Write(nome);
Console.WriteLine();

//usar concatenação
Console.WriteLine("----concatenação----");
Console.WriteLine(nome + " tem " + idade + " anos");

//usar interpolação
Console.WriteLine("----interpolação----");
Console.WriteLine($"{nome} tem {idade} anos");

//usar placeholders
Console.WriteLine("----placeholders----");
Console.WriteLine("{0} tem {1} anos", nome, idade);

Console.ReadLine();
