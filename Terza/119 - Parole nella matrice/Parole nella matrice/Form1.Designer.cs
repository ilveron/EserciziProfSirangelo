﻿namespace Modello_Matrici2
{
    partial class frmAvvio
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.plsVisualizza = new System.Windows.Forms.Button();
            this.lstMat = new System.Windows.Forms.ListBox();
            this.plsInput = new System.Windows.Forms.Button();
            this.numColonne = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numRighe = new System.Windows.Forms.NumericUpDown();
            this.plsParola = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numColonne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRighe)).BeginInit();
            this.SuspendLayout();
            // 
            // plsVisualizza
            // 
            this.plsVisualizza.BackColor = System.Drawing.Color.Black;
            this.plsVisualizza.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.plsVisualizza.Location = new System.Drawing.Point(44, 285);
            this.plsVisualizza.Name = "plsVisualizza";
            this.plsVisualizza.Size = new System.Drawing.Size(134, 38);
            this.plsVisualizza.TabIndex = 20;
            this.plsVisualizza.Text = "VISUALIZZA DATI MATRICE";
            this.plsVisualizza.UseVisualStyleBackColor = false;
            this.plsVisualizza.Click += new System.EventHandler(this.plsVisualizza_Click);
            // 
            // lstMat
            // 
            this.lstMat.FormattingEnabled = true;
            this.lstMat.Location = new System.Drawing.Point(45, 132);
            this.lstMat.Name = "lstMat";
            this.lstMat.Size = new System.Drawing.Size(299, 147);
            this.lstMat.TabIndex = 19;
            // 
            // plsInput
            // 
            this.plsInput.BackColor = System.Drawing.Color.Black;
            this.plsInput.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.plsInput.Location = new System.Drawing.Point(44, 88);
            this.plsInput.Name = "plsInput";
            this.plsInput.Size = new System.Drawing.Size(302, 38);
            this.plsInput.TabIndex = 18;
            this.plsInput.Text = "INIZIA INPUT";
            this.plsInput.UseVisualStyleBackColor = false;
            this.plsInput.Click += new System.EventHandler(this.plsInput_Click);
            // 
            // numColonne
            // 
            this.numColonne.Location = new System.Drawing.Point(227, 62);
            this.numColonne.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numColonne.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numColonne.Name = "numColonne";
            this.numColonne.Size = new System.Drawing.Size(120, 20);
            this.numColonne.TabIndex = 17;
            this.numColonne.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "NUMERO COLONNE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "NUMERO RIGHE:";
            // 
            // numRighe
            // 
            this.numRighe.Location = new System.Drawing.Point(227, 29);
            this.numRighe.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRighe.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRighe.Name = "numRighe";
            this.numRighe.Size = new System.Drawing.Size(120, 20);
            this.numRighe.TabIndex = 16;
            this.numRighe.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // plsParola
            // 
            this.plsParola.BackColor = System.Drawing.Color.Black;
            this.plsParola.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.plsParola.Location = new System.Drawing.Point(213, 285);
            this.plsParola.Name = "plsParola";
            this.plsParola.Size = new System.Drawing.Size(134, 38);
            this.plsParola.TabIndex = 21;
            this.plsParola.Text = "TROVA PAROLA";
            this.plsParola.UseVisualStyleBackColor = false;
            this.plsParola.Click += new System.EventHandler(this.plsParola_Click);
            // 
            // frmAvvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 352);
            this.Controls.Add(this.plsParola);
            this.Controls.Add(this.plsVisualizza);
            this.Controls.Add(this.lstMat);
            this.Controls.Add(this.plsInput);
            this.Controls.Add(this.numColonne);
            this.Controls.Add(this.numRighe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAvvio";
            this.Text = "Parole nella matrice";
            this.Load += new System.EventHandler(this.frmAvvio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numColonne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRighe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plsVisualizza;
        private System.Windows.Forms.ListBox lstMat;
        private System.Windows.Forms.Button plsInput;
        private System.Windows.Forms.NumericUpDown numColonne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numRighe;
        private System.Windows.Forms.Button plsParola;
    }
}

