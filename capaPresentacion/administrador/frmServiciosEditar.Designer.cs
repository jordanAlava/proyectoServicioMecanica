namespace capaPresentacion.administrador
{
    partial class frmServiciosEditar
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
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.txtGarantia = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnAtras = new FontAwesome.Sharp.IconButton();
            this.lblRegistroNoEncontrado = new System.Windows.Forms.Label();
            this.txtIVA = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtCostoUnitario = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtDescripcion = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtTipo = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtNombre = new RJCodeAdvance.RJControls.RJTextBox();
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
            this.lblCostoT = new System.Windows.Forms.Label();
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
            this.panel1.TabIndex = 1;
            // 
            // pnlIngresoDatos
            // 
            this.pnlIngresoDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlIngresoDatos.Controls.Add(this.lblCostoT);
            this.pnlIngresoDatos.Controls.Add(this.btnEditar);
            this.pnlIngresoDatos.Controls.Add(this.txtGarantia);
            this.pnlIngresoDatos.Controls.Add(this.btnAtras);
            this.pnlIngresoDatos.Controls.Add(this.lblRegistroNoEncontrado);
            this.pnlIngresoDatos.Controls.Add(this.txtIVA);
            this.pnlIngresoDatos.Controls.Add(this.txtCostoUnitario);
            this.pnlIngresoDatos.Controls.Add(this.txtDescripcion);
            this.pnlIngresoDatos.Controls.Add(this.txtTipo);
            this.pnlIngresoDatos.Controls.Add(this.txtNombre);
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
            this.pnlIngresoDatos.Size = new System.Drawing.Size(1333, 548);
            this.pnlIngresoDatos.TabIndex = 140;
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
            this.btnEditar.Location = new System.Drawing.Point(960, 468);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnEditar.Size = new System.Drawing.Size(281, 58);
            this.btnEditar.TabIndex = 136;
            this.btnEditar.Text = "&Confirmar Cambios";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtGarantia
            // 
            this.txtGarantia.BackColor = System.Drawing.SystemColors.Window;
            this.txtGarantia.BorderColor = System.Drawing.Color.Black;
            this.txtGarantia.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.txtGarantia.BorderRadius = 0;
            this.txtGarantia.BorderSize = 2;
            this.txtGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGarantia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGarantia.Location = new System.Drawing.Point(564, 400);
            this.txtGarantia.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtGarantia.Multiline = false;
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtGarantia.PasswordChar = false;
            this.txtGarantia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGarantia.PlaceholderText = "";
            this.txtGarantia.Size = new System.Drawing.Size(507, 39);
            this.txtGarantia.TabIndex = 149;
            this.txtGarantia.Texts = "";
            this.txtGarantia.UnderlinedStyle = false;
            this.txtGarantia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
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
            this.btnAtras.TabIndex = 118;
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
            this.lblRegistroNoEncontrado.Location = new System.Drawing.Point(531, 60);
            this.lblRegistroNoEncontrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistroNoEncontrado.Name = "lblRegistroNoEncontrado";
            this.lblRegistroNoEncontrado.Size = new System.Drawing.Size(215, 25);
            this.lblRegistroNoEncontrado.TabIndex = 150;
            this.lblRegistroNoEncontrado.Text = "Registro no Encontrado";
            this.lblRegistroNoEncontrado.Visible = false;
            // 
            // txtIVA
            // 
            this.txtIVA.BackColor = System.Drawing.SystemColors.Window;
            this.txtIVA.BorderColor = System.Drawing.Color.Black;
            this.txtIVA.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.txtIVA.BorderRadius = 0;
            this.txtIVA.BorderSize = 2;
            this.txtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIVA.Location = new System.Drawing.Point(564, 263);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtIVA.Multiline = false;
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtIVA.PasswordChar = false;
            this.txtIVA.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIVA.PlaceholderText = "";
            this.txtIVA.Size = new System.Drawing.Size(507, 39);
            this.txtIVA.TabIndex = 147;
            this.txtIVA.Texts = "";
            this.txtIVA.UnderlinedStyle = false;
            this.txtIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIVA_KeyPress);
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.BackColor = System.Drawing.SystemColors.Window;
            this.txtCostoUnitario.BorderColor = System.Drawing.Color.Black;
            this.txtCostoUnitario.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.txtCostoUnitario.BorderRadius = 0;
            this.txtCostoUnitario.BorderSize = 2;
            this.txtCostoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoUnitario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCostoUnitario.Location = new System.Drawing.Point(564, 199);
            this.txtCostoUnitario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCostoUnitario.Multiline = false;
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtCostoUnitario.PasswordChar = false;
            this.txtCostoUnitario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCostoUnitario.PlaceholderText = "";
            this.txtCostoUnitario.Size = new System.Drawing.Size(507, 39);
            this.txtCostoUnitario.TabIndex = 146;
            this.txtCostoUnitario.Texts = "";
            this.txtCostoUnitario.UnderlinedStyle = false;
            this.txtCostoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcion.BorderColor = System.Drawing.Color.Black;
            this.txtDescripcion.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.txtDescripcion.BorderRadius = 0;
            this.txtDescripcion.BorderSize = 2;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescripcion.Location = new System.Drawing.Point(564, 139);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDescripcion.Multiline = false;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtDescripcion.PasswordChar = false;
            this.txtDescripcion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescripcion.PlaceholderText = "";
            this.txtDescripcion.Size = new System.Drawing.Size(507, 39);
            this.txtDescripcion.TabIndex = 145;
            this.txtDescripcion.Texts = "";
            this.txtDescripcion.UnderlinedStyle = false;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.SystemColors.Window;
            this.txtTipo.BorderColor = System.Drawing.Color.Black;
            this.txtTipo.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.txtTipo.BorderRadius = 0;
            this.txtTipo.BorderSize = 2;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipo.Location = new System.Drawing.Point(564, 78);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTipo.Multiline = false;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtTipo.PasswordChar = false;
            this.txtTipo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTipo.PlaceholderText = "";
            this.txtTipo.Size = new System.Drawing.Size(507, 39);
            this.txtTipo.TabIndex = 144;
            this.txtTipo.Texts = "";
            this.txtTipo.UnderlinedStyle = false;
            this.txtTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BorderColor = System.Drawing.Color.Black;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.txtNombre.BorderRadius = 0;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.Location = new System.Drawing.Point(564, 17);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.Size = new System.Drawing.Size(507, 39);
            this.txtNombre.TabIndex = 143;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = false;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lblGarantia
            // 
            this.lblGarantia.AutoSize = true;
            this.lblGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarantia.Location = new System.Drawing.Point(288, 403);
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
            this.lblCostoTotal.Location = new System.Drawing.Point(288, 333);
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
            this.lblIva.Location = new System.Drawing.Point(288, 266);
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
            this.lblCostoUnitario.Location = new System.Drawing.Point(288, 202);
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
            this.lblDescripcion.Location = new System.Drawing.Point(288, 142);
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
            this.lblTipo.Location = new System.Drawing.Point(288, 81);
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
            this.lblNombre.Location = new System.Drawing.Point(288, 20);
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
            this.txtBarraBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarraBusqueda_KeyPress);
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
            this.lblAgregarServicio.Size = new System.Drawing.Size(252, 39);
            this.lblAgregarServicio.TabIndex = 111;
            this.lblAgregarServicio.Text = "Editar Servicio";
            // 
            // lblCostoT
            // 
            this.lblCostoT.AutoSize = true;
            this.lblCostoT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoT.Location = new System.Drawing.Point(559, 333);
            this.lblCostoT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCostoT.Name = "lblCostoT";
            this.lblCostoT.Size = new System.Drawing.Size(124, 25);
            this.lblCostoT.TabIndex = 151;
            this.lblCostoT.Text = "Costo Total";
            // 
            // frmServiciosEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 838);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmServiciosEditar";
            this.Text = "frmServiciosEditar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlIngresoDatos.ResumeLayout(false);
            this.pnlIngresoDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAtras;
        private System.Windows.Forms.Label lblAgregarServicio;
        private FontAwesome.Sharp.IconButton btnEditar;
        private System.Windows.Forms.Panel pnlIngresoDatos;
        private RJCodeAdvance.RJControls.RJTextBox txtGarantia;
        private RJCodeAdvance.RJControls.RJTextBox txtIVA;
        private RJCodeAdvance.RJControls.RJTextBox txtCostoUnitario;
        private RJCodeAdvance.RJControls.RJTextBox txtDescripcion;
        private RJCodeAdvance.RJControls.RJTextBox txtTipo;
        private RJCodeAdvance.RJControls.RJTextBox txtNombre;
        private System.Windows.Forms.Label lblGarantia;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblCostoUnitario;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNombre;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private RJCodeAdvance.RJControls.RJTextBox txtBarraBusqueda;
        private System.Windows.Forms.Label lblRegistroNoEncontrado;
        private System.Windows.Forms.Label lblCostoT;
    }
}