namespace capaPresentacion
{
    partial class frmTipoRegistro
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
            this.pctrImagenFondo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pctrCliente = new FontAwesome.Sharp.IconPictureBox();
            this.pctrAdministrador = new FontAwesome.Sharp.IconPictureBox();
            this.btnSiguiente = new RJCodeAdvance.RJControls.RJButton();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pctrImagenFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAdministrador)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctrImagenFondo
            // 
            this.pctrImagenFondo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctrImagenFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctrImagenFondo.Location = new System.Drawing.Point(-639, -136);
            this.pctrImagenFondo.Margin = new System.Windows.Forms.Padding(4);
            this.pctrImagenFondo.Name = "pctrImagenFondo";
            this.pctrImagenFondo.Size = new System.Drawing.Size(1562, 1024);
            this.pctrImagenFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrImagenFondo.TabIndex = 0;
            this.pctrImagenFondo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(470, 162);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(166, 26);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Tipo de Uusario";
            // 
            // pctrCliente
            // 
            this.pctrCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctrCliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pctrCliente.ForeColor = System.Drawing.Color.DimGray;
            this.pctrCliente.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.pctrCliente.IconColor = System.Drawing.Color.DimGray;
            this.pctrCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pctrCliente.IconSize = 140;
            this.pctrCliente.Location = new System.Drawing.Point(531, 257);
            this.pctrCliente.Margin = new System.Windows.Forms.Padding(4);
            this.pctrCliente.Name = "pctrCliente";
            this.pctrCliente.Size = new System.Drawing.Size(140, 140);
            this.pctrCliente.TabIndex = 2;
            this.pctrCliente.TabStop = false;
            // 
            // pctrAdministrador
            // 
            this.pctrAdministrador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctrAdministrador.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pctrAdministrador.ForeColor = System.Drawing.Color.DimGray;
            this.pctrAdministrador.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.pctrAdministrador.IconColor = System.Drawing.Color.DimGray;
            this.pctrAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pctrAdministrador.IconSize = 140;
            this.pctrAdministrador.Location = new System.Drawing.Point(703, 257);
            this.pctrAdministrador.Margin = new System.Windows.Forms.Padding(4);
            this.pctrAdministrador.Name = "pctrAdministrador";
            this.pctrAdministrador.Size = new System.Drawing.Size(140, 140);
            this.pctrAdministrador.TabIndex = 3;
            this.pctrAdministrador.TabStop = false;
            this.pctrAdministrador.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSiguiente.BackColor = System.Drawing.Color.Firebrick;
            this.btnSiguiente.BackgroundColor = System.Drawing.Color.Firebrick;
            this.btnSiguiente.BorderColor = System.Drawing.Color.Firebrick;
            this.btnSiguiente.BorderRadius = 10;
            this.btnSiguiente.BorderSize = 0;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(727, 504);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(141, 38);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "&Siguiente";
            this.btnSiguiente.TextColor = System.Drawing.Color.White;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.LightGray;
            this.lblCliente.Location = new System.Drawing.Point(565, 416);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 20);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "Cliente";
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrador.ForeColor = System.Drawing.Color.LightGray;
            this.lblAdministrador.Location = new System.Drawing.Point(723, 416);
            this.lblAdministrador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(111, 20);
            this.lblAdministrador.TabIndex = 11;
            this.lblAdministrador.Text = "Administrador";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.pctrImagenFondo);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(397, 729);
            this.pnlContenedor.TabIndex = 12;
            // 
            // frmTipoRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.lblAdministrador);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.pctrAdministrador);
            this.Controls.Add(this.pctrCliente);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTipoRegistro";
            this.Text = "frmTipoRegistro";
            this.Load += new System.EventHandler(this.frmTipoRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrImagenFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAdministrador)).EndInit();
            this.pnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrImagenFondo;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconPictureBox pctrCliente;
        private FontAwesome.Sharp.IconPictureBox pctrAdministrador;
        private RJCodeAdvance.RJControls.RJButton btnSiguiente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}