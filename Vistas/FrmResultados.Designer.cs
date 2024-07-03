namespace Vistas
{
    partial class FrmResultados
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
            this.lblCompetencia = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gridResultados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAtletasParticipantes = new System.Windows.Forms.TextBox();
            this.txtAtletasAbandonaron = new System.Windows.Forms.TextBox();
            this.txtAtletasDescalificados = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.comboCompetencias = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.AutoSize = true;
            this.lblCompetencia.Location = new System.Drawing.Point(111, 45);
            this.lblCompetencia.Name = "lblCompetencia";
            this.lblCompetencia.Size = new System.Drawing.Size(154, 17);
            this.lblCompetencia.TabIndex = 0;
            this.lblCompetencia.Text = "Ingrese la competencia";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(585, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gridResultados
            // 
            this.gridResultados.AllowUserToAddRows = false;
            this.gridResultados.AllowUserToDeleteRows = false;
            this.gridResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultados.Location = new System.Drawing.Point(114, 130);
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.ReadOnly = true;
            this.gridResultados.RowTemplate.Height = 24;
            this.gridResultados.Size = new System.Drawing.Size(637, 304);
            this.gridResultados.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad de ateltas que participaron";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 554);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad de atletas que abandonaron";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 620);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad de atletas descalificados";
            // 
            // txtAtletasParticipantes
            // 
            this.txtAtletasParticipantes.Location = new System.Drawing.Point(383, 487);
            this.txtAtletasParticipantes.Name = "txtAtletasParticipantes";
            this.txtAtletasParticipantes.Size = new System.Drawing.Size(100, 22);
            this.txtAtletasParticipantes.TabIndex = 8;
            // 
            // txtAtletasAbandonaron
            // 
            this.txtAtletasAbandonaron.Location = new System.Drawing.Point(383, 549);
            this.txtAtletasAbandonaron.Name = "txtAtletasAbandonaron";
            this.txtAtletasAbandonaron.Size = new System.Drawing.Size(100, 22);
            this.txtAtletasAbandonaron.TabIndex = 9;
            // 
            // txtAtletasDescalificados
            // 
            this.txtAtletasDescalificados.Location = new System.Drawing.Point(383, 615);
            this.txtAtletasDescalificados.Name = "txtAtletasDescalificados";
            this.txtAtletasDescalificados.Size = new System.Drawing.Size(100, 22);
            this.txtAtletasDescalificados.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Resultados ordenados de primer a ultimo lugar";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(760, 45);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // comboCompetencias
            // 
            this.comboCompetencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCompetencias.FormattingEnabled = true;
            this.comboCompetencias.Location = new System.Drawing.Point(330, 43);
            this.comboCompetencias.Name = "comboCompetencias";
            this.comboCompetencias.Size = new System.Drawing.Size(169, 24);
            this.comboCompetencias.TabIndex = 13;
            // 
            // FrmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 687);
            this.Controls.Add(this.comboCompetencias);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAtletasDescalificados);
            this.Controls.Add(this.txtAtletasAbandonaron);
            this.Controls.Add(this.txtAtletasParticipantes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridResultados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCompetencia);
            this.Name = "FrmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Resultados";
            this.Load += new System.EventHandler(this.FrmResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompetencia;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView gridResultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAtletasParticipantes;
        private System.Windows.Forms.TextBox txtAtletasAbandonaron;
        private System.Windows.Forms.TextBox txtAtletasDescalificados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox comboCompetencias;
    }
}