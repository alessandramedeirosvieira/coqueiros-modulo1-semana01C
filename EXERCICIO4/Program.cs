// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write ("Informe o valor do seu salário bruto:R$ ");
decimal salarioBruto = decimal.Parse (Console.ReadLine());

if (salarioBruto <= 900) {
    Console.WriteLine ("Isento");
}
else if (salarioBruto <= 1500) {
    Console.WriteLine (" Desconto de 5% sobre o salário");
}
else if (salarioBruto <= 2500) {
    Console.WriteLine (" Desconto de 10% sobre o salário");
}
else {
    Console.WriteLine ("Desconto de 20% sobre o salário");
};








