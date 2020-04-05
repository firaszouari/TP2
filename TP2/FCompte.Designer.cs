namespace TP2
{
    partial class FCompte
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Valid = new System.Windows.Forms.Button();
            this.Txtsolde = new System.Windows.Forms.TextBox();
            this.Txttitulaire = new System.Windows.Forms.TextBox();
            this.Txtnumcompte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Valid);
            this.groupBox1.Controls.Add(this.Txtsolde);
            this.groupBox1.Controls.Add(this.Txttitulaire);
            this.groupBox1.Controls.Add(this.Txtnumcompte);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 415);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creation Nouveau Compte : ";
            // 
            // Btn_Valid
            // 
            this.Btn_Valid.Location = new System.Drawing.Point(207, 358);
            this.Btn_Valid.Name = "Btn_Valid";
            this.Btn_Valid.Size = new System.Drawing.Size(152, 23);
            this.Btn_Valid.TabIndex = 6;
            this.Btn_Valid.Text = "Valider";
            this.Btn_Valid.UseVisualStyleBackColor = true;
            this.Btn_Valid.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txtsolde
            // 
            this.Txtsolde.Location = new System.Drawing.Point(152, 271);
            this.Txtsolde.Name = "Txtsolde";
            this.Txtsolde.Size = new System.Drawing.Size(237, 22);
            this.Txtsolde.TabIndex = 5;
            // 
            // Txttitulaire
            // 
            this.Txttitulaire.Location = new System.Drawing.Point(152, 174);
            this.Txttitulaire.Name = "Txttitulaire";
            this.Txttitulaire.Size = new System.Drawing.Size(237, 22);
            this.Txttitulaire.TabIndex = 4;
            // 
            // Txtnumcompte
            // 
            this.Txtnumcompte.Location = new System.Drawing.Point(152, 77);
            this.Txtnumcompte.Name = "Txtnumcompte";
            this.Txtnumcompte.Size = new System.Drawing.Size(237, 22);
            this.Txtnumcompte.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Solde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulaire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro";
            // 
            // FCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 439);
            this.Controls.Add(this.groupBox1);
            this.Name = "FCompte";
            this.Text = "FCompte";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Valid;
        private System.Windows.Forms.TextBox Txtsolde;
        private System.Windows.Forms.TextBox Txttitulaire;
        private System.Windows.Forms.TextBox Txtnumcompte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}