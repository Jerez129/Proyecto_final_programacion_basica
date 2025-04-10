namespace Capa_Presentacion.FrmsControldeempleados
{
    partial class FrmVisualeditarempleado
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
            dtpFechaingresoeditar = new DateTimePicker();
            dtpFechanacimientoeditar = new DateTimePicker();
            lblFechaNacimientoeditar = new Label();
            cbCargoeditar = new ComboBox();
            lblCargoeditar = new Label();
            cbGeneroeditar = new ComboBox();
            cbDireccioneditar = new ComboBox();
            cbDepartamentoeditar = new ComboBox();
            txtTelefonoeditar = new TextBox();
            txtCorreoeditar = new TextBox();
            txtCedulaeditar = new TextBox();
            txtApellidoeditar = new TextBox();
            txtNombreeditar = new TextBox();
            lbIdgeneroeditar = new Label();
            lblIddireccioneditar = new Label();
            lblIddepartamentoeditar = new Label();
            lblFechaIngresoeeditar = new Label();
            lblTelefonoeditar = new Label();
            lblCorreoeditar = new Label();
            lblCedulaeditar = new Label();
            lblApellidoeditar = new Label();
            lblNombreeditar = new Label();
            dgvEmpleadosEditar = new DataGridView();
            btnEditar = new Button();
            btnEliminar = new Button();
            txtId_Empleadoeditar = new TextBox();
            btnCerrarvisualeditarempleado = new Button();
            txtSalariobaseeditar = new TextBox();
            lblSalariobaseeditar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleadosEditar).BeginInit();
            SuspendLayout();
            // 
            // dtpFechaingresoeditar
            // 
            dtpFechaingresoeditar.Format = DateTimePickerFormat.Short;
            dtpFechaingresoeditar.Location = new Point(175, 471);
            dtpFechaingresoeditar.Name = "dtpFechaingresoeditar";
            dtpFechaingresoeditar.Size = new Size(112, 27);
            dtpFechaingresoeditar.TabIndex = 48;
            // 
            // dtpFechanacimientoeditar
            // 
            dtpFechanacimientoeditar.Format = DateTimePickerFormat.Short;
            dtpFechanacimientoeditar.Location = new Point(175, 438);
            dtpFechanacimientoeditar.Name = "dtpFechanacimientoeditar";
            dtpFechanacimientoeditar.Size = new Size(112, 27);
            dtpFechanacimientoeditar.TabIndex = 47;
            // 
            // lblFechaNacimientoeditar
            // 
            lblFechaNacimientoeditar.AutoSize = true;
            lblFechaNacimientoeditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaNacimientoeditar.ForeColor = Color.FromArgb(19, 116, 125);
            lblFechaNacimientoeditar.Location = new Point(24, 435);
            lblFechaNacimientoeditar.Name = "lblFechaNacimientoeditar";
            lblFechaNacimientoeditar.Size = new Size(134, 20);
            lblFechaNacimientoeditar.TabIndex = 46;
            lblFechaNacimientoeditar.Text = "Fecha Nacimiento";
            // 
            // cbCargoeditar
            // 
            cbCargoeditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCargoeditar.FormattingEnabled = true;
            cbCargoeditar.Items.AddRange(new object[] { "Gerente de Distribución", "Gerente de Logística", "Supervisor de Distribución", "Supervisor de Almacén", "Auxiliar de Distribución", "Chofer de Distribución", "Técnico de Productividad", "Técnico en Logística", "Coordinador de Seguridad Industrial", "Técnico en Control de Calidad", "Técnico de gente y gestión ", "Gerente de Ventas", "Asesor de ventas" });
            cbCargoeditar.Location = new Point(175, 302);
            cbCargoeditar.Name = "cbCargoeditar";
            cbCargoeditar.Size = new Size(190, 28);
            cbCargoeditar.TabIndex = 45;
            // 
            // lblCargoeditar
            // 
            lblCargoeditar.AutoSize = true;
            lblCargoeditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCargoeditar.ForeColor = Color.FromArgb(19, 116, 125);
            lblCargoeditar.Location = new Point(100, 302);
            lblCargoeditar.Name = "lblCargoeditar";
            lblCargoeditar.Size = new Size(50, 20);
            lblCargoeditar.TabIndex = 44;
            lblCargoeditar.Text = "Cargo";
            // 
            // cbGeneroeditar
            // 
            cbGeneroeditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGeneroeditar.FormattingEnabled = true;
            cbGeneroeditar.Location = new Point(175, 404);
            cbGeneroeditar.Name = "cbGeneroeditar";
            cbGeneroeditar.Size = new Size(190, 28);
            cbGeneroeditar.TabIndex = 43;
            // 
            // cbDireccioneditar
            // 
            cbDireccioneditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDireccioneditar.FormattingEnabled = true;
            cbDireccioneditar.Location = new Point(175, 370);
            cbDireccioneditar.Name = "cbDireccioneditar";
            cbDireccioneditar.Size = new Size(415, 28);
            cbDireccioneditar.TabIndex = 42;
            // 
            // cbDepartamentoeditar
            // 
            cbDepartamentoeditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartamentoeditar.FormattingEnabled = true;
            cbDepartamentoeditar.Location = new Point(175, 336);
            cbDepartamentoeditar.Name = "cbDepartamentoeditar";
            cbDepartamentoeditar.Size = new Size(190, 28);
            cbDepartamentoeditar.TabIndex = 41;
            // 
            // txtTelefonoeditar
            // 
            txtTelefonoeditar.Location = new Point(175, 236);
            txtTelefonoeditar.Name = "txtTelefonoeditar";
            txtTelefonoeditar.Size = new Size(233, 27);
            txtTelefonoeditar.TabIndex = 40;
            txtTelefonoeditar.KeyPress += txtTelefonoeditar_KeyPress;
            // 
            // txtCorreoeditar
            // 
            txtCorreoeditar.Location = new Point(175, 203);
            txtCorreoeditar.Name = "txtCorreoeditar";
            txtCorreoeditar.Size = new Size(233, 27);
            txtCorreoeditar.TabIndex = 39;
            // 
            // txtCedulaeditar
            // 
            txtCedulaeditar.Location = new Point(175, 170);
            txtCedulaeditar.Name = "txtCedulaeditar";
            txtCedulaeditar.Size = new Size(233, 27);
            txtCedulaeditar.TabIndex = 38;
            txtCedulaeditar.KeyPress += txtCedulaeditar_KeyPress;
            // 
            // txtApellidoeditar
            // 
            txtApellidoeditar.Location = new Point(175, 137);
            txtApellidoeditar.Name = "txtApellidoeditar";
            txtApellidoeditar.Size = new Size(233, 27);
            txtApellidoeditar.TabIndex = 37;
            txtApellidoeditar.KeyPress += txtApellidoeditar_KeyPress;
            // 
            // txtNombreeditar
            // 
            txtNombreeditar.Enabled = false;
            txtNombreeditar.Location = new Point(175, 104);
            txtNombreeditar.Name = "txtNombreeditar";
            txtNombreeditar.Size = new Size(233, 27);
            txtNombreeditar.TabIndex = 36;
            //txtNombreeditar.TextChanged += txtNombreeditar_TextChanged;
            txtNombreeditar.KeyPress += txtNombreeditar_KeyPress;
            // 
            // lbIdgeneroeditar
            // 
            lbIdgeneroeditar.AutoSize = true;
            lbIdgeneroeditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbIdgeneroeditar.ForeColor = Color.FromArgb(19, 116, 125);
            lbIdgeneroeditar.Location = new Point(92, 409);
            lbIdgeneroeditar.Name = "lbIdgeneroeditar";
            lbIdgeneroeditar.Size = new Size(60, 20);
            lbIdgeneroeditar.TabIndex = 35;
            lbIdgeneroeditar.Text = "Genero";
            // 
            // lblIddireccioneditar
            // 
            lblIddireccioneditar.AutoSize = true;
            lblIddireccioneditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIddireccioneditar.ForeColor = Color.FromArgb(19, 116, 125);
            lblIddireccioneditar.Location = new Point(77, 370);
            lblIddireccioneditar.Name = "lblIddireccioneditar";
            lblIddireccioneditar.Size = new Size(74, 20);
            lblIddireccioneditar.TabIndex = 34;
            lblIddireccioneditar.Text = "Direccion";
            // 
            // lblIddepartamentoeditar
            // 
            lblIddepartamentoeditar.AutoSize = true;
            lblIddepartamentoeditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIddepartamentoeditar.ForeColor = Color.FromArgb(19, 116, 125);
            lblIddepartamentoeditar.Location = new Point(43, 336);
            lblIddepartamentoeditar.Name = "lblIddepartamentoeditar";
            lblIddepartamentoeditar.Size = new Size(111, 20);
            lblIddepartamentoeditar.TabIndex = 33;
            lblIddepartamentoeditar.Text = "Departamento";
            // 
            // lblFechaIngresoeeditar
            // 
            lblFechaIngresoeeditar.AutoSize = true;
            lblFechaIngresoeeditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaIngresoeeditar.ForeColor = Color.FromArgb(19, 116, 125);
            lblFechaIngresoeeditar.Location = new Point(49, 468);
            lblFechaIngresoeeditar.Name = "lblFechaIngresoeeditar";
            lblFechaIngresoeeditar.Size = new Size(106, 20);
            lblFechaIngresoeeditar.TabIndex = 32;
            lblFechaIngresoeeditar.Text = "Fecha Ingreso";
            // 
            // lblTelefonoeditar
            // 
            lblTelefonoeditar.AutoSize = true;
            lblTelefonoeditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefonoeditar.ForeColor = Color.FromArgb(19, 116, 125);
            lblTelefonoeditar.Location = new Point(85, 236);
            lblTelefonoeditar.Name = "lblTelefonoeditar";
            lblTelefonoeditar.Size = new Size(70, 20);
            lblTelefonoeditar.TabIndex = 31;
            lblTelefonoeditar.Text = "Telefono";
            // 
            // lblCorreoeditar
            // 
            lblCorreoeditar.AutoSize = true;
            lblCorreoeditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreoeditar.ForeColor = Color.FromArgb(19, 116, 125);
            lblCorreoeditar.Location = new Point(85, 200);
            lblCorreoeditar.Name = "lblCorreoeditar";
            lblCorreoeditar.Size = new Size(56, 20);
            lblCorreoeditar.TabIndex = 30;
            lblCorreoeditar.Text = "Correo";
            // 
            // lblCedulaeditar
            // 
            lblCedulaeditar.AutoSize = true;
            lblCedulaeditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCedulaeditar.ForeColor = Color.FromArgb(19, 116, 125);
            lblCedulaeditar.Location = new Point(85, 170);
            lblCedulaeditar.Name = "lblCedulaeditar";
            lblCedulaeditar.Size = new Size(56, 20);
            lblCedulaeditar.TabIndex = 29;
            lblCedulaeditar.Text = "Cedula";
            // 
            // lblApellidoeditar
            // 
            lblApellidoeditar.AutoSize = true;
            lblApellidoeditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellidoeditar.ForeColor = Color.FromArgb(19, 116, 125);
            lblApellidoeditar.Location = new Point(85, 137);
            lblApellidoeditar.Name = "lblApellidoeditar";
            lblApellidoeditar.Size = new Size(67, 20);
            lblApellidoeditar.TabIndex = 28;
            lblApellidoeditar.Text = "Apellido";
            // 
            // lblNombreeditar
            // 
            lblNombreeditar.AutoSize = true;
            lblNombreeditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreeditar.ForeColor = Color.FromArgb(19, 116, 125);
            lblNombreeditar.Location = new Point(85, 104);
            lblNombreeditar.Name = "lblNombreeditar";
            lblNombreeditar.Size = new Size(67, 20);
            lblNombreeditar.TabIndex = 27;
            lblNombreeditar.Text = "Nombre";
            // 
            // dgvEmpleadosEditar
            // 
            dgvEmpleadosEditar.BackgroundColor = Color.FromArgb(19, 116, 125);
            dgvEmpleadosEditar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleadosEditar.GridColor = Color.FromArgb(19, 116, 125);
            dgvEmpleadosEditar.Location = new Point(607, 83);
            dgvEmpleadosEditar.Name = "dgvEmpleadosEditar";
            dgvEmpleadosEditar.ReadOnly = true;
            dgvEmpleadosEditar.RowHeadersWidth = 51;
            dgvEmpleadosEditar.Size = new Size(987, 465);
            dgvEmpleadosEditar.TabIndex = 49;
            dgvEmpleadosEditar.CellClick += dgvEmpleadosEditar_CellClick;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(19, 116, 125);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditar.ForeColor = Color.FromArgb(252, 247, 197);
            btnEditar.Location = new Point(112, 599);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 50;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(19, 116, 125);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.FromArgb(252, 247, 197);
            btnEliminar.Location = new Point(229, 599);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 51;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtId_Empleadoeditar
            // 
            txtId_Empleadoeditar.Location = new Point(175, 33);
            txtId_Empleadoeditar.Name = "txtId_Empleadoeditar";
            txtId_Empleadoeditar.Size = new Size(233, 27);
            txtId_Empleadoeditar.TabIndex = 52;
            txtId_Empleadoeditar.Visible = false;
            // 
            // btnCerrarvisualeditarempleado
            // 
            btnCerrarvisualeditarempleado.BackColor = Color.FromArgb(19, 116, 125);
            btnCerrarvisualeditarempleado.FlatStyle = FlatStyle.Flat;
            btnCerrarvisualeditarempleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCerrarvisualeditarempleado.ForeColor = Color.FromArgb(252, 247, 197);
            btnCerrarvisualeditarempleado.Location = new Point(1444, 599);
            btnCerrarvisualeditarempleado.Name = "btnCerrarvisualeditarempleado";
            btnCerrarvisualeditarempleado.Size = new Size(94, 29);
            btnCerrarvisualeditarempleado.TabIndex = 53;
            btnCerrarvisualeditarempleado.Text = "Cerrar";
            btnCerrarvisualeditarempleado.UseVisualStyleBackColor = false;
            btnCerrarvisualeditarempleado.Click += btnCerrarvisualeditarempleado_Click;
            // 
            // txtSalariobaseeditar
            // 
            txtSalariobaseeditar.Location = new Point(175, 269);
            txtSalariobaseeditar.Name = "txtSalariobaseeditar";
            txtSalariobaseeditar.Size = new Size(233, 27);
            txtSalariobaseeditar.TabIndex = 55;
            txtSalariobaseeditar.KeyPress += txtSalariobaseeditar_KeyPress;
            // 
            // lblSalariobaseeditar
            // 
            lblSalariobaseeditar.AutoSize = true;
            lblSalariobaseeditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalariobaseeditar.ForeColor = Color.FromArgb(19, 116, 125);
            lblSalariobaseeditar.Location = new Point(58, 270);
            lblSalariobaseeditar.Name = "lblSalariobaseeditar";
            lblSalariobaseeditar.Size = new Size(93, 20);
            lblSalariobaseeditar.TabIndex = 54;
            lblSalariobaseeditar.Text = "Salario Base";
            // 
            // FrmVisualeditarempleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 247, 197);
            ClientSize = new Size(1620, 712);
            Controls.Add(txtSalariobaseeditar);
            Controls.Add(lblSalariobaseeditar);
            Controls.Add(btnCerrarvisualeditarempleado);
            Controls.Add(txtId_Empleadoeditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(dgvEmpleadosEditar);
            Controls.Add(dtpFechaingresoeditar);
            Controls.Add(dtpFechanacimientoeditar);
            Controls.Add(lblFechaNacimientoeditar);
            Controls.Add(cbCargoeditar);
            Controls.Add(lblCargoeditar);
            Controls.Add(cbGeneroeditar);
            Controls.Add(cbDireccioneditar);
            Controls.Add(cbDepartamentoeditar);
            Controls.Add(txtTelefonoeditar);
            Controls.Add(txtCorreoeditar);
            Controls.Add(txtCedulaeditar);
            Controls.Add(txtApellidoeditar);
            Controls.Add(txtNombreeditar);
            Controls.Add(lbIdgeneroeditar);
            Controls.Add(lblIddireccioneditar);
            Controls.Add(lblIddepartamentoeditar);
            Controls.Add(lblFechaIngresoeeditar);
            Controls.Add(lblTelefonoeditar);
            Controls.Add(lblCorreoeditar);
            Controls.Add(lblCedulaeditar);
            Controls.Add(lblApellidoeditar);
            Controls.Add(lblNombreeditar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVisualeditarempleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVisualeditarempleado";
            Load += FrmVisualeditarempleado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleadosEditar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFechaingresoeditar;
        private DateTimePicker dtpFechanacimientoeditar;
        private Label lblFechaNacimientoeditar;
        private ComboBox cbCargoeditar;
        private Label lblCargoeditar;
        private ComboBox cbGeneroeditar;
        private ComboBox cbDireccioneditar;
        private ComboBox cbDepartamentoeditar;
        private TextBox txtTelefonoeditar;
        private TextBox txtCorreoeditar;
        private TextBox txtCedulaeditar;
        private TextBox txtApellidoeditar;
        private TextBox txtNombreeditar;
        private Label lbIdgeneroeditar;
        private Label lblIddireccioneditar;
        private Label lblIddepartamentoeditar;
        private Label lblFechaIngresoeeditar;
        private Label lblTelefonoeditar;
        private Label lblCorreoeditar;
        private Label lblCedulaeditar;
        private Label lblApellidoeditar;
        private Label lblNombreeditar;
        private DataGridView dgvEmpleadosEditar;
        private Button btnEditar;
        private Button btnEliminar;
        private TextBox txtId_Empleadoeditar;
        private Button btnCerrarvisualeditarempleado;
        private TextBox txtSalariobaseeditar;
        private Label lblSalariobaseeditar;
    }
}