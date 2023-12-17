Console.WriteLine("Precedência de operadores");

//ordem de precedência:
//[] , () , ++ , -- ==>(sufixos)
//! , ++ , -- ==>(prefixos)
//* , / , %
//+ , -
//< , > , >= , <=
// == , !=
//&&
//||
// = , *= , %= , -= , += , /=

bool bll = !(9 != 8) && (5 >= 7 || 8 >= 6);

Console.WriteLine(bll);

//--------------------------//

int a = 5, b = 6, c= 4;

int r = --a * b - ++c;

Console.WriteLine(r);


Console.ReadLine();