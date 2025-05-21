namespace capaPresentacion.cliente.AgendaServicio
{
    partial class frmAgendaAgregar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbxFecha = new RJCodeAdvance.RJControls.RJDatePicker();
            this.cmbxVehiculo = new RJCodeAdvance.RJControls.RJComboBox();
            this.cmbxServicio = new RJCodeAdvance.RJControls.RJComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.btnAtras = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.lblAgendarServicio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.cmbxFecha);
            this.panel1.Controls.Add(this.cmbxVehiculo);
            this.panel1.Controls.Add(this.cmbxServicio);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblVehiculo);
            this.panel1.Controls.Add(this.lblServicio);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.lblAgendarServicio);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 681);
            this.panel1.TabIndex = 1;
            // 
            // cmbxFecha
            // 
            this.cmbxFecha.BorderColor = System.Drawing.Color.Black;
            this.cmbxFecha.BorderSize = 2;
            this.cmbxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cmbxFecha.Location = new System.Drawing.Point(419, 348);
            this.cmbxFecha.MaximumSize = new System.Drawing.Size(380, 380);
            this.cmbxFecha.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.cmbxFecha.MinimumSize = new System.Drawing.Size(4, 35);
            this.cmbxFecha.Name = "cmbxFecha";
            this.cmbxFecha.Size = new System.Drawing.Size(380, 35);
            this.cmbxFecha.SkinColor = System.Drawing.Color.White;
            this.cmbxFecha.TabIndex = 134;
            this.cmbxFecha.TextColor = System.Drawing.Color.Black;
            // 
            // cmbxVehiculo
            // 
            this.cmbxVehiculo.BackColor = System.Drawing.Color.White;
            this.cmbxVehiculo.BorderColor = System.Drawing.Color.Black;
            this.cmbxVehiculo.BorderSize = 2;
            this.cmbxVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbxVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbxVehiculo.ForeColor = System.Drawing.Color.Black;
            this.cmbxVehiculo.IconColor = System.Drawing.Color.Black;
            this.cmbxVehiculo.Items.AddRange(new object[] {
            "op 1",
            "op 2",
            "op 3"});
            this.cmbxVehiculo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxVehiculo.ListTextColor = System.Drawing.Color.Black;
            this.cmbxVehiculo.Location = new System.Drawing.Point(419, 298);
            this.cmbxVehiculo.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbxVehiculo.Name = "cmbxVehiculo";
            this.cmbxVehiculo.Padding = new System.Windows.Forms.Padding(2);
            this.cmbxVehiculo.Size = new System.Drawing.Size(381, 31);
            this.cmbxVehiculo.TabIndex = 133;
            this.cmbxVehiculo.Texts = "Filtrar por (Campo)";
            // 
            // cmbxServicio
            // 
            this.cmbxServicio.BackColor = System.Drawing.Color.White;
            this.cmbxServicio.BorderColor = System.Drawing.Color.Black;
            this.cmbxServicio.BorderSize = 2;
            this.cmbxServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbxServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbxServicio.ForeColor = System.Drawing.Color.Black;
            this.cmbxServicio.IconColor = System.Drawing.Color.Black;
            this.cmbxServicio.Items.AddRange(new object[] {
            "op 1",
            "op 2",
            "op 3"});
            this.cmbxServicio.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxServicio.ListTextColor = System.Drawing.Color.Black;
            this.cmbxServicio.Location = new System.Drawing.Point(419, 249);
            this.cmbxServicio.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbxServicio.Name = "cmbxServicio";
            this.cmbxServicio.Padding = new System.Windows.Forms.Padding(2);
            this.cmbxServicio.Size = new System.Drawing.Size(381, 31);
            this.cmbxServicio.TabIndex = 132;
            this.cmbxServicio.Texts = "Filtrar por (Campo)";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(194, 348);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 20);
            this.lblFecha.TabIndex = 121;
            this.lblFecha.Text = "Fecha";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(194, 298);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(78, 20);
            this.lblVehiculo.TabIndex = 120;
            this.lblVehiculo.Text = "Vehículo";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.Location = new System.Drawing.Point(194, 249);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(72, 20);
            this.lblServicio.TabIndex = 119;
            this.lblServicio.Text = "Servicio";
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtras.BackColor = System.Drawing.SystemColors.Control;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.Firebrick;
            this.btnAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnAtras.IconColor = System.Drawing.Color.Firebrick;
            this.btnAtras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAtras.IconSize = 24;
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(584, 480);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(72, 38);
            this.btnAtras.TabIndex = 118;
            this.btnAtras.Text = "&Atrás";
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            this.btnAtras.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAtras_MouseDown);
            this.btnAtras.MouseEnter += new System.EventHandler(this.btnAtras_MouseEnter);
            this.btnAtras.MouseLeave += new System.EventHandler(this.btnAtras_MouseLeave);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 36;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(714, 473);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(211, 47);
            this.btnAgregar.TabIndex = 117;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // lblAgendarServicio
            // 
            this.lblAgendarServicio.AutoSize = true;
            this.lblAgendarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendarServicio.ForeColor = System.Drawing.Color.Black;
            this.lblAgendarServicio.Location = new System.Drawing.Point(69, 129);
            this.lblAgendarServicio.Name = "lblAgendarServicio";
            this.lblAgendarServicio.Size = new System.Drawing.Size(236, 31);
            this.lblAgendarServicio.TabIndex = 111;
            this.lblAgendarServicio.Text = "Agendar Servicio";
            // 
            // frmAgendaAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 681);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgendaAgregar";
            this.Text = "frmAgendaAgregar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Label lblServicio;
        private FontAwesome.Sharp.IconButton btnAtras;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.Label lblAgendarServicio;
        private RJCodeAdvance.RJControls.RJDatePicker cmbxFecha;
        private RJCodeAdvance.RJControls.RJComboBox cmbxVehiculo;
        private RJCodeAdvance.RJControls.RJComboBox cmbxServicio;
    }
}