namespace capaPresentacion
{
    partial class frmClientePantallaPrincipal
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
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnAgendarServicio = new System.Windows.Forms.Button();
            this.btnMisVehiculos = new System.Windows.Forms.Button();
            this.pnlLogotipo = new System.Windows.Forms.Panel();
            this.pctrLogotipo = new System.Windows.Forms.PictureBox();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.pnlMenuLateral.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlLogotipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.AutoScroll = true;
            this.pnlMenuLateral.BackColor = System.Drawing.Color.Black;
            this.pnlMenuLateral.Controls.Add(this.panel2);
            this.pnlMenuLateral.Controls.Add(this.panel1);
            this.pnlMenuLateral.Controls.Add(this.btnAcercaDe);
            this.pnlMenuLateral.Controls.Add(this.btnAyuda);
            this.pnlMenuLateral.Controls.Add(this.btnAgendarServicio);
            this.pnlMenuLateral.Controls.Add(this.btnMisVehiculos);
            this.pnlMenuLateral.Controls.Add(this.pnlLogotipo);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(264, 681);
            this.pnlMenuLateral.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCerrarSesion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 588);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 53);
            this.panel2.TabIndex = 8;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.Firebrick;
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSesion.IconSize = 36;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 0);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(70, 0, 30, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(264, 53);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            this.btnCerrarSesion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCerrarSesion_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 641);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 40);
            this.panel1.TabIndex = 5;
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.BackColor = System.Drawing.Color.Black;
            this.btnAcercaDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcercaDe.FlatAppearance.BorderSize = 0;
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercaDe.ForeColor = System.Drawing.Color.White;
            this.btnAcercaDe.Location = new System.Drawing.Point(0, 294);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAcercaDe.Size = new System.Drawing.Size(264, 50);
            this.btnAcercaDe.TabIndex = 4;
            this.btnAcercaDe.Text = "Acerca de";
            this.btnAcercaDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcercaDe.UseVisualStyleBackColor = false;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Black;
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Location = new System.Drawing.Point(0, 244);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAyuda.Size = new System.Drawing.Size(264, 50);
            this.btnAyuda.TabIndex = 3;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // btnAgendarServicio
            // 
            this.btnAgendarServicio.BackColor = System.Drawing.Color.Black;
            this.btnAgendarServicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgendarServicio.FlatAppearance.BorderSize = 0;
            this.btnAgendarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendarServicio.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarServicio.ForeColor = System.Drawing.Color.White;
            this.btnAgendarServicio.Location = new System.Drawing.Point(0, 194);
            this.btnAgendarServicio.Name = "btnAgendarServicio";
            this.btnAgendarServicio.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAgendarServicio.Size = new System.Drawing.Size(264, 50);
            this.btnAgendarServicio.TabIndex = 2;
            this.btnAgendarServicio.Text = "Agendar Servicio";
            this.btnAgendarServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendarServicio.UseVisualStyleBackColor = false;
            // 
            // btnMisVehiculos
            // 
            this.btnMisVehiculos.BackColor = System.Drawing.Color.Black;
            this.btnMisVehiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMisVehiculos.FlatAppearance.BorderSize = 0;
            this.btnMisVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisVehiculos.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisVehiculos.ForeColor = System.Drawing.Color.White;
            this.btnMisVehiculos.Location = new System.Drawing.Point(0, 144);
            this.btnMisVehiculos.Name = "btnMisVehiculos";
            this.btnMisVehiculos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMisVehiculos.Size = new System.Drawing.Size(264, 50);
            this.btnMisVehiculos.TabIndex = 1;
            this.btnMisVehiculos.Text = "Mis Vehículos";
            this.btnMisVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisVehiculos.UseVisualStyleBackColor = false;
            this.btnMisVehiculos.Click += new System.EventHandler(this.btnMisVehiculos_Click);
            // 
            // pnlLogotipo
            // 
            this.pnlLogotipo.BackColor = System.Drawing.Color.Black;
            this.pnlLogotipo.Controls.Add(this.pctrLogotipo);
            this.pnlLogotipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogotipo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogotipo.Name = "pnlLogotipo";
            this.pnlLogotipo.Size = new System.Drawing.Size(264, 144);
            this.pnlLogotipo.TabIndex = 0;
            // 
            // pctrLogotipo
            // 
            this.pctrLogotipo.Location = new System.Drawing.Point(-20, -33);
            this.pctrLogotipo.Name = "pctrLogotipo";
            this.pctrLogotipo.Size = new System.Drawing.Size(287, 171);
            this.pctrLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrLogotipo.TabIndex = 1;
            this.pctrLogotipo.TabStop = false;
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Location = new System.Drawing.Point(264, 0);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(1000, 681);
            this.pnlFormulario.TabIndex = 2;
            // 
            // frmClientePantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.pnlMenuLateral);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "frmClientePantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClientePantallaPrincipal";
            this.pnlMenuLateral.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlLogotipo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogotipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuLateral;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnAgendarServicio;
        private System.Windows.Forms.Button btnMisVehiculos;
        private System.Windows.Forms.Panel pnlLogotipo;
        private System.Windows.Forms.PictureBox pctrLogotipo;
        private System.Windows.Forms.Panel pnlFormulario;
    }
}