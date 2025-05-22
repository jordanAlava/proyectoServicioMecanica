namespace capaPresentacion.cliente
{
    partial class frmVehiculosAgregar
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
            this.btnCargarImagen = new FontAwesome.Sharp.IconButton();
            this.grpFoto = new System.Windows.Forms.GroupBox();
            this.pctrFoto = new System.Windows.Forms.PictureBox();
            this.lblFoto = new System.Windows.Forms.Label();
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
            this.btnAtras = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.lblAgregarVehiculo = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.grpFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnCargarImagen);
            this.panel1.Controls.Add(this.grpFoto);
            this.panel1.Controls.Add(this.lblFoto);
            this.panel1.Controls.Add(this.txtCilindraje);
            this.panel1.Controls.Add(this.cmbxCombustible);
            this.panel1.Controls.Add(this.lblCombustible);
            this.panel1.Controls.Add(this.lblCilindraje);
            this.panel1.Controls.Add(this.cmbxSeguro);
            this.panel1.Controls.Add(this.txtNoChasis);
            this.panel1.Controls.Add(this.txtColor);
            this.panel1.Controls.Add(this.txtAnioFab);
            this.panel1.Controls.Add(this.txtModelo);
            this.panel1.Controls.Add(this.txtMarca);
            this.panel1.Controls.Add(this.txtPlaca);
            this.panel1.Controls.Add(this.lblSeguro);
            this.panel1.Controls.Add(this.lblNoChasis);
            this.panel1.Controls.Add(this.lblColor);
            this.panel1.Controls.Add(this.lblAnioFab);
            this.panel1.Controls.Add(this.lblModelo);
            this.panel1.Controls.Add(this.lblMarca);
            this.panel1.Controls.Add(this.lblPlaca);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.lblAgregarVehiculo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 838);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btnCargarImagen.Location = new System.Drawing.Point(1107, 478);
            this.btnCargarImagen.Margin = new System.Windows.Forms.Padding(5);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnCargarImagen.Size = new System.Drawing.Size(135, 36);
            this.btnCargarImagen.TabIndex = 147;
            this.btnCargarImagen.Text = "   &Cargar";
            this.btnCargarImagen.UseVisualStyleBackColor = false;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // grpFoto
            // 
            this.grpFoto.Controls.Add(this.pctrFoto);
            this.grpFoto.Location = new System.Drawing.Point(787, 204);
            this.grpFoto.Margin = new System.Windows.Forms.Padding(4);
            this.grpFoto.Name = "grpFoto";
            this.grpFoto.Padding = new System.Windows.Forms.Padding(4);
            this.grpFoto.Size = new System.Drawing.Size(455, 265);
            this.grpFoto.TabIndex = 146;
            this.grpFoto.TabStop = false;
            // 
            // pctrFoto
            // 
            this.pctrFoto.Location = new System.Drawing.Point(25, 22);
            this.pctrFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pctrFoto.Name = "pctrFoto";
            this.pctrFoto.Size = new System.Drawing.Size(403, 220);
            this.pctrFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrFoto.TabIndex = 147;
            this.pctrFoto.TabStop = false;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(781, 176);
            this.lblFoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(55, 25);
            this.lblFoto.TabIndex = 145;
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
            this.txtCilindraje.Location = new System.Drawing.Point(343, 689);
            this.txtCilindraje.Margin = new System.Windows.Forms.Padding(5);
            this.txtCilindraje.Multiline = false;
            this.txtCilindraje.Name = "txtCilindraje";
            this.txtCilindraje.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtCilindraje.PasswordChar = false;
            this.txtCilindraje.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCilindraje.PlaceholderText = "";
            this.txtCilindraje.Size = new System.Drawing.Size(320, 39);
            this.txtCilindraje.TabIndex = 143;
            this.txtCilindraje.Texts = "";
            this.txtCilindraje.UnderlinedStyle = false;
            this.txtCilindraje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCilindraje_KeyPress);
            // 
            // cmbxCombustible
            // 
            this.cmbxCombustible.BackColor = System.Drawing.Color.White;
            this.cmbxCombustible.BorderColor = System.Drawing.Color.Black;
            this.cmbxCombustible.BorderSize = 2;
            this.cmbxCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbxCombustible.Location = new System.Drawing.Point(343, 622);
            this.cmbxCombustible.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxCombustible.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbxCombustible.Name = "cmbxCombustible";
            this.cmbxCombustible.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxCombustible.Size = new System.Drawing.Size(320, 38);
            this.cmbxCombustible.TabIndex = 142;
            this.cmbxCombustible.Texts = "Seleccionar";
            // 
            // lblCombustible
            // 
            this.lblCombustible.AutoSize = true;
            this.lblCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustible.Location = new System.Drawing.Point(93, 622);
            this.lblCombustible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCombustible.Name = "lblCombustible";
            this.lblCombustible.Size = new System.Drawing.Size(132, 25);
            this.lblCombustible.TabIndex = 140;
            this.lblCombustible.Text = "Combustible";
            // 
            // lblCilindraje
            // 
            this.lblCilindraje.AutoSize = true;
            this.lblCilindraje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCilindraje.Location = new System.Drawing.Point(93, 689);
            this.lblCilindraje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCilindraje.Name = "lblCilindraje";
            this.lblCilindraje.Size = new System.Drawing.Size(103, 25);
            this.lblCilindraje.TabIndex = 139;
            this.lblCilindraje.Text = "Cilindraje";
            // 
            // cmbxSeguro
            // 
            this.cmbxSeguro.BackColor = System.Drawing.Color.White;
            this.cmbxSeguro.BorderColor = System.Drawing.Color.Black;
            this.cmbxSeguro.BorderSize = 2;
            this.cmbxSeguro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbxSeguro.ForeColor = System.Drawing.Color.Black;
            this.cmbxSeguro.IconColor = System.Drawing.Color.Black;
            this.cmbxSeguro.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbxSeguro.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxSeguro.ListTextColor = System.Drawing.Color.Black;
            this.cmbxSeguro.Location = new System.Drawing.Point(343, 553);
            this.cmbxSeguro.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxSeguro.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbxSeguro.Name = "cmbxSeguro";
            this.cmbxSeguro.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxSeguro.Size = new System.Drawing.Size(320, 38);
            this.cmbxSeguro.TabIndex = 135;
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
            this.txtNoChasis.Location = new System.Drawing.Point(343, 489);
            this.txtNoChasis.Margin = new System.Windows.Forms.Padding(5);
            this.txtNoChasis.Multiline = false;
            this.txtNoChasis.Name = "txtNoChasis";
            this.txtNoChasis.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtNoChasis.PasswordChar = false;
            this.txtNoChasis.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNoChasis.PlaceholderText = "";
            this.txtNoChasis.Size = new System.Drawing.Size(320, 39);
            this.txtNoChasis.TabIndex = 134;
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
            this.txtColor.Location = new System.Drawing.Point(343, 422);
            this.txtColor.Margin = new System.Windows.Forms.Padding(5);
            this.txtColor.Multiline = false;
            this.txtColor.Name = "txtColor";
            this.txtColor.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtColor.PasswordChar = false;
            this.txtColor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtColor.PlaceholderText = "";
            this.txtColor.Size = new System.Drawing.Size(320, 39);
            this.txtColor.TabIndex = 133;
            this.txtColor.Texts = "";
            this.txtColor.UnderlinedStyle = false;
            this.txtColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColor_KeyPress);
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
            this.txtAnioFab.Location = new System.Drawing.Point(343, 358);
            this.txtAnioFab.Margin = new System.Windows.Forms.Padding(5);
            this.txtAnioFab.Multiline = false;
            this.txtAnioFab.Name = "txtAnioFab";
            this.txtAnioFab.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtAnioFab.PasswordChar = false;
            this.txtAnioFab.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAnioFab.PlaceholderText = "";
            this.txtAnioFab.Size = new System.Drawing.Size(320, 39);
            this.txtAnioFab.TabIndex = 132;
            this.txtAnioFab.Texts = "";
            this.txtAnioFab.UnderlinedStyle = false;
            this.txtAnioFab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnioFab_KeyPress);
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
            this.txtModelo.Location = new System.Drawing.Point(343, 298);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(5);
            this.txtModelo.Multiline = false;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtModelo.PasswordChar = false;
            this.txtModelo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtModelo.PlaceholderText = "";
            this.txtModelo.Size = new System.Drawing.Size(320, 39);
            this.txtModelo.TabIndex = 131;
            this.txtModelo.Texts = "";
            this.txtModelo.UnderlinedStyle = false;
            this.txtModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModelo_KeyPress);
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
            this.txtMarca.Location = new System.Drawing.Point(343, 236);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(5);
            this.txtMarca.Multiline = false;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtMarca.PasswordChar = false;
            this.txtMarca.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMarca.PlaceholderText = "";
            this.txtMarca.Size = new System.Drawing.Size(320, 39);
            this.txtMarca.TabIndex = 130;
            this.txtMarca.Texts = "";
            this.txtMarca.UnderlinedStyle = false;
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarca_KeyPress);
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
            this.txtPlaca.Location = new System.Drawing.Point(343, 176);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(5);
            this.txtPlaca.Multiline = false;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtPlaca.PasswordChar = false;
            this.txtPlaca.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPlaca.PlaceholderText = "";
            this.txtPlaca.Size = new System.Drawing.Size(320, 39);
            this.txtPlaca.TabIndex = 129;
            this.txtPlaca.Texts = "";
            this.txtPlaca.UnderlinedStyle = false;
            this.txtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguro.Location = new System.Drawing.Point(93, 553);
            this.lblSeguro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(117, 25);
            this.lblSeguro.TabIndex = 128;
            this.lblSeguro.Text = "Asegurado";
            // 
            // lblNoChasis
            // 
            this.lblNoChasis.AutoSize = true;
            this.lblNoChasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoChasis.Location = new System.Drawing.Point(93, 489);
            this.lblNoChasis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoChasis.Name = "lblNoChasis";
            this.lblNoChasis.Size = new System.Drawing.Size(190, 25);
            this.lblNoChasis.TabIndex = 124;
            this.lblNoChasis.Text = "Número de Chasis";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(93, 422);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(64, 25);
            this.lblColor.TabIndex = 123;
            this.lblColor.Text = "Color";
            // 
            // lblAnioFab
            // 
            this.lblAnioFab.AutoSize = true;
            this.lblAnioFab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioFab.Location = new System.Drawing.Point(93, 358);
            this.lblAnioFab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnioFab.Name = "lblAnioFab";
            this.lblAnioFab.Size = new System.Drawing.Size(199, 25);
            this.lblAnioFab.TabIndex = 122;
            this.lblAnioFab.Text = "Año de Fabricación";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(93, 298);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(83, 25);
            this.lblModelo.TabIndex = 121;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(93, 236);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(72, 25);
            this.lblMarca.TabIndex = 120;
            this.lblMarca.Text = "Marca";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(93, 176);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(66, 25);
            this.lblPlaca.TabIndex = 119;
            this.lblPlaca.Text = "Placa";
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
            this.btnAtras.Location = new System.Drawing.Point(787, 698);
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
            this.btnAgregar.Location = new System.Drawing.Point(960, 689);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(281, 58);
            this.btnAgregar.TabIndex = 117;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblAgregarVehiculo
            // 
            this.lblAgregarVehiculo.AutoSize = true;
            this.lblAgregarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarVehiculo.ForeColor = System.Drawing.Color.Black;
            this.lblAgregarVehiculo.Location = new System.Drawing.Point(89, 68);
            this.lblAgregarVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgregarVehiculo.Name = "lblAgregarVehiculo";
            this.lblAgregarVehiculo.Size = new System.Drawing.Size(295, 39);
            this.lblAgregarVehiculo.TabIndex = 111;
            this.lblAgregarVehiculo.Text = "Agregar Vehículo";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmVehiculosAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 838);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVehiculosAgregar";
            this.Text = "frmVehiculosAgregar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
        private FontAwesome.Sharp.IconButton btnAtras;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.Label lblAgregarVehiculo;
        private System.Windows.Forms.Label lblCombustible;
        private System.Windows.Forms.Label lblCilindraje;
        private RJCodeAdvance.RJControls.RJComboBox cmbxSeguro;
        private RJCodeAdvance.RJControls.RJTextBox txtCilindraje;
        private RJCodeAdvance.RJControls.RJComboBox cmbxCombustible;
        private System.Windows.Forms.GroupBox grpFoto;
        private System.Windows.Forms.PictureBox pctrFoto;
        private System.Windows.Forms.Label lblFoto;
        private FontAwesome.Sharp.IconButton btnCargarImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}