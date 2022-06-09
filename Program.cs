// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Globalization;
namespace GeraEstoque {

    class Program {
        static void Main(string[] args)
        {
            string? nome = "";
            double? qtdEstoque = 0;
            decimal? valorCompra = 0M;
            decimal? valorVenda = 0M;

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
                valorCompra = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Valor de venda:");
                valorVenda = Convert.ToDecimal(Console.ReadLine());
                string id = Guid.NewGuid().ToString();
                Console.WriteLine("ID: {0}", id);
                Console.WriteLine("Nome: {0}", nome);
                Console.WriteLine("Qtd: {0}", qtdEstoque);
                Console.WriteLine($"R$ Compra: {valorCompra.ToString()}");
                Console.WriteLine($"R$ Venda: {valorVenda}");
            }
        }
    }
}
