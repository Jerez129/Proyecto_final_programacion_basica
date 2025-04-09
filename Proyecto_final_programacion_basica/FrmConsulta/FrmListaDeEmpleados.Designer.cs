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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvListadeempleados = new DataGridView();
            btnVolveralmenuprincipal = new Button();
            txtBuscarEmpleado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvListadeempleados).BeginInit();
            SuspendLayout();
            // 
            // dgvListadeempleados
            // 
            dgvListadeempleados.BackgroundColor = Color.FromArgb(19, 116, 125);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(252, 247, 197);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(10, 191, 188);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListadeempleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListadeempleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadeempleados.GridColor = Color.FromArgb(19, 116, 125);
            dgvListadeempleados.Location = new Point(22, 86);
            dgvListadeempleados.Name = "dgvListadeempleados";
            dgvListadeempleados.RowHeadersWidth = 51;
            dgvListadeempleados.Size = new Size(1425, 629);
            dgvListadeempleados.TabIndex = 0;
            // 
            // btnVolveralmenuprincipal
            // 
            btnVolveralmenuprincipal.BackColor = Color.FromArgb(19, 116, 125);
            btnVolveralmenuprincipal.FlatStyle = FlatStyle.Flat;
            btnVolveralmenuprincipal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolveralmenuprincipal.ForeColor = Color.FromArgb(252, 247, 197);
            btnVolveralmenuprincipal.Location = new Point(94, 22);
            btnVolveralmenuprincipal.Name = "btnVolveralmenuprincipal";
            btnVolveralmenuprincipal.Size = new Size(94, 29);
            btnVolveralmenuprincipal.TabIndex = 5;
            btnVolveralmenuprincipal.Text = "Volver";
            btnVolveralmenuprincipal.UseVisualStyleBackColor = false;
            // 
            // txtBuscarEmpleado
            // 
            txtBuscarEmpleado.Location = new Point(784, 53);
            txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            txtBuscarEmpleado.Size = new Size(292, 27);
            txtBuscarEmpleado.TabIndex = 6;
            txtBuscarEmpleado.TextChanged += txtBuscarEmpleado_TextChanged;
            // 
            // FrmListaDeEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 247, 197);
            ClientSize = new Size(1468, 746);
            Controls.Add(txtBuscarEmpleado);
            Controls.Add(btnVolveralmenuprincipal);
            Controls.Add(dgvListadeempleados);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListaDeEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListaDeEmpleados";
            Load += FrmListaDeEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListadeempleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListadeempleados;
        private Button btnVolveralmenuprincipal;
        private TextBox txtBuscarEmpleado;
    }
}