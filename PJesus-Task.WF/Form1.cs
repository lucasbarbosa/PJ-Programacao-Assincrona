using PJesus_Task.WF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJesus_Task.WF
{
    public partial class frmTask1 : Form
    {
        #region Propriedades

        CancellationTokenSource MeuToken { get; set; }

        #endregion

        public frmTask1()
        {
            InitializeComponent();
        }

        private async void btnCarregarAwait_Click(object sender, EventArgs e)
        {
            MeuToken = new CancellationTokenSource();
            HabilitarCampos(false);

            try
            {
                List<Tarefa> lista = await Servicos.TarefaServico.ObterTarefas(MeuToken.Token);
                CarregarTarefas(lista, btnCarregarAwait.Text);
            }
            catch (OperationCanceledException ex)
            {
                MessageBox.Show($"Aviso: {ex.Message}", "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro");
            }
            finally
            {
                HabilitarCampos(true);
            }
        }

        private void btnCarregarTask_Click(object sender, EventArgs e)
        {
            MeuToken = new CancellationTokenSource();
            HabilitarCampos(false);

            Task<List<Tarefa>> task = Servicos.TarefaServico.ObterTarefas(MeuToken.Token);

            #region Com Switch Status

            // Sucesso
            task.ContinueWith(lista =>
            {
                switch (lista.Status)
                {
                    case TaskStatus.Canceled:
                        MessageBox.Show("Tarefa cancelada", "Aviso");

                        break;
                    case TaskStatus.Faulted:
                        var excecoes = lista.Exception.Flatten().InnerExceptions;

                        foreach (var excecao in excecoes)
                            MessageBox.Show($"Erro: {excecao.Message}", "Erro");

                        break;
                    case TaskStatus.RanToCompletion:
                        CarregarTarefas(lista.Result, btnCarregarTask.Text);

                        break;
                }

                HabilitarCampos(true);
            }, TaskScheduler.FromCurrentSynchronizationContext());

            #endregion

            #region Sem Switch Status
            /*
            // Sucesso
            task.ContinueWith(lista =>
            {
                CarregarTarefas(lista.Result, btnCarregarTask.Text);
            }, CancellationToken.None,
            TaskContinuationOptions.OnlyOnRanToCompletion,
            TaskScheduler.FromCurrentSynchronizationContext());

            // Erro
            task.ContinueWith(lista =>
            {
                var excecoes = lista.Exception.Flatten().InnerExceptions;

                foreach (var excecao in excecoes)
                    MessageBox.Show($"Erro: {excecao.Message}", "Erro");
            }, CancellationToken.None,
            TaskContinuationOptions.OnlyOnFaulted,
            TaskScheduler.FromCurrentSynchronizationContext());

            // Finally
            task.ContinueWith(lista =>
            {
                HabilitarCampos(true);
            }, TaskScheduler.FromCurrentSynchronizationContext());
            */
            #endregion
        }

        private void btnCancelarTask_Click(object sender, EventArgs e)
        {
            MeuToken.Cancel();
        }

        private void CarregarTarefas(List<Tarefa> resultado, string botao)
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(botao);
            result.AppendLine("--------------------------------------------------------");

            foreach (var item in resultado)
                result.AppendLine(string.Format("Tarefa: {0} | Estado: {1}", item.Minhatarefa, item.Estado));

            txtResultado.Text = result.ToString();
        }

        private void HabilitarCampos(bool acao)
        {
            btnCarregarAwait.Enabled = acao;
            btnCarregarTask.Enabled = acao;
            btnCancelarTask.Enabled = !acao;

            if(!acao)
                txtResultado.Text = "";
        }
    }
}
