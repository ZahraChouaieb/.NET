namespace TourismApp.Forms
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.recupLieu = new MetroFramework.Controls.MetroGrid();
            this.lieuIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameLieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel = new MetroFramework.Drawing.Html.HtmlPanel();
            this.browser = new MetroFramework.Controls.MetroButton();
            this.Description = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.Temp = new MetroFramework.Controls.MetroTextBox();
            this.temperature = new MetroFramework.Controls.MetroLabel();
            this.ZoneGeo = new MetroFramework.Controls.MetroTextBox();
            this.zone = new MetroFramework.Controls.MetroLabel();
            this.VilleLieu = new MetroFramework.Controls.MetroTextBox();
            this.ville = new MetroFramework.Controls.MetroLabel();
            this.nomLieu = new MetroFramework.Controls.MetroTextBox();
            this.pictureLieu = new System.Windows.Forms.PictureBox();
            this.Sauvegarder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recupLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lieuBindingSource)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(481, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Veuillez gérer vos lieux touristiques";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(715, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AliceBlue;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(592, 419);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(305, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 6;
            // 
            // recupLieu
            // 
            this.recupLieu.AccessibleName = "recupLieu";
            this.recupLieu.AllowUserToResizeRows = false;
            this.recupLieu.AutoGenerateColumns = false;
            this.recupLieu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.recupLieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recupLieu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.recupLieu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recupLieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.recupLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recupLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lieuIdDataGridViewTextBoxColumn,
            this.nameLieuDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.recupLieu.DataSource = this.lieuBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.recupLieu.DefaultCellStyle = dataGridViewCellStyle2;
            this.recupLieu.EnableHeadersVisualStyles = false;
            this.recupLieu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.recupLieu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.recupLieu.Location = new System.Drawing.Point(23, 135);
            this.recupLieu.Name = "recupLieu";
            this.recupLieu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recupLieu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.recupLieu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.recupLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recupLieu.Size = new System.Drawing.Size(426, 229);
            this.recupLieu.TabIndex = 10;
            this.recupLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recupLieu_CellClick);
            this.recupLieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recupLieu_CellContentClick);
            // 
            // lieuIdDataGridViewTextBoxColumn
            // 
            this.lieuIdDataGridViewTextBoxColumn.DataPropertyName = "lieuId";
            this.lieuIdDataGridViewTextBoxColumn.HeaderText = "lieuId";
            this.lieuIdDataGridViewTextBoxColumn.Name = "lieuIdDataGridViewTextBoxColumn";
            // 
            // nameLieuDataGridViewTextBoxColumn
            // 
            this.nameLieuDataGridViewTextBoxColumn.DataPropertyName = "nameLieu";
            this.nameLieuDataGridViewTextBoxColumn.HeaderText = "nameLieu";
            this.nameLieuDataGridViewTextBoxColumn.Name = "nameLieuDataGridViewTextBoxColumn";
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // lieuBindingSource
            // 
            this.lieuBindingSource.DataSource = typeof(TourismApp.Model.Lieu);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.AutoScrollMinSize = new System.Drawing.Size(458, 0);
            this.panel.BackColor = System.Drawing.SystemColors.Window;
            this.panel.Controls.Add(this.browser);
            this.panel.Controls.Add(this.Description);
            this.panel.Controls.Add(this.metroLabel1);
            this.panel.Controls.Add(this.metroLabel5);
            this.panel.Controls.Add(this.Temp);
            this.panel.Controls.Add(this.temperature);
            this.panel.Controls.Add(this.ZoneGeo);
            this.panel.Controls.Add(this.zone);
            this.panel.Controls.Add(this.VilleLieu);
            this.panel.Controls.Add(this.ville);
            this.panel.Controls.Add(this.nomLieu);
            this.panel.Controls.Add(this.pictureLieu);
            this.panel.Location = new System.Drawing.Point(504, 94);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(458, 290);
            this.panel.TabIndex = 11;
            // 
            // browser
            // 
            this.browser.BackColor = System.Drawing.Color.AliceBlue;
            this.browser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.browser.Location = new System.Drawing.Point(352, 132);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(75, 20);
            this.browser.TabIndex = 15;
            this.browser.Text = "Browser";
            this.browser.UseSelectable = true;
            this.browser.Click += new System.EventHandler(this.browser_Click);
            // 
            // Description
            // 
            this.Description.AccessibleName = "Description";
            this.Description.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lieuBindingSource, "description", true));
            this.Description.Location = new System.Drawing.Point(106, 175);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(176, 95);
            this.Description.TabIndex = 14;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(42, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(33, 15);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Nom";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.Location = new System.Drawing.Point(29, 181);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(63, 15);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Description";
            // 
            // Temp
            // 
            this.Temp.AccessibleName = "Temp";
            // 
            // 
            // 
            this.Temp.CustomButton.Image = null;
            this.Temp.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.Temp.CustomButton.Name = "";
            this.Temp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Temp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Temp.CustomButton.TabIndex = 1;
            this.Temp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Temp.CustomButton.UseSelectable = true;
            this.Temp.CustomButton.Visible = false;
            this.Temp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lieuBindingSource, "temperatureZone", true));
            this.Temp.Lines = new string[0];
            this.Temp.Location = new System.Drawing.Point(106, 129);
            this.Temp.MaxLength = 32767;
            this.Temp.Name = "Temp";
            this.Temp.PasswordChar = '\0';
            this.Temp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Temp.SelectedText = "";
            this.Temp.SelectionLength = 0;
            this.Temp.SelectionStart = 0;
            this.Temp.ShortcutsEnabled = true;
            this.Temp.Size = new System.Drawing.Size(176, 23);
            this.Temp.TabIndex = 8;
            this.Temp.UseSelectable = true;
            this.Temp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Temp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.FontSize = MetroFramework.MetroLabelSize.Small;
            this.temperature.Location = new System.Drawing.Point(25, 135);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(70, 15);
            this.temperature.TabIndex = 7;
            this.temperature.Text = "Température";
            // 
            // ZoneGeo
            // 
            this.ZoneGeo.AccessibleName = "zoneGeo";
            // 
            // 
            // 
            this.ZoneGeo.CustomButton.Image = null;
            this.ZoneGeo.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.ZoneGeo.CustomButton.Name = "";
            this.ZoneGeo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ZoneGeo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ZoneGeo.CustomButton.TabIndex = 1;
            this.ZoneGeo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ZoneGeo.CustomButton.UseSelectable = true;
            this.ZoneGeo.CustomButton.Visible = false;
            this.ZoneGeo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lieuBindingSource, "zoneGeo", true));
            this.ZoneGeo.Lines = new string[0];
            this.ZoneGeo.Location = new System.Drawing.Point(106, 88);
            this.ZoneGeo.MaxLength = 32767;
            this.ZoneGeo.Name = "ZoneGeo";
            this.ZoneGeo.PasswordChar = '\0';
            this.ZoneGeo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ZoneGeo.SelectedText = "";
            this.ZoneGeo.SelectionLength = 0;
            this.ZoneGeo.SelectionStart = 0;
            this.ZoneGeo.ShortcutsEnabled = true;
            this.ZoneGeo.Size = new System.Drawing.Size(176, 23);
            this.ZoneGeo.TabIndex = 6;
            this.ZoneGeo.UseSelectable = true;
            this.ZoneGeo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ZoneGeo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // zone
            // 
            this.zone.AutoSize = true;
            this.zone.FontSize = MetroFramework.MetroLabelSize.Small;
            this.zone.Location = new System.Drawing.Point(-1, 92);
            this.zone.Name = "zone";
            this.zone.Size = new System.Drawing.Size(108, 15);
            this.zone.TabIndex = 5;
            this.zone.Text = "Zone Géographique";
            this.zone.Click += new System.EventHandler(this.zone_Click);
            // 
            // VilleLieu
            // 
            this.VilleLieu.AccessibleName = "villeLieu";
            // 
            // 
            // 
            this.VilleLieu.CustomButton.Image = null;
            this.VilleLieu.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.VilleLieu.CustomButton.Name = "";
            this.VilleLieu.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.VilleLieu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.VilleLieu.CustomButton.TabIndex = 1;
            this.VilleLieu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VilleLieu.CustomButton.UseSelectable = true;
            this.VilleLieu.CustomButton.Visible = false;
            this.VilleLieu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lieuBindingSource, "ville", true));
            this.VilleLieu.Lines = new string[0];
            this.VilleLieu.Location = new System.Drawing.Point(106, 50);
            this.VilleLieu.MaxLength = 32767;
            this.VilleLieu.Name = "VilleLieu";
            this.VilleLieu.PasswordChar = '\0';
            this.VilleLieu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VilleLieu.SelectedText = "";
            this.VilleLieu.SelectionLength = 0;
            this.VilleLieu.SelectionStart = 0;
            this.VilleLieu.ShortcutsEnabled = true;
            this.VilleLieu.Size = new System.Drawing.Size(176, 23);
            this.VilleLieu.TabIndex = 4;
            this.VilleLieu.UseSelectable = true;
            this.VilleLieu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.VilleLieu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ville
            // 
            this.ville.AutoSize = true;
            this.ville.FontSize = MetroFramework.MetroLabelSize.Small;
            this.ville.Location = new System.Drawing.Point(46, 54);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(26, 15);
            this.ville.TabIndex = 3;
            this.ville.Text = "Ville";
            this.ville.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // nomLieu
            // 
            this.nomLieu.AccessibleName = "nameLieu";
            // 
            // 
            // 
            this.nomLieu.CustomButton.Image = null;
            this.nomLieu.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.nomLieu.CustomButton.Name = "";
            this.nomLieu.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nomLieu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nomLieu.CustomButton.TabIndex = 1;
            this.nomLieu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nomLieu.CustomButton.UseSelectable = true;
            this.nomLieu.CustomButton.Visible = false;
            this.nomLieu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lieuBindingSource, "nameLieu", true));
            this.nomLieu.Lines = new string[0];
            this.nomLieu.Location = new System.Drawing.Point(106, 8);
            this.nomLieu.MaxLength = 32767;
            this.nomLieu.Name = "nomLieu";
            this.nomLieu.PasswordChar = '\0';
            this.nomLieu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nomLieu.SelectedText = "";
            this.nomLieu.SelectionLength = 0;
            this.nomLieu.SelectionStart = 0;
            this.nomLieu.ShortcutsEnabled = true;
            this.nomLieu.Size = new System.Drawing.Size(176, 23);
            this.nomLieu.TabIndex = 2;
            this.nomLieu.UseSelectable = true;
            this.nomLieu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nomLieu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureLieu
            // 
            this.pictureLieu.AccessibleName = "image";
            this.pictureLieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureLieu.Location = new System.Drawing.Point(337, 9);
            this.pictureLieu.Name = "pictureLieu";
            this.pictureLieu.Size = new System.Drawing.Size(100, 114);
            this.pictureLieu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLieu.TabIndex = 0;
            this.pictureLieu.TabStop = false;
            this.pictureLieu.Click += new System.EventHandler(this.image_Click);
            // 
            // Sauvegarder
            // 
            this.Sauvegarder.BackColor = System.Drawing.Color.AliceBlue;
            this.Sauvegarder.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sauvegarder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sauvegarder.Location = new System.Drawing.Point(833, 419);
            this.Sauvegarder.Name = "Sauvegarder";
            this.Sauvegarder.Size = new System.Drawing.Size(116, 23);
            this.Sauvegarder.TabIndex = 12;
            this.Sauvegarder.Text = "Sauvegarder";
            this.Sauvegarder.UseVisualStyleBackColor = false;
            this.Sauvegarder.Click += new System.EventHandler(this.Sauvegarder_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 465);
            this.Controls.Add(this.Sauvegarder);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.recupLieu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "FormMain";
            this.Text = "Espace Admin";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recupLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lieuBindingSource)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource lieuBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroGrid recupLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieuIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameLieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private MetroFramework.Drawing.Html.HtmlPanel panel;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox Temp;
        private MetroFramework.Controls.MetroLabel temperature;
        private MetroFramework.Controls.MetroTextBox ZoneGeo;
        private MetroFramework.Controls.MetroLabel zone;
        private MetroFramework.Controls.MetroTextBox VilleLieu;
        private MetroFramework.Controls.MetroLabel ville;
        private MetroFramework.Controls.MetroTextBox nomLieu;
        private System.Windows.Forms.PictureBox pictureLieu;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton browser;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Button Sauvegarder;
    }
}