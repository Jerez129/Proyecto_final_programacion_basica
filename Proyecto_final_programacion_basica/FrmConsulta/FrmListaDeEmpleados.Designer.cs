namespace Capa_Presentacion.FrmConsulta
{
    partial class FrmListaDeEmpleados
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
            dgvNomina = new DataGridView();
            btnVerConsultasListar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNomina).BeginInit();
            SuspendLayout();
            // 
            // dgvNomina
            // 
            dgvNomina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNomina.Location = new Point(195, 12);
            dgvNomina.Name = "dgvNomina";
            dgvNomina.RowHeadersWidth = 51;
            dgvNomina.Size = new Size(1024, 188);
            dgvNomina.TabIndex = 0;
            // 
            // btnVerConsultasListar
            // 
            btnVerConsultasListar.Location = new Point(195, 289);
            btnVerConsultasListar.Name = "btnVerConsultasListar";
            btnVerConsultasListar.Size = new Size(94, 29);
            btnVerConsultasListar.TabIndex = 1;
            btnVerConsultasListar.Text = "Ver";
            btnVerConsultasListar.UseVisualStyleBackColor = true;
            btnVerConsultasListar.Click += btnVerConsultasListar_Click;
            // 
            // FrmListaDeEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 450);
            Controls.Add(btnVerConsultasListar);
            Controls.Add(dgvNomina);
            Name = "FrmListaDeEmpleados";
            Text = "FrmListaDeEmpleados";
            ((System.ComponentModel.ISupportInitialize)dgvNomina).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvNomina;
        private Button btnVerConsultasListar;
    }
}