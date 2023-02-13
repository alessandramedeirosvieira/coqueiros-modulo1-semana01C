// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine ("Bem vindo ao Banco Nacional Coqueiros, por favor selecione uma opção para continuar:");
Console.WriteLine ("1 -Adicionar Transação;");
Console.WriteLine ("2 -Consultar extrato;");
Console.WriteLine ("3 -Sair;");
Console.Write ("Digite a opção escolhida: ");

int opcao = int.Parse (Console.ReadLine());

if (opcao == 1)
{
    Console.WriteLine ("Adicionar Transação");
}
else if (opcao == 2) 
{
    Console.WriteLine ("Consultar extrato");
}
else if (opcao == 3)
{
    Console.WriteLine ("Sair");
}
else
{
    Console.WriteLine ("Escolha a opção desejada: 1 - Adicionar Transação; 2 - Consultar extrato; 3 - Sair;");
}


















