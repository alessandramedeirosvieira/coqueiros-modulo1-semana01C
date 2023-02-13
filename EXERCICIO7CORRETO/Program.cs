// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write ("Qual o nome do aluno:");
string nome = Console.ReadLine ();

Console.Write ("Quantidade de notas que serão utilizadas: ");
int quantNotas = int.Parse (Console.ReadLine());

Console.Write (" Informe a 1ª nota: ");
double nota1 = double.Parse (Console.ReadLine ());

Console.Write (" Informe a 2ª nota: ");
double nota2 = double.Parse (Console.ReadLine ());

Console.Write (" Informe a 3ª nota: ");
double nota3 = double.Parse (Console.ReadLine ());

double media = ((nota1 + nota2 + nota3)/3);

Console.WriteLine ("Aluno: " + nome);
Console.WriteLine ("Nota1: " + nota1);
Console.WriteLine ("Nota2: " + nota2);
Console.WriteLine ("Nota3: " + nota3);
Console.WriteLine ("Média: " + media);

if (media >= 6)
{
    Console.WriteLine("Aluno aprovado!");
}
else if (media < 6 && media >=5)
{
    Console.WriteLine("Aluno em recuperação!");
}
else
{
    Console.WriteLine("Aluno reprovado!");
}