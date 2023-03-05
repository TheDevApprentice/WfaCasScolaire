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
    public partial class modifierDetruireForm : Form
    {
        public modifierDetruireForm()
        {
            InitializeComponent();
        }
        public void RemplirComboBox()
        {
            var manager = new ManagerCours(); 
            nomCoursComboBox.DataSource = manager.ListeCours();
            nomCoursComboBox.ValueMember = "no_cours"; 
            nomCoursComboBox.DisplayMember= "nom_cours";
        }
        private void modifierDetruireForm_Load(object sender, EventArgs e)
        {
            RemplirComboBox(); 
            nomCoursComboBox.SelectedValue= "";
        }

        private void nomCoursComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                var manager = new ManagerCours();
                tbl_cours cours = manager.GetCoursInformation(nomCoursComboBox.SelectedValue.ToString());
                noCoursTextBox.Text = cours.no_cours.ToString();
                nomCoursTextBox.Text = cours.nom_cours.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void modifierButton_Click(object sender, EventArgs e)
        {
            try
            {
                var manager = new ManagerCours();
                tbl_cours coursAModifier = new tbl_cours();
                coursAModifier.no_cours = noCoursTextBox.Text;
                coursAModifier.nom_cours = nomCoursComboBox.Text; 
                int nbLigneAffected = manager.ModifierCours(coursAModifier);
               
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        private void detruireButton_Click(object sender, EventArgs e)
        {
            try
            {
                var manager = new ManagerCours();
                tbl_cours coursADetruire = (tbl_cours)nomCoursComboBox.SelectedItem;
                int nbLigneAffected = manager.DetruireCours(coursADetruire);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
