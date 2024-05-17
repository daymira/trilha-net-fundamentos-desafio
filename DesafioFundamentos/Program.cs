using System.Reflection;
using System.Runtime.InteropServices;
using DesafioFundamentos.Models;

//exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Bem-vindo(a) ao sistema de estacionamento particular.\n"+
          "Digite o preço inicial: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o preço por hora: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());


Estacionamento estacionar = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while(exibirMenu){
    Console.WriteLine("Digite a opção desejada.\n"+
                      "1 - Adicionar veículo.\n"+
                      "2 - Listar veículos.\n"+
                      "3 - Remover veículo.\n"+
                      "4 - Encerrar.\n");

    switch(Console.ReadLine()){
        case "1":
            estacionar.AdicionarVeiculo();
            break;
        case "2":
            estacionar.ListarVeiculos();
            break;
        case "3":
            estacionar.RemoverVeiculo();
            break;
        case "4":
            exibirMenu = false;
            break;
        default:
        Console.WriteLine("Opção inválida.");
        break;
    }
    Console.WriteLine("Aperte enter para continuar.");
    Console.ReadLine();
}
Console.WriteLine("Programa encerrado.");