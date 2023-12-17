// 1) Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato : Aluno<nome> tem<idade>
// anos e nota<nota> usando a concatenação e a interpolação de strings.
//var nome = "Paulo";
//var idade = 17;
//var nota = 7.5;
//Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}");
//Console.WriteLine("Aluno" + nome + "tem" + idade + "anos e nota" + nota);

// 2) Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes.
//Console.WriteLine($"Aluno {nome} \n tem {idade} anos \n e nota {nota}");

// 3) Para qual tipo de dados você pode converter um float implicitamente ?
//() int
//() double
//() long
//(x) decimal

// 4) Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
//( ) int para long
//( ) double para long
//( ) double para float
//( ) decimal para float
//(x) long para int
//( ) double para decimal

// 5) Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando a concatenação e também a interpolação de strings
//Console.WriteLine("Insira uma letra");
//var a = Console.ReadLine();
//Console.WriteLine("Insira uma letra");
//var b = Console.ReadLine();
//Console.WriteLine("Insira uma letra");
//var c = Console.ReadLine();

//Console.WriteLine($"{c}, {b} e {a}");
//Console.WriteLine(c + ", " + b + " e " + a);

// 6) Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
//(f ) long resultado = 1.32;
//(v ) var nome = “Maria”;
//(f ) string resultado = 100.ToString();
//(v ) A sequência de escape \n inclui uma nova linha
//(f ) float f = 5.45;
//(f ) decimal valor = (decimal)10.99f;
//(f ) var status = null;
//(v ) object o = 12.45m;
//(v ) string titulo = true.ToString();
//(f ) A sequencia \t inclui uma tabulação vertical

// 7) Escreva um programa para receber dois valores via teclado do tipo double e a seguir realize as operações de soma, subtração,
// multiplicação, exponenciação, divisão e módulo exibindo o resultado:
//Console.WriteLine("Escreva um valor");
//var valor1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Escreva outro valor");
//var valor2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"A soma será: {valor1 + valor2}");
//Console.WriteLine($"A subtração será: {valor1 - valor2}");
//Console.WriteLine($"A multiplicação será: {valor1 * valor2}");
//Console.WriteLine($"A divisão será: {valor1 / valor2}");
//Console.WriteLine($"A exponenciação será: {Math.Pow(valor1, valor2)}");
//Console.WriteLine($"A módulo será: {valor1 % valor2}");

// 8) Faça um programa para calcular o resultado da fórmula de baskara dados os valores de a b e c . Valores : a = 1 , b = 12 e c = -13
//double a = 1;
//double b = 12;
//double c = -13;

//double delta = (b * b) - (4 * a * c);

//double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
//double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
//Console.WriteLine($"O valor de X é x1 = {x1} , x2 = {x2}");

// 9) Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e Senha é um inteiro. Se o nome for igual a
// ‘admin’ ou ‘maria’ e a senha for igual a ‘123’ então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
//inválido’: (use o operador condicional ternário)
//Console.WriteLine("Insira seu nome: ");
//string? nome = Console.ReadLine();
//Console.WriteLine("Insira sua senha: ");
//int senha = Convert.ToInt32(Console.ReadLine());
//var resultado = 
//                (nome == "admin" && senha == 123) ? "Login feito com sucesso" : 
//                (nome == "maria" && senha == 123) ? "Login feito com sucesso" : "Login inválido";
//Console.WriteLine(resultado);

// 10) - Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando a nomenclatura usada:
//(v ) string? nome; é um exemplo de nullable reference type;
//(f ) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
//(f ) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)
//(v ) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
//(f ) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
//(f ) Para x = 25 e y=5 , a expressão ( y >= x ) && (y <= x); retorna true;
//(v ) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
//(f ) Para x = 10, o código Console.WriteLine(x+=x); imprime o valor 10;
//(f ) Para x = 5, a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
//(v ) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
//(v ) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?"

// 11) Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no console se x é par ou não e se y é par ou não.
//Use o operador condicional ternário (? :)
//Console.WriteLine("Insira um número: ");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Insira outro número: ");
//int y = Convert.ToInt32(Console.ReadLine());

//var resultadox =
//                (x % 2 == 0) ? $"{x} é par" : $"{x} não é par";

//var resultadoy =
//                (y % 2 == 0) ? $"{y} é par" : $"{y} não é par";

//Console.WriteLine($"{resultadox} | {resultadoy}");

// 12) Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no console o resultado das seguintes operações : (x ^ 2->x ao quadrado) (pi = 3.1415)
//- 6 + x * 5
//(13 - 2) * x
//(x + -2) * (20 / x)
//(12 + x) / (x - 4)
//3 x ^ 2 + x + 10
//pi* x^2

//Console.WriteLine("Insira um número x: ");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"- 6 + x * 5 = {-6 + x * 5}");
//Console.WriteLine($"(13 - 2) * x = {(13 - 2) * x}");
//Console.WriteLine($"(x + -2) * (20 / x) = {(x + -2) * (20 / x)}");
//Console.WriteLine($"(12 + x) / (x - 4) = {(12 + x) / (x - 4)}");
//Console.WriteLine($"3 x ^ 2 + x + 10 = {3 * x ^ 2 + x + 10}");
//Console.WriteLine($"pi* x^2 = {Math.PI * Math.Pow(x,2) }");

// 13)
//int y = 5;
//y = (y++) + y + (++y); // 5 + 6 + 7 = 18
//Console.WriteLine(y);


// 14) Escreva um programa que solicite a temperatura em graus Celsius e converta para Kelvin e Farhenheit usando as fórmulas a seguir:
//-Converter para Kelvin => K = C + 273;
//-Converter para Farhenheit => F = (C * 9) / 5 + 32;
//Console.WriteLine("Escreva uma temperatura em graus Celsius: ");
//double celsius  = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"A temperatura em Kelvin será de {celsius +273} e em farheineit será {(celsius * 9) / 5 + 32}");

