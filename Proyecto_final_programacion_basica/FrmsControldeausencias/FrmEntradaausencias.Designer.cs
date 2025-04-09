namespace Capa_Presentacion.FrmsControldeausencias
{
    partial class FrmEntradaausencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntradaausencias));
            btnRegistrarEntrada = new Button();
            btnEditarEntrada = new Button();
            btnVolveralmenuprincipal = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrarEntrada
            // 
            btnRegistrarEntrada.BackColor = Color.FromArgb(19, 116, 125);
            btnRegistrarEntrada.FlatStyle = FlatStyle.Flat;
            btnRegistrarEntrada.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegistrarEntrada.ForeColor = Color.FromArgb(252, 247, 197);
            btnRegistrarEntrada.Location = new Point(168, 324);
            btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            btnRegistrarEntrada.Size = new Size(94, 29);
            btnRegistrarEntrada.TabIndex = 0;
            btnRegistrarEntrada.Text = "Registrar";
            btnRegistrarEntrada.UseVisualStyleBackColor = false;
            btnRegistrarEntrada.Click += btnRegistrarEntrada_Click;
            // 
            // btnEditarEntrada
            // 
            btnEditarEntrada.BackColor = Color.FromArgb(19, 116, 125);
            btnEditarEntrada.FlatStyle = FlatStyle.Flat;
            btnEditarEntrada.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditarEntrada.ForeColor = Color.FromArgb(252, 247, 197);
            btnEditarEntrada.Location = new Point(488, 324);
            btnEditarEntrada.Name = "btnEditarEntrada";
            btnEditarEntrada.Size = new Size(94, 29);
            btnEditarEntrada.TabIndex = 1;
            btnEditarEntrada.Text = "Editar";
            btnEditarEntrada.UseVisualStyleBackColor = false;
            btnEditarEntrada.Click += btnEditarEntrada_Click;
            // 
            // btnVolveralmenuprincipal
            // 
            btnVolveralmenuprincipal.BackColor = Color.FromArgb(19, 116, 125);
            btnVolveralmenuprincipal.FlatStyle = FlatStyle.Flat;
            btnVolveralmenuprincipal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolveralmenuprincipal.ForeColor = Color.FromArgb(252, 247, 197);
            btnVolveralmenuprincipal.Location = new Point(41, 12);
            btnVolveralmenuprincipal.Name = "btnVolveralmenuprincipal";
            btnVolveralmenuprincipal.Size = new Size(94, 29);
            btnVolveralmenuprincipal.TabIndex = 4;
            btnVolveralmenuprincipal.Text = "Volver";
            btnVolveralmenuprincipal.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(438, 79);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(212, 197);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(116, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FrmEntradaausencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 247, 197);
            ClientSize = new Size(768, 447);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnVolveralmenuprincipal);
            Controls.Add(btnEditarEntrada);
            Controls.Add(btnRegistrarEntrada);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEntradaausencias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEntradaausencias";
            Load += FrmEntradaausencias_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrarEntrada;
        private Button btnEditarEntrada;
        private Button btnVolveralmenuprincipal;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}