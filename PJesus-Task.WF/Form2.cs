using PJesus_Task.WF.Models;
using PJesus_Task.WF.Servicos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PJesus_Task.WF
{
    public partial class frmTask2 : Form
    {
        #region Propriedades

        /*
        private bool isBusy;
        
        public bool IsBusy {
            get { return isBusy; }
            set
            {
                if (SetProperty(ref isBusy, value))
                {
                    CarregarCommand.CanExecuteChanged();
                }
            }
        }

        private string tempo;

        public string Tempo {
            get { return tempo; }
            set { SetProperty(ref tempo, value); }
        }

        public Command CarregarCommand { get; }
        */
        ObservableCollection<Palestra> Palestras { get; }
        ObservableCollection<Palestrante> Palestrantes { get; }
        
        #endregion

        public frmTask2()
        {
            Palestras = new ObservableCollection<Palestra>();
            Palestrantes = new ObservableCollection<Palestrante>();

            InitializeComponent();
        }

        private 
            async 
            void btnCarregar_Click(object sender, EventArgs e)
        {
            var timer = new Stopwatch();

            try
            {
                Palestras.Clear();
                Palestrantes.Clear();

                timer.Start();

                // CarregarSequencial();
                // CarregarSequencialTask();

                // CarregarSequencialAwait();

                CarregarDados(await ApiServico.ObterPalestrasAwait());
                CarregarDados(await ApiServico.ObterPalestrantesAwait());

                timer.Stop();

                txtTimer.Text = timer.ElapsedMilliseconds.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro");
            }
            finally
            {
            }
        }

        private void CarregarSequencial()
        {
            var palestras = ApiServico.ObterPalestras();
            var palestrantes = ApiServico.ObterPalestrantes();

            CarregarDados(palestras);
            CarregarDados(palestrantes);
        }

        private void CarregarSequencialTask()
        {
            #region Exec1 - Incorreto

            // var palestras = Task.Factory.StartNew(() => ApiServico.ObterPalestras()).Result;
            // var palestrantes = Task.Factory.StartNew(() => ApiServico.ObterPalestrantes()).Result;

            // CarregarDados(palestras);
            // CarregarDados(palestrantes);

            #endregion

            #region Exec1

            // Carrega os dados de cada task assim que finalizadas
            //Task.Factory.StartNew(() => ApiServico.ObterPalestras())
            //    .ContinueWith(palestras => {
            //        CarregarDados(palestras.Result);
            //    }, TaskScheduler.FromCurrentSynchronizationContext());

            //Task.Factory.StartNew(() => ApiServico.ObterPalestrantes())
            //    .ContinueWith(palestrantes => {
            //        CarregarDados(palestrantes.Result);
            //    }, TaskScheduler.FromCurrentSynchronizationContext());

            #endregion

            #region Exec2

            // Exibe depois de concluir todas as tasks
            var palestras = Task.Factory.StartNew(() => ApiServico.ObterPalestras());
            var palestrantes = Task.Factory.StartNew(() => ApiServico.ObterPalestrantes());

            Task.WaitAll(palestras, palestrantes);

            CarregarDados(palestras.Result);
            CarregarDados(palestrantes.Result);

            #endregion
        }

        private void CarregarSequencialAwait()
        {
            var palestras = ApiServico.ObterPalestrasAwait();
            var palestrantes = ApiServico.ObterPalestrantesAwait();

            Task.WaitAll(palestras, palestrantes);

            CarregarDados(palestras.Result);
            CarregarDados(palestrantes.Result);
        }

        private void CarregarDados<T>(IEnumerable<T> colecao) where T: class
        {
            if (typeof(T) == typeof(Palestra))
                foreach (var item in colecao)
                    Palestras.Add(item as Palestra);
            else
                foreach (var item in colecao as IEnumerable<Palestrante>)
                    Palestrantes.Add(item);

            CarregarLista(colecao);
        }

        private void CarregarLista<T>(IEnumerable<T> resultado) where T: class
        {
            StringBuilder result = new StringBuilder();

            if (typeof(T) == typeof(Palestra))
            {
                foreach (var item in resultado as IEnumerable<Palestra>)
                    result.AppendLine(item.TituloPalestra);

                txtPalestras.Text = result.ToString();
            }
            else
            {
                foreach (var item in resultado as IEnumerable<Palestrante>)
                    result.AppendLine(item.NomePalestrante);

                txtPalestrantes.Text = result.ToString();
            }
        }
    }
}