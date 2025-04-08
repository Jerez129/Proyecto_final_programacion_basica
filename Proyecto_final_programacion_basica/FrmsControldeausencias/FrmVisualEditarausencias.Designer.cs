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
            btnRegistrarausencia = new Button();
            dtpFechadefin = new DateTimePicker();
            dtpFechadeinicio = new DateTimePicker();
            cbAprobacionausencia = new ComboBox();
            cbTipodeausencia = new ComboBox();
            lblAprobacionAusenciaEditar = new Label();
            lblTipoDeAusenciaEditar = new Label();
            lblFechaDeFinAusenciaEditar = new Label();
            lblFechaDeInicioAusenciaEditar = new Label();
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
            // FrmVisualEditarausencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 629);
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
            ((System.ComponentModel.ISupportInitialize)dgvEditarausencias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEditarausencias;
        private Button btnRegistrarausencia;
        private DateTimePicker dtpFechadefin;
        private DateTimePicker dtpFechadeinicio;
        private ComboBox cbAprobacionausencia;
        private ComboBox cbTipodeausencia;
        private Label lblAprobacionAusenciaEditar;
        private Label lblTipoDeAusenciaEditar;
        private Label lblFechaDeFinAusenciaEditar;
        private Label lblFechaDeInicioAusenciaEditar;
    }
}