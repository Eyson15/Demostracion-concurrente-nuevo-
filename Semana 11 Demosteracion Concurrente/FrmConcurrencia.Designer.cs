namespace Semana_11_Demosteracion_Concurrente
{
    partial class FrmConcurrencia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConcurrencia));
            splitContainer1 = new SplitContainer();
            btnCancelarHilo = new Button();
            btnSalir = new Button();
            btnSecuencial = new Button();
            btnIniciarTarea = new Button();
            btnHilo = new Button();
            txtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel1.BackgroundImage");
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel1.Controls.Add(btnCancelarHilo);
            splitContainer1.Panel1.Controls.Add(btnSalir);
            splitContainer1.Panel1.Controls.Add(btnSecuencial);
            splitContainer1.Panel1.Controls.Add(btnIniciarTarea);
            splitContainer1.Panel1.Controls.Add(btnHilo);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtResultado);
            splitContainer1.Size = new Size(829, 508);
            splitContainer1.SplitterDistance = 239;
            splitContainer1.TabIndex = 0;
            // 
            // btnCancelarHilo
            // 
            btnCancelarHilo.FlatStyle = FlatStyle.Flat;
            btnCancelarHilo.Location = new Point(44, 269);
            btnCancelarHilo.Name = "btnCancelarHilo";
            btnCancelarHilo.Size = new Size(148, 51);
            btnCancelarHilo.TabIndex = 7;
            btnCancelarHilo.Text = "Cancelar Procesos";
            btnCancelarHilo.UseVisualStyleBackColor = true;
            btnCancelarHilo.UseWaitCursor = true;
            btnCancelarHilo.Click += btnCancelarHilo_Click;
            // 
            // btnSalir
            // 
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(44, 425);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(148, 51);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnSecuencial
            // 
            btnSecuencial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSecuencial.BackColor = Color.White;
            btnSecuencial.FlatStyle = FlatStyle.Flat;
            btnSecuencial.Location = new Point(44, 40);
            btnSecuencial.Name = "btnSecuencial";
            btnSecuencial.Size = new Size(148, 51);
            btnSecuencial.TabIndex = 3;
            btnSecuencial.Text = "Iniciar Secuencial";
            btnSecuencial.UseVisualStyleBackColor = false;
            btnSecuencial.Click += btnSecuencial_Click;
            // 
            // btnIniciarTarea
            // 
            btnIniciarTarea.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnIniciarTarea.FlatStyle = FlatStyle.Flat;
            btnIniciarTarea.Location = new Point(44, 198);
            btnIniciarTarea.Name = "btnIniciarTarea";
            btnIniciarTarea.Size = new Size(148, 51);
            btnIniciarTarea.TabIndex = 5;
            btnIniciarTarea.Text = "Iniciar Tarea";
            btnIniciarTarea.UseVisualStyleBackColor = true;
            btnIniciarTarea.Click += btnIniciarTarea_Click;
            // 
            // btnHilo
            // 
            btnHilo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnHilo.FlatStyle = FlatStyle.Flat;
            btnHilo.Location = new Point(44, 118);
            btnHilo.Name = "btnHilo";
            btnHilo.Size = new Size(148, 51);
            btnHilo.TabIndex = 4;
            btnHilo.Text = "Iniciar Hilo";
            btnHilo.UseVisualStyleBackColor = true;
            btnHilo.Click += btnHilo_Click;
            // 
            // txtResultado
            // 
            txtResultado.Dock = DockStyle.Fill;
            txtResultado.Location = new Point(0, 0);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(586, 508);
            txtResultado.TabIndex = 0;
            // 
            // FrmConcurrencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 508);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConcurrencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Demostración de concurrencia";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnSecuencial;
        private Button btnIniciarTarea;
        private Button btnHilo;
        private TextBox txtResultado;
        private Button btnSalir;
        private Button btnCancelarHilo;
    }
}
