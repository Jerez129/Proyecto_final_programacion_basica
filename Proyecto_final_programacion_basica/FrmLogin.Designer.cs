namespace Capa_Presentacion_Proyecto_Final
{
    partial class FrmLogin
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
            btnIniciarsesión = new Button();
            lblUsuario = new Label();
            lblClave = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            SuspendLayout();
            // 
            // btnIniciarsesión
            // 
            btnIniciarsesión.Location = new Point(327, 286);
            btnIniciarsesión.Name = "btnIniciarsesión";
            btnIniciarsesión.Size = new Size(112, 29);
            btnIniciarsesión.TabIndex = 0;
            btnIniciarsesión.Text = "Iniciar Sesión";
            btnIniciarsesión.UseVisualStyleBackColor = true;
            btnIniciarsesión.Click += btnIniciarsesión_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(214, 142);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(228, 196);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(48, 20);
            lblClave.TabIndex = 2;
            lblClave.Text = "Clave:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(314, 142);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(144, 27);
            txtUsuario.TabIndex = 3;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(314, 193);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(144, 27);
            txtClave.TabIndex = 4;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(lblClave);
            Controls.Add(lblUsuario);
            Controls.Add(btnIniciarsesión);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarsesión;
        private Label lblUsuario;
        private Label lblClave;
        private TextBox txtUsuario;
        private TextBox txtClave;
    }
}