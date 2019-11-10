using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private Boolean Connexion(string text1, string text2)
        {
            return true;
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider.Clear();

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider.Clear();
        }
    }
}
