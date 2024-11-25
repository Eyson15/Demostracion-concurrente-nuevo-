namespace Semana_11_Demosteracion_Concurrente
{
    partial class FrmSimulacionTrafico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            btnSalir = new Button();
            lblEstado = new Label();
            btnEntrar = new Button();
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
            splitContainer1.Panel1.Controls.Add(btnSalir);
            splitContainer1.Panel1.Controls.Add(lblEstado);
            splitContainer1.Panel1.Controls.Add(btnEntrar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtResultado);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 433;
            splitContainer1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(192, 255, 255);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(147, 112);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(139, 47);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(12, 399);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(19, 21);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "0";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(192, 255, 255);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Location = new Point(147, 12);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(139, 47);
            btnEntrar.TabIndex = 6;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtResultado
            // 
            txtResultado.Dock = DockStyle.Fill;
            txtResultado.Location = new Point(0, 0);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(363, 450);
            txtResultado.TabIndex = 2;
            // 
            // FrmSimulacionTrafico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FrmSimulacionTrafico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSimulacionTrafico";
            Load += FrmSimulacionTrafico_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnSalir;
        private Label lblEstado;
        private Button btnEntrar;
        private TextBox txtResultado;
    }
}