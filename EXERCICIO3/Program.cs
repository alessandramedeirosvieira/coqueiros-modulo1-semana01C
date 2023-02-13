// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write ("Informe a 1ª nota: ");
double nota1 = double.Parse (Console.ReadLine());

Console.Write ("Informe a 2ª nota: ");
double nota2 = double.Parse (Console.ReadLine());

Console.Write ("Informe a 3ª nota: ");
double nota3 = double.Parse (Console.ReadLine());

double mediaNota = ((nota1 + nota2 + nota3)/3);

if (mediaNota >= 6) {
    Console.WriteLine ("Aluno Aprovado com média " + mediaNota);
    }
else if (mediaNota >=5) {
   Console.WriteLine ("Aluno em Recuperação com média " + mediaNota); 
}
else {
    Console.WriteLine ("Aluno Reprovado com média " + mediaNota);
};












































