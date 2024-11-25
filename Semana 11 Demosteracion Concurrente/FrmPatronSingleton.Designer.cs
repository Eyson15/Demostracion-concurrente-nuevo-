namespace Semana_11_Demosteracion_Concurrente
{
    partial class FrmPatronSingleton
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
            label1 = new Label();
            txtCadenaConexion = new TextBox();
            btnAsignar = new Button();
            btnRecuperar = new Button();
            lblCadenaconxrecuper = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Cadena de conexión";
            // 
            // txtCadenaConexion
            // 
            txtCadenaConexion.Location = new Point(29, 31);
            txtCadenaConexion.Name = "txtCadenaConexion";
            txtCadenaConexion.Size = new Size(719, 23);
            txtCadenaConexion.TabIndex = 1;
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(29, 85);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(158, 60);
            btnAsignar.TabIndex = 2;
            btnAsignar.Text = "Asignar Cadena de Conexión";
            btnAsignar.UseVisualStyleBackColor = true;
            // 
            // btnRecuperar
            // 
            btnRecuperar.Location = new Point(29, 202);
            btnRecuperar.Name = "btnRecuperar";
            btnRecuperar.Size = new Size(158, 60);
            btnRecuperar.TabIndex = 3;
            btnRecuperar.Text = "Obtener Cadena De Conexión";
            btnRecuperar.UseVisualStyleBackColor = true;
            // 
            // lblCadenaconxrecuper
            // 
            lblCadenaconxrecuper.AutoSize = true;
            lblCadenaconxrecuper.Location = new Point(289, 232);
            lblCadenaconxrecuper.Name = "lblCadenaconxrecuper";
            lblCadenaconxrecuper.Size = new Size(120, 15);
            lblCadenaconxrecuper.TabIndex = 4;
            lblCadenaconxrecuper.Text = "Conexión recuperada";
            // 
            // FrmPatronSingleton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 314);
            Controls.Add(lblCadenaconxrecuper);
            Controls.Add(btnRecuperar);
            Controls.Add(btnAsignar);
            Controls.Add(txtCadenaConexion);
            Controls.Add(label1);
            Name = "FrmPatronSingleton";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPatronSingleton";
            Load += FrmPatronSingleton_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCadenaConexion;
        private Button btnAsignar;
        private Button btnRecuperar;
        private Label lblCadenaconxrecuper;
    }
}