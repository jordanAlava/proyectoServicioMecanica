namespace capaPresentacion
{
    partial class frmServicios
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
            this.components = new System.ComponentModel.Container();
            this.dtgvTabla = new System.Windows.Forms.DataGridView();
            this.idServicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreServicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.garantiaServicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDTallerMecanicoDataSet = new capaPresentacion.BDTallerMecanicoDataSet();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.servicioTableAdapter = new capaPresentacion.BDTallerMecanicoDataSetTableAdapters.ServicioTableAdapter();
            this.rjTextBox1 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjComboBox1 = new RJCodeAdvance.RJControls.RJComboBox();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTallerMecanicoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTabla
            // 
            this.dtgvTabla.AllowUserToAddRows = false;
            this.dtgvTabla.AllowUserToDeleteRows = false;
            this.dtgvTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvTabla.AutoGenerateColumns = false;
            this.dtgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServicioDataGridViewTextBoxColumn,
            this.nombreServicioDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.costoUnitarioDataGridViewTextBoxColumn,
            this.ivaDataGridViewTextBoxColumn,
            this.costoTotalDataGridViewTextBoxColumn,
            this.garantiaServicioDataGridViewTextBoxColumn});
            this.dtgvTabla.DataSource = this.servicioBindingSource;
            this.dtgvTabla.Location = new System.Drawing.Point(43, 202);
            this.dtgvTabla.Name = "dtgvTabla";
            this.dtgvTabla.ReadOnly = true;
            this.dtgvTabla.RowHeadersWidth = 51;
            this.dtgvTabla.Size = new System.Drawing.Size(680, 352);
            this.dtgvTabla.TabIndex = 1;
            // 
            // idServicioDataGridViewTextBoxColumn
            // 
            this.idServicioDataGridViewTextBoxColumn.DataPropertyName = "idServicio";
            this.idServicioDataGridViewTextBoxColumn.HeaderText = "id";
            this.idServicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idServicioDataGridViewTextBoxColumn.Name = "idServicioDataGridViewTextBoxColumn";
            this.idServicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idServicioDataGridViewTextBoxColumn.Width = 40;
            // 
            // nombreServicioDataGridViewTextBoxColumn
            // 
            this.nombreServicioDataGridViewTextBoxColumn.DataPropertyName = "nombreServicio";
            this.nombreServicioDataGridViewTextBoxColumn.HeaderText = "Servicio";
            this.nombreServicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreServicioDataGridViewTextBoxColumn.Name = "nombreServicioDataGridViewTextBoxColumn";
            this.nombreServicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreServicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // costoUnitarioDataGridViewTextBoxColumn
            // 
            this.costoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "costoUnitario";
            this.costoUnitarioDataGridViewTextBoxColumn.HeaderText = "Costo Unitario";
            this.costoUnitarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costoUnitarioDataGridViewTextBoxColumn.Name = "costoUnitarioDataGridViewTextBoxColumn";
            this.costoUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.costoUnitarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // ivaDataGridViewTextBoxColumn
            // 
            this.ivaDataGridViewTextBoxColumn.DataPropertyName = "iva";
            this.ivaDataGridViewTextBoxColumn.HeaderText = "Iva";
            this.ivaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ivaDataGridViewTextBoxColumn.Name = "ivaDataGridViewTextBoxColumn";
            this.ivaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ivaDataGridViewTextBoxColumn.Width = 40;
            // 
            // costoTotalDataGridViewTextBoxColumn
            // 
            this.costoTotalDataGridViewTextBoxColumn.DataPropertyName = "costoTotal";
            this.costoTotalDataGridViewTextBoxColumn.HeaderText = "Costo Total";
            this.costoTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costoTotalDataGridViewTextBoxColumn.Name = "costoTotalDataGridViewTextBoxColumn";
            this.costoTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.costoTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // garantiaServicioDataGridViewTextBoxColumn
            // 
            this.garantiaServicioDataGridViewTextBoxColumn.DataPropertyName = "garantiaServicio";
            this.garantiaServicioDataGridViewTextBoxColumn.HeaderText = "Garantia Servicio";
            this.garantiaServicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.garantiaServicioDataGridViewTextBoxColumn.Name = "garantiaServicioDataGridViewTextBoxColumn";
            this.garantiaServicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.garantiaServicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // servicioBindingSource
            // 
            this.servicioBindingSource.DataMember = "Servicio";
            this.servicioBindingSource.DataSource = this.bDTallerMecanicoDataSet;
            // 
            // bDTallerMecanicoDataSet
            // 
            this.bDTallerMecanicoDataSet.DataSetName = "BDTallerMecanicoDataSet";
            this.bDTallerMecanicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(36, 69);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(143, 37);
            this.lblTitulo.TabIndex = 83;
            this.lblTitulo.Text = "Servicios";
            // 
            // servicioTableAdapter
            // 
            this.servicioTableAdapter.ClearBeforeFill = true;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.Black;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.rjTextBox1.BorderRadius = 0;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(43, 145);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "Buscar";
            this.rjTextBox1.Size = new System.Drawing.Size(380, 31);
            this.rjTextBox1.TabIndex = 87;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox1.BorderColor = System.Drawing.Color.Black;
            this.rjComboBox1.BorderSize = 2;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rjComboBox1.ForeColor = System.Drawing.Color.Black;
            this.rjComboBox1.IconColor = System.Drawing.Color.White;
            this.rjComboBox1.Items.AddRange(new object[] {
            "op 1",
            "op 2",
            "op 3"});
            this.rjComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox1.ListTextColor = System.Drawing.Color.Black;
            this.rjComboBox1.Location = new System.Drawing.Point(430, 145);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBox1.Size = new System.Drawing.Size(200, 30);
            this.rjComboBox1.TabIndex = 88;
            this.rjComboBox1.Texts = "Filtrar por";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 36;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(742, 376);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(211, 47);
            this.btnEliminar.TabIndex = 86;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Black;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            this.btnEditar.IconColor = System.Drawing.Color.White;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 36;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(742, 288);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnEditar.Size = new System.Drawing.Size(211, 47);
            this.btnEditar.TabIndex = 85;
            this.btnEditar.Text = "E&ditar";
            this.btnEditar.UseVisualStyleBackColor = false;
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
            this.btnAgregar.Location = new System.Drawing.Point(742, 202);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(211, 47);
            this.btnAgregar.TabIndex = 84;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Black;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 24;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(637, 145);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(86, 30);
            this.iconButton1.TabIndex = 89;
            this.iconButton1.Text = "&Buscar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // frmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 681);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.rjComboBox1);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dtgvTabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmServicios";
            this.Text = "frmServicios";
            this.Load += new System.EventHandler(this.frmServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTallerMecanicoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvTabla;
        private System.Windows.Forms.Label lblTitulo;
        private BDTallerMecanicoDataSet bDTallerMecanicoDataSet;
        private System.Windows.Forms.BindingSource servicioBindingSource;
        private BDTallerMecanicoDataSetTableAdapters.ServicioTableAdapter servicioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn garantiaServicioDataGridViewTextBoxColumn;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox1;
        private RJCodeAdvance.RJControls.RJComboBox rjComboBox1;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}