namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
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
            //IMPLEMENTADO COM SUCESSO!|||
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            //Coloquei essa tratativa para que o usuario não digite um valor nulo ou um já existente||
            if (VeiculoNaoExiste(placa, veiculos) && !string.IsNullOrEmpty(placa))
            {
            veiculos.Add(placa);
            Console.WriteLine($"Veículo com placa {placa} foi estacionado.");
            }
            else
            {
            Console.WriteLine("Placa inválida. Esta placa já está registrada!");
            }
            bool VeiculoNaoExiste(string placa, List<string> veiculos)
            {
            return !veiculos.Contains(placa);
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");            
            //IMPLEMENTADO COM SUCESSO!|||
            string placa = Console.ReadLine();
           
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());

                //IMPLEMENTADO COM SUCESSO!|||
                decimal valorTotal =  precoInicial + precoPorHora * horas; 
                

                //IMPLEMENTADO COM SUCESSO!|||
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido após o tempo de: {horas} e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                foreach(string item in veiculos)
                {
                 Console.WriteLine($"Os veiculos estacionados são: {item}");
                //IMPLEMENTADO COM SUCESSO!||    
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
