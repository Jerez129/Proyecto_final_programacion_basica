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
            dgvEmpleadosbasico = new DataGridView();
            btnVisualRegistrarausencia = new Button();
            btnEditar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleadosbasico).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleadosbasico
            // 
            dgvEmpleadosbasico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleadosbasico.Location = new Point(55, 82);
            dgvEmpleadosbasico.Name = "dgvEmpleadosbasico";
            dgvEmpleadosbasico.RowHeadersWidth = 51;
            dgvEmpleadosbasico.Size = new Size(955, 344);
            dgvEmpleadosbasico.TabIndex = 15;
            // 
            // btnVisualRegistrarausencia
            // 
            btnVisualRegistrarausencia.Location = new Point(494, 546);
            btnVisualRegistrarausencia.Name = "btnVisualRegistrarausencia";
            btnVisualRegistrarausencia.Size = new Size(94, 29);
            btnVisualRegistrarausencia.TabIndex = 16;
            btnVisualRegistrarausencia.Text = "Registrar";
            btnVisualRegistrarausencia.UseVisualStyleBackColor = true;
            btnVisualRegistrarausencia.Click += btnVisualRegistrarausencia_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(916, 546);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 17;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(594, 553);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // FrmControldeausencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 664);
            Controls.Add(btnVolver);
            Controls.Add(btnEditar);
            Controls.Add(btnVisualRegistrarausencia);
            Controls.Add(dgvEmpleadosbasico);
            Name = "FrmControldeausencias";
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
