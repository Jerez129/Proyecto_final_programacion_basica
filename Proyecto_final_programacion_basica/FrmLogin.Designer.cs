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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            btnIniciarsesión = new Button();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnIniciarsesión
            // 
            btnIniciarsesión.Location = new Point(327, 331);
            btnIniciarsesión.Name = "btnIniciarsesión";
            btnIniciarsesión.Size = new Size(112, 29);
            btnIniciarsesión.TabIndex = 0;
            btnIniciarsesión.Text = "Iniciar Sesión";
            btnIniciarsesión.UseVisualStyleBackColor = true;
            btnIniciarsesión.Click += btnIniciarsesión_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(312, 241);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(144, 27);
            txtUsuario.TabIndex = 3;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(312, 292);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(144, 27);
            txtClave.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(312, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(462, 292);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(btnIniciarsesión);
            Name = "FrmLogin";
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarsesión;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}