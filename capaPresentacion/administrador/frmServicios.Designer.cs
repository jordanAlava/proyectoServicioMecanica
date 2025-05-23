﻿namespace capaPresentacion
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
            this.cmbxFiltroBusqueda = new RJCodeAdvance.RJControls.RJComboBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.cmbxFiltroBusquedaDetalle = new RJCodeAdvance.RJControls.RJComboBox();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtgvTabla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTallerMecanicoDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTabla)).BeginInit();
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
            this.panel1.Controls.Add(this.cmbxFiltroBusqueda);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.cmbxFiltroBusquedaDetalle);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.dtgvTabla);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 838);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.cmbxFiltroBusqueda.Location = new System.Drawing.Point(65, 188);
            this.cmbxFiltroBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxFiltroBusqueda.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbxFiltroBusqueda.Name = "cmbxFiltroBusqueda";
            this.cmbxFiltroBusqueda.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxFiltroBusqueda.Size = new System.Drawing.Size(508, 38);
            this.cmbxFiltroBusqueda.TabIndex = 99;
            this.cmbxFiltroBusqueda.Texts = "Filtrar por (Campo)";
            this.cmbxFiltroBusqueda.Enter += new System.EventHandler(this.cmbxFiltroBusqueda_Enter);
            this.cmbxFiltroBusqueda.Leave += new System.EventHandler(this.cmbxFiltroBusqueda_Leave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Black;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 24;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(857, 188);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.btnBuscar.Size = new System.Drawing.Size(115, 37);
            this.btnBuscar.TabIndex = 97;
            this.btnBuscar.Text = "&Filtrar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbxFiltroBusquedaDetalle
            // 
            this.cmbxFiltroBusquedaDetalle.BackColor = System.Drawing.Color.White;
            this.cmbxFiltroBusquedaDetalle.BorderColor = System.Drawing.Color.Black;
            this.cmbxFiltroBusquedaDetalle.BorderSize = 2;
            this.cmbxFiltroBusquedaDetalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbxFiltroBusquedaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbxFiltroBusquedaDetalle.ForeColor = System.Drawing.Color.Black;
            this.cmbxFiltroBusquedaDetalle.IconColor = System.Drawing.Color.Black;
            this.cmbxFiltroBusquedaDetalle.Items.AddRange(new object[] {
            "Ninguno",
            "Costo total 50$ en adelante",
            "Costo total 75$ en adelante",
            "Costo total 100$ en adelante"});
            this.cmbxFiltroBusquedaDetalle.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxFiltroBusquedaDetalle.ListTextColor = System.Drawing.Color.Black;
            this.cmbxFiltroBusquedaDetalle.Location = new System.Drawing.Point(581, 188);
            this.cmbxFiltroBusquedaDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxFiltroBusquedaDetalle.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbxFiltroBusquedaDetalle.Name = "cmbxFiltroBusquedaDetalle";
            this.cmbxFiltroBusquedaDetalle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxFiltroBusquedaDetalle.Size = new System.Drawing.Size(267, 38);
            this.cmbxFiltroBusquedaDetalle.TabIndex = 96;
            this.cmbxFiltroBusquedaDetalle.Texts = "Detalle";
            this.cmbxFiltroBusquedaDetalle.Enter += new System.EventHandler(this.cmbxFiltroBusqueda_Enter);
            this.cmbxFiltroBusquedaDetalle.Leave += new System.EventHandler(this.cmbxFiltroBusqueda_Leave);
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
            this.btnEliminar.Location = new System.Drawing.Point(997, 473);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(281, 58);
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
            this.btnEditar.Location = new System.Drawing.Point(997, 364);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.btnEditar.Size = new System.Drawing.Size(281, 58);
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
            this.btnAgregar.Location = new System.Drawing.Point(997, 258);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(281, 58);
            this.btnAgregar.TabIndex = 92;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(56, 95);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(165, 39);
            this.lblTitulo.TabIndex = 91;
            this.lblTitulo.Text = "Servicios";
            // 
            // dtgvTabla
            // 
            this.dtgvTabla.AllowUserToAddRows = false;
            this.dtgvTabla.AllowUserToDeleteRows = false;
            this.dtgvTabla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTabla.Location = new System.Drawing.Point(65, 258);
            this.dtgvTabla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvTabla.Name = "dtgvTabla";
            this.dtgvTabla.ReadOnly = true;
            this.dtgvTabla.RowHeadersWidth = 51;
            this.dtgvTabla.Size = new System.Drawing.Size(907, 433);
            this.dtgvTabla.TabIndex = 90;
            // 
            // frmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 838);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmServicios";
            this.Text = "frmServicios";
            this.Load += new System.EventHandler(this.frmServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTallerMecanicoDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BDTallerMecanicoDataSet bDTallerMecanicoDataSet;
        private System.Windows.Forms.BindingSource servicioBindingSource;
        private BDTallerMecanicoDataSetTableAdapters.ServicioTableAdapter servicioTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private RJCodeAdvance.RJControls.RJComboBox cmbxFiltroBusquedaDetalle;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dtgvTabla;
        private RJCodeAdvance.RJControls.RJComboBox cmbxFiltroBusqueda;
    }
}