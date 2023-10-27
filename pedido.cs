using System;
using System.Collections.Generic;

class Pedido
{
    private Cliente Cliente;
    private List<Pizza> Pizzas;
    private List<Bebida> Bebidas;

    public Pedido(Cliente Cliente, Pizza pizza, Bebida bebida)
    {
        this.Cliente = Cliente;

        this.Pizzas = new List<Pizza>();
        this.Pizzas.Add(pizza);

        this.Bebidas = new List<Bebida>();
        this.Bebidas.Add(bebida);
    }

    public Cliente getCliente()
    {
        return Cliente;
    }
    public void setCliente(Cliente C)
    {
        Cliente = C;
    }

    public List<Pizza> getPizza()
    {
        return Pizzas;
    }

    public void setPizza(Pizza P)
    {
        Pizzas.Add(P);
    }
    public List<Bebida> getBebida()
    {
        return Bebidas;
    }
    public void setBebida(Bebida b)
    {
        Bebidas.Add(b);
    }

    public void ImprimePedido()
    {
        Console.WriteLine("==============================================================");
        Console.WriteLine("=============       RECIBO DO PEDIDO       ==================");
        Console.WriteLine("==============================================================");

        Console.WriteLine($"Cliente: {Cliente.getnome()}");
        Console.WriteLine("> Pizza:");
        foreach (var pizza in Pizzas)
        {
            Console.WriteLine($" -{pizza.getNome()} - Preço: {pizza.getPreco()}");
            float Valortotalpizza = pizza.getPreco();
        }

        Console.WriteLine("> Bebida:");
        foreach (var bebida in Bebidas)
        {
            Console.WriteLine($" -{bebida.getNome()} - Preço: {bebida.getPreco()}");
            float Valortotalbebida = bebida.getPreco();
        }

        Console.WriteLine("==============================================================");

    }

}

