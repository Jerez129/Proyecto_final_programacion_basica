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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvEmpleadosbasico = new DataGridView();
            btnVisualRegistrarausencia = new Button();
            btnEditar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleadosbasico).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleadosbasico
            // 
            dgvEmpleadosbasico.BackgroundColor = Color.FromArgb(252, 247, 197);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(252, 247, 197);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(10, 191, 188);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmpleadosbasico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmpleadosbasico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(252, 247, 197);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(10, 191, 188);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEmpleadosbasico.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEmpleadosbasico.GridColor = Color.FromArgb(252, 247, 197);
            dgvEmpleadosbasico.Location = new Point(55, 82);
            dgvEmpleadosbasico.Name = "dgvEmpleadosbasico";
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
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(252, 247, 197);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditar.ForeColor = Color.FromArgb(19, 116, 125);
            btnEditar.Location = new Point(615, 529);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
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
            Controls.Add(btnEditar);
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
        private Button btnEditar;
    }
}
