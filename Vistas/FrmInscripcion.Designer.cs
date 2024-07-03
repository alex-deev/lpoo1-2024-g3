namespace Vistas
{
    partial class FrmInscripcion
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
            this.cbCompetencias = new System.Windows.Forms.ComboBox();
            this.txtAtletaID = new System.Windows.Forms.TextBox();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.gridEvento = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCompetencias
            // 
            this.cbCompetencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompetencias.FormattingEnabled = true;
            this.cbCompetencias.Location = new System.Drawing.Point(648, 170);
            this.cbCompetencias.Margin = new System.Windows.Forms.Padding(4);
            this.cbCompetencias.Name = "cbCompetencias";
            this.cbCompetencias.Size = new System.Drawing.Size(160, 24);
            this.cbCompetencias.TabIndex = 0;
            // 
            // txtAtletaID
            // 
            this.txtAtletaID.Location = new System.Drawing.Point(648, 78);
            this.txtAtletaID.Margin = new System.Windows.Forms.Padding(4);
            this.txtAtletaID.Name = "txtAtletaID";
            this.txtAtletaID.Size = new System.Drawing.Size(160, 22);
            this.txtAtletaID.TabIndex = 1;
            // 
            // btnInscribir
            // 
            this.btnInscribir.Location = new System.Drawing.Point(669, 268);
            this.btnInscribir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(100, 28);
            this.btnInscribir.TabIndex = 2;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // gridEvento
            // 
            this.gridEvento.AllowUserToAddRows = false;
            this.gridEvento.AllowUserToDeleteRows = false;
            this.gridEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEvento.Location = new System.Drawing.Point(16, 15);
            this.gridEvento.Margin = new System.Windows.Forms.Padding(4);
            this.gridEvento.Name = "gridEvento";
            this.gridEvento.ReadOnly = true;
            this.gridEvento.Size = new System.Drawing.Size(605, 364);
            this.gridEvento.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(648, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Atleta ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(648, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Competencia";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(669, 334);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 27);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 417);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridEvento);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.txtAtletaID);
            this.Controls.Add(this.cbCompetencias);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInscripcion";
            this.Load += new System.EventHandler(this.FrmInscripcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEvento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCompetencias;
        private System.Windows.Forms.TextBox txtAtletaID;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.DataGridView gridEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
    }
}