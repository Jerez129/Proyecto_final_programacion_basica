namespace Capa_Presentacion.FrmConsulta
{
    partial class FrmReporteDeAusencias
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
            dgvReportedeausencias = new DataGridView();
            txtNombre = new TextBox();
            cbTipoasuencia = new ComboBox();
            checkBox1 = new CheckBox();
            cbAprobado = new ComboBox();
            dtpFechaausencia = new DateTimePicker();
            btnExportaraexcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReportedeausencias).BeginInit();
            SuspendLayout();
            // 
            // dgvReportedeausencias
            // 
            dgvReportedeausencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvReportedeausencias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReportedeausencias.BackgroundColor = Color.FromArgb(19, 116, 125);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(252, 247, 197);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(10, 191, 188);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReportedeausencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReportedeausencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportedeausencias.GridColor = Color.FromArgb(19, 116, 125);
            dgvReportedeausencias.Location = new Point(29, 139);
            dgvReportedeausencias.Name = "dgvReportedeausencias";
            dgvReportedeausencias.RowHeadersWidth = 51;
            dgvReportedeausencias.Size = new Size(775, 588);
            dgvReportedeausencias.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(29, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(166, 27);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // cbTipoasuencia
            // 
            cbTipoasuencia.FormattingEnabled = true;
            cbTipoasuencia.Location = new Point(250, 59);
            cbTipoasuencia.Name = "cbTipoasuencia";
            cbTipoasuencia.Size = new Size(151, 28);
            cbTipoasuencia.TabIndex = 3;
            cbTipoasuencia.SelectedIndexChanged += cbTipoasuencia_SelectedIndexChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(661, 94);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(136, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Filtrar por fecha";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // cbAprobado
            // 
            cbAprobado.FormattingEnabled = true;
            cbAprobado.Location = new Point(457, 60);
            cbAprobado.Name = "cbAprobado";
            cbAprobado.Size = new Size(151, 28);
            cbAprobado.TabIndex = 5;
            cbAprobado.SelectedIndexChanged += cbAprobado_SelectedIndexChanged;
            // 
            // dtpFechaausencia
            // 
            dtpFechaausencia.Format = DateTimePickerFormat.Short;
            dtpFechaausencia.Location = new Point(665, 61);
            dtpFechaausencia.Name = "dtpFechaausencia";
            dtpFechaausencia.Size = new Size(127, 27);
            dtpFechaausencia.TabIndex = 6;
            dtpFechaausencia.ValueChanged += dtpFechaausencia_ValueChanged;
            // 
            // btnExportaraexcel
            // 
            btnExportaraexcel.Location = new Point(665, 12);
            btnExportaraexcel.Name = "btnExportaraexcel";
            btnExportaraexcel.Size = new Size(129, 29);
            btnExportaraexcel.TabIndex = 7;
            btnExportaraexcel.Text = "Exportar a excel";
            btnExportaraexcel.UseVisualStyleBackColor = true;
            btnExportaraexcel.Click += btnExportaraexcel_Click;
            // 
            // FrmReporteDeAusencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 247, 197);
            ClientSize = new Size(836, 737);
            Controls.Add(btnExportaraexcel);
            Controls.Add(dtpFechaausencia);
            Controls.Add(cbAprobado);
            Controls.Add(checkBox1);
            Controls.Add(cbTipoasuencia);
            Controls.Add(txtNombre);
            Controls.Add(dgvReportedeausencias);
            ForeColor = Color.FromArgb(19, 116, 125);
            Name = "FrmReporteDeAusencias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmReporteDeAusencias";
            Load += FrmReporteDeAusencias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReportedeausencias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReportedeausencias;
        private TextBox txtNombre;
        private ComboBox cbTipoasuencia;
        private CheckBox checkBox1;
        private ComboBox cbAprobado;
        private DateTimePicker dtpFechaausencia;
        private Button btnExportaraexcel;
    }
}