// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine ("Informar a primeira medida de um lado do triângulo:");
int a = int.Parse (Console.ReadLine ());

Console.WriteLine ("Informar a segunda medida de um lado do triângulo:");
int b = int.Parse (Console.ReadLine ());

Console.WriteLine ("Informar a terceira medida de um lado do triângulo:");
int c = int.Parse (Console.ReadLine ());

if (a+b>c && a+c>b && b+c>a)
{
    Console.WriteLine ("Os três lados foram um triângulo");
}
else
{
    Console.WriteLine  ("Os três lados não foram um triângulo");
};
        if (a==b && a==c)
        {
            Console.WriteLine ("equilátero");
        }
        else if (a==b || a==c || c==b)
        {
            Console.WriteLine ("isósceles");
        }
        else if (a!=b && b!=c && c!=a)
        {
            Console.WriteLine ("escaleno");
        };
        
















        
        








    





       




        
        





















