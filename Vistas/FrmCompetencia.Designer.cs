namespace Vistas
{
    partial class FrmCompetencia
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
            this.combEstado = new System.Windows.Forms.ComboBox();
            this.combCategoria = new System.Windows.Forms.ComboBox();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblSponsors = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblOrganizador = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.combDisciplina = new System.Windows.Forms.ComboBox();
            this.dateFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dateFechaFin = new System.Windows.Forms.DateTimePicker();
            this.txtSponsors = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtOrganizador = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gridCompetencias = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompetencias)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDatos
            // 
            this.groupDatos.Controls.Add(this.combEstado);
            this.groupDatos.Controls.Add(this.combCategoria);
            this.groupDatos.Controls.Add(this.lblDisciplina);
            this.groupDatos.Controls.Add(this.lblCategoria);
            this.groupDatos.Controls.Add(this.lblSponsors);
            this.groupDatos.Controls.Add(this.lblUbicacion);
            this.groupDatos.Controls.Add(this.lblOrganizador);
            this.groupDatos.Controls.Add(this.lblEstado);
            this.groupDatos.Controls.Add(this.lblFechaFin);
            this.groupDatos.Controls.Add(this.lblFechaInicio);
            this.groupDatos.Controls.Add(this.lblDescripcion);
            this.groupDatos.Controls.Add(this.lblNombre);
            this.groupDatos.Controls.Add(this.combDisciplina);
            this.groupDatos.Controls.Add(this.dateFechaInicio);
            this.groupDatos.Controls.Add(this.dateFechaFin);
            this.groupDatos.Controls.Add(this.txtSponsors);
            this.groupDatos.Controls.Add(this.txtUbicacion);
            this.groupDatos.Controls.Add(this.txtOrganizador);
            this.groupDatos.Controls.Add(this.txtDescripcion);
            this.groupDatos.Controls.Add(this.txtNombre);
            this.groupDatos.Location = new System.Drawing.Point(604, 15);
            this.groupDatos.Margin = new System.Windows.Forms.Padding(11, 4, 4, 4);
            this.groupDatos.Name = "groupDatos";
            this.groupDatos.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.groupDatos.Size = new System.Drawing.Size(316, 398);
            this.groupDatos.TabIndex = 0;
            this.groupDatos.TabStop = false;
            this.groupDatos.Text = "Datos de la Competencia";
            // 
            // combEstado
            // 
            this.combEstado.FormattingEnabled = true;
            this.combEstado.Location = new System.Drawing.Point(141, 185);
            this.combEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combEstado.Name = "combEstado";
            this.combEstado.Size = new System.Drawing.Size(159, 24);
            this.combEstado.TabIndex = 28;
            // 
            // combCategoria
            // 
            this.combCategoria.FormattingEnabled = true;
            this.combCategoria.Location = new System.Drawing.Point(141, 313);
            this.combCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combCategoria.Name = "combCategoria";
            this.combCategoria.Size = new System.Drawing.Size(159, 24);
            this.combCategoria.TabIndex = 27;
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Location = new System.Drawing.Point(15, 348);
            this.lblDisciplina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(68, 17);
            this.lblDisciplina.TabIndex = 26;
            this.lblDisciplina.Text = "Disciplina";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(15, 316);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 17);
            this.lblCategoria.TabIndex = 25;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblSponsors
            // 
            this.lblSponsors.AutoSize = true;
            this.lblSponsors.Location = new System.Drawing.Point(15, 284);
            this.lblSponsors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSponsors.Name = "lblSponsors";
            this.lblSponsors.Size = new System.Drawing.Size(68, 17);
            this.lblSponsors.TabIndex = 24;
            this.lblSponsors.Text = "Sponsors";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(15, 252);
            this.lblUbicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(70, 17);
            this.lblUbicacion.TabIndex = 23;
            this.lblUbicacion.Text = "Ubicación";
            // 
            // lblOrganizador
            // 
            this.lblOrganizador.AutoSize = true;
            this.lblOrganizador.Location = new System.Drawing.Point(15, 220);
            this.lblOrganizador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrganizador.Name = "lblOrganizador";
            this.lblOrganizador.Size = new System.Drawing.Size(87, 17);
            this.lblOrganizador.TabIndex = 22;
            this.lblOrganizador.Text = "Organizador";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(15, 188);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 17);
            this.lblEstado.TabIndex = 21;
            this.lblEstado.Text = "Estado";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(15, 156);
            this.lblFechaFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(90, 17);
            this.lblFechaFin.TabIndex = 20;
            this.lblFechaFin.Text = "Fecha de Fin";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(15, 124);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(103, 17);
            this.lblFechaInicio.TabIndex = 19;
            this.lblFechaInicio.Text = "Fecha de Inicio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 68);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 36);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre";
            // 
            // combDisciplina
            // 
            this.combDisciplina.FormattingEnabled = true;
            this.combDisciplina.Location = new System.Drawing.Point(141, 345);
            this.combDisciplina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combDisciplina.Name = "combDisciplina";
            this.combDisciplina.Size = new System.Drawing.Size(159, 24);
            this.combDisciplina.TabIndex = 16;
            // 
            // dateFechaInicio
            // 
            this.dateFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaInicio.Location = new System.Drawing.Point(141, 121);
            this.dateFechaInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateFechaInicio.Name = "dateFechaInicio";
            this.dateFechaInicio.Size = new System.Drawing.Size(159, 22);
            this.dateFechaInicio.TabIndex = 15;
            // 
            // dateFechaFin
            // 
            this.dateFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaFin.Location = new System.Drawing.Point(141, 153);
            this.dateFechaFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateFechaFin.Name = "dateFechaFin";
            this.dateFechaFin.Size = new System.Drawing.Size(159, 22);
            this.dateFechaFin.TabIndex = 14;
            // 
            // txtSponsors
            // 
            this.txtSponsors.Location = new System.Drawing.Point(141, 281);
            this.txtSponsors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSponsors.Name = "txtSponsors";
            this.txtSponsors.Size = new System.Drawing.Size(159, 22);
            this.txtSponsors.TabIndex = 13;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(141, 249);
            this.txtUbicacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(159, 22);
            this.txtUbicacion.TabIndex = 12;
            // 
            // txtOrganizador
            // 
            this.txtOrganizador.Location = new System.Drawing.Point(141, 217);
            this.txtOrganizador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOrganizador.Name = "txtOrganizador";
            this.txtOrganizador.Size = new System.Drawing.Size(159, 22);
            this.txtOrganizador.TabIndex = 11;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(141, 64);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(159, 48);
            this.txtDescripcion.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(141, 32);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // gridCompetencias
            // 
            this.gridCompetencias.AllowUserToAddRows = false;
            this.gridCompetencias.AllowUserToDeleteRows = false;
            this.gridCompetencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompetencias.Location = new System.Drawing.Point(16, 15);
            this.gridCompetencias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridCompetencias.Name = "gridCompetencias";
            this.gridCompetencias.ReadOnly = true;
            this.gridCompetencias.Size = new System.Drawing.Size(573, 398);
            this.gridCompetencias.TabIndex = 1;
            this.gridCompetencias.CurrentCellChanged += new System.EventHandler(this.gridCompetencias_CurrentCellChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(820, 426);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 28);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(712, 426);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(489, 426);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(381, 426);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 28);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FrmCompetencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 469);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.gridCompetencias);
            this.Controls.Add(this.groupDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCompetencia";
            this.Text = "FrmCompetencias";
            this.Load += new System.EventHandler(this.FrmCompetencia_Load);
            this.groupDatos.ResumeLayout(false);
            this.groupDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompetencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDatos;
        private System.Windows.Forms.DataGridView gridCompetencias;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox combDisciplina;
        private System.Windows.Forms.DateTimePicker dateFechaInicio;
        private System.Windows.Forms.DateTimePicker dateFechaFin;
        private System.Windows.Forms.TextBox txtSponsors;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.TextBox txtOrganizador;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox combCategoria;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblSponsors;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblOrganizador;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.ComboBox combEstado;
    }
}