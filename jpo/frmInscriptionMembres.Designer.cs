
namespace jpo
{
    partial class frmInscriptionMembres
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
            this.lblEnregistrement = new System.Windows.Forms.Label();
            this.plBtoom = new System.Windows.Forms.Panel();
            this.lbxModif = new System.Windows.Forms.LinkLabel();
            this.lbxAnnuler = new System.Windows.Forms.LinkLabel();
            this.plBtoom2 = new System.Windows.Forms.Panel();
            this.lblInscrire = new System.Windows.Forms.LinkLabel();
            this.cbxLigues = new System.Windows.Forms.ComboBox();
            this.lblLigues = new System.Windows.Forms.Label();
            this.lblMembres = new System.Windows.Forms.Label();
            this.cbxMembre = new System.Windows.Forms.ComboBox();
            this.lblCréneau = new System.Windows.Forms.Label();
            this.cbxCreneau = new System.Windows.Forms.ComboBox();
            this.plTop = new System.Windows.Forms.Panel();
            this.lbxModifier = new System.Windows.Forms.LinkLabel();
            this.lbxDel = new System.Windows.Forms.LinkLabel();
            this.lbxNew = new System.Windows.Forms.LinkLabel();
            this.lblDarkMode = new System.Windows.Forms.LinkLabel();
            this.M2L = new System.Windows.Forms.Label();
            this.plTop2 = new System.Windows.Forms.Panel();
            this.lvIMembre = new System.Windows.Forms.ListView();
            this.plBtoom.SuspendLayout();
            this.plTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnregistrement
            // 
            this.lblEnregistrement.AutoSize = true;
            this.lblEnregistrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnregistrement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lblEnregistrement.Location = new System.Drawing.Point(61, 8);
            this.lblEnregistrement.Name = "lblEnregistrement";
            this.lblEnregistrement.Size = new System.Drawing.Size(138, 15);
            this.lblEnregistrement.TabIndex = 2;
            this.lblEnregistrement.Text = "Inscription membres";
            this.lblEnregistrement.Click += new System.EventHandler(this.label1_Click);
            // 
            // plBtoom
            // 
            this.plBtoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.plBtoom.Controls.Add(this.lbxModif);
            this.plBtoom.Controls.Add(this.lbxAnnuler);
            this.plBtoom.Controls.Add(this.plBtoom2);
            this.plBtoom.Controls.Add(this.lblInscrire);
            this.plBtoom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plBtoom.Location = new System.Drawing.Point(0, 368);
            this.plBtoom.Name = "plBtoom";
            this.plBtoom.Size = new System.Drawing.Size(800, 40);
            this.plBtoom.TabIndex = 10;
            this.plBtoom.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lbxModif
            // 
            this.lbxModif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxModif.AutoSize = true;
            this.lbxModif.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.lbxModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxModif.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbxModif.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lbxModif.Location = new System.Drawing.Point(506, 14);
            this.lbxModif.Name = "lbxModif";
            this.lbxModif.Size = new System.Drawing.Size(144, 13);
            this.lbxModif.TabIndex = 12;
            this.lbxModif.TabStop = true;
            this.lbxModif.Text = "&Accepter la modification";
            this.lbxModif.Visible = false;
            this.lbxModif.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbxModif_LinkClicked);
            // 
            // lbxAnnuler
            // 
            this.lbxAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxAnnuler.AutoSize = true;
            this.lbxAnnuler.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.lbxAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAnnuler.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbxAnnuler.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lbxAnnuler.Location = new System.Drawing.Point(739, 15);
            this.lbxAnnuler.Name = "lbxAnnuler";
            this.lbxAnnuler.Size = new System.Drawing.Size(50, 13);
            this.lbxAnnuler.TabIndex = 11;
            this.lbxAnnuler.TabStop = true;
            this.lbxAnnuler.Text = "&Annuler";
            this.lbxAnnuler.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbxAnnuler_LinkClicked);
            // 
            // plBtoom2
            // 
            this.plBtoom2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.plBtoom2.Dock = System.Windows.Forms.DockStyle.Top;
            this.plBtoom2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plBtoom2.Location = new System.Drawing.Point(0, 0);
            this.plBtoom2.Name = "plBtoom2";
            this.plBtoom2.Size = new System.Drawing.Size(800, 1);
            this.plBtoom2.TabIndex = 9;
            // 
            // lblInscrire
            // 
            this.lblInscrire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInscrire.AutoSize = true;
            this.lblInscrire.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.lblInscrire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscrire.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblInscrire.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lblInscrire.Location = new System.Drawing.Point(671, 14);
            this.lblInscrire.Name = "lblInscrire";
            this.lblInscrire.Size = new System.Drawing.Size(49, 13);
            this.lblInscrire.TabIndex = 0;
            this.lblInscrire.TabStop = true;
            this.lblInscrire.Text = "&Inscrire";
            this.lblInscrire.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblInscrire_LinkClicked);
            // 
            // cbxLigues
            // 
            this.cbxLigues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxLigues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(200)))));
            this.cbxLigues.FormattingEnabled = true;
            this.cbxLigues.Location = new System.Drawing.Point(609, 138);
            this.cbxLigues.Name = "cbxLigues";
            this.cbxLigues.Size = new System.Drawing.Size(179, 21);
            this.cbxLigues.TabIndex = 3;
            this.cbxLigues.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblLigues
            // 
            this.lblLigues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLigues.AutoSize = true;
            this.lblLigues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLigues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(200)))));
            this.lblLigues.Location = new System.Drawing.Point(554, 142);
            this.lblLigues.Name = "lblLigues";
            this.lblLigues.Size = new System.Drawing.Size(52, 13);
            this.lblLigues.TabIndex = 3;
            this.lblLigues.Text = "&Ligues :";
            this.lblLigues.Click += new System.EventHandler(this.lblLigues_Click);
            // 
            // lblMembres
            // 
            this.lblMembres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMembres.AutoSize = true;
            this.lblMembres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(200)))));
            this.lblMembres.Location = new System.Drawing.Point(541, 189);
            this.lblMembres.Name = "lblMembres";
            this.lblMembres.Size = new System.Drawing.Size(65, 13);
            this.lblMembres.TabIndex = 4;
            this.lblMembres.Text = "&Membres :";
            this.lblMembres.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbxMembre
            // 
            this.cbxMembre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMembre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(200)))));
            this.cbxMembre.FormattingEnabled = true;
            this.cbxMembre.Location = new System.Drawing.Point(609, 184);
            this.cbxMembre.Name = "cbxMembre";
            this.cbxMembre.Size = new System.Drawing.Size(179, 21);
            this.cbxMembre.TabIndex = 5;
            this.cbxMembre.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblCréneau
            // 
            this.lblCréneau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCréneau.AutoSize = true;
            this.lblCréneau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCréneau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(200)))));
            this.lblCréneau.Location = new System.Drawing.Point(544, 236);
            this.lblCréneau.Name = "lblCréneau";
            this.lblCréneau.Size = new System.Drawing.Size(62, 13);
            this.lblCréneau.TabIndex = 6;
            this.lblCréneau.Text = "&Créneau :";
            this.lblCréneau.Click += new System.EventHandler(this.lblCréneau_Click);
            // 
            // cbxCreneau
            // 
            this.cbxCreneau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCreneau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(200)))));
            this.cbxCreneau.FormattingEnabled = true;
            this.cbxCreneau.Location = new System.Drawing.Point(609, 232);
            this.cbxCreneau.Name = "cbxCreneau";
            this.cbxCreneau.Size = new System.Drawing.Size(179, 21);
            this.cbxCreneau.TabIndex = 7;
            this.cbxCreneau.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // plTop
            // 
            this.plTop.Controls.Add(this.lbxModifier);
            this.plTop.Controls.Add(this.lbxDel);
            this.plTop.Controls.Add(this.lbxNew);
            this.plTop.Controls.Add(this.lblDarkMode);
            this.plTop.Controls.Add(this.M2L);
            this.plTop.Controls.Add(this.lblEnregistrement);
            this.plTop.Controls.Add(this.plTop2);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(800, 33);
            this.plTop.TabIndex = 8;
            this.plTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbxModifier
            // 
            this.lbxModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxModifier.AutoSize = true;
            this.lbxModifier.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.lbxModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxModifier.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbxModifier.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lbxModifier.Location = new System.Drawing.Point(473, 10);
            this.lbxModifier.Name = "lbxModifier";
            this.lbxModifier.Size = new System.Drawing.Size(121, 13);
            this.lbxModifier.TabIndex = 30;
            this.lbxModifier.TabStop = true;
            this.lbxModifier.Text = "&Modifier un Créneau";
            this.lbxModifier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbxModifier_LinkClicked);
            // 
            // lbxDel
            // 
            this.lbxDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxDel.AutoSize = true;
            this.lbxDel.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.lbxDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbxDel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lbxDel.Location = new System.Drawing.Point(600, 11);
            this.lbxDel.Name = "lbxDel";
            this.lbxDel.Size = new System.Drawing.Size(63, 13);
            this.lbxDel.TabIndex = 29;
            this.lbxDel.TabStop = true;
            this.lbxDel.Text = "&Supprimer";
            this.lbxDel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbxDel_LinkClicked);
            // 
            // lbxNew
            // 
            this.lbxNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxNew.AutoSize = true;
            this.lbxNew.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.lbxNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxNew.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbxNew.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lbxNew.Location = new System.Drawing.Point(347, 10);
            this.lbxNew.Name = "lbxNew";
            this.lbxNew.Size = new System.Drawing.Size(120, 13);
            this.lbxNew.TabIndex = 13;
            this.lbxNew.TabStop = true;
            this.lbxNew.Text = "&Nouvelle Inscription";
            this.lbxNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbxNew_LinkClicked);
            // 
            // lblDarkMode
            // 
            this.lblDarkMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDarkMode.AutoSize = true;
            this.lblDarkMode.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.lblDarkMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDarkMode.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblDarkMode.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lblDarkMode.Location = new System.Drawing.Point(723, 10);
            this.lblDarkMode.Name = "lblDarkMode";
            this.lblDarkMode.Size = new System.Drawing.Size(68, 13);
            this.lblDarkMode.TabIndex = 10;
            this.lblDarkMode.TabStop = true;
            this.lblDarkMode.Text = "&Dark mode";
            this.lblDarkMode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDarkMode_LinkClicked);
            // 
            // M2L
            // 
            this.M2L.AutoSize = true;
            this.M2L.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M2L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.M2L.Location = new System.Drawing.Point(4, 4);
            this.M2L.Name = "M2L";
            this.M2L.Size = new System.Drawing.Size(57, 25);
            this.M2L.TabIndex = 11;
            this.M2L.Text = "M2L";
            // 
            // plTop2
            // 
            this.plTop2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.plTop2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plTop2.Location = new System.Drawing.Point(0, 32);
            this.plTop2.Name = "plTop2";
            this.plTop2.Size = new System.Drawing.Size(800, 1);
            this.plTop2.TabIndex = 9;
            // 
            // lvIMembre
            // 
            this.lvIMembre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvIMembre.BackColor = System.Drawing.SystemColors.Window;
            this.lvIMembre.Location = new System.Drawing.Point(12, 39);
            this.lvIMembre.Name = "lvIMembre";
            this.lvIMembre.Size = new System.Drawing.Size(504, 324);
            this.lvIMembre.TabIndex = 28;
            this.lvIMembre.UseCompatibleStateImageBehavior = false;
            this.lvIMembre.View = System.Windows.Forms.View.Details;
            this.lvIMembre.SelectedIndexChanged += new System.EventHandler(this.lvIMembre_SelectedIndexChanged);
            // 
            // frmInscriptionMembres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.plBtoom);
            this.Controls.Add(this.lvIMembre);
            this.Controls.Add(this.plTop);
            this.Controls.Add(this.cbxCreneau);
            this.Controls.Add(this.lblCréneau);
            this.Controls.Add(this.cbxMembre);
            this.Controls.Add(this.lblMembres);
            this.Controls.Add(this.lblLigues);
            this.Controls.Add(this.cbxLigues);
            this.Name = "frmInscriptionMembres";
            this.Text = "frmInscriptionMembres";
            this.Load += new System.EventHandler(this.frmInscriptionMembres_Load);
            this.plBtoom.ResumeLayout(false);
            this.plBtoom.PerformLayout();
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnregistrement;
        private System.Windows.Forms.ComboBox cbxLigues;
        private System.Windows.Forms.Label lblLigues;
        private System.Windows.Forms.Label lblMembres;
        private System.Windows.Forms.ComboBox cbxMembre;
        private System.Windows.Forms.Label lblCréneau;
        private System.Windows.Forms.ComboBox cbxCreneau;
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.Panel plTop2;
        private System.Windows.Forms.Label M2L;
        private System.Windows.Forms.LinkLabel lblInscrire;
        private System.Windows.Forms.Panel plBtoom;
        private System.Windows.Forms.Panel plBtoom2;
        private System.Windows.Forms.LinkLabel lblDarkMode;
        private System.Windows.Forms.ListView lvIMembre;
        private System.Windows.Forms.LinkLabel lbxAnnuler;
        private System.Windows.Forms.LinkLabel lbxNew;
        private System.Windows.Forms.LinkLabel lbxDel;
        private System.Windows.Forms.LinkLabel lbxModifier;
        private System.Windows.Forms.LinkLabel lbxModif;
    }
}