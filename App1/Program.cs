
//Programa 1
Console.WriteLine("Programa 1");
var nome = NomeCompleto();
Console.WriteLine(nome);

string NomeCompleto()
{
    var primeiroNome = "Lucas";
    var segundoNome = "Coelho";

    return primeiroNome + " " + segundoNome;
}


//Programa 2 
Console.WriteLine("Programa 2");
var idade = idadePessoa();
Console.WriteLine(idade);

short idadePessoa()
{
    short idade = 23;
    return idade;
}


//Programa 3
Console.WriteLine("Programa 3");
decimal preco1 = 20.90m;
decimal preco2 = 70m;

var soma = preco1 + preco2;
Console.WriteLine(soma);
Console.WriteLine("Preço = " + preco1);


//Programa 4
Console.WriteLine("Programa 4");
const string nomeFazenda = " Rancho Verde";
Console.WriteLine("Fazenda" + nomeFazenda);

//Programa 5
Console.WriteLine("Programa 5");

int numero1 = 10;
int numero2 = 5;

int multiplicacao = numero1 * numero2;

Console.WriteLine("Resultado da multiplicação: " + multiplicacao);




