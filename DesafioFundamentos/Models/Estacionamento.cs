namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        int contadorCarros = 0;
        int contadorMotos = 0;
        string placaCarro;
        string placaMoto;
        

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
    {
        // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
        //IMPLEMENTADO COM SUCESSO!|||
        //Adicionado uma verificação para pegar o input do usuário se o veículo é um carro ou uma moto ||
        Console.WriteLine("Digite se o seu veículo é um Carro ou uma Moto:");
        string input = Console.ReadLine();

        while (input == "Carro" || input == "Moto")
        {
            if (input == "Carro")
            {
                Console.WriteLine("Digite a placa do seu Carro para estacionar:");
                placaCarro = Console.ReadLine();

                 //Coloquei essa tratativa para que o usuario não digite um valor nulo ou um já existente||
                if (VeiculoNaoExiste(placaCarro, veiculos))
                {
                    veiculos.Add(placaCarro);
                    Console.WriteLine($"Carro com placa {placaCarro} foi estacionado com sucesso!.");
                    contadorCarros++;
                }
                else
                {
                    Console.WriteLine("Placa inválida. Esta placa já está registrada!");
                }
            }
            else if (input == "Moto")
            {
                Console.WriteLine("Digite a placa da sua Moto para estacionar:");
                string placaMoto = Console.ReadLine();

                if (VeiculoNaoExiste(placaMoto, veiculos))
                {
                    veiculos.Add(placaMoto);
                    Console.WriteLine($"Moto com placa {placaMoto} foi estacionada com sucesso!.");
                    contadorMotos++;
                }
                else
                {
                    Console.WriteLine("Placa inválida. Esta placa já está registrada!");
                }
                }

            Console.WriteLine("Digite se o seu veículo é um Carro ou uma Moto (ou 'sair' para encerrar):");
            input = Console.ReadLine();
        }

        bool VeiculoNaoExiste(string placa, List<string> veiculos)
        {
            return !veiculos.Contains(placa);
        }
    }


        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
             // Pedir para o usuário digitar a placa e armazenar na variável placa            
            //IMPLEMENTADO COM SUCESSO!|||
            string placa = Console.ReadLine();
           
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {

                //Coloquei uma condição para que quando o veiculo seja removido ele não apareça mais na lista de veículos ||
                
                if (contadorCarros > 0 && veiculos.Contains(placaCarro))
                {
                    veiculos.Remove(placaCarro);
                    Console.WriteLine($"Carro com placa {placaCarro} removido com sucesso!");
                    contadorCarros--;
                }
                else if (contadorMotos > 0 && veiculos.Contains(placaMoto))
                {
                    veiculos.Remove(placaMoto);
                    Console.WriteLine($"Moto com placa {placaMoto} removida com sucesso!");
                    contadorMotos--;
                }
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());
                
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal
                //IMPLEMENTADO COM SUCESSO!|||
                decimal valorTotal =  precoInicial + precoPorHora * horas; 
                
                 // TODO: Remover a placa digitada da lista de veículos
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
                 // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                //IMPLEMENTADO COM SUCESSO!||    
                }
                //Implementei contadores de carros e de motos para imprimir para o usuário a quantidade de carros e motos estacionadas||
                Console.WriteLine($"A quantidade de Carros estacionados são de: {contadorCarros}");
                 Console.WriteLine($"A quantidade de Motos estacionadas são de: {contadorMotos}");
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
