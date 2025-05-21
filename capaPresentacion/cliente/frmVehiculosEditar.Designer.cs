namespace capaPresentacion.cliente
{
    partial class frmVehiculosEditar
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
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBarraBusqueda = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblAgregarVehiculo = new System.Windows.Forms.Label();
            this.lblRegistroNoEncontrado = new System.Windows.Forms.Label();
            this.btnAtras = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.grpFoto = new System.Windows.Forms.GroupBox();
            this.pctrFoto = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCilindraje = new RJCodeAdvance.RJControls.RJTextBox();
            this.cmbxCombustible = new RJCodeAdvance.RJControls.RJComboBox();
            this.lblCombustible = new System.Windows.Forms.Label();
            this.lblCilindraje = new System.Windows.Forms.Label();
            this.cmbxSeguro = new RJCodeAdvance.RJControls.RJComboBox();
            this.txtNoChasis = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtColor = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtAnioFab = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtModelo = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtMarca = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtPlaca = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.lblNoChasis = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblAnioFab = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.pnlIngresoDatos.SuspendLayout();
            this.grpFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.pnlIngresoDatos);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtBarraBusqueda);
            this.panel1.Controls.Add(this.lblAgregarVehiculo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 681);
            this.panel1.TabIndex = 2;
            // 
            // pnlIngresoDatos
            // 
            this.pnlIngresoDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlIngresoDatos.Controls.Add(this.iconButton1);
            this.pnlIngresoDatos.Controls.Add(this.grpFoto);
            this.pnlIngresoDatos.Controls.Add(this.label3);
            this.pnlIngresoDatos.Controls.Add(this.txtCilindraje);
            this.pnlIngresoDatos.Controls.Add(this.cmbxCombustible);
            this.pnlIngresoDatos.Controls.Add(this.lblCombustible);
            this.pnlIngresoDatos.Controls.Add(this.lblCilindraje);
            this.pnlIngresoDatos.Controls.Add(this.cmbxSeguro);
            this.pnlIngresoDatos.Controls.Add(this.txtNoChasis);
            this.pnlIngresoDatos.Controls.Add(this.txtColor);
            this.pnlIngresoDatos.Controls.Add(this.txtAnioFab);
            this.pnlIngresoDatos.Controls.Add(this.txtModelo);
            this.pnlIngresoDatos.Controls.Add(this.txtMarca);
            this.pnlIngresoDatos.Controls.Add(this.txtPlaca);
            this.pnlIngresoDatos.Controls.Add(this.lblSeguro);
            this.pnlIngresoDatos.Controls.Add(this.lblNoChasis);
            this.pnlIngresoDatos.Controls.Add(this.lblColor);
            this.pnlIngresoDatos.Controls.Add(this.lblAnioFab);
            this.pnlIngresoDatos.Controls.Add(this.lblModelo);
            this.pnlIngresoDatos.Controls.Add(this.lblMarca);
            this.pnlIngresoDatos.Controls.Add(this.lblPlaca);
            this.pnlIngresoDatos.Controls.Add(this.btnEditar);
            this.pnlIngresoDatos.Controls.Add(this.btnAtras);
            this.pnlIngresoDatos.Controls.Add(this.lblRegistroNoEncontrado);
            this.pnlIngresoDatos.Location = new System.Drawing.Point(0, 153);
            this.pnlIngresoDatos.Name = "pnlIngresoDatos";
            this.pnlIngresoDatos.Size = new System.Drawing.Size(1000, 525);
            this.pnlIngresoDatos.TabIndex = 140;
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
            this.btnBuscar.Location = new System.Drawing.Point(705, 116);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 30);
            this.btnBuscar.TabIndex = 139;
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
            this.txtBarraBusqueda.Location = new System.Drawing.Point(212, 115);
            this.txtBarraBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarraBusqueda.Multiline = false;
            this.txtBarraBusqueda.Name = "txtBarraBusqueda";
            this.txtBarraBusqueda.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBarraBusqueda.PasswordChar = false;
            this.txtBarraBusqueda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBarraBusqueda.PlaceholderText = "Buscar por ID";
            this.txtBarraBusqueda.Size = new System.Drawing.Size(485, 31);
            this.txtBarraBusqueda.TabIndex = 137;
            this.txtBarraBusqueda.Texts = "";
            this.txtBarraBusqueda.UnderlinedStyle = false;
            // 
            // lblAgregarVehiculo
            // 
            this.lblAgregarVehiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgregarVehiculo.AutoSize = true;
            this.lblAgregarVehiculo.Font = new System.Drawing.Font("Montserrat Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarVehiculo.ForeColor = System.Drawing.Color.Black;
            this.lblAgregarVehiculo.Location = new System.Drawing.Point(67, 55);
            this.lblAgregarVehiculo.Name = "lblAgregarVehiculo";
            this.lblAgregarVehiculo.Size = new System.Drawing.Size(241, 37);
            this.lblAgregarVehiculo.TabIndex = 111;
            this.lblAgregarVehiculo.Text = "Editar Vehículo";
            // 
            // lblRegistroNoEncontrado
            // 
            this.lblRegistroNoEncontrado.AutoSize = true;
            this.lblRegistroNoEncontrado.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroNoEncontrado.Location = new System.Drawing.Point(401, 100);
            this.lblRegistroNoEncontrado.Name = "lblRegistroNoEncontrado";
            this.lblRegistroNoEncontrado.Size = new System.Drawing.Size(202, 22);
            this.lblRegistroNoEncontrado.TabIndex = 150;
            this.lblRegistroNoEncontrado.Text = "Registro no Encontrado";
            this.lblRegistroNoEncontrado.Visible = false;
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
            this.btnAtras.Location = new System.Drawing.Point(590, 425);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(72, 38);
            this.btnAtras.TabIndex = 118;
            this.btnAtras.Text = "&Atrás";
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.UseVisualStyleBackColor = false;
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
            this.btnEditar.Location = new System.Drawing.Point(720, 420);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEditar.Size = new System.Drawing.Size(211, 47);
            this.btnEditar.TabIndex = 136;
            this.btnEditar.Text = "&Confirmar Cambios";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // grpFoto
            // 
            this.grpFoto.Controls.Add(this.pctrFoto);
            this.grpFoto.Location = new System.Drawing.Point(590, 39);
            this.grpFoto.Name = "grpFoto";
            this.grpFoto.Size = new System.Drawing.Size(341, 215);
            this.grpFoto.TabIndex = 172;
            this.grpFoto.TabStop = false;
            // 
            // pctrFoto
            // 
            this.pctrFoto.Location = new System.Drawing.Point(19, 18);
            this.pctrFoto.Name = "pctrFoto";
            this.pctrFoto.Size = new System.Drawing.Size(302, 179);
            this.pctrFoto.TabIndex = 147;
            this.pctrFoto.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(586, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 171;
            this.label3.Text = "Foto";
            // 
            // txtCilindraje
            // 
            this.txtCilindraje.BackColor = System.Drawing.SystemColors.Window;
            this.txtCilindraje.BorderColor = System.Drawing.Color.Black;
            this.txtCilindraje.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.txtCilindraje.BorderRadius = 0;
            this.txtCilindraje.BorderSize = 2;
            this.txtCilindraje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCilindraje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCilindraje.Location = new System.Drawing.Point(257, 433);
            this.txtCilindraje.Margin = new System.Windows.Forms.Padding(4);
            this.txtCilindraje.Multiline = false;
            this.txtCilindraje.Name = "txtCilindraje";
            this.txtCilindraje.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCilindraje.PasswordChar = false;
            this.txtCilindraje.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCilindraje.PlaceholderText = "";
            this.txtCilindraje.Size = new System.Drawing.Size(240, 31);
            this.txtCilindraje.TabIndex = 170;
            this.txtCilindraje.Texts = "";
            this.txtCilindraje.UnderlinedStyle = false;
            // 
            // cmbxCombustible
            // 
            this.cmbxCombustible.BackColor = System.Drawing.Color.White;
            this.cmbxCombustible.BorderColor = System.Drawing.Color.Black;
            this.cmbxCombustible.BorderSize = 2;
            this.cmbxCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbxCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbxCombustible.ForeColor = System.Drawing.Color.Black;
            this.cmbxCombustible.IconColor = System.Drawing.Color.Black;
            this.cmbxCombustible.Items.AddRange(new object[] {
            "Gasolina Extra: 85 octanos. ",
            "",
            "",
            "Gasolina Ecopaís: 85 octanos.",
            "Gasolina Súper: 92 octanos.",
            "Gasolina Eco Plus: 89 octanos.",
            "",
            "",
            "Diésel Premium."});
            this.cmbxCombustible.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxCombustible.ListTextColor = System.Drawing.Color.Black;
            this.cmbxCombustible.Location = new System.Drawing.Point(257, 378);
            this.cmbxCombustible.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbxCombustible.Name = "cmbxCombustible";
            this.cmbxCombustible.Padding = new System.Windows.Forms.Padding(2);
            this.cmbxCombustible.Size = new System.Drawing.Size(240, 31);
            this.cmbxCombustible.TabIndex = 169;
            this.cmbxCombustible.Texts = "Seleccionar";
            // 
            // lblCombustible
            // 
            this.lblCombustible.AutoSize = true;
            this.lblCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustible.Location = new System.Drawing.Point(70, 378);
            this.lblCombustible.Name = "lblCombustible";
            this.lblCombustible.Size = new System.Drawing.Size(108, 20);
            this.lblCombustible.TabIndex = 168;
            this.lblCombustible.Text = "Combustible";
            // 
            // lblCilindraje
            // 
            this.lblCilindraje.AutoSize = true;
            this.lblCilindraje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCilindraje.Location = new System.Drawing.Point(70, 433);
            this.lblCilindraje.Name = "lblCilindraje";
            this.lblCilindraje.Size = new System.Drawing.Size(83, 20);
            this.lblCilindraje.TabIndex = 167;
            this.lblCilindraje.Text = "Cilindraje";
            // 
            // cmbxSeguro
            // 
            this.cmbxSeguro.BackColor = System.Drawing.Color.White;
            this.cmbxSeguro.BorderColor = System.Drawing.Color.Black;
            this.cmbxSeguro.BorderSize = 2;
            this.cmbxSeguro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbxSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbxSeguro.ForeColor = System.Drawing.Color.Black;
            this.cmbxSeguro.IconColor = System.Drawing.Color.Black;
            this.cmbxSeguro.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbxSeguro.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxSeguro.ListTextColor = System.Drawing.Color.Black;
            this.cmbxSeguro.Location = new System.Drawing.Point(257, 322);
            this.cmbxSeguro.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbxSeguro.Name = "cmbxSeguro";
            this.cmbxSeguro.Padding = new System.Windows.Forms.Padding(2);
            this.cmbxSeguro.Size = new System.Drawing.Size(240, 31);
            this.cmbxSeguro.TabIndex = 166;
            this.cmbxSeguro.Texts = "Seleccionar";
            // 
            // txtNoChasis
            // 
            this.txtNoChasis.BackColor = System.Drawing.SystemColors.Window;
            this.txtNoChasis.BorderColor = System.Drawing.Color.Black;
            this.txtNoChasis.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.txtNoChasis.BorderRadius = 0;
            this.txtNoChasis.BorderSize = 2;
            this.txtNoChasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoChasis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNoChasis.Location = new System.Drawing.Point(257, 270);
            this.txtNoChasis.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoChasis.Multiline = false;
            this.txtNoChasis.Name = "txtNoChasis";
            this.txtNoChasis.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNoChasis.PasswordChar = false;
            this.txtNoChasis.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNoChasis.PlaceholderText = "";
            this.txtNoChasis.Size = new System.Drawing.Size(240, 31);
            this.txtNoChasis.TabIndex = 165;
            this.txtNoChasis.Texts = "";
            this.txtNoChasis.UnderlinedStyle = false;
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.SystemColors.Window;
            this.txtColor.BorderColor = System.Drawing.Color.Black;
            this.txtColor.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.txtColor.BorderRadius = 0;
            this.txtColor.BorderSize = 2;
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtColor.Location = new System.Drawing.Point(257, 216);
            this.txtColor.Margin = new System.Windows.Forms.Padding(4);
            this.txtColor.Multiline = false;
            this.txtColor.Name = "txtColor";
            this.txtColor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtColor.PasswordChar = false;
            this.txtColor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtColor.PlaceholderText = "";
            this.txtColor.Size = new System.Drawing.Size(240, 31);
            this.txtColor.TabIndex = 164;
            this.txtColor.Texts = "";
            this.txtColor.UnderlinedStyle = false;
            // 
            // txtAnioFab
            // 
            this.txtAnioFab.BackColor = System.Drawing.SystemColors.Window;
            this.txtAnioFab.BorderColor = System.Drawing.Color.Black;
            this.txtAnioFab.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.txtAnioFab.BorderRadius = 0;
            this.txtAnioFab.BorderSize = 2;
            this.txtAnioFab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnioFab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAnioFab.Location = new System.Drawing.Point(257, 164);
            this.txtAnioFab.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnioFab.Multiline = false;
            this.txtAnioFab.Name = "txtAnioFab";
            this.txtAnioFab.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAnioFab.PasswordChar = false;
            this.txtAnioFab.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAnioFab.PlaceholderText = "";
            this.txtAnioFab.Size = new System.Drawing.Size(240, 31);
            this.txtAnioFab.TabIndex = 163;
            this.txtAnioFab.Texts = "";
            this.txtAnioFab.UnderlinedStyle = false;
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.SystemColors.Window;
            this.txtModelo.BorderColor = System.Drawing.Color.Black;
            this.txtModelo.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.txtModelo.BorderRadius = 0;
            this.txtModelo.BorderSize = 2;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtModelo.Location = new System.Drawing.Point(257, 115);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelo.Multiline = false;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtModelo.PasswordChar = false;
            this.txtModelo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtModelo.PlaceholderText = "";
            this.txtModelo.Size = new System.Drawing.Size(240, 31);
            this.txtModelo.TabIndex = 162;
            this.txtModelo.Texts = "";
            this.txtModelo.UnderlinedStyle = false;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.SystemColors.Window;
            this.txtMarca.BorderColor = System.Drawing.Color.Black;
            this.txtMarca.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.txtMarca.BorderRadius = 0;
            this.txtMarca.BorderSize = 2;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMarca.Location = new System.Drawing.Point(257, 65);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Multiline = false;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMarca.PasswordChar = false;
            this.txtMarca.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMarca.PlaceholderText = "";
            this.txtMarca.Size = new System.Drawing.Size(240, 31);
            this.txtMarca.TabIndex = 161;
            this.txtMarca.Texts = "";
            this.txtMarca.UnderlinedStyle = false;
            // 
            // txtPlaca
            // 
            this.txtPlaca.BackColor = System.Drawing.SystemColors.Window;
            this.txtPlaca.BorderColor = System.Drawing.Color.Black;
            this.txtPlaca.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.txtPlaca.BorderRadius = 0;
            this.txtPlaca.BorderSize = 2;
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPlaca.Location = new System.Drawing.Point(257, 16);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlaca.Multiline = false;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPlaca.PasswordChar = false;
            this.txtPlaca.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPlaca.PlaceholderText = "";
            this.txtPlaca.Size = new System.Drawing.Size(240, 31);
            this.txtPlaca.TabIndex = 160;
            this.txtPlaca.Texts = "";
            this.txtPlaca.UnderlinedStyle = false;
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguro.Location = new System.Drawing.Point(70, 322);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(96, 20);
            this.lblSeguro.TabIndex = 159;
            this.lblSeguro.Text = "Asegurado";
            // 
            // lblNoChasis
            // 
            this.lblNoChasis.AutoSize = true;
            this.lblNoChasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoChasis.Location = new System.Drawing.Point(70, 270);
            this.lblNoChasis.Name = "lblNoChasis";
            this.lblNoChasis.Size = new System.Drawing.Size(155, 20);
            this.lblNoChasis.TabIndex = 158;
            this.lblNoChasis.Text = "Número de Chasis";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(70, 216);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(51, 20);
            this.lblColor.TabIndex = 157;
            this.lblColor.Text = "Color";
            // 
            // lblAnioFab
            // 
            this.lblAnioFab.AutoSize = true;
            this.lblAnioFab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioFab.Location = new System.Drawing.Point(70, 164);
            this.lblAnioFab.Name = "lblAnioFab";
            this.lblAnioFab.Size = new System.Drawing.Size(164, 20);
            this.lblAnioFab.TabIndex = 156;
            this.lblAnioFab.Text = "Año de Fabricación";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(70, 115);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(67, 20);
            this.lblModelo.TabIndex = 155;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(70, 65);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(58, 20);
            this.lblMarca.TabIndex = 154;
            this.lblMarca.Text = "Marca";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(70, 16);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(53, 20);
            this.lblPlaca.TabIndex = 153;
            this.lblPlaca.Text = "Placa";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Silver;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileArchive;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 24;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(830, 261);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(101, 29);
            this.iconButton1.TabIndex = 173;
            this.iconButton1.Text = "   &Cargar";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // frmVehiculosEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 681);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVehiculosEditar";
            this.Text = "frmVehiculosEditar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlIngresoDatos.ResumeLayout(false);
            this.pnlIngresoDatos.PerformLayout();
            this.grpFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlIngresoDatos;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private RJCodeAdvance.RJControls.RJTextBox txtBarraBusqueda;
        private System.Windows.Forms.Label lblAgregarVehiculo;
        private System.Windows.Forms.GroupBox grpFoto;
        private System.Windows.Forms.PictureBox pctrFoto;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJTextBox txtCilindraje;
        private RJCodeAdvance.RJControls.RJComboBox cmbxCombustible;
        private System.Windows.Forms.Label lblCombustible;
        private System.Windows.Forms.Label lblCilindraje;
        private RJCodeAdvance.RJControls.RJComboBox cmbxSeguro;
        private RJCodeAdvance.RJControls.RJTextBox txtNoChasis;
        private RJCodeAdvance.RJControls.RJTextBox txtColor;
        private RJCodeAdvance.RJControls.RJTextBox txtAnioFab;
        private RJCodeAdvance.RJControls.RJTextBox txtModelo;
        private RJCodeAdvance.RJControls.RJTextBox txtMarca;
        private RJCodeAdvance.RJControls.RJTextBox txtPlaca;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.Label lblNoChasis;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblAnioFab;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPlaca;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAtras;
        private System.Windows.Forms.Label lblRegistroNoEncontrado;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}