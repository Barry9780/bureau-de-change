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
    public partial class frmAdmin : Form
    {
        ClsBureau monBureau = new ClsBureau("B001", "Mon Bureau de Change", "Montréal", "Ouvert");
        int indicecourant = 0; 
        string mode = "";     

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            // Lire les comptes du fichier et les associer au bueau 
            monBureau.Pays = ClsDataSource.GetTousLesPays();

            ActualiserListe();
            AfficherPaysCourant();

            if (monBureau.Pays.Count == 0)
            {
                //Si la collection est vide, allons en mode ajout
                btnAjouter.Visible = true;
                btnModifier.Visible = false;
                btnSupprimer.Visible = false;
                btnSauvegarder.Visible = false;
                btnAnnuler.Visible = false;

                txtNomPays.Text = txtMonais.Text = txtValeur.Text = "Vide";
                lblInformation.Text = "Collection vide, cliquez sur Ajouter pour démarrer !";
            }
            else
            {
                indicecourant = 0;
                ActualiserListe();
                AfficherPaysCourant();
                lblInformation.Text = "Pays " + (indicecourant + 1) + " sur un total de " + monBureau.Pays.Count;
                btnAjouter.Visible = btnModifier.Visible = btnSupprimer.Visible = true;
                btnSauvegarder.Visible = btnAnnuler.Visible = false;
            }

        }

        private void AfficherPaysCourant()
        {
            if (monBureau.Pays.Count == 0)
            {

                //Si la collection est vide, allons en mode ajout
                btnAjouter.Visible = true;
                btnModifier.Visible = false;
                btnSupprimer.Visible = false;
                btnSauvegarder.Visible = false;
                btnAnnuler.Visible = false;

                txtNomPays.Text = txtMonais.Text = txtValeur.Text = "Vide";
                lblInformation.Text = "Collection vide, cliquez sur Ajouter pour démarrer !";
            }
            else
            {
                indicecourant = 0;
                txtNomPays.Text = monBureau.Pays[indicecourant].Nom;
                txtMonais.Text = monBureau.Pays[indicecourant].Monnaie;
                txtValeur.Text = monBureau.Pays[indicecourant].Valeur.ToString();
            }
        }

        public void ActualiserListe()
        {
            //d'abord vider la liste box
            lstPays.Items.Clear();
            //Boucler dans la collection, recuperer et inserer le numero
            //de chaque etudiant dans la listebox
            foreach (ClsPays unPays in monBureau.Pays)
            {
                lstPays.Items.Add(unPays.Nom);
            }

        }
        private bool TryLireSaisie(out string nom, out string monnaie, out decimal valeur)
        {
            nom = txtNomPays.Text;
            monnaie = txtMonais.Text;
            valeur = 0;

            // même esprit que ta logique : simple et direct
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(monnaie))
                return false;

            return decimal.TryParse(txtValeur.Text, out valeur);
        }



        private void btnAjouter_Click(object sender, EventArgs e)
        {
            mode = "Ajout";
            txtNomPays.Text = txtMonais.Text = txtValeur.Text = "";
            txtNomPays.Focus();

            btnAjouter.Visible = btnModifier.Visible = btnSupprimer.Visible = false;
            btnSauvegarder.Visible = btnAnnuler.Visible = true;

            lblInformation.Text = "Mode Ajout : remplissez les champs puis cliquez Sauvegarder.";
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Si la liste est vide, on retourne en mode ajouter car on a rien a modifier dans la collection
            if (monBureau.Pays.Count == 0)
            {
                btnAjouter_Click(sender, e);
            }

            mode = "Modif";
            btnAjouter.Visible = btnModifier.Visible = btnSupprimer.Visible = false;
            btnSauvegarder.Visible = btnAnnuler.Visible = true;

            lblInformation.Text = "Mode Modification : modifiez puis cliquez Sauvegarder.";
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Si la liste est vide, on retourne en mode ajouter car on a rien a supprimer dans la collection
            if (monBureau.Pays.Count == 0)
            {
                btnAjouter_Click(sender, e);
            }

            string nomChoisi = lstPays.SelectedItem.ToString();
            string msg = "Êtes-vous sûr de vouloir supprimer le pays ?";
            string titre = "Attention : Suppression Pays";
            if (MessageBox.Show(msg, titre, MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                foreach (ClsPays unPays in monBureau.Pays)
                {
                    if (unPays.Nom == nomChoisi)
                    {
                        
                        monBureau.Pays.Remove(unPays);
                        break;
                    }
                }
                //monBureau.Pays.RemoveAt(indicecourant);
                if (monBureau.Pays.Count == 0)
                {
                    lstPays.Items.Clear();
                    txtNomPays.Text = txtMonais.Text = txtValeur.Text = "Vide";
                    lblInformation.Text = "Collection vide, veuillez cliquer sur Ajouter pour démarrer !";

                    btnAjouter.Visible = true;
                    btnModifier.Visible = btnSupprimer.Visible = false;
                    btnSauvegarder.Visible = btnAnnuler.Visible = false;

                    indicecourant = 0;
                }
                else
                {

                    indicecourant = monBureau.Pays.Count - 1;
                    ActualiserListe();
                    AfficherPaysCourant();

                    btnAjouter.Visible = btnModifier.Visible = btnSupprimer.Visible = true;
                    btnSauvegarder.Visible = btnAnnuler.Visible = false;

                    lblInformation.Text = "Pays " + (indicecourant + 1) + " sur un total de " 
                        + monBureau.Pays.Count;
                }
                // Enresgistrer les donnees apres suppression
                ClsDataSource.SaveTousLesPays(monBureau.Pays);
            }
        }
        

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {

            // Ctreation de l'objet
            ClsPays unPays = new ClsPays(
                txtNomPays.Text,         
                txtMonais.Text,          
                Convert.ToDecimal(txtValeur.Text) 
            );

            if (mode == "Ajout")
            {
                monBureau.Pays.Add(unPays);
                indicecourant = monBureau.Pays.Count - 1;
            }
            else if (mode == "Modif" && monBureau.Pays.Count > 0)
            {
                monBureau.Pays[indicecourant] = unPays;
            }

            // Sauvegarder la collection dans le fichier
            ClsDataSource.SaveTousLesPays(monBureau.Pays);

            // Rafraîchir l’affichage 
            ActualiserListe();
            AfficherPaysCourant();

            // 5) Rétablir l’état des boutons 
            btnAjouter.Visible = btnModifier.Visible = btnSupprimer.Visible = true;
            btnSauvegarder.Visible = btnAnnuler.Visible = false;

            lblInformation.Text = "Pays " + (indicecourant + 1) + " sur un total de " + monBureau.Pays.Count;
            mode = "";
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (monBureau.Pays.Count > 0)
            {
                AfficherPaysCourant();

            }

            frmAdmin_Load(sender, e);
            mode = "";
        }
        private void lstPays_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = 0;
            //Trouver le pays dont le nom a ete selectionne et l'afficher dans le labelle
            // Recuperer nom choisi
            string nomChoisi = lstPays.SelectedItem.ToString();
            // Boucler pour trouver le pays avec ce nom dans la collection
            foreach (ClsPays unPays in monBureau.Pays)
            {
                if (unPays.Nom == nomChoisi)
                {
                    indicecourant = index;
                    // Afficher les infos dans les TextBox
                    txtNomPays.Text = monBureau.Pays[indicecourant].Nom;
                    txtMonais.Text = monBureau.Pays[indicecourant].Monnaie;
                    txtValeur.Text = monBureau.Pays[indicecourant].Valeur.ToString();
                    // Mettre à jour le label d’information
                    lblInformation.Text = "Pays " + (indicecourant + 1) + 
                        " sur un total de " + monBureau.Pays.Count;
                }
            }
            index++;
        }
    }

}
