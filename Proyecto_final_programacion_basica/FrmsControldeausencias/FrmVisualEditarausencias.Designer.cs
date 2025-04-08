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
            btnRegistrarausencia = new Button();
            dtpFechadefin = new DateTimePicker();
            dtpFechadeinicio = new DateTimePicker();
            cbAprobacionausencia = new ComboBox();
            cbTipodeausencia = new ComboBox();
            lblAprobacionAusenciaEditar = new Label();
            lblTipoDeAusenciaEditar = new Label();
            lblFechaDeFinAusenciaEditar = new Label();
            lblFechaDeInicioAusenciaEditar = new Label();
            cbAprobacionEditar = new ComboBox();
            lblAprobacioneditar = new Label();
            txtIdAusenciaEditar = new TextBox();
            txtIdEmpleadoEditar = new TextBox();
            btnEliminarasuenciaeditar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEditarausencias).BeginInit();
            SuspendLayout();
            // 
            // dgvEditarausencias
            // 
            dgvEditarausencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditarausencias.Location = new Point(408, 116);
            dgvEditarausencias.Name = "dgvEditarausencias";
            dgvEditarausencias.RowHeadersWidth = 51;
            dgvEditarausencias.Size = new Size(796, 327);
            dgvEditarausencias.TabIndex = 0;
            dgvEditarausencias.CellClick += dgvEditarausencias_CellClick;
            // 
            // btnRegistrarausenciaeditar

            btnRegistrarausenciaeditar.Location = new Point(87, 504);
            btnRegistrarausenciaeditar.Name = "btnRegistrarausenciaeditar";
            btnRegistrarausenciaeditar.Size = new Size(94, 29);
            btnRegistrarausenciaeditar.TabIndex = 33;
            btnRegistrarausenciaeditar.Text = "Registrar";
            btnRegistrarausenciaeditar.UseVisualStyleBackColor = true;
            btnRegistrarausenciaeditar.Click += btnRegistrarausencia_Click;

            // 
            // btnRegistrarausencia
            // 
            btnRegistrarausencia.Location = new Point(75, 504);
            btnRegistrarausencia.Name = "btnRegistrarausencia";
            btnRegistrarausencia.Size = new Size(94, 29);
            btnRegistrarausencia.TabIndex = 33;
            btnRegistrarausencia.Text = "Registrar";
            btnRegistrarausencia.UseVisualStyleBackColor = true;
            // 
            // dtpFechadefin
            // 
            dtpFechadefin.Format = DateTimePickerFormat.Short;
            dtpFechadefin.Location = new Point(183, 243);
            dtpFechadefin.Name = "dtpFechadefin";
            dtpFechadefin.Size = new Size(187, 27);
            dtpFechadefin.TabIndex = 32;
            // 
            // dtpFechadeinicio
            // 
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
            lblAprobacionAusenciaEditar.Location = new Point(48, 374);
            lblAprobacionAusenciaEditar.Name = "lblAprobacionAusenciaEditar";
            lblAprobacionAusenciaEditar.Size = new Size(87, 20);
            lblAprobacionAusenciaEditar.TabIndex = 25;
            lblAprobacionAusenciaEditar.Text = "Aprobación";
            // 
            // lblTipoDeAusenciaEditar
            // 
            lblTipoDeAusenciaEditar.AutoSize = true;
            lblTipoDeAusenciaEditar.Location = new Point(46, 309);
            lblTipoDeAusenciaEditar.Name = "lblTipoDeAusenciaEditar";
            lblTipoDeAusenciaEditar.Size = new Size(123, 20);
            lblTipoDeAusenciaEditar.TabIndex = 24;
            lblTipoDeAusenciaEditar.Text = "Tipo de Ausencia";
            // 
            // lblFechaDeFinAusenciaEditar
            // 
            lblFechaDeFinAusenciaEditar.AutoSize = true;
            lblFechaDeFinAusenciaEditar.Location = new Point(48, 243);
            lblFechaDeFinAusenciaEditar.Name = "lblFechaDeFinAusenciaEditar";
            lblFechaDeFinAusenciaEditar.Size = new Size(89, 20);
            lblFechaDeFinAusenciaEditar.TabIndex = 23;
            lblFechaDeFinAusenciaEditar.Text = "Fecha de fin";
            // 
            // lblFechaDeInicioAusenciaEditar
            // 
            lblFechaDeInicioAusenciaEditar.AutoSize = true;
            lblFechaDeInicioAusenciaEditar.Location = new Point(48, 175);
            lblFechaDeInicioAusenciaEditar.Name = "lblFechaDeInicioAusenciaEditar";
            lblFechaDeInicioAusenciaEditar.Size = new Size(108, 20);
            lblFechaDeInicioAusenciaEditar.TabIndex = 22;
            lblFechaDeInicioAusenciaEditar.Text = "Fecha de inicio";
            // 
            // cbAprobacionEditar
            // 
            cbAprobacionEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAprobacionEditar.FormattingEnabled = true;
            cbAprobacionEditar.Location = new Point(183, 367);
            cbAprobacionEditar.Name = "cbAprobacionEditar";
            cbAprobacionEditar.Size = new Size(187, 28);
            cbAprobacionEditar.TabIndex = 35;
            // 
            // lblAprobacioneditar
            // 
            lblAprobacioneditar.AutoSize = true;
            lblAprobacioneditar.Location = new Point(69, 375);
            lblAprobacioneditar.Name = "lblAprobacioneditar";
            lblAprobacioneditar.Size = new Size(87, 20);
            lblAprobacioneditar.TabIndex = 34;
            lblAprobacioneditar.Text = "Aprobacion";
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
            btnEliminarasuenciaeditar.Location = new Point(276, 504);
            btnEliminarasuenciaeditar.Name = "btnEliminarasuenciaeditar";
            btnEliminarasuenciaeditar.Size = new Size(94, 29);
            btnEliminarasuenciaeditar.TabIndex = 38;
            btnEliminarasuenciaeditar.Text = "Eliminar";
            btnEliminarasuenciaeditar.UseVisualStyleBackColor = true;
            btnEliminarasuenciaeditar.Click += btnEliminarasuenciaeditar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(1110, 504);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 39;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmVisualEditarausencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 629);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminarasuenciaeditar);
            Controls.Add(txtIdEmpleadoEditar);
            Controls.Add(txtIdAusenciaEditar);
            Controls.Add(cbAprobacionEditar);
            Controls.Add(lblAprobacioneditar);
            Controls.Add(btnRegistrarausenciaeditar);
            Controls.Add(btnRegistrarausencia);
            Controls.Add(dtpFechadefin);
            Controls.Add(dtpFechadeinicio);
            Controls.Add(cbAprobacionausencia);
            Controls.Add(cbTipodeausencia);
            Controls.Add(lblAprobacionAusenciaEditar);
            Controls.Add(lblTipoDeAusenciaEditar);
            Controls.Add(lblFechaDeFinAusenciaEditar);
            Controls.Add(lblFechaDeInicioAusenciaEditar);
            Controls.Add(dgvEditarausencias);
            Name = "FrmVisualEditarausencias";
            Text = "FrmVisualEditarausencias";
            Load += FrmVisualEditarausencias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEditarausencias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEditarausencias;
        private Button btnRegistrarausenciaeditar;
        private Button btnRegistrarausencia;
        private DateTimePicker dtpFechadefin;
        private DateTimePicker dtpFechadeinicio;
        private ComboBox cbAprobacionausencia;
        private ComboBox cbTipodeausencia;
        private Label lblAprobacionAusenciaEditar;
        private Label lblTipoDeAusenciaEditar;
        private Label lblFechaDeFinAusenciaEditar;
        private Label lblFechaDeInicioAusenciaEditar;
        private ComboBox cbAprobacionEditar;
        private Label lblAprobacioneditar;
        private TextBox txtIdAusenciaEditar;
        private TextBox txtIdEmpleadoEditar;
        private Button btnEliminarasuenciaeditar;
        private Button btnCerrar;
    }
}