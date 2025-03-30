namespace Capa_Presentacion
{
    partial class Frmcalendariodeausencias
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
            dgvAusenciascalendario = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAusenciascalendario).BeginInit();
            SuspendLayout();
            // 
            // dgvAusenciascalendario
            // 
            dgvAusenciascalendario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAusenciascalendario.Location = new Point(54, 24);
            dgvAusenciascalendario.Name = "dgvAusenciascalendario";
            dgvAusenciascalendario.RowHeadersWidth = 51;
            dgvAusenciascalendario.Size = new Size(1028, 274);
            dgvAusenciascalendario.TabIndex = 0;
            // 
            // Frmcalendariodeausencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 450);
            Controls.Add(dgvAusenciascalendario);
            Name = "Frmcalendariodeausencias";
            Text = "Frmcalendariodeausencias";
            Load += Frmcalendariodeausencias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAusenciascalendario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAusenciascalendario;
    }
}