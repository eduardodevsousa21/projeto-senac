using System;
using System.Activities;
using System.Activities.DurableInstancing;
using System.Activities.Statements;
using System.IO;
using System.Threading;

namespace AplicativoFluxoDeTrabalho
{
    class Programa
    {
        static void Main(string[] args)
        {
            // Configura a string de conexão para o armazenamento da instância do SQL Server
            string connectionString = "Data Source=.;Initial Catalog=WorkflowInstanceStore;Integrated Security=True";

            // Verifica se o banco de dados do armazenamento da instância já existe
            VerificarBancoDeDadosExistente(connectionString);

            // Cria e inicializa a instância do armazenamento da instância do SQL Server
            SqlWorkflowInstanceStore armazenamento = new SqlWorkflowInstanceStore(connectionString);
            CreateInstanceStore(armazenamento);

            // Cria e inicializa a aplicação do fluxo de trabalho
            WorkflowApplication wfApp = new WorkflowApplication();

            // Configura a aplicação do fluxo de trabalho
            ConfigurarAplicacaoFluxoDeTrabalho(wfApp);

            // Cria uma instância do fluxo de trabalho e inicia sua execução
            IniciarExecucaoFluxoDeTrabalho(wfApp, armazenamento);

            // Aguarda a conclusão do fluxo de trabalho
            wfApp.Completed += (e) =>
            {
                Console.WriteLine("Fluxo de trabalho concluído.");
            };
            wfApp.Unloaded += (e) =>
            {
                Console.WriteLine("Fluxo de trabalho descarregado.");
            };

            Console.WriteLine("Pressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }

        static void VerificarBancoDeDadosExistente(string connectionString)
        {
            // Verifica se o banco de dados do armazenamento da instância já existe
            // Se não existir, cria o banco de dados
            // Esta implementação é simplificada e não considera todos os casos possíveis
            // Em um ambiente de produção, você pode precisar de uma abordagem mais robusta
            // para configurar o banco de dados do armazenamento da instância
            // Certifique-se de que a conta de usuário utilizada tenha permissões suficientes para criar um banco de dados

            // Exemplo de implementação:
            // Verificar se o banco de dados existe usando SqlConnection e SqlCommand
            // Se não existir, criar o banco de dados usando uma instrução CREATE DATABASE
            // Consulte a documentação do SQL Server para obter mais detalhes sobre como criar bancos de dados
            // Certifique-se de configurar corretamente a string de conexão e as permissões de usuário

            // Neste exemplo simplificado, supomos que o banco de dados já está criado
            // e não realizamos a verificação ou criação do banco de dados
            // Se necessário, você pode adicionar essa funcionalidade aqui
        }

        static void CreateInstanceStore(SqlWorkflowInstanceStore store)
        {
            // Configura o armazenamento da instância
            InstanceView view = store.Execute(store.CreateInstanceHandle(), new CreateWorkflowOwnerCommand(), TimeSpan.FromSeconds(30));
            store.DefaultInstanceOwner = view.InstanceOwner;

            // Especifica o comportamento de rastreamento e persistência
            InstanceHandle handle = store.CreateInstanceHandle();
            InstanceView newInstance = store.Execute(handle, new CreateWorkflowOwnerCommand(), TimeSpan.FromSeconds(30));
            store.DefaultInstanceOwner = newInstance.InstanceOwner;
        }

        static void ConfigurarAplicacaoFluxoDeTrabalho(WorkflowApplication wfApp)
        {
            // Configura o armazenamento da instância, extensões e manipuladores de ciclo de vida do fluxo de trabalho.
            wfApp.InstanceStore = new SqlWorkflowInstanceStore("Data Source=.;Initial Catalog=WorkflowInstanceStore;Integrated Security=True");

            // Adiciona uma extensão personalizada à aplicação de fluxo de trabalho
            wfApp.Extensions.Add(new CustomExtension());

            // Lida com o evento PersistableIdle
            wfApp.PersistableIdle = delegate (WorkflowApplicationIdleEventArgs e)
            {
                // Envia as saídas de WriteLine atuais para a janela de status.
                var writers = e.GetInstanceExtensions<StringWriter>();
                foreach (var writer in writers)
                {
                    Console.WriteLine(writer.ToString());
                }
                return PersistableIdleAction.Unload;
            };

            // Lida com o evento Completed
            wfApp.Completed = delegate (WorkflowApplicationCompletedEventArgs e)
            {
                if (e.CompletionState == ActivityInstanceState.Faulted)
                {
                    // Lida com o estado de falha
                    Console.WriteLine("Fluxo de trabalho falhou.");
                }
                else if (e.CompletionState == ActivityInstanceState.Canceled)
                {
                    // Lida com o estado cancelado
                    Console.WriteLine("Fluxo de trabalho cancelado.");
                }
            };
        }
    }
}


