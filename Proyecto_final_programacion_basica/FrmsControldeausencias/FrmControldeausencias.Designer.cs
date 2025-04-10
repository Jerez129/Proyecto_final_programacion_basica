namespace Capa_Presentacion_Proyecto_Final
{
    partial class FrmControldeausencias
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvEmpleadosbasico = new DataGridView();
            btnVisualRegistrarausencia = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleadosbasico).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleadosbasico
            // 
            dgvEmpleadosbasico.BackgroundColor = Color.FromArgb(252, 247, 197);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(252, 247, 197);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(10, 191, 188);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEmpleadosbasico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEmpleadosbasico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(252, 247, 197);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(10, 191, 188);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvEmpleadosbasico.DefaultCellStyle = dataGridViewCellStyle4;
            dgvEmpleadosbasico.GridColor = Color.FromArgb(252, 247, 197);
            dgvEmpleadosbasico.Location = new Point(55, 82);
            dgvEmpleadosbasico.Name = "dgvEmpleadosbasico";
            dgvEmpleadosbasico.ReadOnly = true;
            dgvEmpleadosbasico.RowHeadersWidth = 51;
            dgvEmpleadosbasico.Size = new Size(955, 344);
            dgvEmpleadosbasico.TabIndex = 15;
            // 
            // btnVisualRegistrarausencia
            // 
            btnVisualRegistrarausencia.BackColor = Color.FromArgb(252, 247, 197);
            btnVisualRegistrarausencia.FlatStyle = FlatStyle.Flat;
            btnVisualRegistrarausencia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVisualRegistrarausencia.ForeColor = Color.FromArgb(19, 116, 125);
            btnVisualRegistrarausencia.Location = new Point(499, 529);
            btnVisualRegistrarausencia.Name = "btnVisualRegistrarausencia";
            btnVisualRegistrarausencia.Size = new Size(94, 29);
            btnVisualRegistrarausencia.TabIndex = 16;
            btnVisualRegistrarausencia.Text = "Registrar";
            btnVisualRegistrarausencia.UseVisualStyleBackColor = false;
            btnVisualRegistrarausencia.Click += btnVisualRegistrarausencia_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(252, 247, 197);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolver.ForeColor = Color.FromArgb(19, 116, 125);
            btnVolver.Location = new Point(916, 529);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 17;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmControldeausencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 116, 125);
            ClientSize = new Size(1079, 664);
            Controls.Add(btnVolver);
            Controls.Add(btnVisualRegistrarausencia);
            Controls.Add(dgvEmpleadosbasico);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmControldeausencias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmControldeausencias";
            Load += FrmControldeausencias_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleadosbasico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmpleadosbasico;
        private Button btnVisualRegistrarausencia;
        private Button btnVolver;
    }
}
