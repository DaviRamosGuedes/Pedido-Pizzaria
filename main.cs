using System;

class Program
{
    public static void Main(string[] args)
    {
        string opcao = "";
        string nomepizza = "";
        float valorpizza = 0;
        Pizza minhaPizza = null;
        string nomeBebida = "";
        float valorBebida = 0;
        Bebida minhaBebida = null;
        Cliente meuCliente;

        Pedido meuPedido;

        while (opcao != "0")
        {
            Console.Clear();
            Console.WriteLine("==============================================================");
            Console.WriteLine("====================       CARDÁPIO       ====================");
            Console.WriteLine("==============================================================");
            Console.WriteLine("==================== 0 - fechar cardápio  ====================");
            Console.WriteLine("==================== 1 - Realizar pedido  ====================");
            Console.WriteLine("==============================================================");
            string opcao1 = Console.ReadLine();

            switch (opcao1)
            {
                case "0":
                    break;

                case "1":

                    Console.WriteLine("Digite seu nome: ");
                    string nomeCliente = Console.ReadLine();
                    meuCliente = new Cliente(nomeCliente);

                    Console.WriteLine("Escolha o seu sabor de Pizza!!");
                    Console.WriteLine("1 - Margherita - R$ 25,00");
                    Console.WriteLine("2 - Pepperoni - R$ 30,00");
                    Console.WriteLine("3 - Portuguesa - R$ 45,00");

                    string op_pizza = Console.ReadLine();

                    switch (op_pizza)
                    {
                        case "1":
                            nomepizza = "Margherita";
                            valorpizza = 25;
                            minhaPizza = new Pizza(nomepizza, valorpizza);
                            break;

                        case "2":
                            nomepizza = "Pepperoni";
                            valorpizza = 30;
                            minhaPizza = new Pizza(nomepizza, valorpizza);
                            break;

                        case "3":
                            nomepizza = "Margherita";
                            valorpizza = 25;
                            minhaPizza = new Pizza(nomepizza, valorpizza);
                            break;

                    }

                    Console.WriteLine("1 - Aguá 500ml - R$ 6,00");
                    Console.WriteLine("2 - Coca-Cola 1l - R$ 10,00");
                    Console.WriteLine("3 - Não quero Bebida");
                    string op_bebida = Console.ReadLine();

                    switch (op_bebida)
                    {
                        case "1":
                            nomeBebida = "Aguá 500ml";
                            valorBebida = 6;
                            minhaBebida = new Bebida(nomeBebida, valorBebida);
                            meuPedido = new Pedido(meuCliente, minhaPizza, minhaBebida);
                            meuPedido.ImprimePedido(); // abrir aba pedido e ver pendencias
                            return;

                        case "2":
                            nomeBebida = "Coca-Cola 1l";
                            valorBebida = 10;
                            minhaBebida = new Bebida(nomeBebida, valorBebida);
                            meuPedido = new Pedido(meuCliente, minhaPizza, minhaBebida);
                            meuPedido.ImprimePedido(); // abrir aba pedido e ver pendencias
                            return;

                        case "3":
                            nomeBebida = "Não quero Bebida";
                            valorBebida = 0;
                            minhaBebida = new Bebida(nomeBebida, valorBebida);
                            meuPedido = new Pedido(meuCliente, minhaPizza, minhaBebida);
                            meuPedido.ImprimePedido(); // abrir aba pedido e ver pendencias
                            return;
                    }
                    //meuPedido = new Pedido(meuCliente,minhaPizza,minhaBebida);
                    //meuPedido.ImprimePedido(); // abrir aba pedido e ver pendencias
                    break;
                default:
                    Console.WriteLine("Selecione uma opção valida!!");
                    break;
            }
            //Console.Clear();

        }
    }
}