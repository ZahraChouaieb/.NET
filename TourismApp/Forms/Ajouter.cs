using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourismApp.Model;

namespace TourismApp.Forms
{
    public partial class Ajouter : Form
    {
        public Ajouter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Ajouter_Load(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                lieuBindingSource.DataSource = db.Lieu.ToList();
            }
            Lieu obj = lieuBindingSource.Current as Lieu;
           
            if (obj != null)
            {
                pictureBox1.Image = Image.FromFile(obj.image);
              
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg"})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    Lieu obj = lieuBindingSource.Current as Lieu; 
                    if (obj != null)
                    {
                        obj.image = ofd.FileName;
                    }
                }

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lieuBindingSource.Add(new Lieu());
            lieuBindingSource.MoveLast(); 

            using( MyDbContext db = new MyDbContext() )
            {
                Lieu obj = lieuBindingSource.Current as Lieu;
                obj.nameLieu = textBox1.Text.Trim();
                obj.ville = textBox2.Text.Trim();
                obj.zoneGeo = textBox3.Text.Trim();
                obj.temperatureZone = textBox4.Text.Trim();
                obj.description = textBox5.Text.Trim(); 

                System.Windows.Forms.MessageBox.Show("hhhhhhh : " + obj.nameLieu);

                  
                    // if (db.Entry<Lieu>(obj).State == System.Data.Entity.EntityState.Detached)
                    //db.Entry<Lieu>(obj).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                    System.Windows.Forms.MessageBox.Show(this,"Saved Successfully!");



                
            }
        }
    }
}
