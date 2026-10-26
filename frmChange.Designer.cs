namespace prjWinCsPOOBureauEchangeClasse
{
    partial class frmChange
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
            this.label1 = new System.Windows.Forms.Label();
            this.gBoxApplyConversion = new System.Windows.Forms.GroupBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboPays = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnRecommencer = new System.Windows.Forms.Button();
            this.rad = new System.Windows.Forms.GroupBox();
            this.lblConv2 = new System.Windows.Forms.Label();
            this.lblConv1 = new System.Windows.Forms.Label();
            this.radAutreVSDoll = new System.Windows.Forms.RadioButton();
            this.radDolVSautre = new System.Windows.Forms.RadioButton();
            this.GboxValeurActuelle = new System.Windows.Forms.GroupBox();
            this.lblValAct2 = new System.Windows.Forms.Label();
            this.lblValAct1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gBoxApplyConversion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.rad.SuspendLayout();
            this.GboxValeurActuelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "BANQUE DE TORONTO";
            // 
            // gBoxApplyConversion
            // 
            this.gBoxApplyConversion.BackColor = System.Drawing.Color.LimeGreen;
            this.gBoxApplyConversion.Controls.Add(this.lblMontant);
            this.gBoxApplyConversion.Controls.Add(this.lblResultat);
            this.gBoxApplyConversion.Controls.Add(this.btnConvertir);
            this.gBoxApplyConversion.Controls.Add(this.txtMontant);
            this.gBoxApplyConversion.Controls.Add(this.label3);
            this.gBoxApplyConversion.Location = new System.Drawing.Point(47, 343);
            this.gBoxApplyConversion.Name = "gBoxApplyConversion";
            this.gBoxApplyConversion.Size = new System.Drawing.Size(826, 129);
            this.gBoxApplyConversion.TabIndex = 2;
            this.gBoxApplyConversion.TabStop = false;
            this.gBoxApplyConversion.Text = "Apply de Conversion";
            // 
            // lblMontant
            // 
            this.lblMontant.ForeColor = System.Drawing.Color.Black;
            this.lblMontant.Location = new System.Drawing.Point(390, 33);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(325, 23);
            this.lblMontant.TabIndex = 7;
            // 
            // lblResultat
            // 
            this.lblResultat.ForeColor = System.Drawing.Color.Black;
            this.lblResultat.Location = new System.Drawing.Point(258, 90);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(367, 23);
            this.lblResultat.TabIndex = 6;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(81, 83);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(150, 30);
            this.btnConvertir.TabIndex = 5;
            this.btnConvertir.Text = "Convertir >>";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txtMontant
            // 
            this.txtMontant.ForeColor = System.Drawing.Color.Red;
            this.txtMontant.Location = new System.Drawing.Point(262, 30);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(122, 30);
            this.txtMontant.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Entrez un montant :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox1.Controls.Add(this.cboPays);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.btnFermer);
            this.groupBox1.Controls.Add(this.btnRecommencer);
            this.groupBox1.Controls.Add(this.gBoxApplyConversion);
            this.groupBox1.Controls.Add(this.rad);
            this.groupBox1.Controls.Add(this.GboxValeurActuelle);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 536);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programme De Change Avec Le Dollar Canadien";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // cboPays
            // 
            this.cboPays.FormattingEnabled = true;
            this.cboPays.Location = new System.Drawing.Point(47, 86);
            this.cboPays.Name = "cboPays";
            this.cboPays.Size = new System.Drawing.Size(285, 31);
            this.cboPays.TabIndex = 6;
            this.cboPays.SelectedIndexChanged += new System.EventHandler(this.cboPays_SelectedIndexChanged);
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(198, 36);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(383, 16);
            this.lblDate.TabIndex = 5;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(606, 478);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(150, 30);
            this.btnFermer.TabIndex = 4;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.Location = new System.Drawing.Point(243, 478);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(150, 30);
            this.btnRecommencer.TabIndex = 3;
            this.btnRecommencer.Text = "Recommencer";
            this.btnRecommencer.UseVisualStyleBackColor = true;
            this.btnRecommencer.Click += new System.EventHandler(this.btnRecommencer_Click);
            // 
            // rad
            // 
            this.rad.BackColor = System.Drawing.Color.LimeGreen;
            this.rad.Controls.Add(this.lblConv2);
            this.rad.Controls.Add(this.lblConv1);
            this.rad.Controls.Add(this.radAutreVSDoll);
            this.rad.Controls.Add(this.radDolVSautre);
            this.rad.Location = new System.Drawing.Point(47, 203);
            this.rad.Name = "rad";
            this.rad.Size = new System.Drawing.Size(826, 119);
            this.rad.TabIndex = 1;
            this.rad.TabStop = false;
            this.rad.Text = "Type De Conversion";
            // 
            // lblConv2
            // 
            this.lblConv2.ForeColor = System.Drawing.Color.Red;
            this.lblConv2.Location = new System.Drawing.Point(48, 68);
            this.lblConv2.Name = "lblConv2";
            this.lblConv2.Size = new System.Drawing.Size(388, 23);
            this.lblConv2.TabIndex = 3;
            // 
            // lblConv1
            // 
            this.lblConv1.ForeColor = System.Drawing.Color.Red;
            this.lblConv1.Location = new System.Drawing.Point(48, 27);
            this.lblConv1.Name = "lblConv1";
            this.lblConv1.Size = new System.Drawing.Size(388, 23);
            this.lblConv1.TabIndex = 2;
            // 
            // radAutreVSDoll
            // 
            this.radAutreVSDoll.AutoSize = true;
            this.radAutreVSDoll.Location = new System.Drawing.Point(25, 71);
            this.radAutreVSDoll.Name = "radAutreVSDoll";
            this.radAutreVSDoll.Size = new System.Drawing.Size(17, 16);
            this.radAutreVSDoll.TabIndex = 1;
            this.radAutreVSDoll.TabStop = true;
            this.radAutreVSDoll.UseVisualStyleBackColor = true;
            // 
            // radDolVSautre
            // 
            this.radDolVSautre.AutoSize = true;
            this.radDolVSautre.Checked = true;
            this.radDolVSautre.Location = new System.Drawing.Point(25, 30);
            this.radDolVSautre.Name = "radDolVSautre";
            this.radDolVSautre.Size = new System.Drawing.Size(17, 16);
            this.radDolVSautre.TabIndex = 0;
            this.radDolVSautre.TabStop = true;
            this.radDolVSautre.UseVisualStyleBackColor = true;
            // 
            // GboxValeurActuelle
            // 
            this.GboxValeurActuelle.BackColor = System.Drawing.Color.LimeGreen;
            this.GboxValeurActuelle.Controls.Add(this.lblValAct2);
            this.GboxValeurActuelle.Controls.Add(this.lblValAct1);
            this.GboxValeurActuelle.Location = new System.Drawing.Point(470, 69);
            this.GboxValeurActuelle.Name = "GboxValeurActuelle";
            this.GboxValeurActuelle.Size = new System.Drawing.Size(403, 117);
            this.GboxValeurActuelle.TabIndex = 0;
            this.GboxValeurActuelle.TabStop = false;
            this.GboxValeurActuelle.Text = "Les Valeurs Actuelles";
            // 
            // lblValAct2
            // 
            this.lblValAct2.ForeColor = System.Drawing.Color.Red;
            this.lblValAct2.Location = new System.Drawing.Point(30, 62);
            this.lblValAct2.Name = "lblValAct2";
            this.lblValAct2.Size = new System.Drawing.Size(367, 23);
            this.lblValAct2.TabIndex = 1;
            // 
            // lblValAct1
            // 
            this.lblValAct1.ForeColor = System.Drawing.Color.Red;
            this.lblValAct1.Location = new System.Drawing.Point(30, 30);
            this.lblValAct1.Name = "lblValAct1";
            this.lblValAct1.Size = new System.Drawing.Size(367, 23);
            this.lblValAct1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(219, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bureau De Changes International";
            // 
            // frmChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(939, 655);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "frmChange";
            this.Text = "frmChange";
            this.Load += new System.EventHandler(this.frmChange_Load);
            this.gBoxApplyConversion.ResumeLayout(false);
            this.gBoxApplyConversion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.rad.ResumeLayout(false);
            this.rad.PerformLayout();
            this.GboxValeurActuelle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBoxApplyConversion;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboPays;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnRecommencer;
        private System.Windows.Forms.GroupBox rad;
        private System.Windows.Forms.Label lblConv2;
        private System.Windows.Forms.Label lblConv1;
        private System.Windows.Forms.RadioButton radAutreVSDoll;
        private System.Windows.Forms.RadioButton radDolVSautre;
        private System.Windows.Forms.GroupBox GboxValeurActuelle;
        private System.Windows.Forms.Label lblValAct2;
        private System.Windows.Forms.Label lblValAct1;
        private System.Windows.Forms.Label label2;
    }
}