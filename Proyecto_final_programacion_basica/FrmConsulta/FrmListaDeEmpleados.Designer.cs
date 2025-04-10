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
            dgvListadeempleados = new DataGridView();
            btnVolveralmenuprincipal = new Button();
            txtBuscarEmpleado = new TextBox();
            dtpFechaMaxima = new DateTimePicker();
            chkFiltrarFecha = new CheckBox();
            cbDepartamento = new ComboBox();
            cbGenero = new ComboBox();
            dtpFechaMinima = new DateTimePicker();
            btnEliminarfiltros = new Button();
            btnExportarexcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListadeempleados).BeginInit();
            SuspendLayout();
            // 
            // dgvListadeempleados
            // 
            dgvListadeempleados.BackgroundColor = Color.FromArgb(19, 116, 125);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(252, 247, 197);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(10, 191, 188);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListadeempleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListadeempleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadeempleados.GridColor = Color.FromArgb(19, 116, 125);
            dgvListadeempleados.Location = new Point(22, 86);
            dgvListadeempleados.Name = "dgvListadeempleados";
            dgvListadeempleados.ReadOnly = true;
            dgvListadeempleados.RowHeadersWidth = 51;
            dgvListadeempleados.Size = new Size(1693, 629);
            dgvListadeempleados.TabIndex = 0;
            // 
            // btnVolveralmenuprincipal
            // 
            btnVolveralmenuprincipal.BackColor = Color.FromArgb(19, 116, 125);
            btnVolveralmenuprincipal.FlatStyle = FlatStyle.Flat;
            btnVolveralmenuprincipal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolveralmenuprincipal.ForeColor = Color.FromArgb(252, 247, 197);
            btnVolveralmenuprincipal.Location = new Point(22, 12);
            btnVolveralmenuprincipal.Name = "btnVolveralmenuprincipal";
            btnVolveralmenuprincipal.Size = new Size(94, 29);
            btnVolveralmenuprincipal.TabIndex = 5;
            btnVolveralmenuprincipal.Text = "Volver";
            btnVolveralmenuprincipal.UseVisualStyleBackColor = false;
            btnVolveralmenuprincipal.Click += btnVolveralmenuprincipal_Click;
            // 
            // txtBuscarEmpleado
            // 
            txtBuscarEmpleado.Location = new Point(242, 55);
            txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            txtBuscarEmpleado.Size = new Size(292, 27);
            txtBuscarEmpleado.TabIndex = 6;
            txtBuscarEmpleado.TextChanged += txtBuscarEmpleado_TextChanged;
            // 
            // dtpFechaMaxima
            // 
            dtpFechaMaxima.Format = DateTimePickerFormat.Short;
            dtpFechaMaxima.Location = new Point(1383, 53);
            dtpFechaMaxima.Name = "dtpFechaMaxima";
            dtpFechaMaxima.Size = new Size(106, 27);
            dtpFechaMaxima.TabIndex = 7;
            dtpFechaMaxima.ValueChanged += dtpFechaIngreso_ValueChanged;
            // 
            // chkFiltrarFecha
            // 
            chkFiltrarFecha.AutoSize = true;
            chkFiltrarFecha.Location = new Point(1505, 56);
            chkFiltrarFecha.Name = "chkFiltrarFecha";
            chkFiltrarFecha.Size = new Size(210, 24);
            chkFiltrarFecha.TabIndex = 8;
            chkFiltrarFecha.Text = "Filtrar por fecha de ingreso";
            chkFiltrarFecha.UseVisualStyleBackColor = true;
            chkFiltrarFecha.CheckedChanged += chkFiltrarFecha_CheckedChanged;
            // 
            // cbDepartamento
            // 
            cbDepartamento.FormattingEnabled = true;
            cbDepartamento.Location = new Point(798, 53);
            cbDepartamento.Name = "cbDepartamento";
            cbDepartamento.Size = new Size(151, 28);
            cbDepartamento.TabIndex = 10;
            cbDepartamento.SelectedIndexChanged += cbDepartamento_SelectedIndexChanged;
            // 
            // cbGenero
            // 
            cbGenero.FormattingEnabled = true;
            cbGenero.Location = new Point(591, 53);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(151, 28);
            cbGenero.TabIndex = 12;
            cbGenero.SelectedIndexChanged += cbGenero_SelectedIndexChanged;
            // 
            // dtpFechaMinima
            // 
            dtpFechaMinima.Format = DateTimePickerFormat.Short;
            dtpFechaMinima.Location = new Point(1383, 20);
            dtpFechaMinima.Name = "dtpFechaMinima";
            dtpFechaMinima.Size = new Size(106, 27);
            dtpFechaMinima.TabIndex = 13;
            dtpFechaMinima.ValueChanged += dtpFechaMinima_ValueChanged;
            // 
            // btnEliminarfiltros
            // 
            btnEliminarfiltros.Location = new Point(990, 53);
            btnEliminarfiltros.Name = "btnEliminarfiltros";
            btnEliminarfiltros.Size = new Size(124, 29);
            btnEliminarfiltros.TabIndex = 14;
            btnEliminarfiltros.Text = "Eliminar filtros";
            btnEliminarfiltros.UseVisualStyleBackColor = true;
            btnEliminarfiltros.Click += btnEliminarfiltros_Click;
            // 
            // btnExportarexcel
            // 
            btnExportarexcel.Location = new Point(1173, 53);
            btnExportarexcel.Name = "btnExportarexcel";
            btnExportarexcel.Size = new Size(124, 29);
            btnExportarexcel.TabIndex = 15;
            btnExportarexcel.Text = "Exportar a excel";
            btnExportarexcel.UseVisualStyleBackColor = true;
            btnExportarexcel.Click += btnExportarexcel_Click;
            // 
            // FrmListaDeEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 247, 197);
            ClientSize = new Size(1738, 746);
            Controls.Add(btnExportarexcel);
            Controls.Add(btnEliminarfiltros);
            Controls.Add(dtpFechaMinima);
            Controls.Add(cbGenero);
            Controls.Add(cbDepartamento);
            Controls.Add(chkFiltrarFecha);
            Controls.Add(dtpFechaMaxima);
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
        private DateTimePicker dtpFechaMaxima;
        private CheckBox chkFiltrarFecha;
        private ComboBox cbDepartamento;
        private ComboBox cbGenero;
        private DateTimePicker dtpFechaMinima;
        private Button btnEliminarfiltros;
        private Button btnExportarexcel;
    }
}