namespace Semana_11_Demosteracion_Concurrente
{
    partial class FrmGestionDeBloqueos
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
            btndisminuir = new Button();
            lblincrementar = new Label();
            btnIncrementar = new Button();
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
            splitContainer1.Panel1.Controls.Add(btndisminuir);
            splitContainer1.Panel1.Controls.Add(lblincrementar);
            splitContainer1.Panel1.Controls.Add(btnIncrementar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtResultado);
            splitContainer1.Size = new Size(799, 429);
            splitContainer1.SplitterDistance = 214;
            splitContainer1.TabIndex = 0;
            // 
            // btndisminuir
            // 
            btndisminuir.BackColor = Color.FromArgb(192, 255, 255);
            btndisminuir.FlatStyle = FlatStyle.Flat;
            btndisminuir.Location = new Point(36, 77);
            btndisminuir.Name = "btndisminuir";
            btndisminuir.Size = new Size(139, 47);
            btndisminuir.TabIndex = 5;
            btndisminuir.Text = "Disminuir";
            btndisminuir.UseVisualStyleBackColor = false;
            btndisminuir.Click += btndisminuir_Click_1;
            // 
            // lblincrementar
            // 
            lblincrementar.AutoSize = true;
            lblincrementar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblincrementar.Location = new Point(97, 399);
            lblincrementar.Name = "lblincrementar";
            lblincrementar.Size = new Size(19, 21);
            lblincrementar.TabIndex = 4;
            lblincrementar.Text = "0";
            // 
            // btnIncrementar
            // 
            btnIncrementar.BackColor = Color.FromArgb(192, 255, 255);
            btnIncrementar.FlatStyle = FlatStyle.Flat;
            btnIncrementar.Location = new Point(36, 12);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(139, 47);
            btnIncrementar.TabIndex = 3;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = false;
            btnIncrementar.Click += btnIncrementar_Click_1;
            // 
            // txtResultado
            // 
            txtResultado.Dock = DockStyle.Fill;
            txtResultado.Location = new Point(0, 0);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(581, 429);
            txtResultado.TabIndex = 1;
            // 
            // FrmGestionDeBloqueos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 429);
            Controls.Add(splitContainer1);
            Name = "FrmGestionDeBloqueos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Bloqueos";
            Load += FrmGestionDeBloqueos_Load;
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
        private Button btndisminuir;
        private Label lblincrementar;
        private Button btnIncrementar;
        private TextBox txtResultado;
    }
}