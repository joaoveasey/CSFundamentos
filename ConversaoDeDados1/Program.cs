Console.WriteLine("Conversão de tipos\n");

//conversão implícita: o compilador converte automaticamente  (tipos compatíveis)
//conversão explícita: precisa ser feita manualmente --> (<tipo>) <nomeDaVariavel>

//implicita
Console.WriteLine("----Implícita----\n");
int numeroInt = 100;
float numeroFloat = numeroInt;
double numeroDouble = numeroFloat;

Console.WriteLine(numeroDouble);

//explicita
Console.WriteLine("----Explícita----\n");
double varDouble = 12.456; // 8 bytes
int varInt = (int)varDouble; // 4 bytes (perda de dados)

Console.WriteLine(varInt); //exibe apenas 12


Console.ReadLine();