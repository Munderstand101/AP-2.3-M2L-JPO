
namespace jpo
{
    partial class frmInscriptionLigues
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
            this.plTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.frmMode = new System.Windows.Forms.LinkLabel();
            this.plTop2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.plBtoom = new System.Windows.Forms.Panel();
            this.lbxModifier = new System.Windows.Forms.LinkLabel();
            this.lbxSupp = new System.Windows.Forms.LinkLabel();
            this.plBtoom2 = new System.Windows.Forms.Panel();
            this.lbxCancel = new System.Windows.Forms.LinkLabel();
            this.lbxSave = new System.Windows.Forms.LinkLabel();
            this.gbxTailelStand = new System.Windows.Forms.GroupBox();
            this.lblLargeur = new System.Windows.Forms.Label();
            this.tbxLargeur = new System.Windows.Forms.TextBox();
            this.lblLongueur = new System.Windows.Forms.Label();
            this.tbxLongueur = new System.Windows.Forms.TextBox();
            this.lvLigue = new System.Windows.Forms.ListView();
            this.lvInscription = new System.Windows.Forms.ListView();
            this.gbxSelectEquip = new System.Windows.Forms.GroupBox();
            this.lvEquipement = new System.Windows.Forms.ListView();
            this.lblEquipSelected = new System.Windows.Forms.Label();
            this.cbxSelectAll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxRechargerInsc = new System.Windows.Forms.LinkLabel();
            this.lbxRechargerLigue = new System.Windows.Forms.LinkLabel();
            this.plTop.SuspendLayout();
            this.plBtoom.SuspendLayout();
            this.gbxTailelStand.SuspendLayout();
            this.gbxSelectEquip.SuspendLayout();
            this.SuspendLayout();
            // 
            // plTop
            // 
            this.plTop.Controls.Add(this.label2);
            this.plTop.Controls.Add(this.frmMode);
            this.plTop.Controls.Add(this.plTop2);
            this.plTop.Controls.Add(this.lblTitle);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(800, 33);
            this.plTop.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 79;
            this.label2.Text = "M2L";
            // 
            // frmMode
            // 
            this.frmMode.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.frmMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.frmMode.AutoSize = true;
            this.frmMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.frmMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.frmMode.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.frmMode.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.frmMode.Location = new System.Drawing.Point(714, 10);
            this.frmMode.Name = "frmMode";
            this.frmMode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.frmMode.Size = new System.Drawing.Size(74, 13);
            this.frmMode.TabIndex = 72;
            this.frmMode.TabStop = true;
            this.frmMode.Text = "&White mode";
            this.frmMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.frmMode.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.frmMode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // plTop2
            // 
            this.plTop2.BackColor = System.Drawing.Color.DimGray;
            this.plTop2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plTop2.Location = new System.Drawing.Point(0, 32);
            this.plTop2.Name = "plTop2";
            this.plTop2.Size = new System.Drawing.Size(800, 1);
            this.plTop2.TabIndex = 63;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.lblTitle.Location = new System.Drawing.Point(66, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Inscription ligues";
            // 
            // plBtoom
            // 
            this.plBtoom.Controls.Add(this.lbxModifier);
            this.plBtoom.Controls.Add(this.lbxSupp);
            this.plBtoom.Controls.Add(this.plBtoom2);
            this.plBtoom.Controls.Add(this.lbxCancel);
            this.plBtoom.Controls.Add(this.lbxSave);
            this.plBtoom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plBtoom.Location = new System.Drawing.Point(0, 357);
            this.plBtoom.Name = "plBtoom";
            this.plBtoom.Size = new System.Drawing.Size(800, 40);
            this.plBtoom.TabIndex = 79;
            // 
            // lbxModifier
            // 
            this.lbxModifier.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lbxModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxModifier.AutoSize = true;
            this.lbxModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbxModifier.Image = global::jpo.Properties.Resources.icons8_edit_16;
            this.lbxModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbxModifier.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbxModifier.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.lbxModifier.Location = new System.Drawing.Point(12, 18);
            this.lbxModifier.Name = "lbxModifier";
            this.lbxModifier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbxModifier.Size = new System.Drawing.Size(72, 13);
            this.lbxModifier.TabIndex = 77;
            this.lbxModifier.TabStop = true;
            this.lbxModifier.Text = "     &Modifier";
            this.lbxModifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbxModifier.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lbxModifier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbxModifier_LinkClicked);
            // 
            // lbxSupp
            // 
            this.lbxSupp.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lbxSupp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxSupp.AutoSize = true;
            this.lbxSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbxSupp.Image = global::jpo.Properties.Resources.icons8_delete_bin_16;
            this.lbxSupp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbxSupp.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbxSupp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.lbxSupp.Location = new System.Drawing.Point(90, 18);
            this.lbxSupp.Name = "lbxSupp";
            this.lbxSupp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbxSupp.Size = new System.Drawing.Size(83, 13);
            this.lbxSupp.TabIndex = 78;
            this.lbxSupp.TabStop = true;
            this.lbxSupp.Text = "     &Supprimer";
            this.lbxSupp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbxSupp.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lbxSupp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbxSupp_LinkClicked);
            // 
            // plBtoom2
            // 
            this.plBtoom2.BackColor = System.Drawing.Color.DimGray;
            this.plBtoom2.Dock = System.Windows.Forms.DockStyle.Top;
            this.plBtoom2.Location = new System.Drawing.Point(0, 0);
            this.plBtoom2.Name = "plBtoom2";
            this.plBtoom2.Size = new System.Drawing.Size(800, 1);
            this.plBtoom2.TabIndex = 0;
            // 
            // lbxCancel
            // 
            this.lbxCancel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lbxCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxCancel.AutoSize = true;
            this.lbxCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbxCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbxCancel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbxCancel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.lbxCancel.Location = new System.Drawing.Point(737, 13);
            this.lbxCancel.Name = "lbxCancel";
            this.lbxCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbxCancel.Size = new System.Drawing.Size(50, 13);
            this.lbxCancel.TabIndex = 71;
            this.lbxCancel.TabStop = true;
            this.lbxCancel.Text = "&Annuler";
            this.lbxCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbxCancel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lbxCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbxCancel_LinkClicked);
            // 
            // lbxSave
            // 
            this.lbxSave.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lbxSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxSave.AutoSize = true;
            this.lbxSave.Enabled = false;
            this.lbxSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbxSave.Image = global::jpo.Properties.Resources.icons8_save2_16;
            this.lbxSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbxSave.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbxSave.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.lbxSave.Location = new System.Drawing.Point(632, 13);
            this.lbxSave.Name = "lbxSave";
            this.lbxSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbxSave.Size = new System.Drawing.Size(84, 13);
            this.lbxSave.TabIndex = 66;
            this.lbxSave.TabStop = true;
            this.lbxSave.Text = "    &Enregistrer";
            this.lbxSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbxSave.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lbxSave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbxSave_LinkClicked);
            // 
            // gbxTailelStand
            // 
            this.gbxTailelStand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTailelStand.Controls.Add(this.lblLargeur);
            this.gbxTailelStand.Controls.Add(this.tbxLargeur);
            this.gbxTailelStand.Controls.Add(this.lblLongueur);
            this.gbxTailelStand.Controls.Add(this.tbxLongueur);
            this.gbxTailelStand.Enabled = false;
            this.gbxTailelStand.Location = new System.Drawing.Point(552, 58);
            this.gbxTailelStand.Name = "gbxTailelStand";
            this.gbxTailelStand.Size = new System.Drawing.Size(235, 97);
            this.gbxTailelStand.TabIndex = 80;
            this.gbxTailelStand.TabStop = false;
            this.gbxTailelStand.Text = "Taille du stand : ";
            // 
            // lblLargeur
            // 
            this.lblLargeur.AutoSize = true;
            this.lblLargeur.Location = new System.Drawing.Point(24, 60);
            this.lblLargeur.Name = "lblLargeur";
            this.lblLargeur.Size = new System.Drawing.Size(49, 13);
            this.lblLargeur.TabIndex = 3;
            this.lblLargeur.Text = "Largeur :";
            // 
            // tbxLargeur
            // 
            this.tbxLargeur.Location = new System.Drawing.Point(77, 57);
            this.tbxLargeur.Name = "tbxLargeur";
            this.tbxLargeur.Size = new System.Drawing.Size(142, 20);
            this.tbxLargeur.TabIndex = 2;
            // 
            // lblLongueur
            // 
            this.lblLongueur.AutoSize = true;
            this.lblLongueur.Location = new System.Drawing.Point(13, 34);
            this.lblLongueur.Name = "lblLongueur";
            this.lblLongueur.Size = new System.Drawing.Size(58, 13);
            this.lblLongueur.TabIndex = 1;
            this.lblLongueur.Text = "Longueur :";
            // 
            // tbxLongueur
            // 
            this.tbxLongueur.BackColor = System.Drawing.Color.White;
            this.tbxLongueur.Location = new System.Drawing.Point(77, 31);
            this.tbxLongueur.Name = "tbxLongueur";
            this.tbxLongueur.Size = new System.Drawing.Size(142, 20);
            this.tbxLongueur.TabIndex = 0;
            // 
            // lvLigue
            // 
            this.lvLigue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvLigue.HideSelection = false;
            this.lvLigue.Location = new System.Drawing.Point(12, 58);
            this.lvLigue.Name = "lvLigue";
            this.lvLigue.Size = new System.Drawing.Size(534, 162);
            this.lvLigue.TabIndex = 81;
            this.lvLigue.UseCompatibleStateImageBehavior = false;
            this.lvLigue.View = System.Windows.Forms.View.Details;
            this.lvLigue.SelectedIndexChanged += new System.EventHandler(this.lvLigue_SelectedIndexChanged);
            // 
            // lvInscription
            // 
            this.lvInscription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvInscription.HideSelection = false;
            this.lvInscription.Location = new System.Drawing.Point(12, 247);
            this.lvInscription.Name = "lvInscription";
            this.lvInscription.Size = new System.Drawing.Size(534, 98);
            this.lvInscription.TabIndex = 82;
            this.lvInscription.UseCompatibleStateImageBehavior = false;
            this.lvInscription.View = System.Windows.Forms.View.Details;
            this.lvInscription.SelectedIndexChanged += new System.EventHandler(this.lvInscription_SelectedIndexChanged);
            // 
            // gbxSelectEquip
            // 
            this.gbxSelectEquip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSelectEquip.Controls.Add(this.lvEquipement);
            this.gbxSelectEquip.Controls.Add(this.lblEquipSelected);
            this.gbxSelectEquip.Controls.Add(this.cbxSelectAll);
            this.gbxSelectEquip.Enabled = false;
            this.gbxSelectEquip.Location = new System.Drawing.Point(552, 161);
            this.gbxSelectEquip.Name = "gbxSelectEquip";
            this.gbxSelectEquip.Size = new System.Drawing.Size(235, 190);
            this.gbxSelectEquip.TabIndex = 83;
            this.gbxSelectEquip.TabStop = false;
            this.gbxSelectEquip.Text = "Liste des équipements : ";
            // 
            // lvEquipement
            // 
            this.lvEquipement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvEquipement.HideSelection = false;
            this.lvEquipement.Location = new System.Drawing.Point(6, 16);
            this.lvEquipement.Name = "lvEquipement";
            this.lvEquipement.Size = new System.Drawing.Size(223, 168);
            this.lvEquipement.TabIndex = 84;
            this.lvEquipement.UseCompatibleStateImageBehavior = false;
            this.lvEquipement.View = System.Windows.Forms.View.Details;
            this.lvEquipement.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvEquipement_ItemCheck);
            // 
            // lblEquipSelected
            // 
            this.lblEquipSelected.AutoSize = true;
            this.lblEquipSelected.Location = new System.Drawing.Point(180, 16);
            this.lblEquipSelected.Name = "lblEquipSelected";
            this.lblEquipSelected.Size = new System.Drawing.Size(123, 13);
            this.lblEquipSelected.TabIndex = 88;
            this.lblEquipSelected.Text = "0 Éléments Sélectionnés";
            this.lblEquipSelected.Visible = false;
            // 
            // cbxSelectAll
            // 
            this.cbxSelectAll.AutoSize = true;
            this.cbxSelectAll.Location = new System.Drawing.Point(6, 16);
            this.cbxSelectAll.Name = "cbxSelectAll";
            this.cbxSelectAll.Size = new System.Drawing.Size(110, 17);
            this.cbxSelectAll.TabIndex = 87;
            this.cbxSelectAll.Text = "Sélectionner Tout";
            this.cbxSelectAll.UseVisualStyleBackColor = true;
            this.cbxSelectAll.Visible = false;
            this.cbxSelectAll.CheckedChanged += new System.EventHandler(this.cbxSelectAll_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "Inscription Stand : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Veuilles selectionner une ligue :";
            // 
            // lbxRechargerInsc
            // 
            this.lbxRechargerInsc.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lbxRechargerInsc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxRechargerInsc.AutoSize = true;
            this.lbxRechargerInsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbxRechargerInsc.Image = global::jpo.Properties.Resources.icons8_reload_14;
            this.lbxRechargerInsc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbxRechargerInsc.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbxRechargerInsc.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.lbxRechargerInsc.Location = new System.Drawing.Point(460, 231);
            this.lbxRechargerInsc.Name = "lbxRechargerInsc";
            this.lbxRechargerInsc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbxRechargerInsc.Size = new System.Drawing.Size(86, 13);
            this.lbxRechargerInsc.TabIndex = 86;
            this.lbxRechargerInsc.TabStop = true;
            this.lbxRechargerInsc.Text = "     &Recharger";
            this.lbxRechargerInsc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbxRechargerInsc.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lbxRechargerInsc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbxRechargerInsc_LinkClicked);
            // 
            // lbxRechargerLigue
            // 
            this.lbxRechargerLigue.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lbxRechargerLigue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxRechargerLigue.AutoSize = true;
            this.lbxRechargerLigue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbxRechargerLigue.Image = global::jpo.Properties.Resources.icons8_reload_14;
            this.lbxRechargerLigue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbxRechargerLigue.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbxRechargerLigue.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.lbxRechargerLigue.Location = new System.Drawing.Point(460, 42);
            this.lbxRechargerLigue.Name = "lbxRechargerLigue";
            this.lbxRechargerLigue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbxRechargerLigue.Size = new System.Drawing.Size(86, 13);
            this.lbxRechargerLigue.TabIndex = 87;
            this.lbxRechargerLigue.TabStop = true;
            this.lbxRechargerLigue.Text = "     &Recharger";
            this.lbxRechargerLigue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbxRechargerLigue.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lbxRechargerLigue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbxRechargerLigue_LinkClicked);
            // 
            // frmInscriptionLigues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.lbxRechargerLigue);
            this.Controls.Add(this.lbxRechargerInsc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxSelectEquip);
            this.Controls.Add(this.lvInscription);
            this.Controls.Add(this.lvLigue);
            this.Controls.Add(this.gbxTailelStand);
            this.Controls.Add(this.plBtoom);
            this.Controls.Add(this.plTop);
            this.Name = "frmInscriptionLigues";
            this.Text = "Inscription ligues";
            this.Load += new System.EventHandler(this.frmInscriptionLigues_Load);
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            this.plBtoom.ResumeLayout(false);
            this.plBtoom.PerformLayout();
            this.gbxTailelStand.ResumeLayout(false);
            this.gbxTailelStand.PerformLayout();
            this.gbxSelectEquip.ResumeLayout(false);
            this.gbxSelectEquip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.Panel plTop2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel plBtoom;
        private System.Windows.Forms.Panel plBtoom2;
        private System.Windows.Forms.LinkLabel lbxCancel;
        private System.Windows.Forms.LinkLabel lbxSave;
        private System.Windows.Forms.LinkLabel frmMode;
        private System.Windows.Forms.GroupBox gbxTailelStand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLargeur;
        private System.Windows.Forms.TextBox tbxLargeur;
        private System.Windows.Forms.Label lblLongueur;
        private System.Windows.Forms.TextBox tbxLongueur;
        private System.Windows.Forms.ListView lvLigue;
        private System.Windows.Forms.ListView lvInscription;
        private System.Windows.Forms.GroupBox gbxSelectEquip;
        private System.Windows.Forms.ListView lvEquipement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEquipSelected;
        private System.Windows.Forms.CheckBox cbxSelectAll;
        private System.Windows.Forms.LinkLabel lbxRechargerInsc;
        private System.Windows.Forms.LinkLabel lbxRechargerLigue;
        private System.Windows.Forms.LinkLabel lbxModifier;
        private System.Windows.Forms.LinkLabel lbxSupp;
    }
}