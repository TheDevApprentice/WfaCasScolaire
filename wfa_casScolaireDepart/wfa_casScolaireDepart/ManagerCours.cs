using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_casScolaireDepart
{
    public class ManagerCours
    {
        public tbl_cours GetCoursInformation(string no_cours)
        {
            using (var context = new Ah_Db_Cours1Entities1())
            {
                return context.tbl_cours.Find(no_cours);
            }
        }
        public List<tbl_cours> ListeCours()
        {
            List<tbl_cours> listcours = null;

            try
            {
                using (var context = new Ah_Db_Cours1Entities1())
                {
                    //context.Database.Log = Console.Write; 
                    listcours = context.tbl_cours.OrderBy(c => c.nom_cours).ToList();
                }
            }
            catch (Exception ex)
            {
                new Exception(ex.Message);
            }


            return listcours;
        }
        public void AjouterCours(string no_cours, string nom_cours)
        {
            using (var context = new Ah_Db_Cours1Entities1())
            {
                try
                {

                }
                catch (Exception ex )
                {

                    throw new Exception(ex.Message);
                }
            }
        }
        public int ModifierCours(tbl_cours coursAModifier)
        {
            
            using (var context = new Ah_Db_Cours1Entities1())
            {

                try
                {
                    tbl_cours coursModifier = context.tbl_cours.Find(coursAModifier.no_cours);
                    coursModifier.no_cours = coursAModifier.no_cours;
                    coursModifier.nom_cours = coursAModifier.nom_cours;
                    int nbLigneAffected = 0;
                    if (context.ChangeTracker.HasChanges())
                    {
                        nbLigneAffected = context.SaveChanges(); 
                    }
                    return nbLigneAffected; 
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
                finally
                {
                    MessageBox.Show(nbLigneAffected.ToString()); 
                }
            }
        }
        public int DetruireCours(tbl_cours coursADetuire)
        {
            int nbLigneAffected = 0;
            using (var context = new Ah_Db_Cours1Entities1())
            {

                try
                {
                    tbl_cours coursDetuit = context.tbl_cours.Find(coursADetuire.no_cours);
                    context.tbl_cours.Remove(coursDetuit); 


                    if (context.ChangeTracker.HasChanges())
                    {
                        nbLigneAffected = context.SaveChanges();
                    }
                    return nbLigneAffected;
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
                finally
                {
                    MessageBox.Show(nbLigneAffected.ToString());
                }
            }
        }
   
    }
}
