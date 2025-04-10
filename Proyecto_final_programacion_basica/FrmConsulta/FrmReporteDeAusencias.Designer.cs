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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvReportedeausencias = new DataGridView();
            txtNombre = new TextBox();
            checkBox1 = new CheckBox();
            btnExportaraexcel = new Button();
            dtpFechaInicio = new DateTimePicker();
            dtpFechafin = new DateTimePicker();
            cbTipodeausencias = new ComboBox();
            btnLimpiarcampos = new Button();
            btnVolveralmenuprincipal = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReportedeausencias).BeginInit();
            SuspendLayout();
            // 
            // dgvReportedeausencias
            // 
            dgvReportedeausencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvReportedeausencias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReportedeausencias.BackgroundColor = Color.FromArgb(19, 116, 125);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(252, 247, 197);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(10, 191, 188);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(41, 34, 31);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReportedeausencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReportedeausencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportedeausencias.GridColor = Color.FromArgb(19, 116, 125);
            dgvReportedeausencias.Location = new Point(29, 139);
            dgvReportedeausencias.Name = "dgvReportedeausencias";
            dgvReportedeausencias.ReadOnly = true;
            dgvReportedeausencias.RowHeadersWidth = 51;
            dgvReportedeausencias.Size = new Size(775, 588);
            dgvReportedeausencias.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(29, 94);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(241, 27);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox1.Location = new Point(661, 99);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(143, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Filtrar por fecha";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnExportaraexcel
            // 
            btnExportaraexcel.BackColor = Color.FromArgb(19, 116, 125);
            btnExportaraexcel.FlatStyle = FlatStyle.Flat;
            btnExportaraexcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExportaraexcel.ForeColor = Color.FromArgb(252, 247, 197);
            btnExportaraexcel.Location = new Point(661, 12);
            btnExportaraexcel.Name = "btnExportaraexcel";
            btnExportaraexcel.Size = new Size(136, 29);
            btnExportaraexcel.TabIndex = 7;
            btnExportaraexcel.Text = "Exportar a Excel";
            btnExportaraexcel.UseVisualStyleBackColor = false;
            btnExportaraexcel.Click += btnExportaraexcel_Click;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(528, 62);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(127, 27);
            dtpFechaInicio.TabIndex = 8;
            dtpFechaInicio.ValueChanged += dtpFechaInicio_ValueChanged;
            // 
            // dtpFechafin
            // 
            dtpFechafin.Format = DateTimePickerFormat.Short;
            dtpFechafin.Location = new Point(528, 95);
            dtpFechafin.Name = "dtpFechafin";
            dtpFechafin.Size = new Size(127, 27);
            dtpFechafin.TabIndex = 9;
            dtpFechafin.ValueChanged += dtpFechafin_ValueChanged;
            // 
            // cbTipodeausencias
            // 
            cbTipodeausencias.FormattingEnabled = true;
            cbTipodeausencias.Location = new Point(276, 94);
            cbTipodeausencias.Name = "cbTipodeausencias";
            cbTipodeausencias.Size = new Size(151, 28);
            cbTipodeausencias.TabIndex = 10;
            cbTipodeausencias.SelectedIndexChanged += cbTipodeausencias_SelectedIndexChanged;
            // 
            // btnLimpiarcampos
            // 
            btnLimpiarcampos.BackColor = Color.FromArgb(19, 116, 125);
            btnLimpiarcampos.FlatStyle = FlatStyle.Flat;
            btnLimpiarcampos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpiarcampos.ForeColor = Color.FromArgb(252, 247, 197);
            btnLimpiarcampos.Location = new Point(433, 71);
            btnLimpiarcampos.Name = "btnLimpiarcampos";
            btnLimpiarcampos.Size = new Size(94, 51);
            btnLimpiarcampos.TabIndex = 11;
            btnLimpiarcampos.Text = "Limpiar campos";
            btnLimpiarcampos.UseVisualStyleBackColor = false;
            btnLimpiarcampos.Click += btnLimpiarcampos_Click;
            // 
            // btnVolveralmenuprincipal
            // 
            btnVolveralmenuprincipal.BackColor = Color.FromArgb(19, 116, 125);
            btnVolveralmenuprincipal.FlatStyle = FlatStyle.Flat;
            btnVolveralmenuprincipal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolveralmenuprincipal.ForeColor = Color.FromArgb(252, 247, 197);
            btnVolveralmenuprincipal.Location = new Point(29, 12);
            btnVolveralmenuprincipal.Name = "btnVolveralmenuprincipal";
            btnVolveralmenuprincipal.Size = new Size(94, 29);
            btnVolveralmenuprincipal.TabIndex = 12;
            btnVolveralmenuprincipal.Text = "Volver";
            btnVolveralmenuprincipal.UseVisualStyleBackColor = false;
            btnVolveralmenuprincipal.Click += btnVolveralmenuprincipal_Click;
            // 
            // FrmReporteDeAusencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 247, 197);
            ClientSize = new Size(836, 737);
            Controls.Add(btnVolveralmenuprincipal);
            Controls.Add(btnLimpiarcampos);
            Controls.Add(cbTipodeausencias);
            Controls.Add(dtpFechafin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(btnExportaraexcel);
            Controls.Add(checkBox1);
            Controls.Add(txtNombre);
            Controls.Add(dgvReportedeausencias);
            ForeColor = Color.FromArgb(19, 116, 125);
            FormBorderStyle = FormBorderStyle.None;
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
        private Button btnExportaraexcel;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechafin;
        private ComboBox cbTipodeausencias;
        private Button btnLimpiarcampos;
        private Button btnVolveralmenuprincipal;
    }
}