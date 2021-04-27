using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleLogin
{
    public partial class Login : Form
    {
        //Donnéées qu'on veut récupérer de la bdd
        public String StrLevel = "Inconnu";
        public String NomUtilisateur = "Inconnu";
        public Login()
        {

            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)//bouton ok
        {
            //On verifie la coherence de login/pass
            //Hasher le mdp en clair
            //Se connecter à la base de données
            //verifier user et mdp
            //Recuperer les infos de l'utilisateur : ID, Nom, Niveau
           
            this.StrLevel = "Administrateur";      //On recupere le niveau de l'utilisateur
            this.NomUtilisateur = "Vallade";
            // Si c'est ok, on positionne DialogResult à OK 
            this.DialogResult = DialogResult.OK;//Modale est validée par OK
           
        }

        private void button1_Click(object sender, EventArgs e)//bouton annuler
        {
            this.DialogResult = DialogResult.Cancel;//Modale est validée par Annuler
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
