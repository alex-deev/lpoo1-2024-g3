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
            ((System.ComponentModel.ISupportInitialize)(this.gridEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCompetencias
            // 
            this.cbCompetencias.FormattingEnabled = true;
            this.cbCompetencias.Location = new System.Drawing.Point(486, 138);
            this.cbCompetencias.Name = "cbCompetencias";
            this.cbCompetencias.Size = new System.Drawing.Size(121, 21);
            this.cbCompetencias.TabIndex = 0;
            // 
            // txtAtletaID
            // 
            this.txtAtletaID.Location = new System.Drawing.Point(486, 63);
            this.txtAtletaID.Name = "txtAtletaID";
            this.txtAtletaID.Size = new System.Drawing.Size(121, 20);
            this.txtAtletaID.TabIndex = 1;
            // 
            // btnInscribir
            // 
            this.btnInscribir.Location = new System.Drawing.Point(502, 218);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(75, 23);
            this.btnInscribir.TabIndex = 2;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // gridEvento
            // 
            this.gridEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEvento.Location = new System.Drawing.Point(12, 12);
            this.gridEvento.Name = "gridEvento";
            this.gridEvento.Size = new System.Drawing.Size(454, 296);
            this.gridEvento.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Atleta ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(486, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Competencia";
            // 
            // FrmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 339);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridEvento);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.txtAtletaID);
            this.Controls.Add(this.cbCompetencias);
            this.Name = "FrmInscripcion";
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
    }
}