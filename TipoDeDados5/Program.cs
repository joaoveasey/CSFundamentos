//tipos de dados (data e hora)

//valor padrão:
//01/01/0001 00:00:00
//dd/mm/aaaa hh:mm:ss

//data atual
DateTime hoje = DateTime.Now; 

//extraindo infos da data atual
Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);

//adicionando valores
Console.WriteLine(hoje.AddDays(10));
Console.WriteLine(hoje.AddMonths(10));
Console.WriteLine(hoje.AddYears(10));

//obter dia da semana/ano
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

//diferentes formatos de data e hora (short, long)
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());

Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());


//criar uma data específica usa o formato: aaaa,mm,dd
DateTime data2005 = new DateTime(2005, 12, 22);
Console.WriteLine(data2005);


Console.ReadLine();