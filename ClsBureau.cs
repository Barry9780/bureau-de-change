using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsPOOBureauEchangeClasse
{
    public class ClsBureau
    {
        // Les Champs prives
        private string numero;
        private string nom;
        private string adresse;
        private List<ClsPays> pays;
        private string statut;

        // Les Constructeurs
        public ClsBureau()
        {
            numero = "Not define";
            nom = "Not define";
            adresse = "Not define";
            pays = new List<ClsPays>();
            statut = "Not define";
        }

        public ClsBureau(string numero, string nom, string adresse, List<ClsPays> pays, string statut)
        {
            this.numero = numero;
            this.nom = nom;
            this.adresse = adresse;
            this.pays = pays;
            this.statut = statut;
        }

        public ClsBureau(string numero, string nom, string adresse, string statut)
        {
            this.numero = numero;
            this.nom = nom;
            this.adresse = adresse;
            this.pays = new List<ClsPays>();
            this.statut = statut;
        }

        // Les Proprietes
        public string Numero
        {
            // lecture seulement
            get => numero;
        }

        public string Nom
        {
            get => nom;
            set => nom = value;
        }

        public string Adresse
        {
            get => adresse;
            set => adresse = value;
        }

        public List<ClsPays> Pays
        {
            get => pays;
            set => pays = value;
        }

        public string Statut
        {
            get => statut;
            set => statut = value;
        }

        // Creqtion des Methodes
        
        public void Creer(string numero, string nom, string adresse, List<ClsPays> pays, string statut)
        {
            this.numero = numero;
            this.nom = nom;
            this.adresse = adresse;
            this.pays = pays;
            this.statut = statut;
        }

        //Recherche un pays par nom dans la collection
        public ClsPays TrouverPays(string nomPays)
        {
            foreach (ClsPays unPays in pays)
            {
                if (unPays.Nom == nomPays)
                    return unPays;
            }
            return null;
        }

        // Afficher les infos 
        public string Afficher()
        {
            string info = "Numero : " + numero +
                          "\nNom : " + nom +
                          "\nAdresse : " + adresse +
                          "\nStatut : " + statut +
                          "\nNombre de pays : " + pays.Count;
            return info;
        }

        // Fermer statut (selon l'intitulé)
        public void Fermer()
        {
            statut = "Ferme";
        }
    }
}
    

