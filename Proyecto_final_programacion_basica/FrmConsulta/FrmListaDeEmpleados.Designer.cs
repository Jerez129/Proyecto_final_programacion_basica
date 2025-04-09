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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvNomina = new DataGridView();
            btnVolveralmenuprincipal = new Button();
            txtBuscarEmpleado = new TextBox();
            btnVerConsultasListar = new Button();
            btnVolveralmenuprincipal = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNomina).BeginInit();
            SuspendLayout();
            // 
            // dgvNomina
            // 
            dgvNomina.BackgroundColor = Color.FromArgb(19, 116, 125);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(252, 247, 197);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(10, 191, 188);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNomina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNomina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNomina.GridColor = Color.FromArgb(19, 116, 125);
            dgvNomina.Location = new Point(195, 12);
            dgvNomina.Name = "dgvNomina";
            dgvNomina.RowHeadersWidth = 51;
            dgvNomina.Size = new Size(1425, 596);
            dgvNomina.TabIndex = 0;
            // 
            // btnVolveralmenuprincipal
            // 
            btnVolveralmenuprincipal.BackColor = Color.FromArgb(19, 116, 125);
            btnVolveralmenuprincipal.FlatStyle = FlatStyle.Flat;
            btnVolveralmenuprincipal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolveralmenuprincipal.ForeColor = Color.FromArgb(252, 247, 197);
            btnVolveralmenuprincipal.Location = new Point(12, 23);
            btnVolveralmenuprincipal.Name = "btnVolveralmenuprincipal";
            btnVolveralmenuprincipal.Size = new Size(94, 29);
            btnVolveralmenuprincipal.TabIndex = 5;
            btnVolveralmenuprincipal.Text = "Volver";
            btnVolveralmenuprincipal.UseVisualStyleBackColor = false;
            // 
            btnVerConsultasListar.BackColor = Color.FromArgb(19, 116, 125);
            btnVerConsultasListar.FlatStyle = FlatStyle.Flat;
            btnVerConsultasListar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVerConsultasListar.ForeColor = Color.FromArgb(252, 247, 197);
            btnVerConsultasListar.Location = new Point(195, 289);
            btnVerConsultasListar.Name = "btnVerConsultasListar";
            btnVerConsultasListar.Size = new Size(94, 29);
            btnVerConsultasListar.TabIndex = 1;
            btnVerConsultasListar.Text = "Ver";
            btnVerConsultasListar.UseVisualStyleBackColor = false;
            btnVerConsultasListar.Click += btnVerConsultasListar_Click;
            // txtBuscarEmpleado
            // 
            txtBuscarEmpleado.Location = new Point(757, 54);
            txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            txtBuscarEmpleado.Size = new Size(277, 27);
            txtBuscarEmpleado.TabIndex = 6;
            // 
            // btnVolveralmenuprincipal
            // 
            btnVolveralmenuprincipal.BackColor = Color.FromArgb(19, 116, 125);
            btnVolveralmenuprincipal.FlatStyle = FlatStyle.Flat;
            btnVolveralmenuprincipal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolveralmenuprincipal.ForeColor = Color.FromArgb(252, 247, 197);
            btnVolveralmenuprincipal.Location = new Point(33, 12);
            btnVolveralmenuprincipal.Name = "btnVolveralmenuprincipal";
            btnVolveralmenuprincipal.Size = new Size(94, 29);
            btnVolveralmenuprincipal.TabIndex = 5;
            btnVolveralmenuprincipal.Text = "Volver";
            btnVolveralmenuprincipal.UseVisualStyleBackColor = false;
            // 
            // FrmListaDeEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 247, 197);
            ClientSize = new Size(1231, 450);
            Controls.Add(btnVolveralmenuprincipal);
            Controls.Add(btnVerConsultasListar);
            BackColor = Color.FromArgb(252, 247, 197);
            ClientSize = new Size(1449, 710);
            Controls.Add(txtBuscarEmpleado);
            Controls.Add(btnVolveralmenuprincipal);
            Controls.Add(dgvNomina);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListaDeEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListaDeEmpleados";
            Load += FrmListaDeEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNomina).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNomina;
        private Button btnVerConsultasListar;
        private Button btnVolveralmenuprincipal;
        private Button btnVolveralmenuprincipal;
        private TextBox txtBuscarEmpleado;
    }
}