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
            this.cmbBuscar = new RJCodeAdvance.RJControls.RJComboBox();
            this.pnlIngresoDatos = new System.Windows.Forms.Panel();
            this.btnCargarImagen = new FontAwesome.Sharp.IconButton();
            this.grpFoto = new System.Windows.Forms.GroupBox();
            this.pctrFoto = new System.Windows.Forms.PictureBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.txtCilindraje = new RJCodeAdvance.RJControls.RJTextBox();
            this.cmbxCombustible = new RJCodeAdvance.RJControls.RJComboBox();
            this.lblCombustible = new System.Windows.Forms.Label();
            this.lblCilindraje = new System.Windows.Forms.Label();
            this.cmbxSeguro = new RJCodeAdvance.RJControls.RJComboBox();
            this.txtColor = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.lblNoChasis = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblAnioFab = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnAtras = new FontAwesome.Sharp.IconButton();
            this.lblRegistroNoEncontrado = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.lblEditarVehiculo = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblPlacaValor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNumChasis = new System.Windows.Forms.Label();
            this.lblMarcaValor = new System.Windows.Forms.Label();
            this.lblModeloValor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlIngresoDatos.SuspendLayout();
            this.grpFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.cmbBuscar);
            this.panel1.Controls.Add(this.pnlIngresoDatos);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.lblEditarVehiculo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 838);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.BackColor = System.Drawing.Color.White;
            this.cmbBuscar.BorderColor = System.Drawing.Color.Black;
            this.cmbBuscar.BorderSize = 2;
            this.cmbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbBuscar.ForeColor = System.Drawing.Color.Black;
            this.cmbBuscar.IconColor = System.Drawing.Color.Black;
            this.cmbBuscar.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbBuscar.ListTextColor = System.Drawing.Color.Black;
            this.cmbBuscar.Location = new System.Drawing.Point(343, 142);
            this.cmbBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBuscar.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBuscar.Size = new System.Drawing.Size(320, 38);
            this.cmbBuscar.TabIndex = 174;
            this.cmbBuscar.Texts = "Seleccionar";
            // 
            // pnlIngresoDatos
            // 
            this.pnlIngresoDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlIngresoDatos.Controls.Add(this.lblModeloValor);
            this.pnlIngresoDatos.Controls.Add(this.lblMarcaValor);
            this.pnlIngresoDatos.Controls.Add(this.lblNumChasis);
            this.pnlIngresoDatos.Controls.Add(this.lblFecha);
            this.pnlIngresoDatos.Controls.Add(this.lblPlacaValor);
            this.pnlIngresoDatos.Controls.Add(this.btnCargarImagen);
            this.pnlIngresoDatos.Controls.Add(this.grpFoto);
            this.pnlIngresoDatos.Controls.Add(this.lblFoto);
            this.pnlIngresoDatos.Controls.Add(this.txtCilindraje);
            this.pnlIngresoDatos.Controls.Add(this.cmbxCombustible);
            this.pnlIngresoDatos.Controls.Add(this.lblCombustible);
            this.pnlIngresoDatos.Controls.Add(this.lblCilindraje);
            this.pnlIngresoDatos.Controls.Add(this.cmbxSeguro);
            this.pnlIngresoDatos.Controls.Add(this.txtColor);
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
            this.pnlIngresoDatos.Location = new System.Drawing.Point(0, 188);
            this.pnlIngresoDatos.Margin = new System.Windows.Forms.Padding(4);
            this.pnlIngresoDatos.Name = "pnlIngresoDatos";
            this.pnlIngresoDatos.Size = new System.Drawing.Size(1333, 646);
            this.pnlIngresoDatos.TabIndex = 140;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.BackColor = System.Drawing.Color.Silver;
            this.btnCargarImagen.FlatAppearance.BorderSize = 0;
            this.btnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarImagen.ForeColor = System.Drawing.Color.Black;
            this.btnCargarImagen.IconChar = FontAwesome.Sharp.IconChar.FileArchive;
            this.btnCargarImagen.IconColor = System.Drawing.Color.Black;
            this.btnCargarImagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarImagen.IconSize = 24;
            this.btnCargarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarImagen.Location = new System.Drawing.Point(1107, 321);
            this.btnCargarImagen.Margin = new System.Windows.Forms.Padding(5);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnCargarImagen.Size = new System.Drawing.Size(135, 36);
            this.btnCargarImagen.TabIndex = 173;
            this.btnCargarImagen.Text = "   &Cargar";
            this.btnCargarImagen.UseVisualStyleBackColor = false;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // grpFoto
            // 
            this.grpFoto.Controls.Add(this.pctrFoto);
            this.grpFoto.Location = new System.Drawing.Point(787, 48);
            this.grpFoto.Margin = new System.Windows.Forms.Padding(4);
            this.grpFoto.Name = "grpFoto";
            this.grpFoto.Padding = new System.Windows.Forms.Padding(4);
            this.grpFoto.Size = new System.Drawing.Size(455, 265);
            this.grpFoto.TabIndex = 172;
            this.grpFoto.TabStop = false;
            // 
            // pctrFoto
            // 
            this.pctrFoto.Location = new System.Drawing.Point(25, 22);
            this.pctrFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pctrFoto.Name = "pctrFoto";
            this.pctrFoto.Size = new System.Drawing.Size(403, 220);
            this.pctrFoto.TabIndex = 147;
            this.pctrFoto.TabStop = false;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(781, 20);
            this.lblFoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(55, 25);
            this.lblFoto.TabIndex = 171;
            this.lblFoto.Text = "Foto";
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
            this.txtCilindraje.Location = new System.Drawing.Point(343, 533);
            this.txtCilindraje.Margin = new System.Windows.Forms.Padding(5);
            this.txtCilindraje.Multiline = false;
            this.txtCilindraje.Name = "txtCilindraje";
            this.txtCilindraje.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtCilindraje.PasswordChar = false;
            this.txtCilindraje.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCilindraje.PlaceholderText = "";
            this.txtCilindraje.Size = new System.Drawing.Size(320, 39);
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
            "Gasolina Extra",
            "Gasolina Ecopaís",
            "Gasolina Súper",
            "Gasolina Eco Plus",
            "Diésel Premium"});
            this.cmbxCombustible.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxCombustible.ListTextColor = System.Drawing.Color.Black;
            this.cmbxCombustible.Location = new System.Drawing.Point(343, 465);
            this.cmbxCombustible.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxCombustible.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbxCombustible.Name = "cmbxCombustible";
            this.cmbxCombustible.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxCombustible.Size = new System.Drawing.Size(320, 38);
            this.cmbxCombustible.TabIndex = 169;
            this.cmbxCombustible.Texts = "Seleccionar";
            // 
            // lblCombustible
            // 
            this.lblCombustible.AutoSize = true;
            this.lblCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustible.Location = new System.Drawing.Point(74, 465);
            this.lblCombustible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCombustible.Name = "lblCombustible";
            this.lblCombustible.Size = new System.Drawing.Size(132, 25);
            this.lblCombustible.TabIndex = 168;
            this.lblCombustible.Text = "Combustible";
            // 
            // lblCilindraje
            // 
            this.lblCilindraje.AutoSize = true;
            this.lblCilindraje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCilindraje.Location = new System.Drawing.Point(74, 533);
            this.lblCilindraje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCilindraje.Name = "lblCilindraje";
            this.lblCilindraje.Size = new System.Drawing.Size(103, 25);
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
            this.cmbxSeguro.Location = new System.Drawing.Point(343, 396);
            this.cmbxSeguro.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxSeguro.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbxSeguro.Name = "cmbxSeguro";
            this.cmbxSeguro.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxSeguro.Size = new System.Drawing.Size(320, 38);
            this.cmbxSeguro.TabIndex = 166;
            this.cmbxSeguro.Texts = "Seleccionar";
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
            this.txtColor.Location = new System.Drawing.Point(343, 266);
            this.txtColor.Margin = new System.Windows.Forms.Padding(5);
            this.txtColor.Multiline = false;
            this.txtColor.Name = "txtColor";
            this.txtColor.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtColor.PasswordChar = false;
            this.txtColor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtColor.PlaceholderText = "";
            this.txtColor.Size = new System.Drawing.Size(320, 39);
            this.txtColor.TabIndex = 164;
            this.txtColor.Texts = "";
            this.txtColor.UnderlinedStyle = false;
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguro.Location = new System.Drawing.Point(74, 396);
            this.lblSeguro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(117, 25);
            this.lblSeguro.TabIndex = 159;
            this.lblSeguro.Text = "Asegurado";
            // 
            // lblNoChasis
            // 
            this.lblNoChasis.AutoSize = true;
            this.lblNoChasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoChasis.Location = new System.Drawing.Point(74, 332);
            this.lblNoChasis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoChasis.Name = "lblNoChasis";
            this.lblNoChasis.Size = new System.Drawing.Size(190, 25);
            this.lblNoChasis.TabIndex = 158;
            this.lblNoChasis.Text = "Número de Chasis";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(74, 266);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(64, 25);
            this.lblColor.TabIndex = 157;
            this.lblColor.Text = "Color";
            // 
            // lblAnioFab
            // 
            this.lblAnioFab.AutoSize = true;
            this.lblAnioFab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioFab.Location = new System.Drawing.Point(74, 202);
            this.lblAnioFab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnioFab.Name = "lblAnioFab";
            this.lblAnioFab.Size = new System.Drawing.Size(199, 25);
            this.lblAnioFab.TabIndex = 156;
            this.lblAnioFab.Text = "Año de Fabricación";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(74, 142);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(83, 25);
            this.lblModelo.TabIndex = 155;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(74, 80);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(72, 25);
            this.lblMarca.TabIndex = 154;
            this.lblMarca.Text = "Marca";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(74, 20);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(66, 25);
            this.lblPlaca.TabIndex = 153;
            this.lblPlaca.Text = "Placa";
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
            this.btnEditar.Location = new System.Drawing.Point(960, 517);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnEditar.Size = new System.Drawing.Size(281, 58);
            this.btnEditar.TabIndex = 136;
            this.btnEditar.Text = "&Confirmar Cambios";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnAtras.Location = new System.Drawing.Point(787, 523);
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
            this.lblRegistroNoEncontrado.Location = new System.Drawing.Point(535, 123);
            this.lblRegistroNoEncontrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistroNoEncontrado.Name = "lblRegistroNoEncontrado";
            this.lblRegistroNoEncontrado.Size = new System.Drawing.Size(215, 25);
            this.lblRegistroNoEncontrado.TabIndex = 150;
            this.lblRegistroNoEncontrado.Text = "Registro no Encontrado";
            this.lblRegistroNoEncontrado.Visible = false;
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
            this.btnBuscar.Location = new System.Drawing.Point(721, 143);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 37);
            this.btnBuscar.TabIndex = 139;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblEditarVehiculo
            // 
            this.lblEditarVehiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditarVehiculo.AutoSize = true;
            this.lblEditarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarVehiculo.ForeColor = System.Drawing.Color.Black;
            this.lblEditarVehiculo.Location = new System.Drawing.Point(89, 68);
            this.lblEditarVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditarVehiculo.Name = "lblEditarVehiculo";
            this.lblEditarVehiculo.Size = new System.Drawing.Size(262, 39);
            this.lblEditarVehiculo.TabIndex = 111;
            this.lblEditarVehiculo.Text = "Editar Vehículo";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblPlacaValor
            // 
            this.lblPlacaValor.AutoSize = true;
            this.lblPlacaValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaValor.Location = new System.Drawing.Point(338, 20);
            this.lblPlacaValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlacaValor.Name = "lblPlacaValor";
            this.lblPlacaValor.Size = new System.Drawing.Size(0, 25);
            this.lblPlacaValor.TabIndex = 174;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(338, 202);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 25);
            this.lblFecha.TabIndex = 175;
            // 
            // lblNumChasis
            // 
            this.lblNumChasis.AutoSize = true;
            this.lblNumChasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumChasis.Location = new System.Drawing.Point(338, 332);
            this.lblNumChasis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumChasis.Name = "lblNumChasis";
            this.lblNumChasis.Size = new System.Drawing.Size(0, 25);
            this.lblNumChasis.TabIndex = 176;
            // 
            // lblMarcaValor
            // 
            this.lblMarcaValor.AutoSize = true;
            this.lblMarcaValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaValor.Location = new System.Drawing.Point(338, 80);
            this.lblMarcaValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarcaValor.Name = "lblMarcaValor";
            this.lblMarcaValor.Size = new System.Drawing.Size(0, 25);
            this.lblMarcaValor.TabIndex = 177;
            // 
            // lblModeloValor
            // 
            this.lblModeloValor.AutoSize = true;
            this.lblModeloValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeloValor.Location = new System.Drawing.Point(338, 142);
            this.lblModeloValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModeloValor.Name = "lblModeloValor";
            this.lblModeloValor.Size = new System.Drawing.Size(0, 25);
            this.lblModeloValor.TabIndex = 178;
            // 
            // frmVehiculosEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 838);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label lblEditarVehiculo;
        private System.Windows.Forms.GroupBox grpFoto;
        private System.Windows.Forms.PictureBox pctrFoto;
        private System.Windows.Forms.Label lblFoto;
        private RJCodeAdvance.RJControls.RJTextBox txtCilindraje;
        private RJCodeAdvance.RJControls.RJComboBox cmbxCombustible;
        private System.Windows.Forms.Label lblCombustible;
        private System.Windows.Forms.Label lblCilindraje;
        private RJCodeAdvance.RJControls.RJComboBox cmbxSeguro;
        private RJCodeAdvance.RJControls.RJTextBox txtColor;
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
        private FontAwesome.Sharp.IconButton btnCargarImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private RJCodeAdvance.RJControls.RJComboBox cmbBuscar;
        private System.Windows.Forms.Label lblNumChasis;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblPlacaValor;
        private System.Windows.Forms.Label lblModeloValor;
        private System.Windows.Forms.Label lblMarcaValor;
    }
}