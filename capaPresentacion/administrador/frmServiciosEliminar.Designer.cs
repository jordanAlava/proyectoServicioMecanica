namespace capaPresentacion.administrador
{
    partial class frmServiciosEliminar
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
            this.pnlIngresoDatos = new System.Windows.Forms.Panel();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnAtras = new FontAwesome.Sharp.IconButton();
            this.lblGarantiaValor = new System.Windows.Forms.Label();
            this.lblCostoTotalValor = new System.Windows.Forms.Label();
            this.lblIvaValor = new System.Windows.Forms.Label();
            this.lblCostoUnitarioValor = new System.Windows.Forms.Label();
            this.lblDescripcionValor = new System.Windows.Forms.Label();
            this.lblTipoValor = new System.Windows.Forms.Label();
            this.lblNombreValor = new System.Windows.Forms.Label();
            this.lblRegistroNoEncontrado = new System.Windows.Forms.Label();
            this.lblGarantia = new System.Windows.Forms.Label();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblCostoUnitario = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBarraBusqueda = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblAgregarServicio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlIngresoDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.pnlIngresoDatos);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtBarraBusqueda);
            this.panel1.Controls.Add(this.lblAgregarServicio);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 838);
            this.panel1.TabIndex = 2;
            // 
            // pnlIngresoDatos
            // 
            this.pnlIngresoDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlIngresoDatos.Controls.Add(this.btnEliminar);
            this.pnlIngresoDatos.Controls.Add(this.btnAtras);
            this.pnlIngresoDatos.Controls.Add(this.lblGarantiaValor);
            this.pnlIngresoDatos.Controls.Add(this.lblCostoTotalValor);
            this.pnlIngresoDatos.Controls.Add(this.lblIvaValor);
            this.pnlIngresoDatos.Controls.Add(this.lblCostoUnitarioValor);
            this.pnlIngresoDatos.Controls.Add(this.lblDescripcionValor);
            this.pnlIngresoDatos.Controls.Add(this.lblTipoValor);
            this.pnlIngresoDatos.Controls.Add(this.lblNombreValor);
            this.pnlIngresoDatos.Controls.Add(this.lblRegistroNoEncontrado);
            this.pnlIngresoDatos.Controls.Add(this.lblGarantia);
            this.pnlIngresoDatos.Controls.Add(this.lblCostoTotal);
            this.pnlIngresoDatos.Controls.Add(this.lblIva);
            this.pnlIngresoDatos.Controls.Add(this.lblCostoUnitario);
            this.pnlIngresoDatos.Controls.Add(this.lblDescripcion);
            this.pnlIngresoDatos.Controls.Add(this.lblTipo);
            this.pnlIngresoDatos.Controls.Add(this.lblNombre);
            this.pnlIngresoDatos.Location = new System.Drawing.Point(0, 224);
            this.pnlIngresoDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlIngresoDatos.Name = "pnlIngresoDatos";
            this.pnlIngresoDatos.Size = new System.Drawing.Size(1333, 540);
            this.pnlIngresoDatos.TabIndex = 140;
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
            this.btnEliminar.Location = new System.Drawing.Point(960, 468);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnEliminar.Size = new System.Drawing.Size(281, 58);
            this.btnEliminar.TabIndex = 159;
            this.btnEliminar.Text = "&Confirmar Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnAtras.Location = new System.Drawing.Point(787, 474);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(96, 47);
            this.btnAtras.TabIndex = 158;
            this.btnAtras.Text = "&Atrás";
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            this.btnAtras.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAtras_MouseDown);
            this.btnAtras.MouseEnter += new System.EventHandler(this.btnAtras_MouseEnter);
            this.btnAtras.MouseLeave += new System.EventHandler(this.btnAtras_MouseLeave);
            // 
            // lblGarantiaValor
            // 
            this.lblGarantiaValor.AutoSize = true;
            this.lblGarantiaValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarantiaValor.Location = new System.Drawing.Point(572, 402);
            this.lblGarantiaValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGarantiaValor.Name = "lblGarantiaValor";
            this.lblGarantiaValor.Size = new System.Drawing.Size(0, 25);
            this.lblGarantiaValor.TabIndex = 157;
            // 
            // lblCostoTotalValor
            // 
            this.lblCostoTotalValor.AutoSize = true;
            this.lblCostoTotalValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotalValor.Location = new System.Drawing.Point(572, 332);
            this.lblCostoTotalValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCostoTotalValor.Name = "lblCostoTotalValor";
            this.lblCostoTotalValor.Size = new System.Drawing.Size(0, 25);
            this.lblCostoTotalValor.TabIndex = 156;
            // 
            // lblIvaValor
            // 
            this.lblIvaValor.AutoSize = true;
            this.lblIvaValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIvaValor.Location = new System.Drawing.Point(572, 266);
            this.lblIvaValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIvaValor.Name = "lblIvaValor";
            this.lblIvaValor.Size = new System.Drawing.Size(0, 25);
            this.lblIvaValor.TabIndex = 155;
            // 
            // lblCostoUnitarioValor
            // 
            this.lblCostoUnitarioValor.AutoSize = true;
            this.lblCostoUnitarioValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoUnitarioValor.Location = new System.Drawing.Point(572, 202);
            this.lblCostoUnitarioValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCostoUnitarioValor.Name = "lblCostoUnitarioValor";
            this.lblCostoUnitarioValor.Size = new System.Drawing.Size(0, 25);
            this.lblCostoUnitarioValor.TabIndex = 154;
            // 
            // lblDescripcionValor
            // 
            this.lblDescripcionValor.AutoSize = true;
            this.lblDescripcionValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionValor.Location = new System.Drawing.Point(572, 142);
            this.lblDescripcionValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionValor.Name = "lblDescripcionValor";
            this.lblDescripcionValor.Size = new System.Drawing.Size(0, 25);
            this.lblDescripcionValor.TabIndex = 153;
            // 
            // lblTipoValor
            // 
            this.lblTipoValor.AutoSize = true;
            this.lblTipoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoValor.Location = new System.Drawing.Point(572, 80);
            this.lblTipoValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoValor.Name = "lblTipoValor";
            this.lblTipoValor.Size = new System.Drawing.Size(0, 25);
            this.lblTipoValor.TabIndex = 152;
            // 
            // lblNombreValor
            // 
            this.lblNombreValor.AutoSize = true;
            this.lblNombreValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreValor.Location = new System.Drawing.Point(572, 20);
            this.lblNombreValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreValor.Name = "lblNombreValor";
            this.lblNombreValor.Size = new System.Drawing.Size(0, 25);
            this.lblNombreValor.TabIndex = 151;
            // 
            // lblRegistroNoEncontrado
            // 
            this.lblRegistroNoEncontrado.AutoSize = true;
            this.lblRegistroNoEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroNoEncontrado.Location = new System.Drawing.Point(549, 63);
            this.lblRegistroNoEncontrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistroNoEncontrado.Name = "lblRegistroNoEncontrado";
            this.lblRegistroNoEncontrado.Size = new System.Drawing.Size(215, 25);
            this.lblRegistroNoEncontrado.TabIndex = 150;
            this.lblRegistroNoEncontrado.Text = "Registro no Encontrado";
            this.lblRegistroNoEncontrado.Visible = false;
            // 
            // lblGarantia
            // 
            this.lblGarantia.AutoSize = true;
            this.lblGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarantia.Location = new System.Drawing.Point(277, 402);
            this.lblGarantia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGarantia.Name = "lblGarantia";
            this.lblGarantia.Size = new System.Drawing.Size(179, 25);
            this.lblGarantia.TabIndex = 142;
            this.lblGarantia.Text = "Garantía (meses)";
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotal.Location = new System.Drawing.Point(277, 332);
            this.lblCostoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(124, 25);
            this.lblCostoTotal.TabIndex = 141;
            this.lblCostoTotal.Text = "Costo Total";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(277, 266);
            this.lblIva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(48, 25);
            this.lblIva.TabIndex = 140;
            this.lblIva.Text = "IVA";
            // 
            // lblCostoUnitario
            // 
            this.lblCostoUnitario.AutoSize = true;
            this.lblCostoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoUnitario.Location = new System.Drawing.Point(277, 202);
            this.lblCostoUnitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCostoUnitario.Name = "lblCostoUnitario";
            this.lblCostoUnitario.Size = new System.Drawing.Size(149, 25);
            this.lblCostoUnitario.TabIndex = 139;
            this.lblCostoUnitario.Text = "Costo Unitario";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(277, 142);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(125, 25);
            this.lblDescripcion.TabIndex = 138;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(277, 80);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(55, 25);
            this.lblTipo.TabIndex = 137;
            this.lblTipo.Text = "Tipo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(277, 20);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(206, 25);
            this.lblNombre.TabIndex = 136;
            this.lblNombre.Text = "Nombre del Servicio";
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
            this.btnBuscar.Location = new System.Drawing.Point(940, 143);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 37);
            this.btnBuscar.TabIndex = 139;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.txtBarraBusqueda.Location = new System.Drawing.Point(283, 142);
            this.txtBarraBusqueda.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBarraBusqueda.Multiline = false;
            this.txtBarraBusqueda.Name = "txtBarraBusqueda";
            this.txtBarraBusqueda.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtBarraBusqueda.PasswordChar = false;
            this.txtBarraBusqueda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBarraBusqueda.PlaceholderText = "Buscar por ID";
            this.txtBarraBusqueda.Size = new System.Drawing.Size(647, 39);
            this.txtBarraBusqueda.TabIndex = 137;
            this.txtBarraBusqueda.Texts = "";
            this.txtBarraBusqueda.UnderlinedStyle = false;
            // 
            // lblAgregarServicio
            // 
            this.lblAgregarServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgregarServicio.AutoSize = true;
            this.lblAgregarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarServicio.ForeColor = System.Drawing.Color.Black;
            this.lblAgregarServicio.Location = new System.Drawing.Point(89, 68);
            this.lblAgregarServicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgregarServicio.Name = "lblAgregarServicio";
            this.lblAgregarServicio.Size = new System.Drawing.Size(289, 39);
            this.lblAgregarServicio.TabIndex = 111;
            this.lblAgregarServicio.Text = "Eliminar Servicio";
            // 
            // frmServiciosEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 838);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmServiciosEliminar";
            this.Text = "frmServiciosEliminar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlIngresoDatos.ResumeLayout(false);
            this.pnlIngresoDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlIngresoDatos;
        private System.Windows.Forms.Label lblRegistroNoEncontrado;
        private System.Windows.Forms.Label lblGarantia;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblCostoUnitario;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNombre;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private RJCodeAdvance.RJControls.RJTextBox txtBarraBusqueda;
        private System.Windows.Forms.Label lblAgregarServicio;
        private System.Windows.Forms.Label lblNombreValor;
        private System.Windows.Forms.Label lblCostoTotalValor;
        private System.Windows.Forms.Label lblIvaValor;
        private System.Windows.Forms.Label lblCostoUnitarioValor;
        private System.Windows.Forms.Label lblDescripcionValor;
        private System.Windows.Forms.Label lblTipoValor;
        private System.Windows.Forms.Label lblGarantiaValor;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnAtras;
    }
}