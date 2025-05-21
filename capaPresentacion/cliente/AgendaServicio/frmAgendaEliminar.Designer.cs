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
            this.btnAtras = new FontAwesome.Sharp.IconButton();
            this.lblRegistroNoEncontrado = new System.Windows.Forms.Label();
            this.cmbxFiltrarBusqueda = new RJCodeAdvance.RJControls.RJComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBarraBusqueda = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblEditarServicio = new System.Windows.Forms.Label();
            this.lblServicioValor = new System.Windows.Forms.Label();
            this.lblVehiculoValor = new System.Windows.Forms.Label();
            this.lblFechaValor = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.lblFechaValor);
            this.panel1.Controls.Add(this.lblVehiculoValor);
            this.panel1.Controls.Add(this.lblServicioValor);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.lblRegistroNoEncontrado);
            this.panel1.Controls.Add(this.cmbxFiltrarBusqueda);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblVehiculo);
            this.panel1.Controls.Add(this.lblServicio);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtBarraBusqueda);
            this.panel1.Controls.Add(this.lblEditarServicio);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 681);
            this.panel1.TabIndex = 5;
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
            this.btnAtras.Location = new System.Drawing.Point(471, 505);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(72, 38);
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
            this.lblRegistroNoEncontrado.Location = new System.Drawing.Point(428, 311);
            this.lblRegistroNoEncontrado.Name = "lblRegistroNoEncontrado";
            this.lblRegistroNoEncontrado.Size = new System.Drawing.Size(178, 20);
            this.lblRegistroNoEncontrado.TabIndex = 179;
            this.lblRegistroNoEncontrado.Text = "Registro no Encontrado";
            this.lblRegistroNoEncontrado.Visible = false;
            // 
            // cmbxFiltrarBusqueda
            // 
            this.cmbxFiltrarBusqueda.BackColor = System.Drawing.Color.White;
            this.cmbxFiltrarBusqueda.BorderColor = System.Drawing.Color.Black;
            this.cmbxFiltrarBusqueda.BorderSize = 2;
            this.cmbxFiltrarBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbxFiltrarBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbxFiltrarBusqueda.ForeColor = System.Drawing.Color.Black;
            this.cmbxFiltrarBusqueda.IconColor = System.Drawing.Color.Black;
            this.cmbxFiltrarBusqueda.Items.AddRange(new object[] {
            "op 1",
            "op 2",
            "op 3"});
            this.cmbxFiltrarBusqueda.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxFiltrarBusqueda.ListTextColor = System.Drawing.Color.Black;
            this.cmbxFiltrarBusqueda.Location = new System.Drawing.Point(519, 155);
            this.cmbxFiltrarBusqueda.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbxFiltrarBusqueda.Name = "cmbxFiltrarBusqueda";
            this.cmbxFiltrarBusqueda.Padding = new System.Windows.Forms.Padding(2);
            this.cmbxFiltrarBusqueda.Size = new System.Drawing.Size(200, 31);
            this.cmbxFiltrarBusqueda.TabIndex = 176;
            this.cmbxFiltrarBusqueda.Texts = "Buscar por (Campo)";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(206, 380);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 20);
            this.lblFecha.TabIndex = 172;
            this.lblFecha.Text = "Fecha";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(206, 330);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(78, 20);
            this.lblVehiculo.TabIndex = 171;
            this.lblVehiculo.Text = "Vehículo";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.Location = new System.Drawing.Point(206, 281);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(72, 20);
            this.lblServicio.TabIndex = 170;
            this.lblServicio.Text = "Servicio";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.Black;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 24;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(726, 155);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 30);
            this.btnBuscar.TabIndex = 169;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBarraBusqueda
            // 
            this.txtBarraBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBarraBusqueda.BackColor = System.Drawing.SystemColors.Window;
            this.txtBarraBusqueda.BorderColor = System.Drawing.Color.Black;
            this.txtBarraBusqueda.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.txtBarraBusqueda.BorderRadius = 0;
            this.txtBarraBusqueda.BorderSize = 2;
            this.txtBarraBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarraBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBarraBusqueda.Location = new System.Drawing.Point(199, 155);
            this.txtBarraBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarraBusqueda.Multiline = false;
            this.txtBarraBusqueda.Name = "txtBarraBusqueda";
            this.txtBarraBusqueda.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBarraBusqueda.PasswordChar = false;
            this.txtBarraBusqueda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBarraBusqueda.PlaceholderText = "Buscar ";
            this.txtBarraBusqueda.Size = new System.Drawing.Size(313, 31);
            this.txtBarraBusqueda.TabIndex = 168;
            this.txtBarraBusqueda.Texts = "";
            this.txtBarraBusqueda.UnderlinedStyle = false;
            // 
            // lblEditarServicio
            // 
            this.lblEditarServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditarServicio.AutoSize = true;
            this.lblEditarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarServicio.ForeColor = System.Drawing.Color.Black;
            this.lblEditarServicio.Location = new System.Drawing.Point(88, 94);
            this.lblEditarServicio.Name = "lblEditarServicio";
            this.lblEditarServicio.Size = new System.Drawing.Size(313, 31);
            this.lblEditarServicio.TabIndex = 167;
            this.lblEditarServicio.Text = "Eliminar Agendamiento";
            // 
            // lblServicioValor
            // 
            this.lblServicioValor.AutoSize = true;
            this.lblServicioValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicioValor.Location = new System.Drawing.Point(428, 281);
            this.lblServicioValor.Name = "lblServicioValor";
            this.lblServicioValor.Size = new System.Drawing.Size(0, 20);
            this.lblServicioValor.TabIndex = 180;
            // 
            // lblVehiculoValor
            // 
            this.lblVehiculoValor.AutoSize = true;
            this.lblVehiculoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculoValor.Location = new System.Drawing.Point(428, 330);
            this.lblVehiculoValor.Name = "lblVehiculoValor";
            this.lblVehiculoValor.Size = new System.Drawing.Size(0, 20);
            this.lblVehiculoValor.TabIndex = 181;
            // 
            // lblFechaValor
            // 
            this.lblFechaValor.AutoSize = true;
            this.lblFechaValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaValor.Location = new System.Drawing.Point(428, 380);
            this.lblFechaValor.Name = "lblFechaValor";
            this.lblFechaValor.Size = new System.Drawing.Size(0, 20);
            this.lblFechaValor.TabIndex = 182;
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
            this.btnEliminar.Location = new System.Drawing.Point(601, 501);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEliminar.Size = new System.Drawing.Size(211, 47);
            this.btnEliminar.TabIndex = 183;
            this.btnEliminar.Text = "&Confirmar Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // frmAgendaEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 681);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private RJCodeAdvance.RJControls.RJComboBox cmbxFiltrarBusqueda;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Label lblServicio;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private RJCodeAdvance.RJControls.RJTextBox txtBarraBusqueda;
        private System.Windows.Forms.Label lblEditarServicio;
        private System.Windows.Forms.Label lblFechaValor;
        private System.Windows.Forms.Label lblVehiculoValor;
        private System.Windows.Forms.Label lblServicioValor;
        private FontAwesome.Sharp.IconButton btnEliminar;
    }
}