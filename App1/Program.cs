// ------------------------------------------
// PROGRAMA 1 - APRESENTAÇÃO PESSOAL
// ------------------------------------------

string nome = "Lucas Gomes Coelho";
int idade = 23;
string cidade = "Rio de Janeiro";
string profissaoDosSonhos = "Desenvolvedor Backend";

Console.WriteLine("=== APRESENTAÇÃO PESSOAL ===");
Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Idade: {idade}");
Console.WriteLine($"Cidade: {cidade}");
Console.WriteLine($"Profissão dos sonhos: {profissaoDosSonhos}");
Console.WriteLine();


// ------------------------------------------
// PROGRAMA 2 - CADASTRO DE PRODUTO
// ------------------------------------------

string nomeProduto = "Teclado Mecânico";
decimal preco = 250.00m;
int quantidadeEstoque = 15;

Console.WriteLine("=== CADASTRO DE PRODUTO ===");
Console.WriteLine($"Produto: {nomeProduto}");
Console.WriteLine($"Preço: R$ {preco:F2}");
Console.WriteLine($"Quantidade: {quantidadeEstoque}");
Console.WriteLine();


// ------------------------------------------
// PROGRAMA 3 - CALCULADORA SIMPLES
// ------------------------------------------

int numero1 = 10;
int numero2 = 5;

Console.WriteLine("=== CALCULADORA SIMPLES ===");
Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
Console.WriteLine($"{numero1} * {numero2} = {numero1 * numero2}");
Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
Console.WriteLine();


// ------------------------------------------
// PROGRAMA 4 - VERIFICADOR DE IDADE
// ------------------------------------------

int idadePessoa = 23;

string resultadoIdade = idadePessoa >= 18
    ? "Maior de idade"
    : "Menor de idade";

Console.WriteLine("=== VERIFICADOR DE IDADE ===");
Console.WriteLine(resultadoIdade);
Console.WriteLine();


// ------------------------------------------
// PROGRAMA 5 - PRIMEIRA FUNÇÃO
// ------------------------------------------

Console.WriteLine("=== PRIMEIRA FUNÇÃO ===");
ExibirMensagem();
Console.WriteLine();

void ExibirMensagem()
{
    Console.WriteLine("Estou aprendendo C# e criando minhas primeiras funções!");
}


// ------------------------------------------
// DESAFIO BÔNUS - CALCULAR MÉDIA
// ------------------------------------------

double nota1 = 8;
double nota2 = 7;
double nota3 = 9;

double media = CalcularMedia(nota1, nota2, nota3);

Console.WriteLine("=== DESAFIO BÔNUS ===");
Console.WriteLine($"Nota 1: {nota1}");
Console.WriteLine($"Nota 2: {nota2}");
Console.WriteLine($"Nota 3: {nota3}");
Console.WriteLine($"Média: {media:F2}");

double CalcularMedia(double n1, double n2, double n3)
{
    return (n1 + n2 + n3) / 3;
}