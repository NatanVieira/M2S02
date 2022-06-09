// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace GeraEstoque {

    class Program {
        static void Main(string[] args)
        {
            string? nome = "";
            double? qtdEstoque = 0;
            double? valorCompra = 0;
            double? valorVenda = 0;

            System.Console.WriteLine("Seja Bem Vindo ao GeraEstoque 1.0");
            System.Console.WriteLine("------------------------------------------");

            System.Console.WriteLine("1 - Cadastrar Produto");
            System.Console.WriteLine("2 - Consultar Produto");
            System.Console.WriteLine("3 - Modificar Produto");
            System.Console.WriteLine("4 - Excluir Produto");
            System.Console.WriteLine("0 - Sair");

            System.Console.WriteLine("Digite a opção:");
            string? escolhaUsuario = Console.ReadLine();

            switch(escolhaUsuario){
                case "1":
                    CadastrarProduto();
                    break;
                default:
                    break;
            }

            void CadastrarProduto(){
                Console.WriteLine("Preencha as informações abaixo");
                Console.WriteLine("Nome:");
                nome = Console.ReadLine();
                Console.WriteLine("Quantidade em estoque:");
                qtdEstoque = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Valor de compra:");
                valorCompra = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Valor de venda:");
                valorVenda = Convert.ToDouble(Console.ReadLine());  
            }
        }
    }
}
