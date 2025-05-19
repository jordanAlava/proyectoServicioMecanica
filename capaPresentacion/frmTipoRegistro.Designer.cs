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
            this.pctrAdministradorMarco = new RJCodeAdvance.RJControls.RJTextBox();
            this.pctrClienteMarco = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnAtras = new FontAwesome.Sharp.IconButton();
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
            this.pctrImagenFondo.Location = new System.Drawing.Point(-555, 3);
            this.pctrImagenFondo.Name = "pctrImagenFondo";
            this.pctrImagenFondo.Size = new System.Drawing.Size(1563, 681);
            this.pctrImagenFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrImagenFondo.TabIndex = 0;
            this.pctrImagenFondo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(606, 176);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(159, 24);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Tipo de Usuario";
            // 
            // pctrCliente
            // 
            this.pctrCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctrCliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pctrCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrCliente.ForeColor = System.Drawing.Color.DimGray;
            this.pctrCliente.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.pctrCliente.IconColor = System.Drawing.Color.DimGray;
            this.pctrCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pctrCliente.IconSize = 140;
            this.pctrCliente.Location = new System.Drawing.Point(657, 253);
            this.pctrCliente.Name = "pctrCliente";
            this.pctrCliente.Size = new System.Drawing.Size(140, 140);
            this.pctrCliente.TabIndex = 2;
            this.pctrCliente.TabStop = false;
            this.pctrCliente.Click += new System.EventHandler(this.pctrCliente_Click);
            this.pctrCliente.DoubleClick += new System.EventHandler(this.pctrCliente_DoubleClick);
            this.pctrCliente.MouseEnter += new System.EventHandler(this.pctrCliente_MouseEnter);
            this.pctrCliente.MouseLeave += new System.EventHandler(this.pctrCliente_MouseLeave);
            // 
            // pctrAdministrador
            // 
            this.pctrAdministrador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctrAdministrador.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pctrAdministrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrAdministrador.ForeColor = System.Drawing.Color.DimGray;
            this.pctrAdministrador.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.pctrAdministrador.IconColor = System.Drawing.Color.DimGray;
            this.pctrAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pctrAdministrador.IconSize = 140;
            this.pctrAdministrador.Location = new System.Drawing.Point(836, 253);
            this.pctrAdministrador.Name = "pctrAdministrador";
            this.pctrAdministrador.Size = new System.Drawing.Size(140, 140);
            this.pctrAdministrador.TabIndex = 3;
            this.pctrAdministrador.TabStop = false;
            this.pctrAdministrador.Click += new System.EventHandler(this.pctrAdministrador_Click);
            this.pctrAdministrador.DoubleClick += new System.EventHandler(this.pctrAdministrador_DoubleClick);
            this.pctrAdministrador.MouseEnter += new System.EventHandler(this.pctrAdministrador_MouseEnter);
            this.pctrAdministrador.MouseLeave += new System.EventHandler(this.pctrAdministrador_MouseLeave);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSiguiente.BackColor = System.Drawing.Color.Firebrick;
            this.btnSiguiente.BackgroundColor = System.Drawing.Color.Firebrick;
            this.btnSiguiente.BorderColor = System.Drawing.Color.Firebrick;
            this.btnSiguiente.BorderRadius = 10;
            this.btnSiguiente.BorderSize = 0;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(829, 490);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(158, 38);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "&Siguiente";
            this.btnSiguiente.TextColor = System.Drawing.Color.White;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.LightGray;
            this.lblCliente.Location = new System.Drawing.Point(699, 376);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(51, 17);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "Cliente";
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrador.ForeColor = System.Drawing.Color.LightGray;
            this.lblAdministrador.Location = new System.Drawing.Point(856, 376);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(95, 17);
            this.lblAdministrador.TabIndex = 11;
            this.lblAdministrador.Text = "Administrador";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlContenedor.Controls.Add(this.pctrImagenFondo);
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(512, 681);
            this.pnlContenedor.TabIndex = 12;
            this.pnlContenedor.Resize += new System.EventHandler(this.pnlContenedor_Resize);
            // 
            // pctrAdministradorMarco
            // 
            this.pctrAdministradorMarco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctrAdministradorMarco.BackColor = System.Drawing.Color.Black;
            this.pctrAdministradorMarco.BorderColor = System.Drawing.Color.Firebrick;
            this.pctrAdministradorMarco.BorderFocusColor = System.Drawing.Color.HotPink;
            this.pctrAdministradorMarco.BorderRadius = 10;
            this.pctrAdministradorMarco.BorderSize = 2;
            this.pctrAdministradorMarco.Enabled = false;
            this.pctrAdministradorMarco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pctrAdministradorMarco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pctrAdministradorMarco.Location = new System.Drawing.Point(829, 245);
            this.pctrAdministradorMarco.Margin = new System.Windows.Forms.Padding(4);
            this.pctrAdministradorMarco.Multiline = true;
            this.pctrAdministradorMarco.Name = "pctrAdministradorMarco";
            this.pctrAdministradorMarco.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.pctrAdministradorMarco.PasswordChar = false;
            this.pctrAdministradorMarco.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.pctrAdministradorMarco.PlaceholderText = "";
            this.pctrAdministradorMarco.Size = new System.Drawing.Size(158, 189);
            this.pctrAdministradorMarco.TabIndex = 13;
            this.pctrAdministradorMarco.Texts = "";
            this.pctrAdministradorMarco.UnderlinedStyle = false;
            this.pctrAdministradorMarco.Visible = false;
            // 
            // pctrClienteMarco
            // 
            this.pctrClienteMarco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctrClienteMarco.BackColor = System.Drawing.Color.Black;
            this.pctrClienteMarco.BorderColor = System.Drawing.Color.Firebrick;
            this.pctrClienteMarco.BorderFocusColor = System.Drawing.Color.HotPink;
            this.pctrClienteMarco.BorderRadius = 10;
            this.pctrClienteMarco.BorderSize = 2;
            this.pctrClienteMarco.Enabled = false;
            this.pctrClienteMarco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pctrClienteMarco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pctrClienteMarco.Location = new System.Drawing.Point(650, 245);
            this.pctrClienteMarco.Margin = new System.Windows.Forms.Padding(4);
            this.pctrClienteMarco.Multiline = true;
            this.pctrClienteMarco.Name = "pctrClienteMarco";
            this.pctrClienteMarco.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.pctrClienteMarco.PasswordChar = false;
            this.pctrClienteMarco.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.pctrClienteMarco.PlaceholderText = "";
            this.pctrClienteMarco.Size = new System.Drawing.Size(158, 189);
            this.pctrClienteMarco.TabIndex = 14;
            this.pctrClienteMarco.Texts = "";
            this.pctrClienteMarco.UnderlinedStyle = false;
            this.pctrClienteMarco.Visible = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtras.BackColor = System.Drawing.Color.Black;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.White;
            this.btnAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnAtras.IconColor = System.Drawing.Color.White;
            this.btnAtras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAtras.IconSize = 24;
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(691, 491);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(72, 38);
            this.btnAtras.TabIndex = 17;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            this.btnAtras.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAtras_MouseDown);
            this.btnAtras.MouseEnter += new System.EventHandler(this.btnAtras_MouseEnter);
            this.btnAtras.MouseLeave += new System.EventHandler(this.btnAtras_MouseLeave);
            // 
            // frmTipoRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.lblAdministrador);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.pctrAdministrador);
            this.Controls.Add(this.pctrCliente);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pctrAdministradorMarco);
            this.Controls.Add(this.pctrClienteMarco);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "frmTipoRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTipoRegistro";
            this.Resize += new System.EventHandler(this.frmTipoRegistro_Resize);
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
        private RJCodeAdvance.RJControls.RJTextBox pctrAdministradorMarco;
        private RJCodeAdvance.RJControls.RJTextBox pctrClienteMarco;
        private FontAwesome.Sharp.IconButton btnAtras;
    }
}