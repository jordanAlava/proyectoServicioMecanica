namespace capaPresentacion
{
    partial class frmIniciarSesion
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
            this.linkRegistrarse = new System.Windows.Forms.LinkLabel();
            this.btnIniciarSesion = new RJCodeAdvance.RJControls.RJButton();
            this.txtContrasenia = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtUsuario = new RJCodeAdvance.RJControls.RJTextBox();
            this.pctrLogotipo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // linkRegistrarse
            // 
            this.linkRegistrarse.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkRegistrarse.AutoSize = true;
            this.linkRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegistrarse.LinkColor = System.Drawing.Color.White;
            this.linkRegistrarse.Location = new System.Drawing.Point(452, 674);
            this.linkRegistrarse.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.linkRegistrarse.Name = "linkRegistrarse";
            this.linkRegistrarse.Size = new System.Drawing.Size(96, 20);
            this.linkRegistrarse.TabIndex = 7;
            this.linkRegistrarse.TabStop = true;
            this.linkRegistrarse.Text = "Registrarse";
            this.linkRegistrarse.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Firebrick;
            this.btnIniciarSesion.BackgroundColor = System.Drawing.Color.Firebrick;
            this.btnIniciarSesion.BorderColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesion.BorderRadius = 10;
            this.btnIniciarSesion.BorderSize = 0;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(457, 575);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(444, 54);
            this.btnIniciarSesion.TabIndex = 6;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.TextColor = System.Drawing.Color.White;
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.Color.Black;
            this.txtContrasenia.BorderColor = System.Drawing.Color.White;
            this.txtContrasenia.BorderFocusColor = System.Drawing.Color.Brown;
            this.txtContrasenia.BorderRadius = 10;
            this.txtContrasenia.BorderSize = 1;
            this.txtContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContrasenia.Location = new System.Drawing.Point(457, 468);
            this.txtContrasenia.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtContrasenia.Multiline = false;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Padding = new System.Windows.Forms.Padding(17, 11, 17, 11);
            this.txtContrasenia.PasswordChar = false;
            this.txtContrasenia.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtContrasenia.PlaceholderText = "Contraseña";
            this.txtContrasenia.Size = new System.Drawing.Size(444, 43);
            this.txtContrasenia.TabIndex = 5;
            this.txtContrasenia.Texts = "";
            this.txtContrasenia.UnderlinedStyle = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Black;
            this.txtUsuario.BorderColor = System.Drawing.Color.White;
            this.txtUsuario.BorderFocusColor = System.Drawing.Color.Brown;
            this.txtUsuario.BorderRadius = 10;
            this.txtUsuario.BorderSize = 1;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.Location = new System.Drawing.Point(457, 366);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(17, 11, 17, 11);
            this.txtUsuario.PasswordChar = false;
            this.txtUsuario.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtUsuario.PlaceholderText = "Usuario";
            this.txtUsuario.Size = new System.Drawing.Size(444, 43);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.Texts = "";
            this.txtUsuario.UnderlinedStyle = false;
            // 
            // pctrLogotipo
            // 
            this.pctrLogotipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctrLogotipo.Location = new System.Drawing.Point(457, 27);
            this.pctrLogotipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctrLogotipo.Name = "pctrLogotipo";
            this.pctrLogotipo.Size = new System.Drawing.Size(444, 353);
            this.pctrLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrLogotipo.TabIndex = 8;
            this.pctrLogotipo.TabStop = false;
            // 
            // frmIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1341, 887);
            this.Controls.Add(this.linkRegistrarse);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pctrLogotipo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmIniciarSesion";
            this.Text = "frmIniciarSesion";
            this.Load += new System.EventHandler(this.frmIniciarSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogotipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkRegistrarse;
        private RJCodeAdvance.RJControls.RJButton btnIniciarSesion;
        private RJCodeAdvance.RJControls.RJTextBox txtContrasenia;
        private RJCodeAdvance.RJControls.RJTextBox txtUsuario;
        private System.Windows.Forms.PictureBox pctrLogotipo;
    }
}