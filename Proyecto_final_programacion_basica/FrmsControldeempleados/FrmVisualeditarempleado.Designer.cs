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
            dtpFechaingresoeditar.Location = new Point(175, 620);
            dtpFechaingresoeditar.Name = "dtpFechaingresoeditar";
            dtpFechaingresoeditar.Size = new Size(112, 27);
            dtpFechaingresoeditar.TabIndex = 48;
            // 
            // dtpFechanacimientoeditar
            // 
            dtpFechanacimientoeditar.Format = DateTimePickerFormat.Short;
            dtpFechanacimientoeditar.Location = new Point(175, 579);
            dtpFechanacimientoeditar.Name = "dtpFechanacimientoeditar";
            dtpFechanacimientoeditar.Size = new Size(112, 27);
            dtpFechanacimientoeditar.TabIndex = 47;
            // 
            // lblFechaNacimientoeditar
            // 
            lblFechaNacimientoeditar.AutoSize = true;
            lblFechaNacimientoeditar.Location = new Point(0, 579);
            lblFechaNacimientoeditar.Name = "lblFechaNacimientoeditar";
            lblFechaNacimientoeditar.Size = new Size(128, 20);
            lblFechaNacimientoeditar.TabIndex = 46;
            lblFechaNacimientoeditar.Text = "Fecha Nacimiento";
            // 
            // cbCargoeditar
            // 
            cbCargoeditar.FormattingEnabled = true;
            cbCargoeditar.Items.AddRange(new object[] { "Gerente de Distribución", "", "", "Gerente de Logística", "", "", "Supervisor de Distribución", "", "", "Supervisor de Almacén", "", "", "Auxiliar de Distribución", "", "", "Chofer de Distribución", "", "", "Técnico de Productividad", "", "", "Técnico en Logística", "", "", "Coordinador de Seguridad Industrial", "", "", "Técnico en Control de Calidad", "", "", "Técnico de gente y gestión ", "", "", "Gerente de Ventas", "Asesor de ventas" });
            cbCargoeditar.Location = new Point(136, 367);
            cbCargoeditar.Name = "cbCargoeditar";
            cbCargoeditar.Size = new Size(190, 28);
            cbCargoeditar.TabIndex = 45;
            // 
            // lblCargoeditar
            // 
            lblCargoeditar.AutoSize = true;
            lblCargoeditar.Location = new Point(76, 370);
            lblCargoeditar.Name = "lblCargoeditar";
            lblCargoeditar.Size = new Size(49, 20);
            lblCargoeditar.TabIndex = 44;
            lblCargoeditar.Text = "Cargo";
            // 
            // cbGeneroeditar
            // 
            cbGeneroeditar.FormattingEnabled = true;
            cbGeneroeditar.Location = new Point(136, 520);
            cbGeneroeditar.Name = "cbGeneroeditar";
            cbGeneroeditar.Size = new Size(190, 28);
            cbGeneroeditar.TabIndex = 43;
            // 
            // cbDireccioneditar
            // 
            cbDireccioneditar.FormattingEnabled = true;
            cbDireccioneditar.Location = new Point(136, 472);
            cbDireccioneditar.Name = "cbDireccioneditar";
            cbDireccioneditar.Size = new Size(362, 28);
            cbDireccioneditar.TabIndex = 42;
            // 
            // cbDepartamentoeditar
            // 
            cbDepartamentoeditar.FormattingEnabled = true;
            cbDepartamentoeditar.Location = new Point(136, 423);
            cbDepartamentoeditar.Name = "cbDepartamentoeditar";
            cbDepartamentoeditar.Size = new Size(190, 28);
            cbDepartamentoeditar.TabIndex = 41;
            // 
            // txtTelefonoeditar
            // 
            txtTelefonoeditar.Location = new Point(136, 275);
            txtTelefonoeditar.Name = "txtTelefonoeditar";
            txtTelefonoeditar.Size = new Size(233, 27);
            txtTelefonoeditar.TabIndex = 40;
            // 
            // txtCorreoeditar
            // 
            txtCorreoeditar.Location = new Point(136, 220);
            txtCorreoeditar.Name = "txtCorreoeditar";
            txtCorreoeditar.Size = new Size(233, 27);
            txtCorreoeditar.TabIndex = 39;
            // 
            // txtCedulaeditar
            // 
            txtCedulaeditar.Location = new Point(136, 167);
            txtCedulaeditar.Name = "txtCedulaeditar";
            txtCedulaeditar.Size = new Size(233, 27);
            txtCedulaeditar.TabIndex = 38;
            // 
            // txtApellidoeditar
            // 
            txtApellidoeditar.Location = new Point(136, 116);
            txtApellidoeditar.Name = "txtApellidoeditar";
            txtApellidoeditar.Size = new Size(233, 27);
            txtApellidoeditar.TabIndex = 37;
            // 
            // txtNombreeditar
            // 
            txtNombreeditar.Location = new Point(136, 52);
            txtNombreeditar.Name = "txtNombreeditar";
            txtNombreeditar.Size = new Size(233, 27);
            txtNombreeditar.TabIndex = 36;
            // 
            // lbIdgeneroeditar
            // 
            lbIdgeneroeditar.AutoSize = true;
            lbIdgeneroeditar.Location = new Point(68, 528);
            lbIdgeneroeditar.Name = "lbIdgeneroeditar";
            lbIdgeneroeditar.Size = new Size(57, 20);
            lbIdgeneroeditar.TabIndex = 35;
            lbIdgeneroeditar.Text = "Genero";
            // 
            // lblIddireccioneditar
            // 
            lblIddireccioneditar.AutoSize = true;
            lblIddireccioneditar.Location = new Point(53, 475);
            lblIddireccioneditar.Name = "lblIddireccioneditar";
            lblIddireccioneditar.Size = new Size(72, 20);
            lblIddireccioneditar.TabIndex = 34;
            lblIddireccioneditar.Text = "Direccion";
            // 
            // lblIddepartamentoeditar
            // 
            lblIddepartamentoeditar.AutoSize = true;
            lblIddepartamentoeditar.Location = new Point(19, 426);
            lblIddepartamentoeditar.Name = "lblIddepartamentoeditar";
            lblIddepartamentoeditar.Size = new Size(106, 20);
            lblIddepartamentoeditar.TabIndex = 33;
            lblIddepartamentoeditar.Text = "Departamento";
            // 
            // lblFechaIngresoeeditar
            // 
            lblFechaIngresoeeditar.AutoSize = true;
            lblFechaIngresoeeditar.Location = new Point(25, 620);
            lblFechaIngresoeeditar.Name = "lblFechaIngresoeeditar";
            lblFechaIngresoeeditar.Size = new Size(100, 20);
            lblFechaIngresoeeditar.TabIndex = 32;
            lblFechaIngresoeeditar.Text = "Fecha Ingreso";
            // 
            // lblTelefonoeditar
            // 
            lblTelefonoeditar.AutoSize = true;
            lblTelefonoeditar.Location = new Point(61, 278);
            lblTelefonoeditar.Name = "lblTelefonoeditar";
            lblTelefonoeditar.Size = new Size(67, 20);
            lblTelefonoeditar.TabIndex = 31;
            lblTelefonoeditar.Text = "Telefono";
            // 
            // lblCorreoeditar
            // 
            lblCorreoeditar.AutoSize = true;
            lblCorreoeditar.Location = new Point(61, 227);
            lblCorreoeditar.Name = "lblCorreoeditar";
            lblCorreoeditar.Size = new Size(54, 20);
            lblCorreoeditar.TabIndex = 30;
            lblCorreoeditar.Text = "Correo";
            // 
            // lblCedulaeditar
            // 
            lblCedulaeditar.AutoSize = true;
            lblCedulaeditar.Location = new Point(61, 170);
            lblCedulaeditar.Name = "lblCedulaeditar";
            lblCedulaeditar.Size = new Size(55, 20);
            lblCedulaeditar.TabIndex = 29;
            lblCedulaeditar.Text = "Cedula";
            // 
            // lblApellidoeditar
            // 
            lblApellidoeditar.AutoSize = true;
            lblApellidoeditar.Location = new Point(61, 119);
            lblApellidoeditar.Name = "lblApellidoeditar";
            lblApellidoeditar.Size = new Size(66, 20);
            lblApellidoeditar.TabIndex = 28;
            lblApellidoeditar.Text = "Apellido";
            // 
            // lblNombreeditar
            // 
            lblNombreeditar.AutoSize = true;
            lblNombreeditar.Location = new Point(61, 55);
            lblNombreeditar.Name = "lblNombreeditar";
            lblNombreeditar.Size = new Size(64, 20);
            lblNombreeditar.TabIndex = 27;
            lblNombreeditar.Text = "Nombre";
            // 
            // dgvEmpleadosEditar
            // 
            dgvEmpleadosEditar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleadosEditar.Location = new Point(504, 90);
            dgvEmpleadosEditar.Name = "dgvEmpleadosEditar";
            dgvEmpleadosEditar.RowHeadersWidth = 51;
            dgvEmpleadosEditar.Size = new Size(1000, 465);
            dgvEmpleadosEditar.TabIndex = 49;
            dgvEmpleadosEditar.CellClick += dgvEmpleadosEditar_CellClick;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(76, 685);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 50;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(193, 685);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 51;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtId_Empleadoeditar
            // 
            txtId_Empleadoeditar.Location = new Point(136, 12);
            txtId_Empleadoeditar.Name = "txtId_Empleadoeditar";
            txtId_Empleadoeditar.Size = new Size(233, 27);
            txtId_Empleadoeditar.TabIndex = 52;
            txtId_Empleadoeditar.Visible = false;
            // 
            // btnCerrarvisualeditarempleado
            // 
            btnCerrarvisualeditarempleado.Location = new Point(1410, 651);
            btnCerrarvisualeditarempleado.Name = "btnCerrarvisualeditarempleado";
            btnCerrarvisualeditarempleado.Size = new Size(94, 29);
            btnCerrarvisualeditarempleado.TabIndex = 53;
            btnCerrarvisualeditarempleado.Text = "Cerrar";
            btnCerrarvisualeditarempleado.UseVisualStyleBackColor = true;
            btnCerrarvisualeditarempleado.Click += btnCerrarvisualeditarempleado_Click;
            // 
            // txtSalariobaseeditar
            // 
            txtSalariobaseeditar.Location = new Point(136, 320);
            txtSalariobaseeditar.Name = "txtSalariobaseeditar";
            txtSalariobaseeditar.Size = new Size(233, 27);
            txtSalariobaseeditar.TabIndex = 55;
            // 
            // lblSalariobaseeditar
            // 
            lblSalariobaseeditar.AutoSize = true;
            lblSalariobaseeditar.Location = new Point(34, 324);
            lblSalariobaseeditar.Name = "lblSalariobaseeditar";
            lblSalariobaseeditar.Size = new Size(90, 20);
            lblSalariobaseeditar.TabIndex = 54;
            lblSalariobaseeditar.Text = "Salario base";
            // 
            // FrmVisualeditarempleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1567, 740);
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
            Name = "FrmVisualeditarempleado";
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