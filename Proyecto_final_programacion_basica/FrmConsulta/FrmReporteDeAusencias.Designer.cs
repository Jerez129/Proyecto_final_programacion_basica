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
            checkBox1.Location = new Point(688, 107);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(136, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Filtrar por fecha";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnExportaraexcel
            // 
            btnExportaraexcel.Location = new Point(668, 12);
            btnExportaraexcel.Name = "btnExportaraexcel";
            btnExportaraexcel.Size = new Size(129, 29);
            btnExportaraexcel.TabIndex = 7;
            btnExportaraexcel.Text = "Exportar a excel";
            btnExportaraexcel.UseVisualStyleBackColor = true;
            btnExportaraexcel.Click += btnExportaraexcel_Click;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(544, 70);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(127, 27);
            dtpFechaInicio.TabIndex = 8;
            dtpFechaInicio.ValueChanged += dtpFechaInicio_ValueChanged;
            // 
            // dtpFechafin
            // 
            dtpFechafin.Format = DateTimePickerFormat.Short;
            dtpFechafin.Location = new Point(544, 103);
            dtpFechafin.Name = "dtpFechafin";
            dtpFechafin.Size = new Size(127, 27);
            dtpFechafin.TabIndex = 9;
            dtpFechafin.ValueChanged += dtpFechafin_ValueChanged;
            // 
            // cbTipodeausencias
            // 
            cbTipodeausencias.FormattingEnabled = true;
            cbTipodeausencias.Location = new Point(287, 94);
            cbTipodeausencias.Name = "cbTipodeausencias";
            cbTipodeausencias.Size = new Size(151, 28);
            cbTipodeausencias.TabIndex = 10;
            cbTipodeausencias.SelectedIndexChanged += cbTipodeausencias_SelectedIndexChanged;
            // 
            // btnLimpiarcampos
            // 
            btnLimpiarcampos.Location = new Point(444, 79);
            btnLimpiarcampos.Name = "btnLimpiarcampos";
            btnLimpiarcampos.Size = new Size(94, 51);
            btnLimpiarcampos.TabIndex = 11;
            btnLimpiarcampos.Text = "Limpiar campos";
            btnLimpiarcampos.UseVisualStyleBackColor = true;
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