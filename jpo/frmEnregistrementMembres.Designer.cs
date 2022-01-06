
namespace jpo
{
    partial class frmEnregistrementMembres
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
            this.plTop = new System.Windows.Forms.Panel();
            this.lbxModifier = new System.Windows.Forms.LinkLabel();
            this.lbxNew = new System.Windows.Forms.LinkLabel();
            this.lbxDel = new System.Windows.Forms.LinkLabel();
            this.frmMode = new System.Windows.Forms.LinkLabel();
            this.M2L = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plTop2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plBtoom = new System.Windows.Forms.Panel();
            this.lbxModif = new System.Windows.Forms.LinkLabel();
            this.lbxAnnuler = new System.Windows.Forms.LinkLabel();
            this.plBtoom2 = new System.Windows.Forms.Panel();
            this.lbxEnregistrement = new System.Windows.Forms.LinkLabel();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblLigue = new System.Windows.Forms.Label();
            this.dgvMembre = new System.Windows.Forms.DataGridView();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.tbxTel = new System.Windows.Forms.TextBox();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.cbxLigues = new System.Windows.Forms.ComboBox();
            this.lvMembre = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.plTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.plBtoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembre)).BeginInit();
            this.SuspendLayout();
            // 
            // plTop
            // 
            this.plTop.Controls.Add(this.lbxModifier);
            this.plTop.Controls.Add(this.lbxNew);
            this.plTop.Controls.Add(this.lbxDel);
            this.plTop.Controls.Add(this.frmMode);
            this.plTop.Controls.Add(this.M2L);
            this.plTop.Controls.Add(this.label2);
            this.plTop.Controls.Add(this.plTop2);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(800, 33);
            this.plTop.TabIndex = 9;
            // 
            // lbxModifier
            // 
            this.lbxModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxModifier.AutoSize = true;
            this.lbxModifier.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.lbxModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxModifier.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbxModifier.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lbxModifier.Location = new System.Drawing.Point(458, 11);
            this.lbxModifier.Name = "lbxModifier";
            this.lbxModifier.Size = new System.Drawing.Size(52, 13);
            this.lbxModifier.TabIndex = 12;
            this.lbxModifier.TabStop = true;
            this.lbxModifier.Text = "&Modifier";
            this.lbxModifier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbxModifier_LinkClicked);
            // 
            // lbxNew
            // 
            this.lbxNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxNew.AutoSize = true;
            this.lbxNew.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.lbxNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxNew.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbxNew.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lbxNew.Location = new System.Drawing.Point(332, 10);
            this.lbxNew.Name = "lbxNew";
            this.lbxNew.Size = new System.Drawing.Size(106, 13);
            this.lbxNew.TabIndex = 12;
            this.lbxNew.TabStop = true;
            this.lbxNew.Text = "&Nouveau Membre";
            this.lbxNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbxNew_LinkClicked);
            // 
            // lbxDel
            // 
            this.lbxDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxDel.AutoSize = true;
            this.lbxDel.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.lbxDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbxDel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lbxDel.Location = new System.Drawing.Point(532, 10);
            this.lbxDel.Name = "lbxDel";
            this.lbxDel.Size = new System.Drawing.Size(63, 13);
            this.lbxDel.TabIndex = 11;
            this.lbxDel.TabStop = true;
            this.lbxDel.Text = "&Supprimer";
            this.lbxDel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbxDel_LinkClicked);
            // 
            // frmMode
            // 
            this.frmMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.frmMode.AutoSize = true;
            this.frmMode.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.frmMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmMode.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.frmMode.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.frmMode.Location = new System.Drawing.Point(723, 10);
            this.frmMode.Name = "frmMode";
            this.frmMode.Size = new System.Drawing.Size(68, 13);
            this.frmMode.TabIndex = 10;
            this.frmMode.TabStop = true;
            this.frmMode.Text = "&Dark mode";
            this.frmMode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(61, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enregistrement membres";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.plBtoom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 39);
            this.panel1.TabIndex = 10;
            // 
            // plBtoom
            // 
            this.plBtoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.plBtoom.Controls.Add(this.lbxModif);
            this.plBtoom.Controls.Add(this.lbxAnnuler);
            this.plBtoom.Controls.Add(this.plBtoom2);
            this.plBtoom.Controls.Add(this.lbxEnregistrement);
            this.plBtoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.plBtoom.Location = new System.Drawing.Point(0, 0);
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
            this.lbxModif.Location = new System.Drawing.Point(496, 14);
            this.lbxModif.Name = "lbxModif";
            this.lbxModif.Size = new System.Drawing.Size(144, 13);
            this.lbxModif.TabIndex = 11;
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
            this.lbxAnnuler.Location = new System.Drawing.Point(738, 14);
            this.lbxAnnuler.Name = "lbxAnnuler";
            this.lbxAnnuler.Size = new System.Drawing.Size(50, 13);
            this.lbxAnnuler.TabIndex = 10;
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
            // lbxEnregistrement
            // 
            this.lbxEnregistrement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxEnregistrement.AutoSize = true;
            this.lbxEnregistrement.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.lbxEnregistrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxEnregistrement.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbxEnregistrement.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lbxEnregistrement.Location = new System.Drawing.Point(655, 14);
            this.lbxEnregistrement.Name = "lbxEnregistrement";
            this.lbxEnregistrement.Size = new System.Drawing.Size(68, 13);
            this.lbxEnregistrement.TabIndex = 0;
            this.lbxEnregistrement.TabStop = true;
            this.lbxEnregistrement.Text = "&Enregistrer";
            this.lbxEnregistrement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbxEnregistrement_LinkClicked);
            this.lbxEnregistrement.Click += new System.EventHandler(this.lbxEnregistrement_Click);
            // 
            // lblNom
            // 
            this.lblNom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(200)))));
            this.lblNom.Location = new System.Drawing.Point(570, 112);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(40, 13);
            this.lblNom.TabIndex = 11;
            this.lblNom.Text = "&Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(200)))));
            this.lblPrenom.Location = new System.Drawing.Point(553, 147);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(57, 13);
            this.lblPrenom.TabIndex = 12;
            this.lblPrenom.Text = "&Prénom :";
            // 
            // lblTel
            // 
            this.lblTel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(200)))));
            this.lblTel.Location = new System.Drawing.Point(535, 182);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(75, 13);
            this.lblTel.TabIndex = 13;
            this.lblTel.Text = "&Téléphone :";
            // 
            // lblMail
            // 
            this.lblMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(200)))));
            this.lblMail.Location = new System.Drawing.Point(572, 217);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(38, 13);
            this.lblMail.TabIndex = 14;
            this.lblMail.Text = "&Mail :";
            // 
            // lblLigue
            // 
            this.lblLigue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLigue.AutoSize = true;
            this.lblLigue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLigue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(200)))));
            this.lblLigue.Location = new System.Drawing.Point(564, 252);
            this.lblLigue.Name = "lblLigue";
            this.lblLigue.Size = new System.Drawing.Size(46, 13);
            this.lblLigue.TabIndex = 15;
            this.lblLigue.Text = "&Ligue :";
            // 
            // dgvMembre
            // 
            this.dgvMembre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMembre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembre.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.dgvMembre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembre.Location = new System.Drawing.Point(9, 39);
            this.dgvMembre.Name = "dgvMembre";
            this.dgvMembre.Size = new System.Drawing.Size(504, 313);
            this.dgvMembre.TabIndex = 21;
            // 
            // tbxNom
            // 
            this.tbxNom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNom.Enabled = false;
            this.tbxNom.Location = new System.Drawing.Point(616, 109);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(162, 20);
            this.tbxNom.TabIndex = 22;
            this.tbxNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNom_KeyPress);
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPrenom.Enabled = false;
            this.tbxPrenom.Location = new System.Drawing.Point(616, 144);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(162, 20);
            this.tbxPrenom.TabIndex = 23;
            this.tbxPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrenom_KeyPress);
            // 
            // tbxTel
            // 
            this.tbxTel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTel.Enabled = false;
            this.tbxTel.Location = new System.Drawing.Point(616, 179);
            this.tbxTel.Name = "tbxTel";
            this.tbxTel.Size = new System.Drawing.Size(162, 20);
            this.tbxTel.TabIndex = 24;
            this.tbxTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTel_KeyPress);
            // 
            // tbxMail
            // 
            this.tbxMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMail.Enabled = false;
            this.tbxMail.Location = new System.Drawing.Point(616, 214);
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.Size = new System.Drawing.Size(162, 20);
            this.tbxMail.TabIndex = 25;
            // 
            // cbxLigues
            // 
            this.cbxLigues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxLigues.Enabled = false;
            this.cbxLigues.FormattingEnabled = true;
            this.cbxLigues.Location = new System.Drawing.Point(616, 249);
            this.cbxLigues.Name = "cbxLigues";
            this.cbxLigues.Size = new System.Drawing.Size(162, 21);
            this.cbxLigues.TabIndex = 26;
            // 
            // lvMembre
            // 
            this.lvMembre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMembre.BackColor = System.Drawing.SystemColors.Window;
            this.lvMembre.HideSelection = false;
            this.lvMembre.Location = new System.Drawing.Point(9, 39);
            this.lvMembre.Name = "lvMembre";
            this.lvMembre.Size = new System.Drawing.Size(504, 313);
            this.lvMembre.TabIndex = 27;
            this.lvMembre.UseCompatibleStateImageBehavior = false;
            this.lvMembre.View = System.Windows.Forms.View.Details;
            this.lvMembre.SelectedIndexChanged += new System.EventHandler(this.lvMembre_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmEnregistrementMembres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.lvMembre);
            this.Controls.Add(this.cbxLigues);
            this.Controls.Add(this.tbxMail);
            this.Controls.Add(this.tbxTel);
            this.Controls.Add(this.tbxPrenom);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.dgvMembre);
            this.Controls.Add(this.lblLigue);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plTop);
            this.Name = "frmEnregistrementMembres";
            this.Text = "Enregistrement membres";
            this.Load += new System.EventHandler(this.frmEnregistrementMembres_Load);
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.plBtoom.ResumeLayout(false);
            this.plBtoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.LinkLabel frmMode;
        private System.Windows.Forms.Label M2L;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel plTop2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plBtoom;
        private System.Windows.Forms.Panel plBtoom2;
        private System.Windows.Forms.LinkLabel lbxEnregistrement;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblLigue;
        private System.Windows.Forms.DataGridView dgvMembre;
        private System.Windows.Forms.LinkLabel lbxAnnuler;
        private System.Windows.Forms.LinkLabel lbxModifier;
        private System.Windows.Forms.LinkLabel lbxNew;
        private System.Windows.Forms.LinkLabel lbxDel;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.TextBox tbxPrenom;
        private System.Windows.Forms.TextBox tbxTel;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.ComboBox cbxLigues;
        private System.Windows.Forms.ListView lvMembre;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.LinkLabel lbxModif;
    }
}