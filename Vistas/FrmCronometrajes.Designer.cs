namespace Vistas
{
    partial class FrmCronometrajes
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
            this.lblTituloCompetencia = new System.Windows.Forms.Label();
            this.lblTituloParticipante = new System.Windows.Forms.Label();
            this.combCompetencia = new System.Windows.Forms.ComboBox();
            this.groupInicio = new System.Windows.Forms.GroupBox();
            this.btnCargarInicio = new System.Windows.Forms.Button();
            this.lblSegundoInicio = new System.Windows.Forms.Label();
            this.lblMinutoInicio = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.numSegundoInicio = new System.Windows.Forms.NumericUpDown();
            this.numMinutoInicio = new System.Windows.Forms.NumericUpDown();
            this.numHoraInico = new System.Windows.Forms.NumericUpDown();
            this.groupFin = new System.Windows.Forms.GroupBox();
            this.btnCargarFin = new System.Windows.Forms.Button();
            this.lblSegundoFin = new System.Windows.Forms.Label();
            this.lblMinutoFin = new System.Windows.Forms.Label();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.numSegundoFin = new System.Windows.Forms.NumericUpDown();
            this.numMinutoFin = new System.Windows.Forms.NumericUpDown();
            this.numHoraFin = new System.Windows.Forms.NumericUpDown();
            this.btnElegirCompetencia = new System.Windows.Forms.Button();
            this.gridParticipantes = new System.Windows.Forms.DataGridView();
            this.btnHabilitarCorrecion = new System.Windows.Forms.Button();
            this.groupInfoEstado = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEstadoAbandono = new System.Windows.Forms.Button();
            this.btnEstadoDescalificado = new System.Windows.Forms.Button();
            this.groupInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSegundoInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutoInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoraInico)).BeginInit();
            this.groupFin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSegundoFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutoFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoraFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridParticipantes)).BeginInit();
            this.groupInfoEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloCompetencia
            // 
            this.lblTituloCompetencia.AutoSize = true;
            this.lblTituloCompetencia.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCompetencia.Location = new System.Drawing.Point(17, 15);
            this.lblTituloCompetencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloCompetencia.Name = "lblTituloCompetencia";
            this.lblTituloCompetencia.Size = new System.Drawing.Size(127, 25);
            this.lblTituloCompetencia.TabIndex = 0;
            this.lblTituloCompetencia.Text = "Competencia";
            // 
            // lblTituloParticipante
            // 
            this.lblTituloParticipante.AutoSize = true;
            this.lblTituloParticipante.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloParticipante.Location = new System.Drawing.Point(17, 82);
            this.lblTituloParticipante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloParticipante.Name = "lblTituloParticipante";
            this.lblTituloParticipante.Size = new System.Drawing.Size(124, 25);
            this.lblTituloParticipante.TabIndex = 0;
            this.lblTituloParticipante.Text = "Participantes";
            // 
            // combCompetencia
            // 
            this.combCompetencia.FormattingEnabled = true;
            this.combCompetencia.Location = new System.Drawing.Point(160, 16);
            this.combCompetencia.Margin = new System.Windows.Forms.Padding(4);
            this.combCompetencia.Name = "combCompetencia";
            this.combCompetencia.Size = new System.Drawing.Size(175, 24);
            this.combCompetencia.TabIndex = 1;
            this.combCompetencia.TextChanged += new System.EventHandler(this.combCompetencia_TextChanged);
            // 
            // groupInicio
            // 
            this.groupInicio.Controls.Add(this.btnCargarInicio);
            this.groupInicio.Controls.Add(this.lblSegundoInicio);
            this.groupInicio.Controls.Add(this.lblMinutoInicio);
            this.groupInicio.Controls.Add(this.lblHoraInicio);
            this.groupInicio.Controls.Add(this.numSegundoInicio);
            this.groupInicio.Controls.Add(this.numMinutoInicio);
            this.groupInicio.Controls.Add(this.numHoraInico);
            this.groupInicio.Location = new System.Drawing.Point(460, 139);
            this.groupInicio.Margin = new System.Windows.Forms.Padding(7, 6, 13, 6);
            this.groupInicio.Name = "groupInicio";
            this.groupInicio.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupInicio.Size = new System.Drawing.Size(219, 271);
            this.groupInicio.TabIndex = 3;
            this.groupInicio.TabStop = false;
            this.groupInicio.Text = "Inicio";
            // 
            // btnCargarInicio
            // 
            this.btnCargarInicio.Location = new System.Drawing.Point(43, 224);
            this.btnCargarInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 12);
            this.btnCargarInicio.Name = "btnCargarInicio";
            this.btnCargarInicio.Size = new System.Drawing.Size(133, 28);
            this.btnCargarInicio.TabIndex = 4;
            this.btnCargarInicio.Text = "Cargar Tiempo";
            this.btnCargarInicio.UseVisualStyleBackColor = true;
            this.btnCargarInicio.Click += new System.EventHandler(this.btnCargarInicio_Click);
            // 
            // lblSegundoInicio
            // 
            this.lblSegundoInicio.AutoSize = true;
            this.lblSegundoInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoInicio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSegundoInicio.Location = new System.Drawing.Point(97, 164);
            this.lblSegundoInicio.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblSegundoInicio.Name = "lblSegundoInicio";
            this.lblSegundoInicio.Size = new System.Drawing.Size(101, 26);
            this.lblSegundoInicio.TabIndex = 5;
            this.lblSegundoInicio.Text = ":segundo";
            // 
            // lblMinutoInicio
            // 
            this.lblMinutoInicio.AutoSize = true;
            this.lblMinutoInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutoInicio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMinutoInicio.Location = new System.Drawing.Point(97, 110);
            this.lblMinutoInicio.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblMinutoInicio.Name = "lblMinutoInicio";
            this.lblMinutoInicio.Size = new System.Drawing.Size(84, 26);
            this.lblMinutoInicio.TabIndex = 4;
            this.lblMinutoInicio.Text = ":minuto";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHoraInicio.Location = new System.Drawing.Point(97, 55);
            this.lblHoraInicio.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(61, 26);
            this.lblHoraInicio.TabIndex = 3;
            this.lblHoraInicio.Text = ":hora";
            // 
            // numSegundoInicio
            // 
            this.numSegundoInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSegundoInicio.Location = new System.Drawing.Point(11, 153);
            this.numSegundoInicio.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.numSegundoInicio.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numSegundoInicio.Name = "numSegundoInicio";
            this.numSegundoInicio.Size = new System.Drawing.Size(87, 45);
            this.numSegundoInicio.TabIndex = 2;
            this.numSegundoInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSegundoInicio.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // numMinutoInicio
            // 
            this.numMinutoInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMinutoInicio.Location = new System.Drawing.Point(11, 98);
            this.numMinutoInicio.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.numMinutoInicio.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinutoInicio.Name = "numMinutoInicio";
            this.numMinutoInicio.Size = new System.Drawing.Size(87, 45);
            this.numMinutoInicio.TabIndex = 1;
            this.numMinutoInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMinutoInicio.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // numHoraInico
            // 
            this.numHoraInico.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHoraInico.Location = new System.Drawing.Point(11, 44);
            this.numHoraInico.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.numHoraInico.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHoraInico.Name = "numHoraInico";
            this.numHoraInico.Size = new System.Drawing.Size(87, 45);
            this.numHoraInico.TabIndex = 0;
            this.numHoraInico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numHoraInico.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // groupFin
            // 
            this.groupFin.Controls.Add(this.btnCargarFin);
            this.groupFin.Controls.Add(this.lblSegundoFin);
            this.groupFin.Controls.Add(this.lblMinutoFin);
            this.groupFin.Controls.Add(this.lblHoraFin);
            this.groupFin.Controls.Add(this.numSegundoFin);
            this.groupFin.Controls.Add(this.numMinutoFin);
            this.groupFin.Controls.Add(this.numHoraFin);
            this.groupFin.Location = new System.Drawing.Point(699, 139);
            this.groupFin.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupFin.Name = "groupFin";
            this.groupFin.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupFin.Size = new System.Drawing.Size(219, 271);
            this.groupFin.TabIndex = 6;
            this.groupFin.TabStop = false;
            this.groupFin.Text = "Fin";
            // 
            // btnCargarFin
            // 
            this.btnCargarFin.Location = new System.Drawing.Point(43, 224);
            this.btnCargarFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 12);
            this.btnCargarFin.Name = "btnCargarFin";
            this.btnCargarFin.Size = new System.Drawing.Size(133, 28);
            this.btnCargarFin.TabIndex = 4;
            this.btnCargarFin.Text = "Cargar Tiempo";
            this.btnCargarFin.UseVisualStyleBackColor = true;
            this.btnCargarFin.Click += new System.EventHandler(this.btnCargarFin_Click);
            // 
            // lblSegundoFin
            // 
            this.lblSegundoFin.AutoSize = true;
            this.lblSegundoFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoFin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSegundoFin.Location = new System.Drawing.Point(97, 164);
            this.lblSegundoFin.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblSegundoFin.Name = "lblSegundoFin";
            this.lblSegundoFin.Size = new System.Drawing.Size(101, 26);
            this.lblSegundoFin.TabIndex = 5;
            this.lblSegundoFin.Text = ":segundo";
            // 
            // lblMinutoFin
            // 
            this.lblMinutoFin.AutoSize = true;
            this.lblMinutoFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutoFin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMinutoFin.Location = new System.Drawing.Point(97, 110);
            this.lblMinutoFin.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblMinutoFin.Name = "lblMinutoFin";
            this.lblMinutoFin.Size = new System.Drawing.Size(84, 26);
            this.lblMinutoFin.TabIndex = 4;
            this.lblMinutoFin.Text = ":minuto";
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHoraFin.Location = new System.Drawing.Point(97, 55);
            this.lblHoraFin.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(61, 26);
            this.lblHoraFin.TabIndex = 3;
            this.lblHoraFin.Text = ":hora";
            // 
            // numSegundoFin
            // 
            this.numSegundoFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSegundoFin.Location = new System.Drawing.Point(11, 153);
            this.numSegundoFin.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.numSegundoFin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numSegundoFin.Name = "numSegundoFin";
            this.numSegundoFin.Size = new System.Drawing.Size(87, 45);
            this.numSegundoFin.TabIndex = 2;
            this.numSegundoFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSegundoFin.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // numMinutoFin
            // 
            this.numMinutoFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMinutoFin.Location = new System.Drawing.Point(11, 98);
            this.numMinutoFin.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.numMinutoFin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinutoFin.Name = "numMinutoFin";
            this.numMinutoFin.Size = new System.Drawing.Size(87, 45);
            this.numMinutoFin.TabIndex = 1;
            this.numMinutoFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMinutoFin.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // numHoraFin
            // 
            this.numHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHoraFin.Location = new System.Drawing.Point(11, 44);
            this.numHoraFin.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.numHoraFin.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHoraFin.Name = "numHoraFin";
            this.numHoraFin.Size = new System.Drawing.Size(87, 45);
            this.numHoraFin.TabIndex = 0;
            this.numHoraFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numHoraFin.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // btnElegirCompetencia
            // 
            this.btnElegirCompetencia.Location = new System.Drawing.Point(344, 15);
            this.btnElegirCompetencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnElegirCompetencia.Name = "btnElegirCompetencia";
            this.btnElegirCompetencia.Size = new System.Drawing.Size(79, 28);
            this.btnElegirCompetencia.TabIndex = 7;
            this.btnElegirCompetencia.Text = "Elegir";
            this.btnElegirCompetencia.UseVisualStyleBackColor = true;
            this.btnElegirCompetencia.Click += new System.EventHandler(this.btnElegirCompetencia_Click);
            // 
            // gridParticipantes
            // 
            this.gridParticipantes.AllowUserToAddRows = false;
            this.gridParticipantes.AllowUserToDeleteRows = false;
            this.gridParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridParticipantes.Location = new System.Drawing.Point(22, 112);
            this.gridParticipantes.Margin = new System.Windows.Forms.Padding(4);
            this.gridParticipantes.Name = "gridParticipantes";
            this.gridParticipantes.ReadOnly = true;
            this.gridParticipantes.Size = new System.Drawing.Size(415, 342);
            this.gridParticipantes.TabIndex = 9;
            this.gridParticipantes.CurrentCellChanged += new System.EventHandler(this.gridParticipantes_CurrentCellChanged);
            // 
            // btnHabilitarCorrecion
            // 
            this.btnHabilitarCorrecion.Location = new System.Drawing.Point(577, 426);
            this.btnHabilitarCorrecion.Margin = new System.Windows.Forms.Padding(4);
            this.btnHabilitarCorrecion.Name = "btnHabilitarCorrecion";
            this.btnHabilitarCorrecion.Size = new System.Drawing.Size(219, 28);
            this.btnHabilitarCorrecion.TabIndex = 10;
            this.btnHabilitarCorrecion.Text = "Habilitar correciones de tiempo";
            this.btnHabilitarCorrecion.UseVisualStyleBackColor = true;
            this.btnHabilitarCorrecion.Click += new System.EventHandler(this.btnHabilitarCorrecion_Click);
            // 
            // groupInfoEstado
            // 
            this.groupInfoEstado.Controls.Add(this.label1);
            this.groupInfoEstado.Controls.Add(this.btnEstadoAbandono);
            this.groupInfoEstado.Controls.Add(this.btnEstadoDescalificado);
            this.groupInfoEstado.Location = new System.Drawing.Point(460, 15);
            this.groupInfoEstado.Margin = new System.Windows.Forms.Padding(4);
            this.groupInfoEstado.Name = "groupInfoEstado";
            this.groupInfoEstado.Padding = new System.Windows.Forms.Padding(4);
            this.groupInfoEstado.Size = new System.Drawing.Size(453, 103);
            this.groupInfoEstado.TabIndex = 11;
            this.groupInfoEstado.TabStop = false;
            this.groupInfoEstado.Text = "Estado del Participante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Actualizar estado del participante:";
            // 
            // btnEstadoAbandono
            // 
            this.btnEstadoAbandono.Location = new System.Drawing.Point(120, 60);
            this.btnEstadoAbandono.Margin = new System.Windows.Forms.Padding(4);
            this.btnEstadoAbandono.Name = "btnEstadoAbandono";
            this.btnEstadoAbandono.Size = new System.Drawing.Size(100, 28);
            this.btnEstadoAbandono.TabIndex = 1;
            this.btnEstadoAbandono.Text = "Abandono";
            this.btnEstadoAbandono.UseVisualStyleBackColor = true;
            this.btnEstadoAbandono.Click += new System.EventHandler(this.btnEstadoAbandono_Click);
            // 
            // btnEstadoDescalificado
            // 
            this.btnEstadoDescalificado.Location = new System.Drawing.Point(228, 60);
            this.btnEstadoDescalificado.Margin = new System.Windows.Forms.Padding(4);
            this.btnEstadoDescalificado.Name = "btnEstadoDescalificado";
            this.btnEstadoDescalificado.Size = new System.Drawing.Size(107, 28);
            this.btnEstadoDescalificado.TabIndex = 0;
            this.btnEstadoDescalificado.Text = "Descalificado";
            this.btnEstadoDescalificado.UseVisualStyleBackColor = true;
            this.btnEstadoDescalificado.Click += new System.EventHandler(this.btnEstadoDescalificado_Click);
            // 
            // FrmCronometrajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 469);
            this.Controls.Add(this.groupInfoEstado);
            this.Controls.Add(this.btnHabilitarCorrecion);
            this.Controls.Add(this.gridParticipantes);
            this.Controls.Add(this.btnElegirCompetencia);
            this.Controls.Add(this.groupFin);
            this.Controls.Add(this.groupInicio);
            this.Controls.Add(this.combCompetencia);
            this.Controls.Add(this.lblTituloParticipante);
            this.Controls.Add(this.lblTituloCompetencia);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCronometrajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCronometrajes";
            this.Load += new System.EventHandler(this.FrmCronometrajes_Load);
            this.groupInicio.ResumeLayout(false);
            this.groupInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSegundoInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutoInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoraInico)).EndInit();
            this.groupFin.ResumeLayout(false);
            this.groupFin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSegundoFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutoFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoraFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridParticipantes)).EndInit();
            this.groupInfoEstado.ResumeLayout(false);
            this.groupInfoEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCompetencia;
        private System.Windows.Forms.Label lblTituloParticipante;
        private System.Windows.Forms.ComboBox combCompetencia;
        private System.Windows.Forms.GroupBox groupInicio;
        private System.Windows.Forms.NumericUpDown numHoraInico;
        private System.Windows.Forms.NumericUpDown numMinutoInicio;
        private System.Windows.Forms.NumericUpDown numSegundoInicio;
        private System.Windows.Forms.Label lblSegundoInicio;
        private System.Windows.Forms.Label lblMinutoInicio;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Button btnCargarInicio;
        private System.Windows.Forms.GroupBox groupFin;
        private System.Windows.Forms.Button btnCargarFin;
        private System.Windows.Forms.Label lblSegundoFin;
        private System.Windows.Forms.Label lblMinutoFin;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.NumericUpDown numSegundoFin;
        private System.Windows.Forms.NumericUpDown numMinutoFin;
        private System.Windows.Forms.NumericUpDown numHoraFin;
        private System.Windows.Forms.Button btnElegirCompetencia;
        private System.Windows.Forms.DataGridView gridParticipantes;
        private System.Windows.Forms.Button btnHabilitarCorrecion;
        private System.Windows.Forms.GroupBox groupInfoEstado;
        private System.Windows.Forms.Button btnEstadoAbandono;
        private System.Windows.Forms.Button btnEstadoDescalificado;
        private System.Windows.Forms.Label label1;
    }
}