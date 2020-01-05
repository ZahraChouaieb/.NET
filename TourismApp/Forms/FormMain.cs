using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourismApp.Model;

namespace TourismApp.Forms
{
    public partial class FormMain : MetroFramework.Forms.MetroForm 
    {
        public FormMain()
        {
            InitializeComponent();
           // FillCombo();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      


        private void button1_Click(object sender, EventArgs e)
        {
            pictureLieu.Image = null;
            panel.Enabled = true;
            lieuBindingSource.Add(new Lieu());
            lieuBindingSource.MoveLast();
            nomLieu.Focus();
        }
      
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     
        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'tourismBDDataSet.Categories'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.categoriesTableAdapter.Fill(this.tourismBDDataSet.Categories);


            using (MyDbContext db = new MyDbContext())
            {
                lieuBindingSource.DataSource = db.Lieu.ToList();
            }
            panel.Enabled = false; 
            Lieu obj = lieuBindingSource.Current as Lieu;

            if (obj != null)
            {
              pictureLieu.Image = Image.FromFile(obj.image);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Vous etes sur de vouloir supprimer ce lieu ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MyDbContext db = new MyDbContext())
                {
                    
                    Lieu l = lieuBindingSource.Current as Lieu;
                    if (l != null)
                    {
                        if (db.Entry<Lieu>(l).State == System.Data.Entity.EntityState.Detached)
                            db.Set<Lieu>().Attach(l);
                        db.Entry<Lieu>(l).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Lieu supprimé");
                        lieuBindingSource.RemoveCurrent();
                        panel.Enabled = false;
                        pictureLieu.Image = null;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            nomLieu.Focus();
            lieuBindingSource.ResetBindings(false); 
          
        }

      /*  private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MyDbContext db = new MyDbContext();
                int idLieu = Convert.ToInt32(recupLieu.Rows[recupLieu.CurrentRow.Index].Cells[0].Value);
                var l = db.Lieu.Find(idLieu);
                l.nameLieu = nomLieu.Text.ToString();
                l.ville = VilleLieu.Text.ToString();
                l.temperatureZone = Temp.Text.ToString();
                l.zoneGeo = ZoneGeo.Text.ToString();
                l.description = Description.Text.ToString();
                //pictureLieu.Image = Image.FromFile(l.image);
                String msg = l.nameLieu +" "+ l.ville +" "+ l.temperatureZone + " " + l.zoneGeo + " "+ l.description;

                MetroFramework.MetroMessageBox.Show(this, msg);

            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show("msg : " + ex.EntityValidationErrors);
            }
        } */

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void zone_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void image_Click(object sender, EventArgs e)
        {

        }

        private void browser_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureLieu.Image = Image.FromFile(ofd.FileName);
                    Lieu obj = lieuBindingSource.Current as Lieu;
                    if (obj != null)
                    {
                        obj.image = ofd.FileName;
                    }
                }



            }
        }

        private void Sauvegarder_Click(object sender, EventArgs e)
        {
          

            using (MyDbContext db = new MyDbContext())
            {
                Lieu l = lieuBindingSource.Current as Lieu;
                if( l != null)
                {
                    if (db.Entry<Lieu>(l).State == System.Data.Entity.EntityState.Detached)
                        db.Set<Lieu>().Attach(l);
                    if (l.lieuId == 0)
                        db.Entry<Lieu>(l).State = System.Data.Entity.EntityState.Added;
                    else
                        db.Entry<Lieu>(l).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Saved successfully");
                    recupLieu.Refresh();
                    panel.Enabled = false; 

                }
            }

        }

        private void recupLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Lieu l = lieuBindingSource.Current as Lieu;
            if (l != null)
                pictureLieu.Image = Image.FromFile(l.image); 
        }
      /*  void FillCombo()
        {
            SqlConnection oConnexion = new SqlConnection("Data Source=pc-fatma;Initial Catalog=TourismBD;Integrated Security=True");
            SqlCommand oCommand = new SqlCommand("SELECT * FROM Categories", oConnexion);
            try
            {
                // Ouverture de la connexion et exécution de la requête
                oConnexion.Open();

                SqlDataReader drCat = oCommand.ExecuteReader();
                // Parcours de la liste des utilisateurs
                while (drCat.Read())
                {
                    String cName = drCat["name"].ToString();
                    comboBox1.Items.Add(cName);
                }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }
            oConnexion.Close();

        }*/

        private void recupLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lieuBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void temperature_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoriesTableAdapter.FillBy(this.tourismBDDataSet.Categories);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
