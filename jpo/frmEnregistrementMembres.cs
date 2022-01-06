using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jpo
{
    public partial class frmEnregistrementMembres : Form
    {
        OleDbConnection connex = new System.Data.OleDb.OleDbConnection();
        string memoire = "";
        public frmEnregistrementMembres()
        {
            InitializeComponent();
        }


        private void disable()
        {
            //désactive toutes les textbox, les linklabel, et la combobox

            tbxNom.Enabled = false;
            tbxPrenom.Enabled = false;
            tbxTel.Enabled = false;
            tbxMail.Enabled = false;
            cbxLigues.Enabled = false;
            lbxEnregistrement.Enabled = false;
            lbxAnnuler.Enabled = false;
        }

        private void enable()
        {
            //active toutes les textbox, les linklabel, et la combobox

            tbxNom.Enabled = true;
            tbxPrenom.Enabled = true;
            tbxTel.Enabled = true;
            tbxMail.Enabled = true;
            cbxLigues.Enabled = true;
            lbxAnnuler.Enabled = true;
            lbxEnregistrement.Enabled = true;
        }
        private void frmEnregistrementMembres_Load(object sender, EventArgs e)
        {
            Mode(2);

            //met à jour la listbox

            LoadLV();

            dgvMembre.Columns.Add("iCode", "Code");
            dgvMembre.Columns.Add("iNom", "Nom");
            dgvMembre.Columns.Add("iPrénom", "Prénom");
            dgvMembre.Columns.Add("iTel", "Téléphone");
            dgvMembre.Columns.Add("iMail", "Mail");
            dgvMembre.Columns.Add("iLigues", "Ligues");


            //met à jour le dgv( caché )
            refresgdgv();
            disable();



        }

        private void lbxAnnuler_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            //désactive toutes les textbox, les linklabel, et la combobox et les vides


            disable();
            tbxNom.Text = "";
            tbxMail.Text = "";
            tbxPrenom.Text = "";
            tbxTel.Text = "";
            lbxModif.Visible = false;
        }
        private void refresgdgv()
        {
            //création du dgv (première methode)

            dgvMembre.Rows.Clear();
            string connexString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source=" + Program.dbPatch;
            connex.ConnectionString = connexString;
            connex.Open();

            OleDbCommand command = new OleDbCommand();
            command.CommandText = "select * from membre";
            command.Connection = connex;

            OleDbCommand commandLigue = new OleDbCommand();
            commandLigue.CommandText = "select * from Ligues";
            commandLigue.Connection = connex;

            OleDbDataReader DtReaderLigue = commandLigue.ExecuteReader();
            OleDbDataReader DtReader = command.ExecuteReader();

            int i = 0;
            int il = 0;

            while (DtReaderLigue.Read())
            {
                cbxLigues.Items.Add(Convert.ToString(DtReaderLigue.GetValue(1)));
                il++;
            }
            dgvMembre.RowHeadersVisible = false;
            dgvMembre.Columns[0].Visible = false;


            while (DtReader.Read())
            {
                dgvMembre.Rows.Add();
                dgvMembre[0, i].Value = Convert.ToString(DtReader.GetValue(0));
                dgvMembre[1, i].Value = Convert.ToString(DtReader.GetValue(1));
                dgvMembre[2, i].Value = Convert.ToString(DtReader.GetValue(2));
                dgvMembre[3, i].Value = Convert.ToString(DtReader.GetValue(3));
                dgvMembre[4, i].Value = Convert.ToString(DtReader.GetValue(4));
                dgvMembre[5, i].Value = Convert.ToString(DtReader.GetValue(5));
                i++;
            }
            connex.Close();
        }
        private void lbxEnregistrement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            

            //--------------------------------------------------------------- REGEX

            

            string tel= tbxTel.Text;
            Regex regT = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            if (!regT.IsMatch(tel))
            {
                tbxTel.Focus();
                tbxTel.Text = null;
                MessageBox.Show("Saisi tel incorrect");
            }

            string mail = tbxMail.Text;
            Regex regM = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!regM.IsMatch(mail))
            {
                tbxMail.Focus();
                tbxMail.Text = null;
                MessageBox.Show("Saisi mail incorrect");
            }

            //--------------------------------------------------------------- REGEX

            if (regM.IsMatch(mail) && regT.IsMatch(tel))
            {
                //déclaration variable pour récupere valeur des clefs primaires

                int codeligue = 0;
                int il = 0;
                connex.Open();

                OleDbCommand commandLigue = new OleDbCommand();
                commandLigue.CommandText = "select * from Ligues";
                commandLigue.Connection = connex;
                OleDbDataReader DtReaderLigues = commandLigue.ExecuteReader();

                //recupére valeur clef primaire et la met dans une variable
                while (DtReaderLigues.Read())
                {

                    if (Convert.ToString(DtReaderLigues.GetValue(1)) == cbxLigues.Text)
                        codeligue = DtReaderLigues.GetInt32(0);

                    il++;
                }

                //requete d'insertion pour un nouvel enregistrement dans la table membre
                string uneRequete = "insert into membre (nom, prénom, téléphone, mail, codeLigue) values('" + tbxNom.Text +
                    "', '" + tbxPrenom.Text + "', '" + tbxTel.Text + "', '" + tbxMail.Text + "', '" + codeligue + "'); ";


                OleDbCommand oleCommande = new OleDbCommand(uneRequete, connex);
                int reponse = oleCommande.ExecuteNonQuery();
            }
            

            //fermeture de la connexion, met a jour la ListViewItem et le dgv (cachée) et désactives toutes les textbox, les linklabel, et la combobox         

            connex.Close();
            refresgdgv();
            disable();
            LoadLV();
        }

        private void lbxNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //met dans les tbx aucunes valeurs ou ""
            Null();
            
            //actives toutes les textbox, les linklabel, et la combobox      

            enable();
            lbxModif.Visible = false;
        }

        private void lbxModifier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //actives toutes les textbox, les linklabel, et la combobox      

            enable();
            lbxModif.Visible = true;

            if (lvMembre.SelectedItems.Count > 0)
            {
                ListViewItem itiem = lvMembre.SelectedItems[lvMembre.SelectedItems.Count - 1];
                if (itiem != null)

                    //boucle qui permet de mettre le numéro de tel dans une variable mémoire

                    foreach (ListViewItem lv in lvMembre.SelectedItems)
                    {


                        memoire = lv.SubItems[2].Text;


                    }
            }
            lbxEnregistrement.Enabled = false;

        }

        private void lbxDel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //désactives toutes les textbox, les linklabel, et la combobox      



            disable();
            //exception pour gérer des enregistrement connexes
            try
            {
                if (lvMembre.SelectedItems.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Êtes vous sûres de vouloir supprimer ce membre ?", "Suppression du membre !", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ListViewItem itiem = lvMembre.SelectedItems[lvMembre.SelectedItems.Count - 1];
                        if (itiem != null)

                            //boucle qui suprimme un enregistrement en fonction du nom et du prenom

                            foreach (ListViewItem lv in lvMembre.SelectedItems)
                            {

                                string uneRequete = "delete from membre where nom = '" + tbxNom.Text + "' AND prénom = '" + tbxPrenom.Text + "'";
                                OleDbCommand oleCommande = new OleDbCommand(uneRequete, connex);
                                connex.Open();
                                int reponse = oleCommande.ExecuteNonQuery();
                                connex.Close();


                            }

                        //clear de la ListView

                        lvMembre.Items.Clear();


                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un contact !!");
                }
            }
            catch (Exception ex)
            {
                connex.Close();
                MessageBox.Show("Exception Message: " + ex.Message);
            }
            


            //met a jour la ListView
            LoadLV();

        }
        private void LoadLV()
        {


            if (DbConnex.etatConnection() != ConnectionState.Open)
            {
                DbConnex.connexionBase();
            }

            OleDbDataReader drmembre = DbConnex.GetDataReader("select * from membre");

            lvMembre.Items.Clear();
            lvMembre.Columns.Clear();

            lvMembre.FullRowSelect = true;
            //Membreue.GridLines = true;
            lvMembre.Sorting = SortOrder.Ascending;

            //création en tête ListView
            lvMembre.Columns.Add("Nom", 0, HorizontalAlignment.Left);
            lvMembre.Columns.Add("Prénom", 0, HorizontalAlignment.Left);
            lvMembre.Columns.Add("Téléphone", 0, HorizontalAlignment.Left);
            lvMembre.Columns.Add("Mail", 0, HorizontalAlignment.Left);
            lvMembre.Columns.Add("CodeLigue", 0, HorizontalAlignment.Left);

            int i = 0;

            //création ListViewItem qui va prendre les données de la table puis la ListView va prendre les valeurs la ListViewItem
            while (drmembre.Read())
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = drmembre.GetString(1);
                lst.SubItems.Add(drmembre.GetString(2));
                lst.SubItems.Add(drmembre.GetString(3));
                lst.SubItems.Add(drmembre.GetString(4));
                lst.SubItems.Add(drmembre.GetInt32(5).ToString());
                lst.ImageIndex = 0;
                lvMembre.Items.Add(lst);
                i++;
            }

            DbConnex.connexionClose();
            lvMembre.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvMembre.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void lvMembre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMembre.SelectedItems.Count > 0)
            {
                ListViewItem itiem = lvMembre.SelectedItems[lvMembre.SelectedItems.Count - 1];
                if (itiem != null)

                    //boucle qui permet de mettre l'enregistrement séléctionné dans la ListView à l'intérieur des cbx

                    foreach (ListViewItem lv in lvMembre.SelectedItems)
                    {

                        tbxNom.Text = lv.SubItems[0].Text;
                        tbxPrenom.Text = lv.SubItems[1].Text;
                        tbxTel.Text = lv.SubItems[2].Text;
                        tbxMail.Text = lv.SubItems[3].Text;
                        cbxLigues.Text = lv.SubItems[4].Text;

                    }
            }
            //fermeture connexion
            connex.Close();
        }

        private void lbxEnregistrement_Click(object sender, EventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbxNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && e.KeyChar != '\'' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void tbxPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && e.KeyChar != '\'' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void tbxTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && e.KeyChar != '\'' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void lbxModif_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //déclaration variable pour récupere valeur des clefs primaires
            disable();
            lbxModifier.Enabled = true;
            string memoire = "";
            
            connex.Open();

            OleDbCommand commandLigue = new OleDbCommand();
            commandLigue.CommandText = "select * from membre";
            commandLigue.Connection = connex;
            OleDbDataReader DtReaderLigues = commandLigue.ExecuteReader();

            
            if (lvMembre.SelectedItems.Count > 0)
            {
                ListViewItem itiem = lvMembre.SelectedItems[lvMembre.SelectedItems.Count - 1];
                if (itiem != null)

                    //boucle qui permet de mettre le numéro de tel dans une variable mémoire

                    foreach (ListViewItem lv in lvMembre.SelectedItems)
                    {


                        memoire = lv.SubItems[2].Text;
                        

                    }
            }
            
            //requete de mis a jour pour un nouvel enregistrement dans la table membre
            string uneRequete = "UPDATE membre SET nom = '"
                        + tbxNom.Text
                        + "', prénom = '"
                        + tbxPrenom.Text
                        + "', Téléphone = '"
                        + tbxTel.Text
                        + "', mail = '"
                        + tbxMail.Text
                        + "', codeLigue = '"
                        + cbxLigues.Text
                        + "' WHERE Téléphone = '"
                        + memoire + "';";


            OleDbCommand oleCommande = new OleDbCommand(uneRequete, connex);
            int reponse = oleCommande.ExecuteNonQuery();

            //fermeture connexion
            connex.Close();
            disable();
            //refresh de la ListView
            LoadLV();

            lbxModif.Visible = false;
        }
        private void Null()
        {
            //fonction qui vide les tbx
            tbxMail.Text = "";
            tbxNom.Text = "";
            tbxPrenom.Text = "";
            tbxTel.Text = "";
            
        }

        private void Mode(int mode)
        {
            switch (mode)
            {
                case 1:
                    {
                        frmMode.Text = "&White mode";

                        //frm
                        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));

                        //Panels
                        this.plTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
                        this.plTop2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
                        this.plBtoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
                        this.plBtoom2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));

                        //Linklabels
                        this.frmMode.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));

                        this.lbxModif.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lbxAnnuler.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lbxModifier.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lbxDel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lbxNew.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));


                        //Labels
                        this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lblNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lblPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lblTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lblMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lblLigue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.M2L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));

                        break;
                    }
                case 2:
                    {
                        frmMode.Text = "&Dark mode";

                        //frm
                        this.BackColor = System.Drawing.Color.White;

                        //Panels
                        this.plTop.BackColor = System.Drawing.Color.White;
                        this.plTop2.BackColor = System.Drawing.Color.DimGray;
                        this.plBtoom2.BackColor = System.Drawing.Color.DimGray;
                        this.plBtoom.BackColor = System.Drawing.Color.White;

                        //Linklabels
                        this.frmMode.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));

                        this.lbxEnregistrement.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lbxModifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lbxModif.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lbxAnnuler.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lbxModifier.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lbxDel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lbxNew.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));

                        //Labels
                        this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lblNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lblPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lblTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lblMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lblLigue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.M2L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        break;
                    }
            }

        } // MODE : 2 = White 1 = Dark

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
    }
}
