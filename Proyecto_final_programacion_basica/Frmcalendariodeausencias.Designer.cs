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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvAusenciascalendario = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAusenciascalendario).BeginInit();
            SuspendLayout();
            // 
            // dgvAusenciascalendario
            // 
            dgvAusenciascalendario.BackgroundColor = Color.FromArgb(252, 247, 197);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(252, 247, 197);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(10, 191, 188);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAusenciascalendario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAusenciascalendario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(252, 247, 197);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(10, 191, 188);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAusenciascalendario.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAusenciascalendario.GridColor = Color.FromArgb(252, 247, 197);
            dgvAusenciascalendario.Location = new Point(54, 24);
            dgvAusenciascalendario.Name = "dgvAusenciascalendario";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(252, 247, 197);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(10, 191, 188);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvAusenciascalendario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvAusenciascalendario.RowHeadersWidth = 51;
            dgvAusenciascalendario.Size = new Size(1028, 274);
            dgvAusenciascalendario.TabIndex = 0;
            // 
            // Frmcalendariodeausencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 116, 125);
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