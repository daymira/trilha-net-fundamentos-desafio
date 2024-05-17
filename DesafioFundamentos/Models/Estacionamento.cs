using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos;

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            this.veiculos = new List<string>();
        }


        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine() ?? string.Empty;

            if (!string.IsNullOrEmpty(placa) && !veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                veiculos.Add(placa);
                Console.WriteLine($"Placa {placa} adicionada com sucesso");
            }
            else
            {
                Console.WriteLine("A placa não pode ser nula ou já está estacionada. Tente novamente.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo que deseja remover: ");
            string placa = Console.ReadLine() ?? string.Empty;

            if (!string.IsNullOrEmpty(placa) && veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo ficou estacionado: ");

                string entradaHoras = Console.ReadLine() ?? string.Empty;

                if (int.TryParse(entradaHoras, out int horas) && horas >= 0)
            {
                decimal valorTotal = precoInicial + (precoPorHora * horas);
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo de placa {placa} foi removido e o valor total foi de R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("A quantidade de horas é inválida. Tente novamente.");
            }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são: ");
                foreach (string v in veiculos)
                {
                    Console.WriteLine(v);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
