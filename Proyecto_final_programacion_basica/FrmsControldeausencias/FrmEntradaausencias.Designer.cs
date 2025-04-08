namespace Capa_Presentacion.FrmsControldeausencias
{
    partial class FrmEntradaausencias
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
            btnRegistrarEntrada = new Button();
            btnEditarEntrada = new Button();
            SuspendLayout();
            // 
            // btnRegistrarEntrada
            // 
            btnRegistrarEntrada.Location = new Point(322, 481);
            btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            btnRegistrarEntrada.Size = new Size(94, 29);
            btnRegistrarEntrada.TabIndex = 0;
            btnRegistrarEntrada.Text = "Registrar";
            btnRegistrarEntrada.UseVisualStyleBackColor = true;
            btnRegistrarEntrada.Click += btnRegistrarEntrada_Click;
            // 
            // btnEditarEntrada
            // 
            btnEditarEntrada.Location = new Point(642, 481);
            btnEditarEntrada.Name = "btnEditarEntrada";
            btnEditarEntrada.Size = new Size(94, 29);
            btnEditarEntrada.TabIndex = 1;
            btnEditarEntrada.Text = "Editar";
            btnEditarEntrada.UseVisualStyleBackColor = true;
            btnEditarEntrada.Click += btnEditarEntrada_Click;
            // 
            // FrmEntradaausencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 624);
            Controls.Add(btnEditarEntrada);
            Controls.Add(btnRegistrarEntrada);
            Name = "FrmEntradaausencias";
            Text = "FrmEntradaausencias";
            Load += FrmEntradaausencias_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrarEntrada;
        private Button btnEditarEntrada;
    }
}