using System;

namespace Exercicio___Gerenciamento_de_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[10];
            float[] preco = new float[10];
           bool[] promocao = new bool [10];
            int contator = 0;

            
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Sistema de Gerenciamento de Produtos.");
            Console.WriteLine("-------------------------------------------");
            int Menu;
            
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("Escolha uma opção válida.");
                Console.WriteLine("[1]Cadastrar Produto");
                Console.WriteLine("[2]Listar Produtos Cadastrados");
                Console.WriteLine("[0] Sair");
                Menu = int.Parse(Console.ReadLine());
                int contador = 0;
                string resposta;
                switch (Menu)
                {
                    case 1:
                    do
                    {
                        if(contador<10)
                        {
                            Console.WriteLine($"Digite o nome do {contador+1}º Produto");
                            nome[contador] = Console.ReadLine();
                            Console.WriteLine($"Digite o preço do {contador+1}º Produto");
                            preco[contador] = float.Parse(Console.ReadLine());
                            Console.WriteLine($"O {contador+1}º produto esta em promoção?");
                            promocao[contador] = bool.Parse(Console.ReadLine());
                            if (promocao[contador] == true)
                            {
                                Console.WriteLine("O produto esta em promoção");
                            }
                            else
                            {
                                Console.WriteLine("O produto não esta em promoção");
                            }
                            
                            
                            contador++;
                            
                        }
                        else
                        {
                            Console.WriteLine("Excedido o número de produtos cadastrados");
                            break;
                        }
                        Console.WriteLine("Gostaria de cadastrar um novo produto?");
                        resposta = Console.ReadLine();
                        
                        
                    } while (resposta == "sim");
                    if(contador > contator)
                    {
                        contator = contador;
                    }
                    break;
                    case 2:
                        for (var i = 0; i < contator; i++)
                        {
                            
                            Console.WriteLine($"Produto: {nome[i]}");
                            Console.WriteLine($"Preço: {preco[i]}");
                            Console.WriteLine($"Promoção:{promocao[i]}");
                            
                        }
                    break;
                    case 0:
                    break;

                    default:
                    break;
                }
            }while(Menu != 0);
        }
    }
}
