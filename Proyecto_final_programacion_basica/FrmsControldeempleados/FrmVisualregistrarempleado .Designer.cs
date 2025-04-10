namespace Capa_Presentacion_Proyecto_Final
{
    partial class FrmVisualregistrarempleado
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblCedula = new Label();
            lblCorreo = new Label();
            lblTelefono = new Label();
            lblFechaIngreso = new Label();
            lblIddepartamento = new Label();
            lblIddireccion = new Label();
            lbIdgenero = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtCedula = new TextBox();
            txtCorreo = new TextBox();
            cbDepartamento = new ComboBox();
            cbDireccion = new ComboBox();
            cbGenero = new ComboBox();
            btnRegistrarusuario = new Button();
            btnCerrarvisualregistraremplead = new Button();
            cbCargo = new ComboBox();
            lblCargo = new Label();
            lblFechaNacimiento = new Label();
            txtTelefono = new TextBox();
            dtpFechanacimiento = new DateTimePicker();
            dtpFechaingreso = new DateTimePicker();
            txtSalariobase = new TextBox();
            lblSalariobase = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(252, 247, 197);
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(19, 116, 125);
            lblNombre.Location = new Point(65, 155);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblApellido.ForeColor = Color.FromArgb(19, 116, 125);
            lblApellido.Location = new Point(65, 197);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 20);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCedula.ForeColor = Color.FromArgb(19, 116, 125);
            lblCedula.Location = new Point(65, 248);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(56, 20);
            lblCedula.TabIndex = 2;
            lblCedula.Text = "Cedula";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCorreo.ForeColor = Color.FromArgb(19, 116, 125);
            lblCorreo.Location = new Point(65, 297);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(56, 20);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTelefono.ForeColor = Color.FromArgb(19, 116, 125);
            lblTelefono.Location = new Point(65, 339);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Telefono";
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaIngreso.ForeColor = Color.FromArgb(19, 116, 125);
            lblFechaIngreso.Location = new Point(34, 487);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(106, 20);
            lblFechaIngreso.TabIndex = 5;
            lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // lblIddepartamento
            // 
            lblIddepartamento.AutoSize = true;
            lblIddepartamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIddepartamento.ForeColor = Color.FromArgb(19, 116, 125);
            lblIddepartamento.Location = new Point(418, 200);
            lblIddepartamento.Name = "lblIddepartamento";
            lblIddepartamento.Size = new Size(111, 20);
            lblIddepartamento.TabIndex = 6;
            lblIddepartamento.Text = "Departamento";
            // 
            // lblIddireccion
            // 
            lblIddireccion.AutoSize = true;
            lblIddireccion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIddireccion.ForeColor = Color.FromArgb(19, 116, 125);
            lblIddireccion.Location = new Point(452, 248);
            lblIddireccion.Name = "lblIddireccion";
            lblIddireccion.Size = new Size(74, 20);
            lblIddireccion.TabIndex = 7;
            lblIddireccion.Text = "Direccion";
            // 
            // lbIdgenero
            // 
            lbIdgenero.AutoSize = true;
            lbIdgenero.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbIdgenero.ForeColor = Color.FromArgb(19, 116, 125);
            lbIdgenero.Location = new Point(457, 301);
            lbIdgenero.Name = "lbIdgenero";
            lbIdgenero.Size = new Size(60, 20);
            lbIdgenero.TabIndex = 8;
            lbIdgenero.Text = "Genero";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(160, 155);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(233, 27);
            txtNombre.TabIndex = 11;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(160, 197);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(233, 27);
            txtApellido.TabIndex = 12;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(160, 248);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(233, 27);
            txtCedula.TabIndex = 13;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(160, 293);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(233, 27);
            txtCorreo.TabIndex = 14;
            // 
            // cbDepartamento
            // 
            cbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartamento.FormattingEnabled = true;
            cbDepartamento.Location = new Point(530, 197);
            cbDepartamento.Name = "cbDepartamento";
            cbDepartamento.Size = new Size(190, 28);
            cbDepartamento.TabIndex = 17;
            // 
            // cbDireccion
            // 
            cbDireccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDireccion.FormattingEnabled = true;
            cbDireccion.Location = new Point(530, 245);
            cbDireccion.Name = "cbDireccion";
            cbDireccion.Size = new Size(504, 28);
            cbDireccion.TabIndex = 18;
            // 
            // cbGenero
            // 
            cbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGenero.FormattingEnabled = true;
            cbGenero.Location = new Point(530, 293);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(190, 28);
            cbGenero.TabIndex = 19;
            // 
            // btnRegistrarusuario
            // 
            btnRegistrarusuario.BackColor = Color.FromArgb(19, 116, 125);
            btnRegistrarusuario.FlatStyle = FlatStyle.Flat;
            btnRegistrarusuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegistrarusuario.ForeColor = Color.FromArgb(252, 247, 197);
            btnRegistrarusuario.Location = new Point(732, 414);
            btnRegistrarusuario.Name = "btnRegistrarusuario";
            btnRegistrarusuario.Size = new Size(94, 29);
            btnRegistrarusuario.TabIndex = 20;
            btnRegistrarusuario.Text = "Registrar";
            btnRegistrarusuario.UseVisualStyleBackColor = false;
            btnRegistrarusuario.Click += btnRegistrarusuario_Click;
            // 
            // btnCerrarvisualregistraremplead
            // 
            btnCerrarvisualregistraremplead.BackColor = Color.FromArgb(19, 116, 125);
            btnCerrarvisualregistraremplead.FlatStyle = FlatStyle.Flat;
            btnCerrarvisualregistraremplead.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCerrarvisualregistraremplead.ForeColor = Color.FromArgb(252, 247, 197);
            btnCerrarvisualregistraremplead.Location = new Point(732, 478);
            btnCerrarvisualregistraremplead.Name = "btnCerrarvisualregistraremplead";
            btnCerrarvisualregistraremplead.Size = new Size(94, 29);
            btnCerrarvisualregistraremplead.TabIndex = 21;
            btnCerrarvisualregistraremplead.Text = "Cerrar";
            btnCerrarvisualregistraremplead.UseVisualStyleBackColor = false;
            btnCerrarvisualregistraremplead.Click += btnCerrarvisualregistraremplead_Click;
            // 
            // cbCargo
            // 
            cbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCargo.FormattingEnabled = true;
            cbCargo.Items.AddRange(new object[] { "Gerente de Distribución", "Gerente de Logística", "Supervisor de Distribución", "Supervisor de Almacén", "Auxiliar de Distribución", "Chofer de Distribución", "Técnico de Productividad", "Técnico en Logística", "Coordinador de Seguridad Industrial", "Técnico en Control de Calidad", "Técnico de gente y gestión ", "Gerente de Ventas", "Asesor de ventas" });
            cbCargo.Location = new Point(530, 155);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(190, 28);
            cbCargo.TabIndex = 23;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCargo.ForeColor = Color.FromArgb(19, 116, 125);
            lblCargo.Location = new Point(457, 155);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(50, 20);
            lblCargo.TabIndex = 22;
            lblCargo.Text = "Cargo";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaNacimiento.ForeColor = Color.FromArgb(19, 116, 125);
            lblFechaNacimiento.Location = new Point(11, 441);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(134, 20);
            lblFechaNacimiento.TabIndex = 24;
            lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(160, 339);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(233, 27);
            txtTelefono.TabIndex = 15;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // dtpFechanacimiento
            // 
            dtpFechanacimiento.Format = DateTimePickerFormat.Short;
            dtpFechanacimiento.Location = new Point(160, 434);
            dtpFechanacimiento.Name = "dtpFechanacimiento";
            dtpFechanacimiento.Size = new Size(112, 27);
            dtpFechanacimiento.TabIndex = 25;
            // 
            // dtpFechaingreso
            // 
            dtpFechaingreso.Format = DateTimePickerFormat.Short;
            dtpFechaingreso.Location = new Point(160, 482);
            dtpFechaingreso.Name = "dtpFechaingreso";
            dtpFechaingreso.Size = new Size(112, 27);
            dtpFechaingreso.TabIndex = 26;
            // 
            // txtSalariobase
            // 
            txtSalariobase.Location = new Point(160, 387);
            txtSalariobase.Name = "txtSalariobase";
            txtSalariobase.Size = new Size(233, 27);
            txtSalariobase.TabIndex = 28;
            txtSalariobase.KeyPress += txtSalariobase_KeyPress;
            // 
            // lblSalariobase
            // 
            lblSalariobase.AutoSize = true;
            lblSalariobase.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSalariobase.ForeColor = Color.FromArgb(19, 116, 125);
            lblSalariobase.Location = new Point(41, 387);
            lblSalariobase.Name = "lblSalariobase";
            lblSalariobase.Size = new Size(93, 20);
            lblSalariobase.TabIndex = 27;
            lblSalariobase.Text = "Salario Base";
            // 
            // FrmVisualregistrarempleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 247, 197);
            ClientSize = new Size(1108, 601);
            Controls.Add(txtSalariobase);
            Controls.Add(lblSalariobase);
            Controls.Add(dtpFechaingreso);
            Controls.Add(dtpFechanacimiento);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(cbCargo);
            Controls.Add(lblCargo);
            Controls.Add(btnCerrarvisualregistraremplead);
            Controls.Add(btnRegistrarusuario);
            Controls.Add(cbGenero);
            Controls.Add(cbDireccion);
            Controls.Add(cbDepartamento);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtCedula);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lbIdgenero);
            Controls.Add(lblIddireccion);
            Controls.Add(lblIddepartamento);
            Controls.Add(lblFechaIngreso);
            Controls.Add(lblTelefono);
            Controls.Add(lblCorreo);
            Controls.Add(lblCedula);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVisualregistrarempleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVisualregistrarempleado";
            Load += FrmVisualregistrarempleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblCedula;
        private Label lblCorreo;
        private Label lblTelefono;
        private Label lblFechaIngreso;
        private Label lblIddepartamento;
        private Label lblIddireccion;
        private Label lbIdgenero;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCedula;
        private TextBox txtCorreo;
        private ComboBox cbDepartamento;
        private ComboBox cbDireccion;
        private ComboBox cbGenero;
        private Button btnRegistrarusuario;
        private Button btnCerrarvisualregistraremplead;
        private ComboBox cbCargo;
        private Label lblCargo;
        private Label lblFechaNacimiento;
        private TextBox txtTelefono;
        private DateTimePicker dtpFechanacimiento;
        private DateTimePicker dtpFechaingreso;
        private TextBox txtSalariobase;
        private Label lblSalariobase;
    }
}