namespace Capa_Presentacion_Proyecto_Final
{
    partial class FrmVisualcontroldeempleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisualcontroldeempleados));
            btnVisualregistrarempleado = new Button();
            btnVisualeditarempleado = new Button();
            btnVolveralmenuprincipal = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnVisualregistrarempleado
            // 
            btnVisualregistrarempleado.BackColor = Color.FromArgb(19, 116, 125);
            btnVisualregistrarempleado.FlatStyle = FlatStyle.Flat;
            btnVisualregistrarempleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVisualregistrarempleado.ForeColor = Color.FromArgb(252, 247, 197);
            btnVisualregistrarempleado.Location = new Point(169, 325);
            btnVisualregistrarempleado.Name = "btnVisualregistrarempleado";
            btnVisualregistrarempleado.Size = new Size(94, 29);
            btnVisualregistrarempleado.TabIndex = 0;
            btnVisualregistrarempleado.Text = "Registrar";
            btnVisualregistrarempleado.UseVisualStyleBackColor = false;
            btnVisualregistrarempleado.Click += btnVisualregistrarempleado_Click;
            // 
            // btnVisualeditarempleado
            // 
            btnVisualeditarempleado.BackColor = Color.FromArgb(19, 116, 125);
            btnVisualeditarempleado.FlatStyle = FlatStyle.Flat;
            btnVisualeditarempleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVisualeditarempleado.ForeColor = Color.FromArgb(252, 247, 197);
            btnVisualeditarempleado.Location = new Point(496, 325);
            btnVisualeditarempleado.Name = "btnVisualeditarempleado";
            btnVisualeditarempleado.Size = new Size(94, 29);
            btnVisualeditarempleado.TabIndex = 1;
            btnVisualeditarempleado.Text = "Editar";
            btnVisualeditarempleado.UseVisualStyleBackColor = false;
            btnVisualeditarempleado.Click += btnVisualeditarempleado_Click;
            // 
            // btnVolveralmenuprincipal
            // 
            btnVolveralmenuprincipal.BackColor = Color.FromArgb(19, 116, 125);
            btnVolveralmenuprincipal.FlatStyle = FlatStyle.Flat;
            btnVolveralmenuprincipal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolveralmenuprincipal.ForeColor = Color.FromArgb(252, 247, 197);
            btnVolveralmenuprincipal.Location = new Point(12, 12);
            btnVolveralmenuprincipal.Name = "btnVolveralmenuprincipal";
            btnVolveralmenuprincipal.Size = new Size(94, 29);
            btnVolveralmenuprincipal.TabIndex = 3;
            btnVolveralmenuprincipal.Text = "Volver";
            btnVolveralmenuprincipal.UseVisualStyleBackColor = false;
            btnVolveralmenuprincipal.Click += btnVolveralmenuprincipal_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(121, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(443, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(212, 197);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // FrmVisualcontroldeempleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 247, 197);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnVolveralmenuprincipal);
            Controls.Add(btnVisualeditarempleado);
            Controls.Add(btnVisualregistrarempleado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVisualcontroldeempleados";
            Text = "FrmVisualcontroldeempleados";
            Load += FrmVisualcontroldeempleados_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVisualregistrarempleado;
        private Button btnVisualeditarempleado;
        private Button btnVolveralmenuprincipal;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}