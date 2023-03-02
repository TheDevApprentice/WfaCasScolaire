using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_casScolaireDepart
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void ajouterUnCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouterCoursForm maForme = new ajouterCoursForm();
            maForme.ShowDialog();
        }

        private void modifierdétruireUnCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifierDetruireForm maForme = new modifierDetruireForm();
            maForme.ShowDialog();
        }
    }
}
