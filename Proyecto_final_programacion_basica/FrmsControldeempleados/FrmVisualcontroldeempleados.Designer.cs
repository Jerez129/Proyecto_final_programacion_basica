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
            btnVisualregistrarempleado = new Button();
            btnVisualeditarempleado = new Button();
            btnVolveralmenuprincipal = new Button();
            SuspendLayout();
            // 
            // btnVisualregistrarempleado
            // 
            btnVisualregistrarempleado.Location = new Point(169, 325);
            btnVisualregistrarempleado.Name = "btnVisualregistrarempleado";
            btnVisualregistrarempleado.Size = new Size(94, 29);
            btnVisualregistrarempleado.TabIndex = 0;
            btnVisualregistrarempleado.Text = "Registrar";
            btnVisualregistrarempleado.UseVisualStyleBackColor = true;
            btnVisualregistrarempleado.Click += btnVisualregistrarempleado_Click;
            // 
            // btnVisualeditarempleado
            // 
            btnVisualeditarempleado.Location = new Point(496, 325);
            btnVisualeditarempleado.Name = "btnVisualeditarempleado";
            btnVisualeditarempleado.Size = new Size(94, 29);
            btnVisualeditarempleado.TabIndex = 1;
            btnVisualeditarempleado.Text = "Editar";
            btnVisualeditarempleado.UseVisualStyleBackColor = true;
            btnVisualeditarempleado.Click += btnVisualeditarempleado_Click;
            // 
            // btnVolveralmenuprincipal
            // 
            btnVolveralmenuprincipal.Location = new Point(12, 12);
            btnVolveralmenuprincipal.Name = "btnVolveralmenuprincipal";
            btnVolveralmenuprincipal.Size = new Size(94, 29);
            btnVolveralmenuprincipal.TabIndex = 3;
            btnVolveralmenuprincipal.Text = "Volver";
            btnVolveralmenuprincipal.UseVisualStyleBackColor = true;
            btnVolveralmenuprincipal.Click += btnVolveralmenuprincipal_Click;
            // 
            // FrmVisualcontroldeempleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolveralmenuprincipal);
            Controls.Add(btnVisualeditarempleado);
            Controls.Add(btnVisualregistrarempleado);
            Name = "FrmVisualcontroldeempleados";
            Text = "FrmVisualcontroldeempleados";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVisualregistrarempleado;
        private Button btnVisualeditarempleado;
        private Button btnVolveralmenuprincipal;
    }
}