using System;
using System.Collections.Generic;

namespace Atividade_01{
    class Program{
        static void Main(string[] args){

            Pedido pedido = new Pedido();  
            string produto;
            double valor, qt;

            char novoPedido = 's';
            do{
                Console.Clear();

                Console.WriteLine("Digite o nome do produto a adicionar?");
                produto = Console.ReadLine();
                Console.WriteLine("Digite o valor do produto?");
                valor = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade do produto?");
                qt = double.Parse(Console.ReadLine());

                pedido.NovoItem(produto, valor, qt);                
                Console.WriteLine("Adicionar novo pedido? (S/N)");
                novoPedido = char.Parse(Console.ReadLine());   
                             
            } while (novoPedido == 's' || novoPedido == 'S');
            Console.WriteLine("Total de R$" + pedido.TotalValorPedido() + " reais.");     
            
            Console.WriteLine("Descrição completa do pedido: ");            
            pedido.FinalPedido();   
            Console.WriteLine("Total de " + pedido.TotalItensPedido() + " itens por R$" + pedido.TotalValorPedido() + " reais.");
        }
    }
}
