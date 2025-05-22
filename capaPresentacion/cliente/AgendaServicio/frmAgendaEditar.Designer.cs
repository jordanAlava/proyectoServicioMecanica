namespace capaPresentacion.cliente.AgendaServicio
{
    partial class frmAgendaEditar
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
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnAtras = new FontAwesome.Sharp.IconButton();
            this.lblRegistroNoEncontrado = new System.Windows.Forms.Label();
            this.cmbxFiltrarBusqueda = new RJCodeAdvance.RJControls.RJComboBox();
            this.cmbxFecha = new RJCodeAdvance.RJControls.RJDatePicker();
            this.cmbxVehiculo = new RJCodeAdvance.RJControls.RJComboBox();
            this.cmbxServicio = new RJCodeAdvance.RJControls.RJComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBarraBusqueda = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblEditarServicio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.lblRegistroNoEncontrado);
            this.panel1.Controls.Add(this.cmbxFiltrarBusqueda);
            this.panel1.Controls.Add(this.cmbxFecha);
            this.panel1.Controls.Add(this.cmbxVehiculo);
            this.panel1.Controls.Add(this.cmbxServicio);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblVehiculo);
            this.panel1.Controls.Add(this.lblServicio);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtBarraBusqueda);
            this.panel1.Controls.Add(this.lblEditarServicio);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 838);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.Black;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            this.btnEditar.IconColor = System.Drawing.Color.White;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 36;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(801, 615);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnEditar.Size = new System.Drawing.Size(281, 58);
            this.btnEditar.TabIndex = 178;
            this.btnEditar.Text = "&Confirmar Cambios";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
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
            this.lblRegistroNoEncontrado.Location = new System.Drawing.Point(571, 346);
            this.lblRegistroNoEncontrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistroNoEncontrado.Name = "lblRegistroNoEncontrado";
            this.lblRegistroNoEncontrado.Size = new System.Drawing.Size(215, 25);
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
            this.cmbxFiltrarBusqueda.Location = new System.Drawing.Point(692, 191);
            this.cmbxFiltrarBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxFiltrarBusqueda.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbxFiltrarBusqueda.Name = "cmbxFiltrarBusqueda";
            this.cmbxFiltrarBusqueda.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxFiltrarBusqueda.Size = new System.Drawing.Size(267, 38);
            this.cmbxFiltrarBusqueda.TabIndex = 176;
            this.cmbxFiltrarBusqueda.Texts = "Buscar por (Campo)";
            // 
            // cmbxFecha
            // 
            this.cmbxFecha.BorderColor = System.Drawing.Color.Black;
            this.cmbxFecha.BorderSize = 2;
            this.cmbxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cmbxFecha.Location = new System.Drawing.Point(575, 431);
            this.cmbxFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxFecha.MaximumSize = new System.Drawing.Size(505, 380);
            this.cmbxFecha.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.cmbxFecha.MinimumSize = new System.Drawing.Size(4, 35);
            this.cmbxFecha.Name = "cmbxFecha";
            this.cmbxFecha.Size = new System.Drawing.Size(505, 35);
            this.cmbxFecha.SkinColor = System.Drawing.Color.White;
            this.cmbxFecha.TabIndex = 175;
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
            this.cmbxVehiculo.Location = new System.Drawing.Point(575, 369);
            this.cmbxVehiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxVehiculo.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbxVehiculo.Name = "cmbxVehiculo";
            this.cmbxVehiculo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxVehiculo.Size = new System.Drawing.Size(508, 38);
            this.cmbxVehiculo.TabIndex = 174;
            this.cmbxVehiculo.Texts = "(Seleccionar)";
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
            this.cmbxServicio.Location = new System.Drawing.Point(575, 309);
            this.cmbxServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxServicio.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbxServicio.Name = "cmbxServicio";
            this.cmbxServicio.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxServicio.Size = new System.Drawing.Size(508, 38);
            this.cmbxServicio.TabIndex = 173;
            this.cmbxServicio.Texts = "(Seleccionar)";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(275, 431);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(72, 25);
            this.lblFecha.TabIndex = 172;
            this.lblFecha.Text = "Fecha";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(275, 369);
            this.lblVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(96, 25);
            this.lblVehiculo.TabIndex = 171;
            this.lblVehiculo.Text = "Vehículo";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.Location = new System.Drawing.Point(275, 309);
            this.lblServicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(90, 25);
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
            this.btnBuscar.Location = new System.Drawing.Point(968, 191);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 37);
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
            this.txtBarraBusqueda.Location = new System.Drawing.Point(265, 191);
            this.txtBarraBusqueda.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBarraBusqueda.Multiline = false;
            this.txtBarraBusqueda.Name = "txtBarraBusqueda";
            this.txtBarraBusqueda.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtBarraBusqueda.PasswordChar = false;
            this.txtBarraBusqueda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBarraBusqueda.PlaceholderText = "Buscar";
            this.txtBarraBusqueda.Size = new System.Drawing.Size(417, 39);
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
            this.lblEditarServicio.Location = new System.Drawing.Point(117, 116);
            this.lblEditarServicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditarServicio.Name = "lblEditarServicio";
            this.lblEditarServicio.Size = new System.Drawing.Size(354, 39);
            this.lblEditarServicio.TabIndex = 167;
            this.lblEditarServicio.Text = "Editar Agendamiento";
            // 
            // frmAgendaEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 838);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAgendaEditar";
            this.Text = "frmAgendaEditar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAtras;
        private System.Windows.Forms.Label lblRegistroNoEncontrado;
        private RJCodeAdvance.RJControls.RJComboBox cmbxFiltrarBusqueda;
        private RJCodeAdvance.RJControls.RJDatePicker cmbxFecha;
        private RJCodeAdvance.RJControls.RJComboBox cmbxVehiculo;
        private RJCodeAdvance.RJControls.RJComboBox cmbxServicio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Label lblServicio;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private RJCodeAdvance.RJControls.RJTextBox txtBarraBusqueda;
        private System.Windows.Forms.Label lblEditarServicio;
    }
}