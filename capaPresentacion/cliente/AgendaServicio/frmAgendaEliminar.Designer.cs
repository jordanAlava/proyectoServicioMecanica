namespace capaPresentacion.cliente.AgendaServicio
{
    partial class frmAgendaEliminar
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
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.lblFechaValor = new System.Windows.Forms.Label();
            this.lblVehiculoValor = new System.Windows.Forms.Label();
            this.lblServicioValor = new System.Windows.Forms.Label();
            this.btnAtras = new FontAwesome.Sharp.IconButton();
            this.lblRegistroNoEncontrado = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.lblEditarServicio = new System.Windows.Forms.Label();
            this.cmbxVehiculo = new RJCodeAdvance.RJControls.RJComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbServicio = new RJCodeAdvance.RJControls.RJComboBox();
            this.cmbFecha = new RJCodeAdvance.RJControls.RJComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.cmbFecha);
            this.panel1.Controls.Add(this.cmbServicio);
            this.panel1.Controls.Add(this.cmbxVehiculo);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblFechaValor);
            this.panel1.Controls.Add(this.lblVehiculoValor);
            this.panel1.Controls.Add(this.lblServicioValor);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.lblRegistroNoEncontrado);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblServicio);
            this.panel1.Controls.Add(this.lblEditarServicio);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 838);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 36;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(801, 617);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnEliminar.Size = new System.Drawing.Size(281, 58);
            this.btnEliminar.TabIndex = 183;
            this.btnEliminar.Text = "&Confirmar Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblFechaValor
            // 
            this.lblFechaValor.AutoSize = true;
            this.lblFechaValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaValor.Location = new System.Drawing.Point(571, 468);
            this.lblFechaValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaValor.Name = "lblFechaValor";
            this.lblFechaValor.Size = new System.Drawing.Size(0, 25);
            this.lblFechaValor.TabIndex = 182;
            // 
            // lblVehiculoValor
            // 
            this.lblVehiculoValor.AutoSize = true;
            this.lblVehiculoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculoValor.Location = new System.Drawing.Point(571, 406);
            this.lblVehiculoValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehiculoValor.Name = "lblVehiculoValor";
            this.lblVehiculoValor.Size = new System.Drawing.Size(0, 25);
            this.lblVehiculoValor.TabIndex = 181;
            // 
            // lblServicioValor
            // 
            this.lblServicioValor.AutoSize = true;
            this.lblServicioValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicioValor.Location = new System.Drawing.Point(571, 346);
            this.lblServicioValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServicioValor.Name = "lblServicioValor";
            this.lblServicioValor.Size = new System.Drawing.Size(0, 25);
            this.lblServicioValor.TabIndex = 180;
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
            this.btnAtras.Location = new System.Drawing.Point(628, 622);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(96, 47);
            this.btnAtras.TabIndex = 177;
            this.btnAtras.Text = "&Atrás";
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            this.btnAtras.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAtras_MouseDown);
            this.btnAtras.MouseEnter += new System.EventHandler(this.btnAtras_MouseEnter);
            this.btnAtras.MouseLeave += new System.EventHandler(this.btnAtras_MouseLeave);
            // 
            // lblRegistroNoEncontrado
            // 
            this.lblRegistroNoEncontrado.AutoSize = true;
            this.lblRegistroNoEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroNoEncontrado.Location = new System.Drawing.Point(571, 383);
            this.lblRegistroNoEncontrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistroNoEncontrado.Name = "lblRegistroNoEncontrado";
            this.lblRegistroNoEncontrado.Size = new System.Drawing.Size(215, 25);
            this.lblRegistroNoEncontrado.TabIndex = 179;
            this.lblRegistroNoEncontrado.Text = "Registro no Encontrado";
            this.lblRegistroNoEncontrado.Visible = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(275, 468);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(72, 25);
            this.lblFecha.TabIndex = 172;
            this.lblFecha.Text = "Fecha";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.Location = new System.Drawing.Point(275, 346);
            this.lblServicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(90, 25);
            this.lblServicio.TabIndex = 170;
            this.lblServicio.Text = "Servicio";
            // 
            // lblEditarServicio
            // 
            this.lblEditarServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditarServicio.AutoSize = true;
            this.lblEditarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarServicio.ForeColor = System.Drawing.Color.Black;
            this.lblEditarServicio.Location = new System.Drawing.Point(117, 116);
            this.lblEditarServicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditarServicio.Name = "lblEditarServicio";
            this.lblEditarServicio.Size = new System.Drawing.Size(391, 39);
            this.lblEditarServicio.TabIndex = 167;
            this.lblEditarServicio.Text = "Eliminar Agendamiento";
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
            this.cmbxVehiculo.Location = new System.Drawing.Point(457, 260);
            this.cmbxVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxVehiculo.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbxVehiculo.Name = "cmbxVehiculo";
            this.cmbxVehiculo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxVehiculo.Size = new System.Drawing.Size(267, 38);
            this.cmbxVehiculo.TabIndex = 135;
            this.cmbxVehiculo.Texts = "(Seleccionar)";
            this.cmbxVehiculo.OnSelectedIndexChanged += new System.EventHandler(this.cmbxVehiculo_OnSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 273);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 134;
            this.label1.Text = "Vehículo";
            // 
            // cmbServicio
            // 
            this.cmbServicio.BackColor = System.Drawing.Color.White;
            this.cmbServicio.BorderColor = System.Drawing.Color.Black;
            this.cmbServicio.BorderSize = 2;
            this.cmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbServicio.ForeColor = System.Drawing.Color.Black;
            this.cmbServicio.IconColor = System.Drawing.Color.Black;
            this.cmbServicio.Items.AddRange(new object[] {
            "op 1",
            "op 2",
            "op 3"});
            this.cmbServicio.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbServicio.ListTextColor = System.Drawing.Color.Black;
            this.cmbServicio.Location = new System.Drawing.Point(457, 333);
            this.cmbServicio.Margin = new System.Windows.Forms.Padding(4);
            this.cmbServicio.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbServicio.Size = new System.Drawing.Size(267, 38);
            this.cmbServicio.TabIndex = 184;
            this.cmbServicio.Texts = "(Seleccionar)";
            this.cmbServicio.OnSelectedIndexChanged += new System.EventHandler(this.cmbServicio_OnSelectedIndexChanged);
            // 
            // cmbFecha
            // 
            this.cmbFecha.BackColor = System.Drawing.Color.White;
            this.cmbFecha.BorderColor = System.Drawing.Color.Black;
            this.cmbFecha.BorderSize = 2;
            this.cmbFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbFecha.ForeColor = System.Drawing.Color.Black;
            this.cmbFecha.IconColor = System.Drawing.Color.Black;
            this.cmbFecha.Items.AddRange(new object[] {
            "op 1",
            "op 2",
            "op 3"});
            this.cmbFecha.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbFecha.ListTextColor = System.Drawing.Color.Black;
            this.cmbFecha.Location = new System.Drawing.Point(457, 455);
            this.cmbFecha.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFecha.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbFecha.Name = "cmbFecha";
            this.cmbFecha.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFecha.Size = new System.Drawing.Size(267, 38);
            this.cmbFecha.TabIndex = 185;
            this.cmbFecha.Texts = "(Seleccionar)";
            // 
            // frmAgendaEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 838);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAgendaEliminar";
            this.Text = "frmAgendaEliminar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAtras;
        private System.Windows.Forms.Label lblRegistroNoEncontrado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Label lblEditarServicio;
        private System.Windows.Forms.Label lblFechaValor;
        private System.Windows.Forms.Label lblVehiculoValor;
        private System.Windows.Forms.Label lblServicioValor;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private RJCodeAdvance.RJControls.RJComboBox cmbxVehiculo;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJComboBox cmbServicio;
        private RJCodeAdvance.RJControls.RJComboBox cmbFecha;
    }
}