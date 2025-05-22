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
            this.cmbxVehiculo = new RJCodeAdvance.RJControls.RJComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.btnAtras = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.lblAgendarServicio = new System.Windows.Forms.Label();
            this.dtgvTabla = new System.Windows.Forms.DataGridView();
            this.txtidServicio = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtFecha = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.txtFecha);
            this.panel1.Controls.Add(this.txtidServicio);
            this.panel1.Controls.Add(this.dtgvTabla);
            this.panel1.Controls.Add(this.cmbxVehiculo);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblVehiculo);
            this.panel1.Controls.Add(this.lblServicio);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.lblAgendarServicio);
            this.panel1.Location = new System.Drawing.Point(34, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 838);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.cmbxVehiculo.Location = new System.Drawing.Point(1078, 288);
            this.cmbxVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxVehiculo.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbxVehiculo.Name = "cmbxVehiculo";
            this.cmbxVehiculo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxVehiculo.Size = new System.Drawing.Size(267, 38);
            this.cmbxVehiculo.TabIndex = 133;
            this.cmbxVehiculo.Texts = "(Seleccionar)";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(886, 345);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(72, 25);
            this.lblFecha.TabIndex = 121;
            this.lblFecha.Text = "Fecha";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(886, 284);
            this.lblVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(96, 25);
            this.lblVehiculo.TabIndex = 120;
            this.lblVehiculo.Text = "Vehículo";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.Location = new System.Drawing.Point(886, 223);
            this.lblServicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(129, 25);
            this.lblServicio.TabIndex = 119;
            this.lblServicio.Text = "Servicio (id)";
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
            this.btnAtras.Location = new System.Drawing.Point(841, 736);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(96, 47);
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
            this.btnAgregar.Location = new System.Drawing.Point(1004, 727);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(281, 58);
            this.btnAgregar.TabIndex = 117;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblAgendarServicio
            // 
            this.lblAgendarServicio.AutoSize = true;
            this.lblAgendarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendarServicio.ForeColor = System.Drawing.Color.Black;
            this.lblAgendarServicio.Location = new System.Drawing.Point(92, 159);
            this.lblAgendarServicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgendarServicio.Name = "lblAgendarServicio";
            this.lblAgendarServicio.Size = new System.Drawing.Size(293, 39);
            this.lblAgendarServicio.TabIndex = 111;
            this.lblAgendarServicio.Text = "Agendar Servicio";
            // 
            // dtgvTabla
            // 
            this.dtgvTabla.AllowUserToAddRows = false;
            this.dtgvTabla.AllowUserToDeleteRows = false;
            this.dtgvTabla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTabla.Location = new System.Drawing.Point(14, 223);
            this.dtgvTabla.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvTabla.Name = "dtgvTabla";
            this.dtgvTabla.ReadOnly = true;
            this.dtgvTabla.RowHeadersWidth = 51;
            this.dtgvTabla.Size = new System.Drawing.Size(849, 477);
            this.dtgvTabla.TabIndex = 135;
            // 
            // txtidServicio
            // 
            this.txtidServicio.BackColor = System.Drawing.SystemColors.Window;
            this.txtidServicio.BorderColor = System.Drawing.Color.Black;
            this.txtidServicio.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.txtidServicio.BorderRadius = 0;
            this.txtidServicio.BorderSize = 2;
            this.txtidServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtidServicio.Location = new System.Drawing.Point(1078, 223);
            this.txtidServicio.Margin = new System.Windows.Forms.Padding(5);
            this.txtidServicio.Multiline = false;
            this.txtidServicio.Name = "txtidServicio";
            this.txtidServicio.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtidServicio.PasswordChar = false;
            this.txtidServicio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtidServicio.PlaceholderText = "";
            this.txtidServicio.Size = new System.Drawing.Size(167, 39);
            this.txtidServicio.TabIndex = 136;
            this.txtidServicio.Texts = "";
            this.txtidServicio.UnderlinedStyle = false;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Window;
            this.txtFecha.BorderColor = System.Drawing.Color.Black;
            this.txtFecha.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.txtFecha.BorderRadius = 0;
            this.txtFecha.BorderSize = 2;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFecha.Location = new System.Drawing.Point(1078, 345);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(5);
            this.txtFecha.Multiline = false;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtFecha.PasswordChar = false;
            this.txtFecha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFecha.PlaceholderText = "";
            this.txtFecha.Size = new System.Drawing.Size(250, 39);
            this.txtFecha.TabIndex = 137;
            this.txtFecha.Texts = "";
            this.txtFecha.UnderlinedStyle = false;
            // 
            // frmAgendaAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 838);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAgendaAgregar";
            this.Text = "frmAgendaAgregar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTabla)).EndInit();
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
        private RJCodeAdvance.RJControls.RJComboBox cmbxVehiculo;
        private System.Windows.Forms.DataGridView dtgvTabla;
        private RJCodeAdvance.RJControls.RJTextBox txtidServicio;
        private RJCodeAdvance.RJControls.RJTextBox txtFecha;
    }
}