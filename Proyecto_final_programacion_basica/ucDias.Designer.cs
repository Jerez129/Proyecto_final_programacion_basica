namespace Capa_Presentacion
{
    partial class ucDias
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDias = new Label();
            SuspendLayout();
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.BackColor = Color.FromArgb(19, 116, 125);
            lblDias.Location = new Point(20, 10);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(27, 20);
            lblDias.TabIndex = 0;
            lblDias.Text = "00";
            lblDias.Click += lblDias_Click;
            // 
            // ucDias
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 116, 125);
            Controls.Add(lblDias);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(252, 247, 197);
            Name = "ucDias";
            Size = new Size(65, 49);
            Load += ucDias_Load;
            Click += ucDias_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDias;
    }
}
