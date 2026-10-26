namespace prjWinCsPOOBureauEchangeClasse
{
    partial class frmAdmin
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
            this.lstPays = new System.Windows.Forms.ListBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtNomPays = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMonais = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.gxbx = new System.Windows.Forms.GroupBox();
            this.gxbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPays
            // 
            this.lstPays.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPays.FormattingEnabled = true;
            this.lstPays.ItemHeight = 23;
            this.lstPays.Location = new System.Drawing.Point(12, 130);
            this.lstPays.Name = "lstPays";
            this.lstPays.Size = new System.Drawing.Size(213, 234);
            this.lstPays.TabIndex = 16;
            // 
            // lblInformation
            // 
            this.lblInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInformation.ForeColor = System.Drawing.Color.Blue;
            this.lblInformation.Location = new System.Drawing.Point(10, 174);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(549, 29);
            this.lblInformation.TabIndex = 19;
            this.lblInformation.Text = "Informations";
            this.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Black;
            this.btnAnnuler.ForeColor = System.Drawing.Color.Lime;
            this.btnAnnuler.Location = new System.Drawing.Point(565, 155);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(150, 37);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.AccessibleName = "black";
            this.btnSauvegarder.BackColor = System.Drawing.Color.Black;
            this.btnSauvegarder.ForeColor = System.Drawing.Color.Lime;
            this.btnSauvegarder.Location = new System.Drawing.Point(565, 123);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(150, 37);
            this.btnSauvegarder.TabIndex = 13;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = false;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Black;
            this.btnSupprimer.ForeColor = System.Drawing.Color.Lime;
            this.btnSupprimer.Location = new System.Drawing.Point(565, 86);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(150, 39);
            this.btnSupprimer.TabIndex = 12;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Black;
            this.btnModifier.ForeColor = System.Drawing.Color.Lime;
            this.btnModifier.Location = new System.Drawing.Point(565, 59);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(150, 37);
            this.btnModifier.TabIndex = 11;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Black;
            this.btnAjouter.ForeColor = System.Drawing.Color.Lime;
            this.btnAjouter.Location = new System.Drawing.Point(565, 26);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(150, 37);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtNomPays
            // 
            this.txtNomPays.ForeColor = System.Drawing.Color.Red;
            this.txtNomPays.Location = new System.Drawing.Point(129, 40);
            this.txtNomPays.Name = "txtNomPays";
            this.txtNomPays.Size = new System.Drawing.Size(430, 27);
            this.txtNomPays.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(297, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Bureau De Changes International";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nom Pays :";
            // 
            // txtMonais
            // 
            this.txtMonais.ForeColor = System.Drawing.Color.Red;
            this.txtMonais.Location = new System.Drawing.Point(129, 79);
            this.txtMonais.Name = "txtMonais";
            this.txtMonais.Size = new System.Drawing.Size(430, 27);
            this.txtMonais.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "par rapport a 1 CAN, Dollar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valeur :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Monais :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(350, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "BANQUE DE TORONTO";
            // 
            // txtValeur
            // 
            this.txtValeur.ForeColor = System.Drawing.Color.Red;
            this.txtValeur.Location = new System.Drawing.Point(129, 128);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(167, 27);
            this.txtValeur.TabIndex = 6;
            // 
            // gxbx
            // 
            this.gxbx.BackColor = System.Drawing.Color.LightGreen;
            this.gxbx.Controls.Add(this.lblInformation);
            this.gxbx.Controls.Add(this.btnAnnuler);
            this.gxbx.Controls.Add(this.btnSauvegarder);
            this.gxbx.Controls.Add(this.btnSupprimer);
            this.gxbx.Controls.Add(this.btnModifier);
            this.gxbx.Controls.Add(this.btnAjouter);
            this.gxbx.Controls.Add(this.txtNomPays);
            this.gxbx.Controls.Add(this.label7);
            this.gxbx.Controls.Add(this.txtValeur);
            this.gxbx.Controls.Add(this.txtMonais);
            this.gxbx.Controls.Add(this.label6);
            this.gxbx.Controls.Add(this.label4);
            this.gxbx.Controls.Add(this.label3);
            this.gxbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gxbx.ForeColor = System.Drawing.Color.Black;
            this.gxbx.Location = new System.Drawing.Point(243, 130);
            this.gxbx.Name = "gxbx";
            this.gxbx.Size = new System.Drawing.Size(775, 230);
            this.gxbx.TabIndex = 13;
            this.gxbx.TabStop = false;
            this.gxbx.Text = "Information sur pays choisi";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1044, 410);
            this.Controls.Add(this.lstPays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gxbx);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.gxbx.ResumeLayout(false);
            this.gxbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPays;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtNomPays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMonais;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValeur;
        private System.Windows.Forms.GroupBox gxbx;
    }
}