using System;
using System.Collections.Generic;
using System.Linq;

namespace Proj_Banco_Morangao
{
    internal class Program
    {
        // as listas para salvar os cadastros devem ficar aqui no inicio
        static List<Agencia> agencias = new List<Agencia>();
        static List<Funcionario> funcionarios = new List<Funcionario>();
        static List<Gerente> gerentes = new List<Gerente>();
        static List<Cliente> clientes = new List<Cliente>();
        //----------------------------------------------------------
        #region TELAS E NAVEGAÇÃO
        static void TelaInicial()
        {
            int opcao = 0;
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
                        TelaInicioClientes();
                        break;

                    case 2:
                        ///ACESSO DE FUNCIONARIOS
                        TelaInicioFuncionarios();
                        break;

                    case 0:
                        Console.WriteLine("\n\t\tEncerrando...");
                        Environment.Exit(0);
                        ///aqui precisa salvar tudo que foi feito em arquivo texto antes de fechar de fato o programa...
                        break;
                }
            } while (opcao != 0);
        }

        #region OPERAÇÕES RELACIONADAS AOS FUNCIONARIOS
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
                        TelaAcessoAtendente();
                        break;

                    case 2:
                        ///ACESSO GERENTE
                        TelaAcessoGerente();
                        break;
                    case 0:
                        TelaInicial();
                        break;
                }
            } while (opcao != 0);

        }
        static void TelaAcessoAtendente()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("\t\t0 - Voltar para tela de Funcionários -");
                Console.WriteLine("\t\t1 - Aprovar Cadastro de um novo Cliente -");
                Console.Write("\t\tOpção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ///Aprovar cadastros
                        AprovarCadastros();
                        break;
                    case 0:
                        ///voltar
                        TelaInicioFuncionarios();
                        break;
                }
            } while (opcao != 0);
        }
        static void AprovarCadastros()
        {
            Console.Clear();

            int idCliente;
            bool atendimento = false;
            do
            {
                int cont = 0;
                foreach (Cliente clientes in clientes)
                {
                    if (clientes.Acesso == false)
                    {
                        cont++;
                    }
                }
                Console.Write("\n\t\tQuantidade de pedidos: " + cont + "\n");
                if (cont > 0)
                {
                    foreach (Cliente cliente in clientes)
                    {
                        if (cliente.Acesso == false)
                        {
                            Console.WriteLine("\n\t\tID: " + cliente.NumeroDaConta + "\t|| Nome: " + cliente.NomeCliente);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\n\t\tLista de Pedidos vazia!");
                    PausaParaContinuar();
                    TelaInicioFuncionarios();
                }
                Console.Write("-----------------------------------------------------------------------------");
                Console.Write("\n\n\t\tDigite o ID do Cliente para ver seu pedido\n\n\t\tOU\n\n\t\tAperte '0' para sair");
                idCliente = int.Parse(Console.ReadLine());
                Console.Clear();
                if (idCliente == 0)
                {
                    TelaInicioFuncionarios();
                }
                else
                {
                    foreach (Cliente cliente in clientes)
                    {
                        if (idCliente == cliente.NumeroDaConta && cliente.Acesso == false)
                        {
                            Console.Write("\n\t\tSOLICITAÇÃO DE ABERTURA DE CONTA:\n\n");
                            Console.Write(cliente.MostrarPedidoDeAbertura());

                            Console.WriteLine("\n\n\t\tO cliente solicita uma " + cliente.VerTipoDeConta());

                            Console.Write("\n-----------------------------------------------------------------------------------------\n");
                            int opc = 0;
                            do
                            {
                                Console.Write("\n\t\t0 - VOLTAR     ");
                                Console.Write("\n\t\t1 - APROVAR    ");
                                Console.Write("\n\t\t2 - RECUSAR    ");
                                opc = int.Parse(Console.ReadLine());
                                switch (opc)
                                {
                                    case 0:
                                        AprovarCadastros();
                                        break;

                                    case 1:
                                        cliente.LiberarAcesso();
                                        atendimento = true;
                                        AprovarCadastros();
                                        break;

                                    case 2:
                                        Console.Clear();
                                        atendimento = false;
                                        Console.WriteLine("\n\t\tPedido Recusado!");
                                        PausaParaContinuar();
                                        AprovarCadastros();
                                        break;
                                }
                            } while (opc != 0);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n\t\tNúmero de ID inválido!\n\t\tEscolha um ID da lista para continuar.");
                        }
                    }
                    if (atendimento == true)
                    {
                        Console.Clear();
                        Console.WriteLine("\n\t\tPedido de Cadastro foi APROVADO!");
                        Console.WriteLine("\n\t\tPor favor, iforme o Cliente que seu ID de Acesso foi liberado!");
                    }
                    PausaParaContinuar();
                }

            } while (atendimento == false);

        }
        static void TelaAcessoGerente()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("\t\t0 - Voltar para tela de Acesso de Funcionários -");
                Console.WriteLine("\t\t1 - Aprovar Cadastro de um Cliente -");
                Console.WriteLine("\t\t2 - Cadastrar um novo Funcionário -");
                Console.WriteLine("\t\t3 - Cadastrar uma nova Agência -");
                Console.Write("\t\tOpção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ///Ver lista de pedidos de aprovação de Cadastro de conta
                        AprovarCadastros();
                        break;

                    case 2:
                        ///Abrir formulario de cadastro para gerar um novo Objeto FUNCIONARIO
                        TelaCadastroFuncionario();
                        break;
                    case 3:
                        ///Abrir formulario de cadastro para gerar uma nova agência
                        TelaCadastroAgencia();
                        break;
                }
            } while (opcao != 0);
            TelaInicioFuncionarios();
        }
        static void TelaCadastroAgencia()
        {
            //variaveis para auxiliar no cadastro de varias agencias
            int numeroAgencia = 0, numeroEndereco = 0;
            String rua = "", cidade = "";
            Agencia novaAgencia;

            Console.Clear();
            Console.WriteLine("\n\t\tCADASTRO DE UMA NOVA AGÊNCIA:");
            Console.WriteLine("\n\t\tInforme o endereço:\n");
            Console.Write("\t\tCidade: ");
            cidade = Console.ReadLine();
            Console.Write("\t\tRua: ");
            rua = Console.ReadLine();
            Console.Write("\t\tNúmero: ");
            numeroEndereco = int.Parse(Console.ReadLine());
            Console.Write("\n\t\tNúmero de ID para essa Agência: ");
            numeroAgencia = int.Parse(Console.ReadLine());

            novaAgencia = new Agencia(numeroAgencia, new Endereco(rua, numeroEndereco, cidade));
            agencias.Add(novaAgencia);//adiciona a nova agencia na lista (lista instanciada nas primeiras linhas do PROGRAM ^^^^^^
            PausaParaContinuar();

            ////////////////////////////////--- exemplo de como printar na tela todas as Agencias cadastradas na lista ---//////////////////
            //Console.Clear();
            //foreach (Agencia a in agencias)
            //{
            //    Console.WriteLine("\t\t-----------------------------------------------\n" +
            //                        a.MostrarAgenciaCadastrada());
            //}
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // instancia um novo objeto do tipo "AGENCIA" e como um dos seus parametros é "ENDERECO", o "new" já instancia tambem um
            //novo ojeto do tipo "ENDERECO" que dessa forma sera associado a essa nova agencia

        }
        static void TelaCadastroFuncionario()
        {
            String nome;
            int matricula;
            char gerencia;
            int numeroAgencia;
            Funcionario novoFuncionario;
            Gerente novoGerente;

            Console.Clear();
            Console.WriteLine("\n\t\tCADASTRO DE NOVO FUNCIONÁRIO:");
            Console.Write("\n\n\t\tInforme o Nome:");
            nome = Console.ReadLine();
            Console.Write("\n\t\tInforme o número de Matrícula: ");
            matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\t\tO funcionário terá capacidades Administrativas como Gerente?\n\t\t    ( S )  || ( N )");
            gerencia = char.Parse(Console.ReadLine().ToUpper());
            ///try catch aqui depois para evitar numeros no 'gerencia'

            bool cadastro = false;
            do
            {

                Console.Clear();
                Console.WriteLine("\n\n\t\tEste Funcionário será de qual Agência? ");
                foreach (Agencia a in agencias)
                {
                    Console.WriteLine("\t\t-----------------------------------------------\n" +
                                        a.MostrarAgenciaCadastrada());

                }
                Console.WriteLine("\t\t-----------------------------------------------\n");
                Console.Write("\n\n\t\tEscolha o Id da Agência desejada para continar: ");
                numeroAgencia = int.Parse(Console.ReadLine());

                foreach (Agencia a in agencias)
                {
                    if (numeroAgencia == a.NumeroId)
                    {
                        if (gerencia == 'S')
                        {
                            novoGerente = new Gerente(nome, matricula, a);
                            gerentes.Add(novoGerente);
                            cadastro = true;
                            break;
                        }
                        else if (gerencia == 'N')
                        {
                            novoFuncionario = new Funcionario(nome, matricula, a);
                            funcionarios.Add(novoFuncionario);
                            cadastro = true;
                            break;
                        }
                    }
                }
                if (cadastro == false)
                {
                    Console.WriteLine("\n\t\tAgência não encontrada!");
                }
                else if (cadastro == true)
                {
                    Console.WriteLine("\n\t\tCadastro efetuado com sucesso!");
                }
                PausaParaContinuar();
            } while (cadastro != true);
        }
        #endregion

        #region OPERAÇÕES RELACIONADAS AOS CLIENTES
        static void TelaInicioClientes()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("\t\t0 - Voltar para tela inicial -");
                Console.WriteLine("\t\t1 - Entrar com seu ID de Acesso -");
                Console.WriteLine("\t\t2 - Solicitar abertura de Conta -");
                Console.Write("\t\tOpção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ///Ir para validação de ID
                        TelaValidacaoIdCliente();
                        break;

                    case 2:
                        ///Ir para formulario de Cadastro de Clientes
                        TelaCadastroCliente();
                        break;
                    case 0:
                        TelaInicial();
                        break;
                }
            } while (opcao != 0);
        }
        static void TelaCadastroCliente()
        {
            String nome;
            String cpf;
            DateTime dataNascimento;
            String telefone;
            double faixaSalarial;
            int tipoDeConta, opc = 0, idCliente;
            int numeroAgencia = 0, numeroEndereco = 0;
            String rua = "", cidade = "";
            Cliente novoCliente;

            Console.Clear();
            Console.WriteLine("\n\t\tCADASTRO DE NOVO CLIENTE:");
            Console.WriteLine("\n\t\tVocê precisará de um ID para Acesso. Esse ID será como sua senha de Entrada,\n" +
                "\t\tpor favor utilize apenas números e guarde bem seu número de acesso!");
            Console.Write("\n\t\tInforme seu ID desejado: ");
            idCliente = int.Parse(Console.ReadLine());
            Console.Write("\n\t\tInforme o Nome: ");
            nome = Console.ReadLine();
            Console.Write("\n\t\tInforme o CPF: ");
            cpf = Console.ReadLine();
            Console.Write("\n\t\tInforme sua data de Nascimento (dd/MM/yy): ");
            dataNascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("\n\t\tInforme seu Telefone: ");
            telefone = Console.ReadLine();
            Console.Write("\n\t\tQual o valor médio que recebe Mensalmente? ");
            faixaSalarial = double.Parse(Console.ReadLine());

            do
            {
                Console.Clear();
                Console.WriteLine("\n\t\tQual tipo de conta você Prefere?");
                Console.WriteLine("\n\t\t1 - Conta Universitária");
                Console.WriteLine("\n\t\t2 - Conta Comum");
                Console.WriteLine("\n\t\t3 - Conta VIP");
                tipoDeConta = int.Parse(Console.ReadLine());
                if (tipoDeConta > 0 && tipoDeConta < 4)
                {
                    opc++;
                }
                else
                {
                    Console.WriteLine("\n\t\tOpção inválida!");
                    PausaParaContinuar();
                }

            } while (opc == 0);

            Console.Clear();
            Console.WriteLine("\n\t\tInforme o seu endereço:\n");
            Console.Write("\t\tCidade: ");
            cidade = Console.ReadLine();
            Console.Write("\t\tRua: ");
            rua = Console.ReadLine();
            Console.Write("\t\tNúmero: ");
            numeroEndereco = int.Parse(Console.ReadLine());

            bool cadastro = false;
            do
            {

                Console.Clear();
                Console.WriteLine("\n\n\t\tEm qual Agência você deseja se Cadastrar?");
                foreach (Agencia a in agencias)
                {
                    Console.WriteLine("\t\t-----------------------------------------------\n" +
                                        a.MostrarAgenciaCadastrada());

                }
                Console.WriteLine("\t\t-----------------------------------------------\n");
                Console.Write("\n\n\t\tEscolha o Id da Agência desejada para continar: ");
                numeroAgencia = int.Parse(Console.ReadLine());

                foreach (Agencia a in agencias)
                {
                    if (numeroAgencia == a.NumeroId)
                    {
                        novoCliente = new Cliente(idCliente, a, nome, cpf, dataNascimento, telefone, new Endereco(rua, numeroEndereco, cidade), faixaSalarial, tipoDeConta);
                        clientes.Add(novoCliente);
                        cadastro = true;
                        break;
                    }
                }
                if (cadastro == false)
                {
                    Console.WriteLine("\n\t\tAgência não encontrada!");
                }
                else if (cadastro == true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\tPedido de Cadastro efetuado com sucesso!");
                    Console.WriteLine("\n\t\tPor favor, aguarde até que um Funcionário Libere seu ID para Acesso!");
                }
                PausaParaContinuar();
            } while (cadastro != true);
        }
        static void TelaValidacaoIdCliente()
        {
            int idAcesso;
            bool login = false;

            do
            {
                Console.Clear();
                Console.Write("\n\t\tBem Vindo!\n\t\tPor Favor, Informe seu ID de Acesso: ");
                idAcesso = int.Parse(Console.ReadLine());

                foreach (Cliente cliente in clientes)
                {
                    if (cliente.NumeroDaConta == idAcesso)
                    {
                        if (cliente.Acesso == true)
                        {
                            Console.Clear();
                            Console.WriteLine("\n\t\tAcesso Permitido!");
                            Console.WriteLine("\n\t\tBem vindo " + cliente.NomeCliente + "!!!");
                            login = true;
                            PausaParaContinuar();
                            TelaInicialConta(cliente); ///////////////////////////////////////////////////////
                            break;
                        }
                        else if (cliente.Acesso == false)
                        {
                            Console.Clear();
                            Console.WriteLine("\n\t\tAcesso Negado!");
                            Console.WriteLine("\n\t\tPor favor, aguarde até que um de nossos colaboradores" +
                                              "\n\t\tLibere seu ID para acesso!");
                            PausaParaContinuar();
                            TelaInicioClientes();
                            break;
                        }
                        else if (idAcesso != cliente.NumeroDaConta)
                        {
                            
                        }
                    }                  
                }
                Console.WriteLine("\n\t\tDesculpe. O ID de acesso infomado é inválido ou não existe!");
                PausaParaContinuar();
                TelaInicioClientes();
            } while (login == false);
        }
        #endregion

        #region OPERAÇÕES RELACIONADAS AS MOVIMENTAÇÕES NA CONTA DO CLIENTE

        static void TelaInicialConta (Cliente clienteAtivo)
        {
            bool sair = false;
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\t\tBem vindo ao Banco Morangão " + clienteAtivo.NomeCliente);
                Console.WriteLine("\n\t\t" + clienteAtivo.VerTipoDeConta());
                Console.WriteLine("\n\t\tAgência: " + clienteAtivo.AgenciaCliente.NumeroId);
                Console.WriteLine("\n\n\t\tSaldo: R$: " + clienteAtivo.ContaCorrente.SaldoEmConta);
                Console.WriteLine("\n\n\t\tO que deseja fazer?");
                Console.WriteLine("\t\t0 - Encerrar Sessão -");
                Console.WriteLine("\t\t1 - Sacar -");
                Console.WriteLine("\t\t2 - Depositar -");
                Console.Write("\t\tOpção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ///sacar
                        Console.Clear();
                        Console.Write("\n\t\tQual valor deseja sacar? R$: ");
                        double valorSaque = double.Parse(Console.ReadLine());
                        bool transacao = clienteAtivo.ContaCorrente.Sacar(valorSaque);
                        if(transacao == true)
                        {
                            Console.WriteLine("\n\t\tSaque efetuado com sucesso!");
                            PausaParaContinuar();
                            TelaInicialConta(clienteAtivo);
                        }
                        else
                        {
                            Console.WriteLine("\n\t\tImpossível Sacar! Valor pedido é maior que o Saldo Disponível!");
                            PausaParaContinuar();
                            TelaInicialConta(clienteAtivo);
                        }
                        break;

                    case 2:
                        //depositar
                        Console.Clear();
                        Console.Write("\n\t\tQual valor deseja Depositar R$: ");
                        double valorDeposito = double.Parse(Console.ReadLine());
                        bool situacao = clienteAtivo.ContaCorrente.Depositar(valorDeposito);
                        if (situacao == true)
                        {
                            Console.WriteLine("\n\t\tDepósito efetuado com sucesso!");
                            PausaParaContinuar();
                            TelaInicialConta(clienteAtivo);
                        }
                        else
                        {
                            Console.WriteLine("\n\t\tImpossível Depositar esse valor!");
                            PausaParaContinuar();
                            TelaInicialConta(clienteAtivo);
                        }
                        break;
                    case 0:
                        Console.WriteLine("\n\n\t\tVolte sempre " + clienteAtivo.NomeCliente + "!\n\n\t\tEncerrando Sessão...");
                        PausaParaContinuar();
                        TelaInicioClientes();
                        break;
                }
            } while (sair == false);

        }
        #endregion

        #endregion //region para as telas
        static void PausaParaContinuar()
        {
            Console.WriteLine("\n\n\t\tAperte qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            ///para não esquecer:
            ///ao programa ser iniciado pela primeira vez, fazer os cadastros a serem usados, ao fechar irá antes salvar em arquivos texto
            ///tudo que tiver sido feito de movimentação importante... cadastros, listas, objetos, etc
            ///assim, quando for aberto o programa de novo, primeiro ele devera ler esses arquivos texto para ja
            ///carregar tudo que foi feito na sessão anterior

            TelaInicial();
        }
    }
}
