using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private const int V = 0;
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string placa = Console.ReadLine(); //
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            veiculos.Add (placa.ToUpper());
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string placa = Console.ReadLine(); //
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            if (veiculos.Any(x => x.Equals(placa, StringComparison.CurrentCultureIgnoreCase)))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas; //

#pragma warning disable CS8602 // Dereference of a possibly null reference.
                _ = veiculos.Remove(placa.ToUpper()); //
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
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
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos) //
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}