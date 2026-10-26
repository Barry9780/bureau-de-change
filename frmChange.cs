using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsPOOBureauEchangeClasse
{
    public partial class frmChange : Form
    {
        ClsBureau monBureau;
        public frmChange()
        {
            InitializeComponent();
        }

        private void frmChange_Load(object sender, EventArgs e)
        {
            //Création du bureau 
            monBureau = new ClsBureau();
            monBureau.Pays = ClsDataSource.GetTousLesPays();

            // Affichage du date
            lblDate.Text = "Montréal, Aujourd'hui " + DateTime.Today.ToLongDateString();

            // Remplir la combo avec le
            cboPays.Items.Clear();
            foreach (ClsPays unPays in monBureau.Pays)
            {
                cboPays.Items.Add(unPays.Nom + "-" + unPays.Monnaie);
            }
            radDolVSautre.Checked = true;

            
            lblConv1.Text = "";
            lblConv2.Text = "";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void cboPays_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            decimal result;
            decimal montant = Convert.ToDecimal(txtMontant.Text);
            string nomChoisi = cboPays.SelectedItem.ToString(); 
            foreach (ClsPays unPays in monBureau.Pays) 
            { if (unPays.Nom == nomChoisi)
                {
                    if (radDolVSautre.Checked == true)
                    {
                       
                        result = montant * unPays.Valeur;
                        lblResultat.Text = result + " " + unPays.Monnaie;
                        lblMontant.Text = " CAD.Dollar";
                    }
                    else if (radAutreVSDoll.Checked == true)
                    {
                        result = montant / unPays.Valeur;
                        lblResultat.Text = result + " " + unPays.Monnaie;

                    }
                } 
            }
        }

        private void btnRecommencer_Click(object sender, EventArgs e)
        {
            txtMontant.Text = "";
            lblResultat.Text = "";
            txtMontant.Focus();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous fermer l'application ?", "Fermeture de l'application",
               MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
} 
