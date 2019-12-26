using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourismApp.Forms
{
    public partial class FormLogin : Form 
    {
        ErrorProvider errorProvider = new ErrorProvider();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            String login = txtLogin.Text;
            String password = txtPassword.Text;
            if (!String.IsNullOrEmpty(login) && !String.IsNullOrEmpty(password))
            {
                
                if (Connexion(login , password ))
                {
                   
                    Forms.FormMain formMain = new FormMain();
                    formMain.ShowDialog();
                }
                else
                {
                   
                    this.errorProvider.SetError(txtLogin, "Login ou Mot de passe incorrect. Veuillez vérifier vos coordonnées");

                }
            }
            else
            {
                if (String.IsNullOrEmpty(login))
                {
                    this.errorProvider.SetError(txtLogin, "Le champ Login ne peut pas etre vide!");
                }
                else
                {
                    this.errorProvider.SetError(txtPassword, "Le champ Mot de passe ne peut pas etre vide!");

                }

            }

        }

        private Boolean Connexion(string strUtilisateur, string strMotDePasse)
        {
            bool bOk = false;
            // Cryptage du mot de passe
            //strMotDePasse = FormsAuthentication.HashPasswordForStoringInConfigFile(strMotDePasse, "MD5");
            // Création d'une connexion SGBD
            SqlConnection oConnexion = new SqlConnection("Initial Catalog=TourismBD;Data Source=.;Integrated Security=True");
            // Définition de la requête à exécuter
            SqlCommand oCommand = new SqlCommand("SELECT * FROM Users WHERE Name='" + strUtilisateur + "'", oConnexion);
            try
            {
                // Ouverture de la connexion et exécution de la requête
                oConnexion.Open();
               
                SqlDataReader drUtilisateur = oCommand.ExecuteReader();
                // Parcours de la liste des utilisateurs
                while (drUtilisateur.Read())
                {
                  
                    if (drUtilisateur["Password"].ToString() == strMotDePasse)
                    {
                        bOk = true; break;
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
             
                bOk = false;
            }
            
               
        
            oConnexion.Close();
            return bOk;
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider.Clear();

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
