namespace AppTélécommande
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.vsiLuminosité = new VisualArrays.VisualCells.VisualInt();
            this.panAjustements = new System.Windows.Forms.Panel();
            this.lblNomModeImage = new System.Windows.Forms.Label();
            this.lblNetteté = new System.Windows.Forms.Label();
            this.vsiNetteté = new VisualArrays.VisualCells.VisualInt();
            this.lblTeinte = new System.Windows.Forms.Label();
            this.vsiTeinte = new VisualArrays.VisualCells.VisualInt();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.vsiCouleur = new VisualArrays.VisualCells.VisualInt();
            this.label1 = new System.Windows.Forms.Label();
            this.lblContraste = new System.Windows.Forms.Label();
            this.vsiContraste = new VisualArrays.VisualCells.VisualInt();
            this.lblLuminosité = new System.Windows.Forms.Label();
            this.btnMémoriser = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.cboSourceCourante = new System.Windows.Forms.ComboBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.btnSourdine = new System.Windows.Forms.Button();
            this.btnCanalMoins = new System.Windows.Forms.Button();
            this.btnCanalPlus = new System.Windows.Forms.Button();
            this.btnVolumeMoins = new System.Windows.Forms.Button();
            this.btnVolumePlus = new System.Windows.Forms.Button();
            this.lblVolume = new System.Windows.Forms.Label();
            this.vsiVolume = new VisualArrays.VisualCells.VisualInt();
            this.vsiCanal = new VisualArrays.VisualCells.VisualInt();
            this.lblCanal = new System.Windows.Forms.Label();
            this.lblSourdine = new System.Windows.Forms.Label();
            this.panBase = new System.Windows.Forms.Panel();
            this.lblÉtatSourdine = new System.Windows.Forms.Label();
            this.lblChampsSourdine = new System.Windows.Forms.Label();
            this.lblChampsCanal = new System.Windows.Forms.Label();
            this.lblChampsVolume = new System.Windows.Forms.Label();
            this.btnModeImageSuivant = new System.Windows.Forms.Button();
            this.panAjustements.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // vsiLuminosité
            // 
            this.vsiLuminosité.BackColor = System.Drawing.Color.DarkGray;
            this.vsiLuminosité.BorderColor = System.Drawing.Color.Black;
            this.vsiLuminosité.FocusColor = System.Drawing.Color.Gray;
            this.vsiLuminosité.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiLuminosité.ForeColor = System.Drawing.Color.White;
            this.vsiLuminosité.GraphAppearance.BarColor = System.Drawing.Color.DarkCyan;
            this.vsiLuminosité.GraphAppearance.BarMargin = new System.Windows.Forms.Padding(2);
            this.vsiLuminosité.Location = new System.Drawing.Point(17, 62);
            this.vsiLuminosité.Minimum = 0;
            this.vsiLuminosité.Name = "vsiLuminosité";
            this.vsiLuminosité.Size = new System.Drawing.Size(197, 19);
            this.vsiLuminosité.TabIndex = 3;
            this.vsiLuminosité.TabStop = false;
            this.vsiLuminosité.View = VisualArrays.enuIntView.GraphNumber;
            this.vsiLuminosité.ValueChanged += new System.EventHandler(this.vsiLuminosité_ValueChanged);
            // 
            // panAjustements
            // 
            this.panAjustements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panAjustements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panAjustements.Controls.Add(this.lblNomModeImage);
            this.panAjustements.Controls.Add(this.lblNetteté);
            this.panAjustements.Controls.Add(this.vsiNetteté);
            this.panAjustements.Controls.Add(this.lblTeinte);
            this.panAjustements.Controls.Add(this.vsiTeinte);
            this.panAjustements.Controls.Add(this.lblCouleur);
            this.panAjustements.Controls.Add(this.vsiCouleur);
            this.panAjustements.Controls.Add(this.label1);
            this.panAjustements.Controls.Add(this.lblContraste);
            this.panAjustements.Controls.Add(this.vsiContraste);
            this.panAjustements.Controls.Add(this.lblLuminosité);
            this.panAjustements.Controls.Add(this.btnMémoriser);
            this.panAjustements.Controls.Add(this.vsiLuminosité);
            this.panAjustements.Location = new System.Drawing.Point(44, 114);
            this.panAjustements.Name = "panAjustements";
            this.panAjustements.Size = new System.Drawing.Size(237, 297);
            this.panAjustements.TabIndex = 1;
            // 
            // lblNomModeImage
            // 
            this.lblNomModeImage.BackColor = System.Drawing.Color.Silver;
            this.lblNomModeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomModeImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomModeImage.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNomModeImage.Location = new System.Drawing.Point(90, 12);
            this.lblNomModeImage.Name = "lblNomModeImage";
            this.lblNomModeImage.Size = new System.Drawing.Size(124, 25);
            this.lblNomModeImage.TabIndex = 1;
            this.lblNomModeImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNomModeImage.Click += new System.EventHandler(this.lblNomModeImage_Click);
            // 
            // lblNetteté
            // 
            this.lblNetteté.ForeColor = System.Drawing.Color.Silver;
            this.lblNetteté.Location = new System.Drawing.Point(14, 209);
            this.lblNetteté.Name = "lblNetteté";
            this.lblNetteté.Size = new System.Drawing.Size(200, 13);
            this.lblNetteté.TabIndex = 10;
            this.lblNetteté.Text = "&Netteté :";
            // 
            // vsiNetteté
            // 
            this.vsiNetteté.BackColor = System.Drawing.Color.DarkGray;
            this.vsiNetteté.BorderColor = System.Drawing.Color.Black;
            this.vsiNetteté.FocusColor = System.Drawing.Color.Gray;
            this.vsiNetteté.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiNetteté.ForeColor = System.Drawing.Color.White;
            this.vsiNetteté.GraphAppearance.BarColor = System.Drawing.Color.DarkCyan;
            this.vsiNetteté.GraphAppearance.BarMargin = new System.Windows.Forms.Padding(2);
            this.vsiNetteté.Location = new System.Drawing.Point(17, 224);
            this.vsiNetteté.Maximum = 10;
            this.vsiNetteté.Minimum = 0;
            this.vsiNetteté.Name = "vsiNetteté";
            this.vsiNetteté.Size = new System.Drawing.Size(197, 19);
            this.vsiNetteté.TabIndex = 11;
            this.vsiNetteté.View = VisualArrays.enuIntView.GraphNumber;
            // 
            // lblTeinte
            // 
            this.lblTeinte.ForeColor = System.Drawing.Color.Silver;
            this.lblTeinte.Location = new System.Drawing.Point(14, 167);
            this.lblTeinte.Name = "lblTeinte";
            this.lblTeinte.Size = new System.Drawing.Size(200, 13);
            this.lblTeinte.TabIndex = 8;
            this.lblTeinte.Text = "&Teinte :";
            // 
            // vsiTeinte
            // 
            this.vsiTeinte.BackColor = System.Drawing.Color.DarkGray;
            this.vsiTeinte.BorderColor = System.Drawing.Color.Black;
            this.vsiTeinte.FocusColor = System.Drawing.Color.Gray;
            this.vsiTeinte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiTeinte.ForeColor = System.Drawing.Color.White;
            this.vsiTeinte.GraphAppearance.BarColor = System.Drawing.Color.DarkCyan;
            this.vsiTeinte.GraphAppearance.BarMargin = new System.Windows.Forms.Padding(2);
            this.vsiTeinte.Location = new System.Drawing.Point(17, 182);
            this.vsiTeinte.Maximum = 10;
            this.vsiTeinte.Minimum = -10;
            this.vsiTeinte.Name = "vsiTeinte";
            this.vsiTeinte.Size = new System.Drawing.Size(197, 19);
            this.vsiTeinte.TabIndex = 9;
            this.vsiTeinte.View = VisualArrays.enuIntView.GraphNumber;
            // 
            // lblCouleur
            // 
            this.lblCouleur.ForeColor = System.Drawing.Color.Silver;
            this.lblCouleur.Location = new System.Drawing.Point(14, 128);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(200, 13);
            this.lblCouleur.TabIndex = 6;
            this.lblCouleur.Text = "C&ouleur :";
            // 
            // vsiCouleur
            // 
            this.vsiCouleur.BackColor = System.Drawing.Color.DarkGray;
            this.vsiCouleur.BorderColor = System.Drawing.Color.Black;
            this.vsiCouleur.FocusColor = System.Drawing.Color.Gray;
            this.vsiCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiCouleur.ForeColor = System.Drawing.Color.White;
            this.vsiCouleur.GraphAppearance.BarColor = System.Drawing.Color.DarkCyan;
            this.vsiCouleur.GraphAppearance.BarMargin = new System.Windows.Forms.Padding(2);
            this.vsiCouleur.Location = new System.Drawing.Point(17, 142);
            this.vsiCouleur.Minimum = 0;
            this.vsiCouleur.Name = "vsiCouleur";
            this.vsiCouleur.Size = new System.Drawing.Size(197, 19);
            this.vsiCouleur.TabIndex = 7;
            this.vsiCouleur.View = VisualArrays.enuIntView.GraphNumber;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Mode Image :";
            // 
            // lblContraste
            // 
            this.lblContraste.ForeColor = System.Drawing.Color.Silver;
            this.lblContraste.Location = new System.Drawing.Point(14, 88);
            this.lblContraste.Name = "lblContraste";
            this.lblContraste.Size = new System.Drawing.Size(200, 13);
            this.lblContraste.TabIndex = 4;
            this.lblContraste.Text = "&Constraste :";
            // 
            // vsiContraste
            // 
            this.vsiContraste.BackColor = System.Drawing.Color.DarkGray;
            this.vsiContraste.BorderColor = System.Drawing.Color.Black;
            this.vsiContraste.FocusColor = System.Drawing.Color.Gray;
            this.vsiContraste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiContraste.ForeColor = System.Drawing.Color.White;
            this.vsiContraste.GraphAppearance.BarColor = System.Drawing.Color.DarkCyan;
            this.vsiContraste.GraphAppearance.BarMargin = new System.Windows.Forms.Padding(2);
            this.vsiContraste.Location = new System.Drawing.Point(17, 102);
            this.vsiContraste.Minimum = 0;
            this.vsiContraste.Name = "vsiContraste";
            this.vsiContraste.Size = new System.Drawing.Size(197, 19);
            this.vsiContraste.TabIndex = 5;
            this.vsiContraste.View = VisualArrays.enuIntView.GraphNumber;
            // 
            // lblLuminosité
            // 
            this.lblLuminosité.ForeColor = System.Drawing.Color.Silver;
            this.lblLuminosité.Location = new System.Drawing.Point(14, 48);
            this.lblLuminosité.Name = "lblLuminosité";
            this.lblLuminosité.Size = new System.Drawing.Size(200, 13);
            this.lblLuminosité.TabIndex = 2;
            this.lblLuminosité.Text = "&Luminosité :";
            // 
            // btnMémoriser
            // 
            this.btnMémoriser.BackColor = System.Drawing.Color.Transparent;
            this.btnMémoriser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMémoriser.Location = new System.Drawing.Point(17, 259);
            this.btnMémoriser.Name = "btnMémoriser";
            this.btnMémoriser.Size = new System.Drawing.Size(197, 24);
            this.btnMémoriser.TabIndex = 2;
            this.btnMémoriser.Text = "Mémoriser les ajustements";
            this.btnMémoriser.UseVisualStyleBackColor = false;
            this.btnMémoriser.Click += new System.EventHandler(this.BtnMémoriser_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(324, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(154, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.MnuFichierQuitter_Click);
            // 
            // cboSourceCourante
            // 
            this.cboSourceCourante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSourceCourante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSourceCourante.FormattingEnabled = true;
            this.cboSourceCourante.Items.AddRange(new object[] {
            "HDMI 1",
            "HDMI 2",
            "HDMI 3",
            "Netflix",
            "Prime",
            "Crave",
            "YouTube",
            "TV"});
            this.cboSourceCourante.Location = new System.Drawing.Point(137, 80);
            this.cboSourceCourante.Name = "cboSourceCourante";
            this.cboSourceCourante.Size = new System.Drawing.Size(122, 26);
            this.cboSourceCourante.TabIndex = 4;
            this.cboSourceCourante.SelectedIndexChanged += new System.EventHandler(this.CboSourceCourante_SelectedIndexChanged);
            // 
            // lblSource
            // 
            this.lblSource.BackColor = System.Drawing.Color.Transparent;
            this.lblSource.ForeColor = System.Drawing.Color.White;
            this.lblSource.Location = new System.Drawing.Point(81, 83);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(50, 19);
            this.lblSource.TabIndex = 12;
            this.lblSource.Text = "Source :";
            this.lblSource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSourdine
            // 
            this.btnSourdine.BackColor = System.Drawing.Color.Transparent;
            this.btnSourdine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSourdine.Location = new System.Drawing.Point(135, 633);
            this.btnSourdine.Name = "btnSourdine";
            this.btnSourdine.Size = new System.Drawing.Size(57, 30);
            this.btnSourdine.TabIndex = 55;
            this.btnSourdine.UseVisualStyleBackColor = false;
            this.btnSourdine.Click += new System.EventHandler(this.BtnSourdine_Click);
            // 
            // btnCanalMoins
            // 
            this.btnCanalMoins.BackColor = System.Drawing.Color.Transparent;
            this.btnCanalMoins.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCanalMoins.Location = new System.Drawing.Point(207, 652);
            this.btnCanalMoins.Name = "btnCanalMoins";
            this.btnCanalMoins.Size = new System.Drawing.Size(42, 32);
            this.btnCanalMoins.TabIndex = 54;
            this.btnCanalMoins.UseVisualStyleBackColor = false;
            this.btnCanalMoins.Click += new System.EventHandler(this.BtnCanalMoins_Click);
            // 
            // btnCanalPlus
            // 
            this.btnCanalPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnCanalPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCanalPlus.Location = new System.Drawing.Point(206, 609);
            this.btnCanalPlus.Name = "btnCanalPlus";
            this.btnCanalPlus.Size = new System.Drawing.Size(43, 32);
            this.btnCanalPlus.TabIndex = 53;
            this.btnCanalPlus.UseVisualStyleBackColor = false;
            this.btnCanalPlus.Click += new System.EventHandler(this.BtnCanalPlus_Click);
            // 
            // btnVolumeMoins
            // 
            this.btnVolumeMoins.BackColor = System.Drawing.Color.Transparent;
            this.btnVolumeMoins.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolumeMoins.Location = new System.Drawing.Point(76, 652);
            this.btnVolumeMoins.Name = "btnVolumeMoins";
            this.btnVolumeMoins.Size = new System.Drawing.Size(42, 32);
            this.btnVolumeMoins.TabIndex = 52;
            this.btnVolumeMoins.UseVisualStyleBackColor = false;
            this.btnVolumeMoins.Click += new System.EventHandler(this.BtnVolumeMoins_Click);
            // 
            // btnVolumePlus
            // 
            this.btnVolumePlus.BackColor = System.Drawing.Color.Transparent;
            this.btnVolumePlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolumePlus.Location = new System.Drawing.Point(76, 609);
            this.btnVolumePlus.Name = "btnVolumePlus";
            this.btnVolumePlus.Size = new System.Drawing.Size(43, 32);
            this.btnVolumePlus.TabIndex = 51;
            this.btnVolumePlus.UseVisualStyleBackColor = false;
            this.btnVolumePlus.Click += new System.EventHandler(this.BtnVolumePlus_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.BackColor = System.Drawing.Color.Transparent;
            this.lblVolume.ForeColor = System.Drawing.Color.White;
            this.lblVolume.Location = new System.Drawing.Point(76, 591);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(43, 15);
            this.lblVolume.TabIndex = 56;
            this.lblVolume.Text = "Volume";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vsiVolume
            // 
            this.vsiVolume.BackColor = System.Drawing.Color.DarkGray;
            this.vsiVolume.BorderColor = System.Drawing.Color.Black;
            this.vsiVolume.FocusColor = System.Drawing.Color.Gray;
            this.vsiVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiVolume.ForeColor = System.Drawing.Color.White;
            this.vsiVolume.GraphAppearance.BarColor = System.Drawing.Color.DarkCyan;
            this.vsiVolume.GraphAppearance.BarMargin = new System.Windows.Forms.Padding(2);
            this.vsiVolume.Location = new System.Drawing.Point(19, 21);
            this.vsiVolume.Maximum = 50;
            this.vsiVolume.Minimum = 0;
            this.vsiVolume.Name = "vsiVolume";
            this.vsiVolume.ReadOnly = true;
            this.vsiVolume.Size = new System.Drawing.Size(197, 19);
            this.vsiVolume.TabIndex = 57;
            this.vsiVolume.TabStop = false;
            this.vsiVolume.View = VisualArrays.enuIntView.GraphNumber;
            // 
            // vsiCanal
            // 
            this.vsiCanal.BackColor = System.Drawing.Color.DarkGray;
            this.vsiCanal.BorderColor = System.Drawing.Color.Black;
            this.vsiCanal.FocusColor = System.Drawing.Color.Gray;
            this.vsiCanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiCanal.ForeColor = System.Drawing.Color.White;
            this.vsiCanal.GraphAppearance.BarColor = System.Drawing.Color.DarkCyan;
            this.vsiCanal.GraphAppearance.BarMargin = new System.Windows.Forms.Padding(2);
            this.vsiCanal.Location = new System.Drawing.Point(165, 55);
            this.vsiCanal.Maximum = 125;
            this.vsiCanal.Minimum = 2;
            this.vsiCanal.Name = "vsiCanal";
            this.vsiCanal.ReadOnly = true;
            this.vsiCanal.Size = new System.Drawing.Size(51, 25);
            this.vsiCanal.TabIndex = 59;
            this.vsiCanal.TabStop = false;
            this.vsiCanal.Value = 2;
            // 
            // lblCanal
            // 
            this.lblCanal.BackColor = System.Drawing.Color.Transparent;
            this.lblCanal.ForeColor = System.Drawing.Color.White;
            this.lblCanal.Location = new System.Drawing.Point(207, 590);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(43, 15);
            this.lblCanal.TabIndex = 60;
            this.lblCanal.Text = "Canal";
            this.lblCanal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSourdine
            // 
            this.lblSourdine.BackColor = System.Drawing.Color.Transparent;
            this.lblSourdine.ForeColor = System.Drawing.Color.White;
            this.lblSourdine.Location = new System.Drawing.Point(137, 615);
            this.lblSourdine.Name = "lblSourdine";
            this.lblSourdine.Size = new System.Drawing.Size(55, 15);
            this.lblSourdine.TabIndex = 61;
            this.lblSourdine.Text = "Sourdine";
            this.lblSourdine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panBase
            // 
            this.panBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panBase.Controls.Add(this.lblÉtatSourdine);
            this.panBase.Controls.Add(this.lblChampsSourdine);
            this.panBase.Controls.Add(this.lblChampsCanal);
            this.panBase.Controls.Add(this.lblChampsVolume);
            this.panBase.Controls.Add(this.vsiVolume);
            this.panBase.Controls.Add(this.vsiCanal);
            this.panBase.Location = new System.Drawing.Point(44, 477);
            this.panBase.Name = "panBase";
            this.panBase.Size = new System.Drawing.Size(237, 100);
            this.panBase.TabIndex = 12;
            // 
            // lblÉtatSourdine
            // 
            this.lblÉtatSourdine.BackColor = System.Drawing.Color.Silver;
            this.lblÉtatSourdine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblÉtatSourdine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblÉtatSourdine.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblÉtatSourdine.Location = new System.Drawing.Point(73, 55);
            this.lblÉtatSourdine.Name = "lblÉtatSourdine";
            this.lblÉtatSourdine.Size = new System.Drawing.Size(44, 25);
            this.lblÉtatSourdine.TabIndex = 12;
            this.lblÉtatSourdine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChampsSourdine
            // 
            this.lblChampsSourdine.ForeColor = System.Drawing.Color.Silver;
            this.lblChampsSourdine.Location = new System.Drawing.Point(16, 53);
            this.lblChampsSourdine.Name = "lblChampsSourdine";
            this.lblChampsSourdine.Size = new System.Drawing.Size(58, 25);
            this.lblChampsSourdine.TabIndex = 61;
            this.lblChampsSourdine.Text = "Sourdine :";
            this.lblChampsSourdine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChampsCanal
            // 
            this.lblChampsCanal.ForeColor = System.Drawing.Color.Silver;
            this.lblChampsCanal.Location = new System.Drawing.Point(123, 53);
            this.lblChampsCanal.Name = "lblChampsCanal";
            this.lblChampsCanal.Size = new System.Drawing.Size(40, 25);
            this.lblChampsCanal.TabIndex = 60;
            this.lblChampsCanal.Text = "Canal :";
            this.lblChampsCanal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChampsVolume
            // 
            this.lblChampsVolume.ForeColor = System.Drawing.Color.Silver;
            this.lblChampsVolume.Location = new System.Drawing.Point(16, 5);
            this.lblChampsVolume.Name = "lblChampsVolume";
            this.lblChampsVolume.Size = new System.Drawing.Size(200, 13);
            this.lblChampsVolume.TabIndex = 12;
            this.lblChampsVolume.Text = "Volume :";
            // 
            // btnModeImageSuivant
            // 
            this.btnModeImageSuivant.BackColor = System.Drawing.Color.Transparent;
            this.btnModeImageSuivant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModeImageSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModeImageSuivant.ForeColor = System.Drawing.Color.White;
            this.btnModeImageSuivant.Location = new System.Drawing.Point(64, 420);
            this.btnModeImageSuivant.Name = "btnModeImageSuivant";
            this.btnModeImageSuivant.Size = new System.Drawing.Size(195, 27);
            this.btnModeImageSuivant.TabIndex = 0;
            this.btnModeImageSuivant.Text = "Mode image suivant";
            this.btnModeImageSuivant.UseVisualStyleBackColor = false;
            this.btnModeImageSuivant.Click += new System.EventHandler(this.BtnModeImageSuivant_Click);
            // 
            // FrmPrincipal
            // 
            this.AcceptButton = this.btnModeImageSuivant;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(324, 807);
            this.Controls.Add(this.panBase);
            this.Controls.Add(this.lblSourdine);
            this.Controls.Add(this.lblCanal);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.btnSourdine);
            this.Controls.Add(this.btnCanalMoins);
            this.Controls.Add(this.btnCanalPlus);
            this.Controls.Add(this.btnVolumeMoins);
            this.Controls.Add(this.btnVolumePlus);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.cboSourceCourante);
            this.Controls.Add(this.btnModeImageSuivant);
            this.Controls.Add(this.panAjustements);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Télécommande (Matériel)";
            this.panAjustements.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panBase.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        public System.Windows.Forms.Panel panAjustements;
        public System.Windows.Forms.Button btnMémoriser;
        public VisualArrays.VisualCells.VisualInt vsiLuminosité;
        public System.Windows.Forms.Label lblLuminosité;
        public System.Windows.Forms.Label lblContraste;
        public VisualArrays.VisualCells.VisualInt vsiContraste;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTeinte;
        public VisualArrays.VisualCells.VisualInt vsiTeinte;
        public System.Windows.Forms.Label lblCouleur;
        public VisualArrays.VisualCells.VisualInt vsiCouleur;
        public VisualArrays.VisualCells.VisualInt vsiNetteté;
        public System.Windows.Forms.Label lblNomModeImage;
        public System.Windows.Forms.Label lblNetteté;
        public System.Windows.Forms.Label lblSource;
        public System.Windows.Forms.Button btnSourdine;
        public System.Windows.Forms.Button btnCanalMoins;
        public System.Windows.Forms.Button btnCanalPlus;
        public System.Windows.Forms.Button btnVolumeMoins;
        public System.Windows.Forms.Button btnVolumePlus;
        public System.Windows.Forms.Label lblVolume;
        public VisualArrays.VisualCells.VisualInt vsiVolume;
        public VisualArrays.VisualCells.VisualInt vsiCanal;
        public System.Windows.Forms.Label lblCanal;
        public System.Windows.Forms.Label lblSourdine;
        private System.Windows.Forms.Panel panBase;
        public System.Windows.Forms.Label lblChampsCanal;
        public System.Windows.Forms.Label lblChampsVolume;
        public System.Windows.Forms.Label lblÉtatSourdine;
        public System.Windows.Forms.Label lblChampsSourdine;
        public System.Windows.Forms.Button btnModeImageSuivant;
        public System.Windows.Forms.ComboBox cboSourceCourante;
    }
}

