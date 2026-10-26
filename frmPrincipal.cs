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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Voulez vous fermer l'application ?", "Fermeture de l'application",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void bureauDeChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmChange Fc = new frmChange();
            //Fc.MdiParent = this;
            Fc.Show();
        }

        private void gestionDesPaysToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAdmin FA = new frmAdmin();
            FA.Show();
        }
    }
}
