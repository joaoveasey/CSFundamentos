Console.WriteLine("Tipos de referência anuláveis");

//string nome = null;
//Console.WriteLine(nome.ToUpper()); //--> erro em tempo de execução

//como consertar?
string? nome1 = null; //ou atribuir um valor vazio ""
Console.WriteLine(nome1?.ToUpper());


Console.ReadKey();