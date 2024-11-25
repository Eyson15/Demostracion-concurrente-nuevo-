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
    public partial class FrmGestionDeBloqueos : Form
    {
        private int contador = 0;
        private object bloqueo = new();
        private SemaphoreSlim semaforo =new SemaphoreSlim(2);
        public FrmGestionDeBloqueos()
        {
            InitializeComponent();
        }

        private void FrmGestionDeBloqueos_Load(object sender, EventArgs e)
        {

        }

        private void btnIncrementar_Click_1(object sender, EventArgs e)
        {
            // estructura de una tarea --->> Task.Run(() => { });
            //dentro de las llaves se pone el codigo que quiro que se a¿ejecute de manera ascincrona

            Task.Run(() =>
            {//wait solicitamos permiso para que pueda realizar la tarea
                semaforo.Wait();

                lock (bloqueo)
                {
                    contador++;
                    Thread.Sleep(1000);//para que duerma 
                                       //actualizar la interfas
                    this.Invoke((MethodInvoker)delegate
                    {
                        lblincrementar.Text = contador.ToString();
                    });
                    //comando pulse notifica los bloqueos
                    Monitor.Pulse(bloqueo);
            }
                //release libera un hilo y da capacidad para atender otra peticion
                //semaforo.Release();

                ////LO DE ABAJO SE HACE PRIMERO LUEGO PASA A LA LLAVE DE LOCK BLOQUEO
                //// significa o es igual a que yo diga contador = contador +1
                //contador++;
                //Thread.Sleep(5000);//para que duerma 
                ////actualizar la interfas
                //this.Invoke((MethodInvoker)delegate
                //{
                //    lblincrementar.Text = contador.ToString();
                //});
            });


        }

        private void btndisminuir_Click_1(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                lock (bloqueo)
                {
                    //WHILE ESPERA HASTA QUE SE LIBERE EL PROCESO PARA DISMINUIR
                    while (contador <= 0)
                    {
                        ActualizarResultado("Esperando...............");
                        Monitor.Wait(bloqueo);
                    }

                    if (contador > 0)
                    {
                        contador--;
                        Thread.Sleep(1000);//para que duerma 
                                           //actualizar la interfas
                        this.Invoke((MethodInvoker)delegate
                        {
                            lblincrementar.Text = contador.ToString();
                        });
                    }
                    ActualizarResultado("Prosesando...............");

                    //SE ELIMINA EL ELSE PK YA NO ES NESESARIO POR EL WHILE
                    //else
                    //{
                    //    MessageBox.Show("Error. No se pudo disminuir un valor menor a 0.");
                    //}

                }
            });
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
    }
}
