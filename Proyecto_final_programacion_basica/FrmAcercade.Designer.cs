namespace Capa_Presentacion
{
    partial class FrmAcercade
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
            lblNombrededesarrollador1 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnVolveralmenuprincipal = new Button();
            SuspendLayout();
            // 
            // lblNombrededesarrollador1
            // 
            lblNombrededesarrollador1.BackColor = Color.FromArgb(19, 116, 125);
            lblNombrededesarrollador1.FlatStyle = FlatStyle.Flat;
            lblNombrededesarrollador1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombrededesarrollador1.ForeColor = Color.FromArgb(252, 247, 197);
            lblNombrededesarrollador1.Location = new Point(200, 141);
            lblNombrededesarrollador1.Name = "lblNombrededesarrollador1";
            lblNombrededesarrollador1.Size = new Size(510, 43);
            lblNombrededesarrollador1.TabIndex = 26;
            lblNombrededesarrollador1.Text = "Johansell Perez Feliz (2023-0668)";
            lblNombrededesarrollador1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(19, 116, 125);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(252, 247, 197);
            label1.Location = new Point(200, 43);
            label1.Name = "label1";
            label1.Size = new Size(510, 43);
            label1.TabIndex = 27;
            label1.Text = "Equipo desarrollador:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(19, 116, 125);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(252, 247, 197);
            label2.Location = new Point(200, 202);
            label2.Name = "label2";
            label2.Size = new Size(510, 43);
            label2.TabIndex = 28;
            label2.Text = "Eliana Stephania Montero 2023-3777";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(19, 116, 125);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(252, 247, 197);
            label3.Location = new Point(200, 265);
            label3.Name = "label3";
            label3.Size = new Size(510, 43);
            label3.TabIndex = 29;
            label3.Text = "Ricardo pimentel muñoz 2023-3776";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVolveralmenuprincipal
            // 
            btnVolveralmenuprincipal.BackColor = Color.FromArgb(19, 116, 125);
            btnVolveralmenuprincipal.FlatStyle = FlatStyle.Flat;
            btnVolveralmenuprincipal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolveralmenuprincipal.ForeColor = Color.FromArgb(252, 247, 197);
            btnVolveralmenuprincipal.Location = new Point(12, 12);
            btnVolveralmenuprincipal.Name = "btnVolveralmenuprincipal";
            btnVolveralmenuprincipal.Size = new Size(94, 29);
            btnVolveralmenuprincipal.TabIndex = 34;
            btnVolveralmenuprincipal.Text = "Volver";
            btnVolveralmenuprincipal.UseVisualStyleBackColor = false;
            btnVolveralmenuprincipal.Click += btnVolveralmenuprincipal_Click;
            // 
            // FrmAcercade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 247, 197);
            ClientSize = new Size(886, 450);
            Controls.Add(btnVolveralmenuprincipal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNombrededesarrollador1);
            Name = "FrmAcercade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAcercade";
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombrededesarrollador1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnVolveralmenuprincipal;
    }
}