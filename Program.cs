// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
         
        Cliente cliente = new Cliente();
        cliente.MostrarInfo();
        
        Pedido pedido = new Pedido();
        pedido.Mostrapedido();

        Console.WriteLine(" ");

        Extra tienda = new Extra();

        tienda.MostrarInfo();
    }
}
