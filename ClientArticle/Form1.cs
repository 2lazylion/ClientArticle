using ClientArticle.ServiceReferenceArticle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientArticle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void lbl1_Click(object sender, EventArgs e)
        {

        }
        private void lblTitre_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Le service
            Service1Client service = new Service1Client();

            // Entite
            ServiceReferenceArticle.Journaliste j = null;
            ServiceReferenceArticle.Article art = new ServiceReferenceArticle.Article();
            

            // propriete de l'article
            string titre;
            string texteArticle;
            int journaliste_id;

            
            // validation des entrees, recherche du journaliste sur la BD et envoie l'article au service
            if(Int32.TryParse(txtId.Text, out journaliste_id) && !txtTitre.Text.Equals("") && !txtArticle.Text.Equals(""))
            {
                Console.WriteLine("ID EXISTANT");
                j = service.GetJournaliste(journaliste_id);
                Console.WriteLine(j.nom);
                Console.WriteLine(j.prenom);

                art.auteur = j;
                art.titre = txtTitre.Text;
                art.texte = txtArticle.Text;
                service.PostArticle(art);
                videForm();
                
            }
            else
            {
                // Dialogue d'erreur a l'usager
            } 

        }

        private void videForm()
        {
            txtArticle.Text = "";
            txtId.Text = "";
            txtTitre.Text = "";
        }
    }
}
