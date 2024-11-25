using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_11_Demosteracion_Concurrente
{
    public partial class FrmSimulacionTrafico : Form
    {
        private int vehiculosEnInterseccion = 0; // Contador de vehículos en la intersección
        private SemaphoreSlim semaforo = new SemaphoreSlim(3); // Máximo 3 vehículos a la vez
        private object bloqueo = new();
        public FrmSimulacionTrafico()
        {
            InitializeComponent();
        }

        private void FrmSimulacionTrafico_Load(object sender, EventArgs e)
        {
            ActualizarResultado("Intersección lista. Máximo 3 vehículos permitidos.");
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                ActualizarResultado("Vehículo intentando entrar...");
                semaforo.Wait(); // Solicita permiso para entrar

                lock (bloqueo)
                {
                    vehiculosEnInterseccion++;
                    ActualizarResultado($"Vehículo entró. Total en intersección: {vehiculosEnInterseccion}");
                }

                Thread.Sleep(2000); // Simula el tiempo que tarda el vehículo en cruzar
                Actualizarlog("Vehículo cruzando la intersección...");
            });
        }

        private void ActualizarResultado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarResultado(mensaje)));
                return;
            }
            lblEstado.Text = mensaje;
        }


        private void Actualizarlog(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => Actualizarlog(mensaje)));
                return;
            }
            txtResultado.AppendText($"{DateTime.Now:HH:mm:ss.fff}:{mensaje}{Environment.NewLine}");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                lock (bloqueo)
                {
                    if (vehiculosEnInterseccion > 0)
                    {
                        vehiculosEnInterseccion--;
                        ActualizarResultado($"Vehículo salió. Total en intersección: {vehiculosEnInterseccion}");
                        semaforo.Release(); // Libera el permiso
                    }
                    else
                    {
                        ActualizarResultado("No hay vehículos en la intersección.");
                    }
                }

                Actualizarlog("Vehículo dejó la intersección.");
            });
        }
    }
}
