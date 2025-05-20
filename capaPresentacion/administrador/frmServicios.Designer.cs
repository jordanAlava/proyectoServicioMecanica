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
            this.servicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDTallerMecanicoDataSet = new capaPresentacion.BDTallerMecanicoDataSet();
            this.servicioTableAdapter = new capaPresentacion.BDTallerMecanicoDataSetTableAdapters.ServicioTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.cmbxFiltroBusqueda = new RJCodeAdvance.RJControls.RJComboBox();
            this.txtBarraBusqueda = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtgvTabla = new System.Windows.Forms.DataGridView();
            this.fKServicioidSer6754599EBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicio_RepuestoTableAdapter = new capaPresentacion.BDTallerMecanicoDataSetTableAdapters.Servicio_RepuestoTableAdapter();
            this.fKServicioidSer6754599EBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idServicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRepuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInstalacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCambioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTallerMecanicoDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKServicioidSer6754599EBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKServicioidSer6754599EBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // servicioTableAdapter
            // 
            this.servicioTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.cmbxFiltroBusqueda);
            this.panel1.Controls.Add(this.txtBarraBusqueda);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.dtgvTabla);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 681);
            this.panel1.TabIndex = 0;
            // 
            // btnBuscar
            // 
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
            this.btnBuscar.Location = new System.Drawing.Point(643, 153);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 30);
            this.btnBuscar.TabIndex = 97;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // cmbxFiltroBusqueda
            // 
            this.cmbxFiltroBusqueda.BackColor = System.Drawing.Color.White;
            this.cmbxFiltroBusqueda.BorderColor = System.Drawing.Color.Black;
            this.cmbxFiltroBusqueda.BorderSize = 2;
            this.cmbxFiltroBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbxFiltroBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbxFiltroBusqueda.ForeColor = System.Drawing.Color.Black;
            this.cmbxFiltroBusqueda.IconColor = System.Drawing.Color.Black;
            this.cmbxFiltroBusqueda.Items.AddRange(new object[] {
            "op 1",
            "op 2",
            "op 3"});
            this.cmbxFiltroBusqueda.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxFiltroBusqueda.ListTextColor = System.Drawing.Color.Black;
            this.cmbxFiltroBusqueda.Location = new System.Drawing.Point(436, 153);
            this.cmbxFiltroBusqueda.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbxFiltroBusqueda.Name = "cmbxFiltroBusqueda";
            this.cmbxFiltroBusqueda.Padding = new System.Windows.Forms.Padding(2);
            this.cmbxFiltroBusqueda.Size = new System.Drawing.Size(200, 31);
            this.cmbxFiltroBusqueda.TabIndex = 96;
            this.cmbxFiltroBusqueda.Texts = "Filtrar por";
            this.cmbxFiltroBusqueda.Enter += new System.EventHandler(this.cmbxFiltroBusqueda_Enter);
            this.cmbxFiltroBusqueda.Leave += new System.EventHandler(this.cmbxFiltroBusqueda_Leave);
            // 
            // txtBarraBusqueda
            // 
            this.txtBarraBusqueda.BackColor = System.Drawing.SystemColors.Window;
            this.txtBarraBusqueda.BorderColor = System.Drawing.Color.Black;
            this.txtBarraBusqueda.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.txtBarraBusqueda.BorderRadius = 0;
            this.txtBarraBusqueda.BorderSize = 2;
            this.txtBarraBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarraBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBarraBusqueda.Location = new System.Drawing.Point(49, 153);
            this.txtBarraBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarraBusqueda.Multiline = false;
            this.txtBarraBusqueda.Name = "txtBarraBusqueda";
            this.txtBarraBusqueda.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBarraBusqueda.PasswordChar = false;
            this.txtBarraBusqueda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBarraBusqueda.PlaceholderText = "Buscar";
            this.txtBarraBusqueda.Size = new System.Drawing.Size(380, 31);
            this.txtBarraBusqueda.TabIndex = 95;
            this.txtBarraBusqueda.Texts = "";
            this.txtBarraBusqueda.UnderlinedStyle = false;
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
            this.btnEliminar.Location = new System.Drawing.Point(748, 384);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(211, 47);
            this.btnEliminar.TabIndex = 94;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
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
            this.btnEditar.Location = new System.Drawing.Point(748, 296);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnEditar.Size = new System.Drawing.Size(211, 47);
            this.btnEditar.TabIndex = 93;
            this.btnEditar.Text = "E&ditar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 36;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(748, 210);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(211, 47);
            this.btnAgregar.TabIndex = 92;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Montserrat Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(42, 77);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 37);
            this.lblTitulo.TabIndex = 91;
            this.lblTitulo.Text = "Servicios";
            // 
            // dtgvTabla
            // 
            this.dtgvTabla.AllowUserToAddRows = false;
            this.dtgvTabla.AllowUserToDeleteRows = false;
            this.dtgvTabla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgvTabla.AutoGenerateColumns = false;
            this.dtgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServicioDataGridViewTextBoxColumn,
            this.idRepuestoDataGridViewTextBoxColumn,
            this.fechaInstalacionDataGridViewTextBoxColumn,
            this.fechaCambioDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.dtgvTabla.DataSource = this.fKServicioidSer6754599EBindingSource1;
            this.dtgvTabla.Location = new System.Drawing.Point(49, 210);
            this.dtgvTabla.Name = "dtgvTabla";
            this.dtgvTabla.ReadOnly = true;
            this.dtgvTabla.RowHeadersWidth = 51;
            this.dtgvTabla.Size = new System.Drawing.Size(680, 352);
            this.dtgvTabla.TabIndex = 90;
            // 
            // fKServicioidSer6754599EBindingSource
            // 
            this.fKServicioidSer6754599EBindingSource.DataMember = "FK__Servicio___idSer__6754599E";
            this.fKServicioidSer6754599EBindingSource.DataSource = this.servicioBindingSource;
            // 
            // servicio_RepuestoTableAdapter
            // 
            this.servicio_RepuestoTableAdapter.ClearBeforeFill = true;
            // 
            // fKServicioidSer6754599EBindingSource1
            // 
            this.fKServicioidSer6754599EBindingSource1.DataMember = "FK__Servicio___idSer__6754599E";
            this.fKServicioidSer6754599EBindingSource1.DataSource = this.servicioBindingSource;
              // 
            // idServicioDataGridViewTextBoxColumn
            // 
            this.idServicioDataGridViewTextBoxColumn.DataPropertyName = "idServicio";
            this.idServicioDataGridViewTextBoxColumn.HeaderText = "idServicio";
            this.idServicioDataGridViewTextBoxColumn.Name = "idServicioDataGridViewTextBoxColumn";
            this.idServicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idRepuestoDataGridViewTextBoxColumn
            // 
            this.idRepuestoDataGridViewTextBoxColumn.DataPropertyName = "idRepuesto";
            this.idRepuestoDataGridViewTextBoxColumn.HeaderText = "idRepuesto";
            this.idRepuestoDataGridViewTextBoxColumn.Name = "idRepuestoDataGridViewTextBoxColumn";
            this.idRepuestoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInstalacionDataGridViewTextBoxColumn
            // 
            this.fechaInstalacionDataGridViewTextBoxColumn.DataPropertyName = "fechaInstalacion";
            this.fechaInstalacionDataGridViewTextBoxColumn.HeaderText = "fechaInstalacion";
            this.fechaInstalacionDataGridViewTextBoxColumn.Name = "fechaInstalacionDataGridViewTextBoxColumn";
            this.fechaInstalacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCambioDataGridViewTextBoxColumn
            // 
            this.fechaCambioDataGridViewTextBoxColumn.DataPropertyName = "fechaCambio";
            this.fechaCambioDataGridViewTextBoxColumn.HeaderText = "fechaCambio";
            this.fechaCambioDataGridViewTextBoxColumn.Name = "fechaCambioDataGridViewTextBoxColumn";
            this.fechaCambioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 681);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmServicios";
            this.Text = "frmServicios";
            this.Load += new System.EventHandler(this.frmServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTallerMecanicoDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKServicioidSer6754599EBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKServicioidSer6754599EBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BDTallerMecanicoDataSet bDTallerMecanicoDataSet;
        private System.Windows.Forms.BindingSource servicioBindingSource;
        private BDTallerMecanicoDataSetTableAdapters.ServicioTableAdapter servicioTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private RJCodeAdvance.RJControls.RJComboBox cmbxFiltroBusqueda;
        private RJCodeAdvance.RJControls.RJTextBox txtBarraBusqueda;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dtgvTabla;
        private System.Windows.Forms.BindingSource fKServicioidSer6754599EBindingSource;
        private BDTallerMecanicoDataSetTableAdapters.Servicio_RepuestoTableAdapter servicio_RepuestoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRepuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInstalacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCambioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKServicioidSer6754599EBindingSource1;
    }
}