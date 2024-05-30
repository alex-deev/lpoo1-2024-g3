namespace Vistas
{
    partial class FrmUsuario
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
            this.groupDatos = new System.Windows.Forms.GroupBox();
            this.combRol = new System.Windows.Forms.ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblApellidoNombre = new System.Windows.Forms.Label();
            this.txtApellidoNombre = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gridUsuarios = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDatos
            // 
            this.groupDatos.Controls.Add(this.combRol);
            this.groupDatos.Controls.Add(this.lblRol);
            this.groupDatos.Controls.Add(this.lblApellidoNombre);
            this.groupDatos.Controls.Add(this.txtApellidoNombre);
            this.groupDatos.Controls.Add(this.txtContrasenia);
            this.groupDatos.Controls.Add(this.lblContrasenia);
            this.groupDatos.Controls.Add(this.txtUsuario);
            this.groupDatos.Controls.Add(this.lblUsuario);
            this.groupDatos.Location = new System.Drawing.Point(453, 12);
            this.groupDatos.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.groupDatos.Name = "groupDatos";
            this.groupDatos.Padding = new System.Windows.Forms.Padding(8);
            this.groupDatos.Size = new System.Drawing.Size(237, 323);
            this.groupDatos.TabIndex = 0;
            this.groupDatos.TabStop = false;
            this.groupDatos.Text = "Datos del Usuario";
            // 
            // combRol
            // 
            this.combRol.FormattingEnabled = true;
            this.combRol.Location = new System.Drawing.Point(105, 99);
            this.combRol.Name = "combRol";
            this.combRol.Size = new System.Drawing.Size(121, 21);
            this.combRol.TabIndex = 8;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(11, 102);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(23, 13);
            this.lblRol.TabIndex = 7;
            this.lblRol.Text = "Rol";
            // 
            // lblApellidoNombre
            // 
            this.lblApellidoNombre.Location = new System.Drawing.Point(11, 181);
            this.lblApellidoNombre.Name = "lblApellidoNombre";
            this.lblApellidoNombre.Size = new System.Drawing.Size(89, 26);
            this.lblApellidoNombre.TabIndex = 5;
            this.lblApellidoNombre.Text = "Apellido y Nombre";
            // 
            // txtApellidoNombre
            // 
            this.txtApellidoNombre.Location = new System.Drawing.Point(106, 178);
            this.txtApellidoNombre.Multiline = true;
            this.txtApellidoNombre.Name = "txtApellidoNombre";
            this.txtApellidoNombre.Size = new System.Drawing.Size(120, 40);
            this.txtApellidoNombre.TabIndex = 4;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(106, 152);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(120, 20);
            this.txtContrasenia.TabIndex = 3;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(11, 155);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(61, 13);
            this.lblContrasenia.TabIndex = 2;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(106, 126);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(120, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(11, 129);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(615, 346);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.AllowUserToAddRows = false;
            this.gridUsuarios.AllowUserToDeleteRows = false;
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Location = new System.Drawing.Point(12, 46);
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.ReadOnly = true;
            this.gridUsuarios.Size = new System.Drawing.Size(429, 323);
            this.gridUsuarios.TabIndex = 2;
            this.gridUsuarios.CurrentCellChanged += new System.EventHandler(this.gridUsuarios_CurrentCellChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(534, 346);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(453, 346);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Borrar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 381);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.gridUsuarios);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupDatos);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.groupDatos.ResumeLayout(false);
            this.groupDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDatos;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView gridUsuarios;
        private System.Windows.Forms.ComboBox combRol;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblApellidoNombre;
        private System.Windows.Forms.TextBox txtApellidoNombre;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
    }
}