﻿
//criado a lista que será nossa transação
List <double> transacao = new List<double>();

// criacao de variavel opcao
string opcao;

//as 2 variaveis acima sao criadas qdo o sistema inicia (não serão recriadas)

//enquanto não selecionar 3, o menu vai continuar repetindo
do{
   Console.WriteLine("Bem vindo ao Banco Nacional Coqueiros, por favor selecione uma opção para continuar: ");
   Console.WriteLine("1 - Adicionar Transação");
   Console.WriteLine("2 - Consultar extrato");
   Console.WriteLine("3 - Sair");
   opcao = Console.ReadLine();

//se a opcao for 1, aparece mensagem para digitar o valor, dá a leitura do double e adiciona
   if (opcao == "1"){
      Console.Write("Digite o valor a ser depositado:R$ ");
      transacao.Add (double.Parse (Console.ReadLine()));
      }

//se a opçcao for 2, mostra o extrato e o saldo (somando a cada loop que der)
    else if (opcao == "2") {
     Console.WriteLine("Seu extrato: ");
     double saldo = 0;
     foreach (var valor in transacao) {
        saldo = saldo + valor;
        Console.WriteLine($"R$ " + valor);
        }
    Console.WriteLine ("Seu saldo é de R$ " + saldo);
    }
     
     }while (!(opcao == "3"));
