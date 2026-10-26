using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsPOOBureauEchangeClasse
{
    public class ClsPays
    {
        
        // Les Champs prives
        private string nom;
        private string monnaie;
        private decimal valeur; 

        //Les Constructeurs
        public ClsPays()
        {
            nom = "Not define";
            monnaie = "Not define";
            valeur = 0;
        }

        public ClsPays(string nom, string monnaie, decimal valeur)
        {
            this.nom = nom;
            this.monnaie = monnaie;
            this.valeur = valeur;
        }

        // Les Proprietes
        public string Nom
        {
            // Lecture Seulement
            get => nom;
            
        }

        public string Monnaie
        {
            get => monnaie;
            set => monnaie = value;
        }

        public decimal Valeur
        {
            get => valeur;
            set => valeur = value;
        }

        // Les Methodes
        
        public void Creer(string nom, string monnaie, decimal valeur)
        {
            this.nom = nom;
            this.monnaie = monnaie;
            this.valeur = valeur;
        }

        
        public decimal GetValeurCanada()
        {
            return valeur;
        }

        public string Afficher()
        {
            string info = "Nom : " + nom +
                          "\nMonnaie : " + monnaie +
                          "\nValeur : " + valeur + " CAD";
            return info;
        }
    }
}
