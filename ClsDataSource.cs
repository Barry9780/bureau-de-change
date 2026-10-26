using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsPOOBureauEchangeClasse
{
    public class ClsDataSource
    {
        public static List<ClsPays> GetTousLesPays()
        {
            List<ClsPays> TousLesPays = new List<ClsPays>();
            StreamReader monfichier = new StreamReader("PaysDB.txt");

            while (monfichier.EndOfStream == false)
            {
                string nom = monfichier.ReadLine();
                string monnaie = monfichier.ReadLine();
                decimal valeur = Convert.ToDecimal(monfichier.ReadLine());
                ClsPays unPays = new ClsPays(nom, monnaie, valeur);
                TousLesPays.Add(unPays);
            }

            monfichier.Close();
            return TousLesPays;
        }

        public static void SaveTousLesPays(List<ClsPays> LesClsPays)
        {
            StreamWriter monfichier = new StreamWriter("PaysDB.txt");

            foreach (ClsPays unPays in LesClsPays)
            {
                monfichier.WriteLine(unPays.Nom);
                monfichier.WriteLine(unPays.Monnaie);
                monfichier.WriteLine(unPays.Valeur);
            }

            monfichier.Close();
        }
    }
}
