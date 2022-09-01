using System;

namespace Proj_Banco_Morangao
{
    internal class Program
    {
        #region TELAS E NAVEGAÇÃO
        static void TelaInicial()
        {
            int opcao=0;
            do
            {
                Console.Clear();
                Console.WriteLine("\t\tBem vindo ao Banco Morangão!\n");
                Console.WriteLine("\t\t0 - Encerrar Sessão -");
                Console.WriteLine("\t\t1 - Acesso para Clientes -");
                Console.WriteLine("\t\t2 - Acesso para Funcionários -");
                Console.Write("\t\tOpção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ///ACESSO CLIENTE
                        break;

                    case 2:
                        ///ACESSO DE FUNCIONARIOS
                        TelaInicioFuncionarios();
                        break;
                }
            } while (opcao != 0);
            Console.WriteLine("Encerrando...");
            ///aqui precisa salvar tudo que foi feito em arquivo texto antes de fechar de fato o programa...
        }
        static void TelaInicioFuncionarios()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("\t\t0 - Voltar para tela inicial -");
                Console.WriteLine("\t\t1 - Acesso para Atendente -");
                Console.WriteLine("\t\t2 - Acesso para Gerente -");
                Console.Write("\t\tOpção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ///ACESSO ATENDENTE
                        break;

                    case 2:
                        ///ACESSO GERENTE
                        TelaAcessoGerente();
                        break;
                }
            } while (opcao != 0);
            TelaInicial();
        }
        static void TelaAcessoGerente ()
        {
            int opcao=0;
            do
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("\t\t0 - Voltar para tela de Acesso de Funcionários -");
                Console.WriteLine("\t\t1 - Aprovar Cadastro de um Cliente -");
                Console.WriteLine("\t\t2 - Cadastrar um novo Funcionário -");
                Console.WriteLine("\t\t3 - Cadastrar uma nova Agência -");
                Console.WriteLine("\t\t4 - Ver lista de pedidos de Empréstimo -");
                Console.Write("\t\tOpção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ///Ver lista de pedidos de aprovação de Cadastro de conta
                        break;

                    case 2:
                        ///Abrir formulario de cadastro para gerar um novo Objeto FUNCIONARIO
                        break;
                    case 3:
                        ///Abrir formulario de cadastro para gerar uma nova agência
                        TelaCadastroAgencia();
                        break;
                    case 4:
                        ///ver lista de pedidos de Empréstimo para aprovar/negar os pedidos
                        break;
                }
            } while (opcao != 0);
            TelaInicioFuncionarios();
        }
        static void TelaCadastroAgencia ()
        {
            //variaveis para auxiliar no cadastro de varias agencias
            int numeroAgencia, numeroEndereco;
            String rua, cidade;

            Console.Clear();
            Console.WriteLine("\n\t\tCADASTRO DE UMA NOVA AGÊNCIA:");
            Console.WriteLine("\n\t\tInforme o endereço:\n");
            Console.WriteLine("\t\tCidade: ");
            cidade = Console.ReadLine();
            Console.WriteLine("\t\tRua: ");
            rua = Console.ReadLine();
            Console.WriteLine("\t\tNúmero: ");
            numeroEndereco = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\t\tNúmero de ID para essa Agência: ");
            numeroAgencia = int.Parse(Console.ReadLine());

            Console.ReadKey();
        }
        #endregion //region para as telas
        static void Main(string[] args)
        {
            ///para não esquecer:
            ///ao programa ser iniciado pela primeira vez, fazer os cadastros e ser usado, ao fechar ira antes salvar em arquivos texto
            ///tudo que tiver sido feito de movimentação importante... cadastros, listas, objetos, etc
            ///assim, quando for aberto o programa de novo, primeiro ele devera ler esses arquivos texto para ja
            ///carregar tudo que foi feito na sessão anterior

            TelaInicial();
        }
    }
}
