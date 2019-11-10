namespace TourismApp.Forms
{
    partial class FormStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblwelcome = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnNvCompte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblwelcome
            // 
            this.lblwelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.Location = new System.Drawing.Point(163, 9);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(87, 21);
            this.lblwelcome.TabIndex = 0;
            this.lblwelcome.Text = "Bienvenue!";
            this.lblwelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(25, 70);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(163, 23);
            this.btnConnexion.TabIndex = 1;
            this.btnConnexion.Text = "Se Connecter";
            this.btnConnexion.UseVisualStyleBackColor = true;
            // 
            // btnNvCompte
            // 
            this.btnNvCompte.Location = new System.Drawing.Point(220, 70);
            this.btnNvCompte.Name = "btnNvCompte";
            this.btnNvCompte.Size = new System.Drawing.Size(163, 23);
            this.btnNvCompte.TabIndex = 2;
            this.btnNvCompte.Text = "Créer un compte";
            this.btnNvCompte.UseVisualStyleBackColor = true;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(421, 142);
            this.Controls.Add(this.btnNvCompte);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.lblwelcome);
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnNvCompte;
    }
}