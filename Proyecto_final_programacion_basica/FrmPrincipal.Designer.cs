namespace Capa_Presentacion_Proyecto_Final
{
    partial class FrmPrincipal
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
            pnlMenuPrincipal = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlbtnEmpleados = new Panel();
            btnEmpleados = new Button();
            pnlMenuempleados = new Panel();
            btnControldeausencias = new Button();
            btnControldenomina = new Button();
            btnControldeempleados = new Button();
            panel1 = new Panel();
            btnConsulta = new Button();
            pnlConsulta = new Panel();
            btnReportedeausencias = new Button();
            btnListadeempledos = new Button();
            panel3 = new Panel();
            btnSistema = new Button();
            pnlSistema = new Panel();
            btnCerrarsesion = new Button();
            btnAcercade = new Button();
            panel2 = new Panel();
            btnMenuprincipal = new Button();
            pnlMenuPrincipal.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlbtnEmpleados.SuspendLayout();
            pnlMenuempleados.SuspendLayout();
            panel1.SuspendLayout();
            pnlConsulta.SuspendLayout();
            panel3.SuspendLayout();
            pnlSistema.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenuPrincipal
            // 
            pnlMenuPrincipal.Controls.Add(flowLayoutPanel1);
            pnlMenuPrincipal.Dock = DockStyle.Left;
            pnlMenuPrincipal.Location = new Point(0, 0);
            pnlMenuPrincipal.Name = "pnlMenuPrincipal";
            pnlMenuPrincipal.Size = new Size(250, 545);
            pnlMenuPrincipal.TabIndex = 0;
            pnlMenuPrincipal.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(pnlbtnEmpleados);
            flowLayoutPanel1.Controls.Add(pnlMenuempleados);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(pnlConsulta);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(pnlSistema);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(9, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(238, 530);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // pnlbtnEmpleados
            // 
            pnlbtnEmpleados.Controls.Add(btnEmpleados);
            pnlbtnEmpleados.Location = new Point(6, 3);
            pnlbtnEmpleados.Name = "pnlbtnEmpleados";
            pnlbtnEmpleados.Size = new Size(229, 38);
            pnlbtnEmpleados.TabIndex = 1;
            // 
            // btnEmpleados
            // 
            btnEmpleados.Dock = DockStyle.Top;
            btnEmpleados.Location = new Point(0, 0);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(229, 29);
            btnEmpleados.TabIndex = 0;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // pnlMenuempleados
            // 
            pnlMenuempleados.Controls.Add(btnControldeausencias);
            pnlMenuempleados.Controls.Add(btnControldenomina);
            pnlMenuempleados.Controls.Add(btnControldeempleados);
            pnlMenuempleados.Location = new Point(6, 47);
            pnlMenuempleados.Name = "pnlMenuempleados";
            pnlMenuempleados.Size = new Size(229, 124);
            pnlMenuempleados.TabIndex = 1;
            pnlMenuempleados.Visible = false;
            // 
            // btnControldeausencias
            // 
            btnControldeausencias.Location = new Point(58, 82);
            btnControldeausencias.Name = "btnControldeausencias";
            btnControldeausencias.Size = new Size(168, 29);
            btnControldeausencias.TabIndex = 4;
            btnControldeausencias.Text = "Control de ausencias";
            btnControldeausencias.UseVisualStyleBackColor = true;
            // 
            // btnControldenomina
            // 
            btnControldenomina.Location = new Point(58, 47);
            btnControldenomina.Name = "btnControldenomina";
            btnControldenomina.Size = new Size(168, 29);
            btnControldenomina.TabIndex = 3;
            btnControldenomina.Text = "Control de nomina";
            btnControldenomina.UseVisualStyleBackColor = true;
            // 
            // btnControldeempleados
            // 
            btnControldeempleados.Location = new Point(58, 12);
            btnControldeempleados.Name = "btnControldeempleados";
            btnControldeempleados.Size = new Size(168, 29);
            btnControldeempleados.TabIndex = 2;
            btnControldeempleados.Text = "Control de empleados";
            btnControldeempleados.UseVisualStyleBackColor = true;
            btnControldeempleados.Click += btnControldeempleados_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnConsulta);
            panel1.Location = new Point(6, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 38);
            panel1.TabIndex = 2;
            // 
            // btnConsulta
            // 
            btnConsulta.Dock = DockStyle.Top;
            btnConsulta.Location = new Point(0, 0);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(229, 29);
            btnConsulta.TabIndex = 0;
            btnConsulta.Text = "Consulta";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // pnlConsulta
            // 
            pnlConsulta.Controls.Add(btnReportedeausencias);
            pnlConsulta.Controls.Add(btnListadeempledos);
            pnlConsulta.Location = new Point(6, 221);
            pnlConsulta.Name = "pnlConsulta";
            pnlConsulta.Size = new Size(229, 93);
            pnlConsulta.TabIndex = 3;
            pnlConsulta.Visible = false;
            // 
            // btnReportedeausencias
            // 
            btnReportedeausencias.Location = new Point(58, 47);
            btnReportedeausencias.Name = "btnReportedeausencias";
            btnReportedeausencias.Size = new Size(168, 29);
            btnReportedeausencias.TabIndex = 3;
            btnReportedeausencias.Text = "Reporte de ausencias";
            btnReportedeausencias.UseVisualStyleBackColor = true;
            // 
            // btnListadeempledos
            // 
            btnListadeempledos.Location = new Point(58, 12);
            btnListadeempledos.Name = "btnListadeempledos";
            btnListadeempledos.Size = new Size(168, 29);
            btnListadeempledos.TabIndex = 2;
            btnListadeempledos.Text = "Lista de empleados";
            btnListadeempledos.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSistema);
            panel3.Location = new Point(6, 320);
            panel3.Name = "panel3";
            panel3.Size = new Size(229, 38);
            panel3.TabIndex = 4;
            // 
            // btnSistema
            // 
            btnSistema.Dock = DockStyle.Top;
            btnSistema.Location = new Point(0, 0);
            btnSistema.Name = "btnSistema";
            btnSistema.Size = new Size(229, 29);
            btnSistema.TabIndex = 0;
            btnSistema.Text = "Sistema";
            btnSistema.UseVisualStyleBackColor = true;
            btnSistema.Click += btnSistema_Click;
            // 
            // pnlSistema
            // 
            pnlSistema.Controls.Add(btnCerrarsesion);
            pnlSistema.Controls.Add(btnAcercade);
            pnlSistema.Location = new Point(6, 364);
            pnlSistema.Name = "pnlSistema";
            pnlSistema.Size = new Size(229, 93);
            pnlSistema.TabIndex = 5;
            pnlSistema.Visible = false;
            // 
            // btnCerrarsesion
            // 
            btnCerrarsesion.Location = new Point(58, 47);
            btnCerrarsesion.Name = "btnCerrarsesion";
            btnCerrarsesion.Size = new Size(168, 29);
            btnCerrarsesion.TabIndex = 3;
            btnCerrarsesion.Text = "Cerrar sesion";
            btnCerrarsesion.UseVisualStyleBackColor = true;
            // 
            // btnAcercade
            // 
            btnAcercade.Location = new Point(58, 12);
            btnAcercade.Name = "btnAcercade";
            btnAcercade.Size = new Size(168, 29);
            btnAcercade.TabIndex = 2;
            btnAcercade.Text = "Acerca de";
            btnAcercade.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnMenuprincipal);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(645, 545);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnMenuprincipal
            // 
            btnMenuprincipal.Location = new Point(0, 24);
            btnMenuprincipal.Name = "btnMenuprincipal";
            btnMenuprincipal.Size = new Size(94, 29);
            btnMenuprincipal.TabIndex = 0;
            btnMenuprincipal.Text = "Home";
            btnMenuprincipal.UseVisualStyleBackColor = true;
            btnMenuprincipal.Click += btnMenuprincipal_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 545);
            Controls.Add(panel2);
            Controls.Add(pnlMenuPrincipal);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            pnlMenuPrincipal.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            pnlbtnEmpleados.ResumeLayout(false);
            pnlMenuempleados.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlConsulta.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pnlSistema.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenuPrincipal;
        private Panel panel2;
        private Panel pnlbtnEmpleados;
        private Button btnEmpleados;
        private Button btnMenuprincipal;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlMenuempleados;
        private Button btnControldeausencias;
        private Button btnControldenomina;
        private Button btnControldeempleados;
        private Panel panel1;
        private Button btnConsulta;
        private Panel pnlConsulta;
        private Button button6;
        private Button btnReportedeausencias;
        private Button btnListadeempledos;
        private Button button9;
        private Button button10;
        private Button button11;
        private Panel panel3;
        private Button btnSistema;
        private Panel pnlSistema;
        private Button btnCerrarsesion;
        private Button btnAcercade;
    }
}