using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace jpo
{
    public partial class frmInscriptionLigues : Form
    {

        public frmInscriptionLigues()
        {
            InitializeComponent();
        }

        private bool enCours = false;
        private int codeLigue = 0;
        private int codeInscription = 0;
        OleDbConnection connex = new System.Data.OleDb.OleDbConnection();
       
        void Set()
        {
            String connexString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source=" + Program.dbPatch;
            connex.ConnectionString = connexString;
        } // ...
       
        private void LoadLigueLV()
        {
            if (DbConnex.etatConnection() != ConnectionState.Open)
            {
                DbConnex.connexionBase();
            }
            OleDbDataReader drLigues = DbConnex.GetDataReader("select * from ligues");

            lvLigue.Items.Clear();
            lvLigue.Columns.Clear();
            //lvLigue.CheckBoxes = true;
            lvLigue.FullRowSelect = true;
            //lvLigue.GridLines = true;
            lvLigue.Sorting = SortOrder.Ascending;

            lvLigue.Columns.Add("Nom Ligue", 0, HorizontalAlignment.Left);
            lvLigue.Columns.Add("Adresse", 0, HorizontalAlignment.Left);
            lvLigue.Columns.Add("CP", 0, HorizontalAlignment.Left);
            lvLigue.Columns.Add("Ville", 0, HorizontalAlignment.Left);
            lvLigue.Columns.Add("Discipline", 0, HorizontalAlignment.Left);

            int i = 0;
            while (drLigues.Read())
            {
                ListViewItem lst = new ListViewItem();
                //lst.Checked = false;
                lst.Text = drLigues.GetString(1);
                lst.SubItems.Add(drLigues.GetString(2));
                lst.SubItems.Add(drLigues.GetString(3));
                lst.SubItems.Add(drLigues.GetString(4));
                lst.SubItems.Add(drLigues.GetString(5));
                lst.ImageIndex = 0;
                lvLigue.Items.Add(lst);
                i++;
            }

            DbConnex.connexionClose();
            lvLigue.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvLigue.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        } // Charger le listview lvLigue
        private void LoadEquipementLV()
        {
            lvEquipement.Items.Clear();
            lvEquipement.Columns.Clear();
            lvEquipement.View = View.Details;
            lvEquipement.AllowColumnReorder = true;
            lvEquipement.CheckBoxes = true;
            lvEquipement.FullRowSelect = true;
            //lvEquipement.GridLines = true;
            lvEquipement.Sorting = SortOrder.Ascending;
            lvEquipement.Columns.Add("Equipement", 0, HorizontalAlignment.Left);

            try
            {
                if (DbConnex.etatConnection() != ConnectionState.Open)
                {
                    DbConnex.connexionBase();
                }
                OleDbDataReader drEquipement = DbConnex.GetDataReader("select * from Equipement");
                int i = 0;
                while (drEquipement.Read())
                {
                    ListViewItem lst = new ListViewItem();
                    lst.Checked = false;
                    lst.Text = drEquipement.GetString(1);
                    // lst.SubItems.Add("");
                    lst.ImageIndex = 4;
                    lvEquipement.Items.Add(lst);
                    i++;
                }
                drEquipement.Close();
                DbConnex.connexionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Program.WriteError(ex.ToString(), "WriteConsole");
            }
           
            lvEquipement.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvEquipement.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        } // Charger le listview lvEquipement
        private void LoadEquipementLV(int numInscription)
        {
            lvEquipement.Items.Clear();
            lvEquipement.Columns.Clear();
            lvEquipement.View = View.Details;
            lvEquipement.AllowColumnReorder = true;
            lvEquipement.CheckBoxes = true;
            lvEquipement.FullRowSelect = true;
            //lvEquipement.GridLines = true;
            lvEquipement.Sorting = SortOrder.Ascending;

            lvEquipement.Columns.Add("Equipement", 0, HorizontalAlignment.Left);

            try
            {
                if (DbConnex.etatConnection() != ConnectionState.Open)
                {
                    DbConnex.connexionBase();
                }
                OleDbDataReader drEquip = DbConnex.GetDataReader("select * from Equipement");

                while (drEquip.Read())
                {
                    ListViewItem lst = new ListViewItem();
                    if (DbConnex.etatConnection() != ConnectionState.Open)
                    {
                        DbConnex.connexionBase();
                    }
                    OleDbDataReader drDemander = DbConnex.GetDataReader("select * from Demander where numInscription=" + numInscription);

                    while (drDemander.Read())
                    {
                        if (drDemander.GetInt32(0) == numInscription)
                        {
                            if (drDemander.GetInt32(1) == drEquip.GetInt32(0))
                                lst.Checked = true;
                        }
                    }
                    drDemander.Close();

                    lst.Text = drEquip.GetString(1);
                    //lst.SubItems.Add("");
                    //lst.ImageIndex = 4;
                    lvEquipement.Items.Add(lst);

                }
                drEquip.Close();
                DbConnex.connexionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Program.WriteError(ex.ToString(), "WriteConsole");
            }

            lvEquipement.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvEquipement.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        } // Charger le listview lvEquipement par numInscription
        private void LoadInscriptionLV()
        {
            lvInscription.Items.Clear();
            lvInscription.Columns.Clear();

            lvInscription.FullRowSelect = true;
            //lvInscription.GridLines = true;
            lvInscription.Sorting = SortOrder.Ascending;

            lvInscription.Columns.Add("Longueur", 0, HorizontalAlignment.Left);
            lvInscription.Columns.Add("Largeur", 0, HorizontalAlignment.Left);
            lvInscription.Columns.Add("Ligue", 0, HorizontalAlignment.Left);

            try
            {
                if (DbConnex.etatConnection() != ConnectionState.Open)
                {
                    DbConnex.connexionBase();
                }
                OleDbDataReader drInsc = DbConnex.GetDataReader("select * from Inscription");
                while (drInsc.Read())
                {
                    string codeLigue = "";
                    OleDbDataReader drLigues = DbConnex.GetDataReader("select * from ligues");
                    while (drLigues.Read())
                    {
                        if (drLigues.GetInt32(0) == drInsc.GetInt32(3))
                        {
                            codeLigue = drLigues.GetString(1);
                        }
                    }
                    drLigues.Close();

                    ListViewItem lst = new ListViewItem();
                    lst.Text = drInsc.GetInt32(1).ToString();
                    lst.SubItems.Add(drInsc.GetInt32(2).ToString());
                    // lst.SubItems.Add(drInsc.GetInt32(3).ToString());
                    lst.SubItems.Add(codeLigue);
                    lst.ImageIndex = 0;
                    lvInscription.Items.Add(lst);
              
                }

                drInsc.Close();
                DbConnex.connexionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Program.WriteError(ex.ToString(), "WriteConsole");
            }

            lvInscription.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvInscription.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        } // Charger le listview lvEquipement


        private void frmInscriptionLigues_Load(object sender, EventArgs e)
        {
            Mode(2);
            Set();
            LoadLigueLV();
            LoadInscriptionLV();
            LoadEquipementLV();
        }

        private void lvLigue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLigue.SelectedItems.Count > 0)
            {
                ListViewItem itiem = lvLigue.SelectedItems[lvLigue.SelectedItems.Count - 1];
                if (itiem != null)
                    foreach (ListViewItem lv in lvLigue.SelectedItems)
                    {
                        if (DbConnex.etatConnection() != ConnectionState.Open)
                        {
                            DbConnex.connexionBase();
                        }
                        OleDbDataReader drLigues = DbConnex.GetDataReader("select * from ligues");

                        while (drLigues.Read())
                        {
                            if (Convert.ToString(drLigues.GetString(1)) == lv.SubItems[0].Text)
                            {
                                codeLigue = drLigues.GetInt32(0);
                            }
                        }
                        drLigues.Close();
                        DbConnex.connexionClose();

                        tbxLongueur.Text = "";
                        tbxLargeur.Text = "";

                        lbxSave.Enabled = true;
                        gbxTailelStand.Enabled = true;
                    }
            }
            else
            {
                tbxLongueur.Text = "";
                tbxLargeur.Text = "";
                lbxSave.Enabled = false;
                gbxTailelStand.Enabled = false;
            }
        } // Selection Ligue

        private void lbxRechargerLigue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadLigueLV();
        } // Recharge le listview Ligue

        private void lbxRechargerInsc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadInscriptionLV();
        } // Recharge le listview Inscription

        private void cbxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSelectAll.Checked)
            {
                cbxSelectAll.Text = "Désélectionner Tout";
                for (int i = 0; i < lvEquipement.Items.Count; i++)
                {
                    lvEquipement.Items[i].Checked = true;
                }
            }
            else
            {
                cbxSelectAll.Text = "Sélectionner Tout";
                for (int i = 0; i < lvEquipement.Items.Count; i++)
                {
                    lvEquipement.Items[i].Checked = false;
                }
            }
        } // Sellectionner et deselectionner tout les equipements

        private void lvEquipement_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (enCours == false)
            {
                if (e.CurrentValue == CheckState.Unchecked)
                {
                    ListViewItem item = lvEquipement.Items[e.Index];
                    try
                    {
                        string uneRequete = "insert into Demander (numInscription, codeEquipement) values(" + codeInscription + ", " + DbConnex.codeEquipement(item.Text) + "); ";
                        connex.Open();
                        OleDbCommand oleCommande = new OleDbCommand(uneRequete, connex);
                        int reponse = oleCommande.ExecuteNonQuery();
                        connex.Close();
                        LoadInscriptionLV();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Program.WriteError(ex.ToString(), "WriteConsole");
                    }

                } // insert
                else
                {
                    ListViewItem item = lvEquipement.Items[e.Index];
                    try
                    {
                        string uneRequete = "delete from Demander where codeEquipement = " + DbConnex.codeEquipement(item.Text);
                        connex.Open();
                        OleDbCommand oleCommande = new OleDbCommand(uneRequete, connex);
                        int reponse = oleCommande.ExecuteNonQuery();
                        connex.Close();
                        LoadInscriptionLV();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Program.WriteError(ex.ToString(), "WriteConsole");
                    }

                } // delete
            } // enCours
        } // Sellection equipements

        private void lbxCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lvLigue.Enabled = true;

            lbxSave.Enabled = false;

            cbxSelectAll.Checked = false;

            tbxLongueur.Text = "";
            tbxLargeur.Text = "";

            gbxTailelStand.Enabled = false;
            gbxSelectEquip.Enabled = false;

            // deselection des checkbox du listview 
            for (int i = 0; i < lvEquipement.Items.Count; i++)
            {
                lvEquipement.Items[i].Checked = false;
            }

        } // deselection des checkbox du listview et vider les textbox ...

        private void lvInscription_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvInscription.SelectedItems.Count > 0)
            {
                ListViewItem itiem = lvInscription.SelectedItems[lvInscription.SelectedItems.Count - 1];
                if (itiem != null)
                {
                    codeInscription = DbConnex.codeInscription(DbConnex.codeLigue(itiem.SubItems[2].Text));

                    gbxSelectEquip.Enabled = true;
                    cbxSelectAll.Checked = false;

                    enCours = true;
                    LoadEquipementLV(codeInscription);
                    enCours = false;
                }
            }
            else
            {
                gbxSelectEquip.Enabled = false;
                lvEquipement.Items.Clear();
            }
        } // Selection Inscription

        private void lbxSupp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lvInscription.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Êtes vous sûres de vouloir supprimer cette Inscription ?", "Suppression Inscription !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ListViewItem itiem = lvInscription.SelectedItems[lvInscription.SelectedItems.Count - 1];
                    if (itiem != null)
                        foreach (ListViewItem lv in lvInscription.SelectedItems)
                        {
                            try
                            {

                                connex.Open();
                                string uneRequete = "delete from Inscription where codeLigue = " + DbConnex.codeLigue(lv.SubItems[2].Text);
                                OleDbCommand oleCommande = new OleDbCommand(uneRequete, connex);
                                int reponse = oleCommande.ExecuteNonQuery();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Assurez vous d'avoir désélectionner tous les equipements !!");
                                //MessageBox.Show(ex.Message);
                                Program.WriteError(ex.ToString(), "WriteConsole");
                            }
                            connex.Close();
                            LoadInscriptionLV();
                        }

                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une Inscription !!");
            }
        } // Suppresion Inscription

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (frmMode.Text == "&White mode")
            {
                Mode(2);
            }
            else if (frmMode.Text == "&Dark mode")
            {
                Mode(1);
            }
        } // Choix Mode

        private void Mode(int mode)
        {
            switch (mode)
            {
                case 1:
                    {
                        frmMode.Text = "&White mode";
                        this.frmMode.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));

                        //frm
                        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));

                        //Panels
                        this.plTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
                        this.plTop2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
                        this.plBtoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
                        this.plBtoom2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));

                        //Linklabels
                        this.lbxRechargerInsc.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lbxRechargerLigue.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lbxModifier.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lbxSupp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lbxCancel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lbxSave.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));

                        //Labels
                        this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lblLargeur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lblLongueur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lblEquipSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));

                        //Groupbox
                        this.gbxTailelStand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.gbxSelectEquip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));

                        break;
                    }
                case 2:
                    {
                        frmMode.Text = "&Dark mode";
                        this.frmMode.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));

                        //frm
                        this.BackColor = System.Drawing.Color.White;

                        //Panels
                        this.plTop.BackColor = System.Drawing.Color.White;
                        this.plTop2.BackColor = System.Drawing.Color.DimGray;
                        this.plBtoom2.BackColor = System.Drawing.Color.DimGray;
                        this.plBtoom.BackColor = System.Drawing.Color.White;

                        //Linklabels
                        this.lbxModifier.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lbxSupp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lbxCancel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lbxSave.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lbxRechargerInsc.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lbxRechargerLigue.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));

                        //Labels
                        this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lblLargeur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lblLongueur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lblEquipSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                       
                        //Groupbox
                        this.gbxTailelStand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.gbxSelectEquip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));

                        break;
                    }
            }

        } // MODE : 2 = White 1 = Dark


        private void lbxSave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tbxLongueur.Text != "" && tbxLargeur.Text != "")
            {
                // a faire : verifier si codeLigue existe dans inscription
                try
                {
                    string uneRequete = "insert into Inscription (longueur, largeur, codeLigue) values(" + tbxLongueur.Text + ", " + tbxLargeur.Text + ", " + codeLigue + ");";
                    connex.Open();
                    OleDbCommand oleCommande = new OleDbCommand(uneRequete, connex);
                    int reponse = oleCommande.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Program.WriteError(ex.ToString(), "WriteConsole");
                }
                connex.Close();

                gbxTailelStand.Enabled = false;
                lbxSave.Enabled = false;
                tbxLongueur.Text = "";
                tbxLargeur.Text = "";

                LoadInscriptionLV();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs !!");
            }

        } // Creation Inscription

        private void lbxModifier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // a faire 
            //string uneRequete = 
            //    "UPDATE Inscription SET longueur = " + tbxLongueur.Text + ", largeur = "
            //    + tbxLargeur.Text + ", codeLigue = " + codeLigue.ToString() + ";";
        } // Modifier Inscription
    }
}
