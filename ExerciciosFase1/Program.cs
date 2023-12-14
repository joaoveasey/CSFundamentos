//1) Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.
using System.Drawing;
using System.IO.Pipes;

int idade = 35;
Console.WriteLine(idade);

//2) Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.
string nome = "Maria";
Console.WriteLine(nome);

//3) Crie uma variável chamada altura e atribua a ela o valor 3.45.
float altura = 3.45f;
Console.WriteLine(altura);

//4) Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor.
DateTime data = new DateTime(1999, 09, 04);
Console.WriteLine(data);

//5) Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor;
const int ANO = 12;
Console.WriteLine(ANO);

//6) Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor.
Nullable<double> nota = 7.80; //double? nota = 7.80; --> poderia ser feito assim também
Console.WriteLine(nota);

//7) Quais as diferenças entre os tipos por valor e os tipos por referência ?
// R: os tipos por valor são declarados e contém diretamente seus dados, ficam na memória STACK, alguns exemplos de tipos por valor são: int, double, decimal, etc.
// os tipos por referência não contém diretamente seus dados, eles armazenam apenas a referência (endereço na memória HEAP), alguns exemplos são: string, dynamic, object.

//8) Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:

//( int ) x = 10;
//( double ) numero = 7.99;
//( char ) letra = 'C';
//( float ) temperatura = 27.4f;
//( bool ) ativo = false;
//( string ) nome = "Manoel";
//( decimal ) salario = 950.99m;
//( datetime ) hoje = DateTime.Now;

//9 - Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por referência (R) :

//(V ) int n = 1;
//(R ) string titulo = "A vida";
//(V ) float f = 12.45f;
//(V ) double d = 5.45;
//(V ) decimal valor = 10.99m;
//(V ) char sexo = ‘M’;
//(R ) object o = null;

//10) O que é um nullable type e qual a sua utilidade ?
//R: nullable type é uma utilidade do c# que permite com que valores possam ser nulos, pode ser útil quando há a necessidade de armazenar um valor nulo,
//como em um banco de dados, por exemplo.

//11) O que é Camel Case ? Dê um exemplo de sua aplicação.
//R: Camel Case é um conceito para nomear, onde o nome precisa ser sem espaços, a primeira letra deve ser mínuscula e cada nova palavra deve iniciar com
//letra maiúscula, um exemplo de aplicação é ao nomear um valor em C#, por exemplo: int meuNumeroInteiro = 10;

//12) O que é Pascal Case ? Dê um exemplo de sua aplicação.
//R: Pascal Case também é um conceito para nomear, onde não temos espaços, e todas as palavras descritas devem iniciar com letra maiúcula, um exemplo
//de aplicação é ao nomear uma classe em C#, por exemplo: public class MinhaClasse {}.

//13) Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a seguir imprima o valor da soma de x com y.
//(Use o operador aritmético + para realizar a operação de soma)
int x = 77;
int y = 66;
Console.WriteLine(x + y);

//14) Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string.
//bool --> true ou false;
//char --> 'x';
//int --> x;
//double --> x.xx;
//float --> x.xxf;
//decimal --> x.xxm;
//string --> "x";

//15) - Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando a nomenclatura usada:

//(F ) double 1valor = 12.45;
//(F ) string #nome = "Pedro";
//(V ) float _temperatura = 12.45f;
//(F ) double int = 5;
//(F ) decimal renda extra = 91.45m;
//(F ) bool status$conta = false;
//(V ) string titulo3 = “Tópico 1”;
//(V ) float salario_mensal = 1999.55f;
//(V ) int percentualValorDesconto = 5;
//(V ) const bool MENSALIDADE_EM_DIA = true;


