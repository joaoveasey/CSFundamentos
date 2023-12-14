Console.WriteLine("Nullable Types");

Nullable<int> i = null; //aceita todos os valores int + null
Nullable<double> j = null; //aceita todos os valores double + null
Nullable<bool> k = null; //aceita os valores true, false e null

int? n1 =  null;
double? n2 = null;
bool? valor = null;


int? a = null;
int b = a ?? 0; //se a = null ele atribui 0 // se a != null, ele atribui o valor de a


//.HasValue e .Value
int? numero = 2;
        if (numero.HasValue)
        {
            Console.WriteLine($"número = {numero.Value}");
        }
        else
        {
            Console.WriteLine("número não existe (nulo)");
        }

Console.ReadLine();