// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(""); 
Console.WriteLine("Seja bem vindo ao programa que lhe trará a sequência de Fibonacci. Para iniciar basta dar um ENTER.");
Console.ReadLine(); 
int number=0; 
int fibo=1; 
int fibonacci; 
Console.WriteLine(number); 
for(int i=0;i<20;i++)
{     fibonacci=number+fibo; Console.WriteLine(fibonacci); 
number=+fibo; fibo=+(number+1); }
