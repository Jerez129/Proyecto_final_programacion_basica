namespace Capa_Presentacion.FrmsControldeausencias
{
    partial class FrmVisualEditarausencias
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
            dgvEditarausencias = new DataGridView();
            btnRegistrarausenciaeditar = new Button();
            dtpFechadefin = new DateTimePicker();
            dtpFechadeinicio = new DateTimePicker();
            cbAprobacionausencia = new ComboBox();
            cbTipodeausencia = new ComboBox();
            lblAprobacionAusenciaEditar = new Label();
            lblTipoDeAusenciaEditar = new Label();
            lblFechaDeFinAusenciaEditar = new Label();
            lblFechaDeInicioAusenciaEditar = new Label();
            cbAprobacionEditar = new ComboBox();
            txtIdAusenciaEditar = new TextBox();
            txtIdEmpleadoEditar = new TextBox();
            btnEliminarasuenciaeditar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEditarausencias).BeginInit();
            SuspendLayout();
            // 
            // dgvEditarausencias
            // 
            dgvEditarausencias.BackgroundColor = Color.FromArgb(19, 116, 125);
            dgvEditarausencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditarausencias.GridColor = Color.FromArgb(19, 116, 125);
            dgvEditarausencias.Location = new Point(408, 116);
            dgvEditarausencias.Name = "dgvEditarausencias";
            dgvEditarausencias.RowHeadersWidth = 51;
            dgvEditarausencias.Size = new Size(796, 327);
            dgvEditarausencias.TabIndex = 0;
            dgvEditarausencias.CellClick += dgvEditarausencias_CellClick;
            // 
            // btnRegistrarausenciaeditar
            // 
            btnRegistrarausenciaeditar.BackColor = Color.FromArgb(19, 116, 125);
            btnRegistrarausenciaeditar.FlatStyle = FlatStyle.Flat;
            btnRegistrarausenciaeditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegistrarausenciaeditar.ForeColor = Color.FromArgb(252, 247, 197);
            btnRegistrarausenciaeditar.Location = new Point(163, 504);
            btnRegistrarausenciaeditar.Name = "btnRegistrarausenciaeditar";
            btnRegistrarausenciaeditar.Size = new Size(94, 29);
            btnRegistrarausenciaeditar.TabIndex = 33;
            btnRegistrarausenciaeditar.Text = "Registrar";
            btnRegistrarausenciaeditar.UseVisualStyleBackColor = false;
            btnRegistrarausenciaeditar.Click += btnRegistrarausencia_Click;
            // 
            // dtpFechadefin
            // 
            dtpFechadefin.CalendarMonthBackground = Color.FromArgb(252, 247, 197);
            dtpFechadefin.Format = DateTimePickerFormat.Short;
            dtpFechadefin.Location = new Point(183, 243);
            dtpFechadefin.Name = "dtpFechadefin";
            dtpFechadefin.Size = new Size(187, 27);
            dtpFechadefin.TabIndex = 32;
            // 
            // dtpFechadeinicio
            // 
            dtpFechadeinicio.CalendarMonthBackground = Color.FromArgb(252, 247, 197);
            dtpFechadeinicio.Format = DateTimePickerFormat.Short;
            dtpFechadeinicio.Location = new Point(183, 175);
            dtpFechadeinicio.Name = "dtpFechadeinicio";
            dtpFechadeinicio.Size = new Size(187, 27);
            dtpFechadeinicio.TabIndex = 31;
            // 
            // cbAprobacionausencia
            // 
            cbAprobacionausencia.FormattingEnabled = true;
            cbAprobacionausencia.Location = new Point(183, 366);
            cbAprobacionausencia.Name = "cbAprobacionausencia";
            cbAprobacionausencia.Size = new Size(187, 28);
            cbAprobacionausencia.TabIndex = 30;
            // 
            // cbTipodeausencia
            // 
            cbTipodeausencia.BackColor = Color.FromArgb(252, 247, 197);
            cbTipodeausencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipodeausencia.FormattingEnabled = true;
            cbTipodeausencia.Location = new Point(183, 301);
            cbTipodeausencia.Name = "cbTipodeausencia";
            cbTipodeausencia.Size = new Size(187, 28);
            cbTipodeausencia.TabIndex = 29;
            // 
            // lblAprobacionAusenciaEditar
            // 
            lblAprobacionAusenciaEditar.AutoSize = true;
            lblAprobacionAusenciaEditar.BackColor = Color.FromArgb(19, 116, 125);
            lblAprobacionAusenciaEditar.FlatStyle = FlatStyle.Flat;
            lblAprobacionAusenciaEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAprobacionAusenciaEditar.ForeColor = Color.FromArgb(252, 247, 197);
            lblAprobacionAusenciaEditar.Location = new Point(48, 374);
            lblAprobacionAusenciaEditar.Name = "lblAprobacionAusenciaEditar";
            lblAprobacionAusenciaEditar.Size = new Size(90, 20);
            lblAprobacionAusenciaEditar.TabIndex = 25;
            lblAprobacionAusenciaEditar.Text = "Aprobación";
            // 
            // lblTipoDeAusenciaEditar
            // 
            lblTipoDeAusenciaEditar.AutoSize = true;
            lblTipoDeAusenciaEditar.BackColor = Color.FromArgb(19, 116, 125);
            lblTipoDeAusenciaEditar.FlatStyle = FlatStyle.Flat;
            lblTipoDeAusenciaEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTipoDeAusenciaEditar.ForeColor = Color.FromArgb(252, 247, 197);
            lblTipoDeAusenciaEditar.Location = new Point(46, 309);
            lblTipoDeAusenciaEditar.Name = "lblTipoDeAusenciaEditar";
            lblTipoDeAusenciaEditar.Size = new Size(128, 20);
            lblTipoDeAusenciaEditar.TabIndex = 24;
            lblTipoDeAusenciaEditar.Text = "Tipo de Ausencia";
            // 
            // lblFechaDeFinAusenciaEditar
            // 
            lblFechaDeFinAusenciaEditar.AutoSize = true;
            lblFechaDeFinAusenciaEditar.BackColor = Color.FromArgb(19, 116, 125);
            lblFechaDeFinAusenciaEditar.FlatStyle = FlatStyle.Flat;
            lblFechaDeFinAusenciaEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaDeFinAusenciaEditar.ForeColor = Color.FromArgb(252, 247, 197);
            lblFechaDeFinAusenciaEditar.Location = new Point(48, 243);
            lblFechaDeFinAusenciaEditar.Name = "lblFechaDeFinAusenciaEditar";
            lblFechaDeFinAusenciaEditar.Size = new Size(93, 20);
            lblFechaDeFinAusenciaEditar.TabIndex = 23;
            lblFechaDeFinAusenciaEditar.Text = "Fecha de fin";
            // 
            // lblFechaDeInicioAusenciaEditar
            // 
            lblFechaDeInicioAusenciaEditar.AutoSize = true;
            lblFechaDeInicioAusenciaEditar.BackColor = Color.FromArgb(19, 116, 125);
            lblFechaDeInicioAusenciaEditar.FlatStyle = FlatStyle.Flat;
            lblFechaDeInicioAusenciaEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaDeInicioAusenciaEditar.ForeColor = Color.FromArgb(252, 247, 197);
            lblFechaDeInicioAusenciaEditar.Location = new Point(48, 175);
            lblFechaDeInicioAusenciaEditar.Name = "lblFechaDeInicioAusenciaEditar";
            lblFechaDeInicioAusenciaEditar.Size = new Size(111, 20);
            lblFechaDeInicioAusenciaEditar.TabIndex = 22;
            lblFechaDeInicioAusenciaEditar.Text = "Fecha de inicio";
            // 
            // cbAprobacionEditar
            // 
            cbAprobacionEditar.BackColor = Color.FromArgb(252, 247, 197);
            cbAprobacionEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAprobacionEditar.FormattingEnabled = true;
            cbAprobacionEditar.Location = new Point(183, 367);
            cbAprobacionEditar.Name = "cbAprobacionEditar";
            cbAprobacionEditar.Size = new Size(187, 28);
            cbAprobacionEditar.TabIndex = 35;
            // 
            // txtIdAusenciaEditar
            // 
            txtIdAusenciaEditar.Location = new Point(183, 130);
            txtIdAusenciaEditar.Name = "txtIdAusenciaEditar";
            txtIdAusenciaEditar.Size = new Size(187, 27);
            txtIdAusenciaEditar.TabIndex = 36;
            txtIdAusenciaEditar.Visible = false;
            // 
            // txtIdEmpleadoEditar
            // 
            txtIdEmpleadoEditar.Location = new Point(183, 87);
            txtIdEmpleadoEditar.Name = "txtIdEmpleadoEditar";
            txtIdEmpleadoEditar.Size = new Size(187, 27);
            txtIdEmpleadoEditar.TabIndex = 37;
            txtIdEmpleadoEditar.Visible = false;
            // 
            // btnEliminarasuenciaeditar
            // 
            btnEliminarasuenciaeditar.BackColor = Color.FromArgb(19, 116, 125);
            btnEliminarasuenciaeditar.FlatStyle = FlatStyle.Flat;
            btnEliminarasuenciaeditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminarasuenciaeditar.ForeColor = Color.FromArgb(252, 247, 197);
            btnEliminarasuenciaeditar.Location = new Point(263, 504);
            btnEliminarasuenciaeditar.Name = "btnEliminarasuenciaeditar";
            btnEliminarasuenciaeditar.Size = new Size(94, 29);
            btnEliminarasuenciaeditar.TabIndex = 38;
            btnEliminarasuenciaeditar.Text = "Eliminar";
            btnEliminarasuenciaeditar.UseVisualStyleBackColor = false;
            btnEliminarasuenciaeditar.Click += btnEliminarasuenciaeditar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(19, 116, 125);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.FromArgb(252, 247, 197);
            btnCerrar.Location = new Point(1110, 504);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 39;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmVisualEditarausencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 247, 197);
            ClientSize = new Size(1244, 629);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminarasuenciaeditar);
            Controls.Add(txtIdEmpleadoEditar);
            Controls.Add(txtIdAusenciaEditar);
            Controls.Add(cbAprobacionEditar);
            Controls.Add(btnRegistrarausenciaeditar);
            Controls.Add(dtpFechadefin);
            Controls.Add(dtpFechadeinicio);
            Controls.Add(cbAprobacionausencia);
            Controls.Add(cbTipodeausencia);
            Controls.Add(lblAprobacionAusenciaEditar);
            Controls.Add(lblTipoDeAusenciaEditar);
            Controls.Add(lblFechaDeFinAusenciaEditar);
            Controls.Add(lblFechaDeInicioAusenciaEditar);
            Controls.Add(dgvEditarausencias);
            ForeColor = Color.FromArgb(19, 116, 125);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVisualEditarausencias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVisualEditarausencias";
            Load += FrmVisualEditarausencias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEditarausencias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEditarausencias;
        private Button btnRegistrarausenciaeditar;
        private DateTimePicker dtpFechadefin;
        private DateTimePicker dtpFechadeinicio;
        private ComboBox cbAprobacionausencia;
        private ComboBox cbTipodeausencia;
        private Label lblAprobacionAusenciaEditar;
        private Label lblTipoDeAusenciaEditar;
        private Label lblFechaDeFinAusenciaEditar;
        private Label lblFechaDeInicioAusenciaEditar;
        private ComboBox cbAprobacionEditar;
        private TextBox txtIdAusenciaEditar;
        private TextBox txtIdEmpleadoEditar;
        private Button btnEliminarasuenciaeditar;
        private Button btnCerrar;
    }
}