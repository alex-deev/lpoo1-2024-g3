namespace Vistas
{
    partial class FrmAnularInscripcion
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
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gridParticipantes = new System.Windows.Forms.DataGridView();
            this.gridCompetencia = new System.Windows.Forms.DataGridView();
            this.btnAnularInscripcion = new System.Windows.Forms.Button();
            this.txtIdCompetencia = new System.Windows.Forms.TextBox();
            this.lblTituloCompetencia = new System.Windows.Forms.Label();
            this.btnAcreditarInscripcion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridParticipantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompetencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(16, 64);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(31, 17);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "DNI";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(156, 60);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(359, 22);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(597, 57);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBuscar.Size = new System.Drawing.Size(128, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gridParticipantes
            // 
            this.gridParticipantes.AllowUserToAddRows = false;
            this.gridParticipantes.AllowUserToDeleteRows = false;
            this.gridParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridParticipantes.Location = new System.Drawing.Point(20, 121);
            this.gridParticipantes.Margin = new System.Windows.Forms.Padding(4);
            this.gridParticipantes.Name = "gridParticipantes";
            this.gridParticipantes.ReadOnly = true;
            this.gridParticipantes.Size = new System.Drawing.Size(705, 137);
            this.gridParticipantes.TabIndex = 3;
            this.gridParticipantes.CurrentCellChanged += new System.EventHandler(this.gridParticipantes_CurrentCellChanged);
            // 
            // gridCompetencia
            // 
            this.gridCompetencia.AllowUserToAddRows = false;
            this.gridCompetencia.AllowUserToDeleteRows = false;
            this.gridCompetencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompetencia.Location = new System.Drawing.Point(20, 315);
            this.gridCompetencia.Margin = new System.Windows.Forms.Padding(4);
            this.gridCompetencia.Name = "gridCompetencia";
            this.gridCompetencia.ReadOnly = true;
            this.gridCompetencia.Size = new System.Drawing.Size(705, 185);
            this.gridCompetencia.TabIndex = 6;
            this.gridCompetencia.CurrentCellChanged += new System.EventHandler(this.gridCompetencia_CurrentCellChanged);
            // 
            // btnAnularInscripcion
            // 
            this.btnAnularInscripcion.Location = new System.Drawing.Point(789, 474);
            this.btnAnularInscripcion.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnularInscripcion.Name = "btnAnularInscripcion";
            this.btnAnularInscripcion.Size = new System.Drawing.Size(161, 26);
            this.btnAnularInscripcion.TabIndex = 7;
            this.btnAnularInscripcion.Text = "ANULAR";
            this.btnAnularInscripcion.UseVisualStyleBackColor = true;
            this.btnAnularInscripcion.Click += new System.EventHandler(this.btnAnularInscripcion_Click);
            // 
            // txtIdCompetencia
            // 
            this.txtIdCompetencia.Enabled = false;
            this.txtIdCompetencia.Location = new System.Drawing.Point(788, 366);
            this.txtIdCompetencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCompetencia.Name = "txtIdCompetencia";
            this.txtIdCompetencia.Size = new System.Drawing.Size(160, 22);
            this.txtIdCompetencia.TabIndex = 8;
            this.txtIdCompetencia.Visible = false;
            // 
            // lblTituloCompetencia
            // 
            this.lblTituloCompetencia.AutoSize = true;
            this.lblTituloCompetencia.Location = new System.Drawing.Point(16, 281);
            this.lblTituloCompetencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloCompetencia.Name = "lblTituloCompetencia";
            this.lblTituloCompetencia.Size = new System.Drawing.Size(160, 17);
            this.lblTituloCompetencia.TabIndex = 9;
            this.lblTituloCompetencia.Text = "Competencias del Atleta";
            // 
            // btnAcreditarInscripcion
            // 
            this.btnAcreditarInscripcion.Location = new System.Drawing.Point(1016, 474);
            this.btnAcreditarInscripcion.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcreditarInscripcion.Name = "btnAcreditarInscripcion";
            this.btnAcreditarInscripcion.Size = new System.Drawing.Size(161, 28);
            this.btnAcreditarInscripcion.TabIndex = 10;
            this.btnAcreditarInscripcion.Text = "ACREDITAR";
            this.btnAcreditarInscripcion.UseVisualStyleBackColor = true;
            this.btnAcreditarInscripcion.Click += new System.EventHandler(this.btnAcreditarInscripcion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 430);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "ANULAR INSCRIPCION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1012, 430);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "ACREDITAR INSCRIPCION";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(362, 530);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 39);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmAnularInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 581);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAcreditarInscripcion);
            this.Controls.Add(this.lblTituloCompetencia);
            this.Controls.Add(this.txtIdCompetencia);
            this.Controls.Add(this.btnAnularInscripcion);
            this.Controls.Add(this.gridCompetencia);
            this.Controls.Add(this.gridParticipantes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAnularInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnularInscripcion";
            ((System.ComponentModel.ISupportInitialize)(this.gridParticipantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompetencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView gridParticipantes;
        private System.Windows.Forms.DataGridView gridCompetencia;
        private System.Windows.Forms.Button btnAnularInscripcion;
        private System.Windows.Forms.TextBox txtIdCompetencia;
        private System.Windows.Forms.Label lblTituloCompetencia;
        private System.Windows.Forms.Button btnAcreditarInscripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
    }
}