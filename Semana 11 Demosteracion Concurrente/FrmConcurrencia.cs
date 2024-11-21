namespace Semana_11_Demosteracion_Concurrente
{
    public partial class FrmConcurrencia : Form
    {
        //poner para los btn cancelar hilos
        private CancellationTokenSource _cts;
        public FrmConcurrencia()
        {
            InitializeComponent();
        }


        private void btnSecuencial_Click(object sender, EventArgs e)
        {
            ActualizarResultado("Iniciando proceso secuencial..👀");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                ActualizarResultado($" Actividad - Paso{i + 1})");
            }

            ActualizarResultado("Fin del proceso secuencial.👌👌");
        }

        private void ActualizarResultado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarResultado(mensaje)));
                return;
            }
            txtResultado.AppendText($"{DateTime.Now:HH:mm:ss.fff}:{mensaje}{Environment.NewLine}");
        }
        

        private void btnHilo_Click(object sender, EventArgs e)
        {
            // va para cncelar hilo
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            //va primero 
            Thread hilo1 = new Thread(() =>
            {
                //cancelar hilo
                // escribo try y doy 2 tab para q genere automatico y paso el codigo de hilo (va primero) dentro de try
                try
                {

                    ActualizarResultado($"Iniciando nuevo hilo{Thread.CurrentThread.ManagedThreadId}...👀");
                    for (int i = 0; i < 5; i++)
                    {
                        //LLAMAR A LA EXEPCION
                        token.ThrowIfCancellationRequested();
                        Thread.Sleep(1000);
                        ActualizarResultado($"Actividad en hilo {Thread.CurrentThread.ManagedThreadId}: - Paso{i + 1})");
                    }
                    ActualizarResultado($"Hilo {Thread.CurrentThread.ManagedThreadId} terminado.👀");
                }
                catch (OperationCanceledException)
                {

                    ActualizarResultado("Hilo Cancelado");
                }
                //va 1ro 
                //ActualizarResultado($"Iniciando nuevo hilo{Thread.CurrentThread.ManagedThreadId}...👀");
                //for (int i = 0; i < 5; i++)
                //{
                //    Thread.Sleep(1000);
                //    ActualizarResultado($"Actividad en hilo {Thread.CurrentThread.ManagedThreadId}: - Paso{i + 1})");
                //}
                //ActualizarResultado($"Hilo {Thread.CurrentThread.ManagedThreadId} terminado.👀");
            });
            hilo1.Start();
        }

        private async void btnIniciarTarea_Click(object sender, EventArgs e)
        {
            // va para cncelar tarea
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            await Task.Run(() =>
            {//igual que arriba
                try
                {
                    ActualizarResultado($"Iniciando  Task {Task.CurrentId}..........");
                    for (int i = 0; i < 5; i++)
                    {
                        token.ThrowIfCancellationRequested();

                        Thread.Sleep(1000);
                        ActualizarResultado($"Actividad en tarea {Task.CurrentId} - paso {i + 1}");
                    }
                    ActualizarResultado($"Task {Task.CurrentId} Finalizada");
                }
                catch (OperationCanceledException)
                {

                    ActualizarResultado("Tarea Cancelada");
                }
                //ActualizarResultado($"Iniciando  Task {Task.CurrentId}..........");
                //for (int i = 0; i < 5; i++)
                //{
                //    Thread.Sleep(1000);
                //    ActualizarResultado($"Actividad en tarea {Task.CurrentId} - paso {i + 1}");
                //}
                //ActualizarResultado($"Task {Task.CurrentId} Finalizada");

            });

        }

        private void btnCancelarHilo_Click(object sender, EventArgs e)
        {
            _cts?.Cancel();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

