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
    public partial class frmInscriptionMembres : Form
    {
        public frmInscriptionMembres()
        {
            InitializeComponent();
        }
        OleDbConnection connex = new System.Data.OleDb.OleDbConnection();
        int mCreneau = 0 , mMembre = 0;
        int codeMemb = 0;
        int codeCren = 0;

        private void frmInscriptionMembres_Load(object sender, EventArgs e)
        {
            disable();
            string connexString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source=" + Program.dbPatch;
            connex.ConnectionString = connexString;
            connex.Open();
            OleDbCommand commandCreneau = new OleDbCommand();
            commandCreneau.CommandText = "select * from creneau";
            commandCreneau.Connection = connex;
            OleDbDataReader DtReaderCreneau = commandCreneau.ExecuteReader();

            OleDbCommand commandMembre = new OleDbCommand();
            commandMembre.CommandText = "select * from membre";
            commandMembre.Connection = connex;
            OleDbDataReader DtReaderMembre = commandMembre.ExecuteReader();

            OleDbCommand commandLigue = new OleDbCommand();
            commandLigue.CommandText = "select * from ligues";
            commandLigue.Connection = connex;
            OleDbDataReader DtReaderLigue = commandLigue.ExecuteReader();

            int ic = 0;
            int il = 0;
            int im = 0;

            while (DtReaderCreneau.Read())
            {
                cbxCreneau.Items.Add(Convert.ToString(DtReaderCreneau.GetValue(1)));
                ic++;
            }
            while (DtReaderMembre.Read())
            {
                cbxMembre.Items.Add(Convert.ToString(DtReaderMembre.GetValue(1) + " " + DtReaderMembre.GetValue(2)));
                im++;
            }
            while (DtReaderLigue.Read())
            {
                cbxLigues.Items.Add(Convert.ToString(DtReaderLigue.GetValue(1)));
                il++;
            }
            connex.Close();

            LoadLV();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codelui = 0;
            
            RefreshConnection();
            OleDbCommand commandMembre = new OleDbCommand();
            commandMembre.CommandText = "select * from membre";
            commandMembre.Connection = connex;
            OleDbDataReader DtReaderMembre = commandMembre.ExecuteReader();

            OleDbCommand commandLigue = new OleDbCommand();
            commandLigue.CommandText = "select * from Ligues";
            commandLigue.Connection = connex;
            OleDbDataReader DtReaderLigues = commandLigue.ExecuteReader();

            cbxMembre.Items.Clear();

            //double boucle qui permet de mettre les membres dans la cbxMembres en fonction de la ligue choisi

            while (DtReaderLigues.Read())
            {

                if (Convert.ToString(DtReaderLigues.GetValue(1)) == cbxLigues.Text)
                {
                    codelui = DtReaderLigues.GetInt32(0);
                 
                    while (DtReaderMembre.Read())
                    {
                        

                        if (codelui == DtReaderMembre.GetInt32(5))
                        {
                         
                            cbxMembre.Items.Add(Convert.ToString(DtReaderMembre.GetValue(1) + " " + DtReaderMembre.GetValue(2)));
                        }
                            
                        

                    }
                }
            }

          
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Condition qui va récuperer la valeur de codeCreneau en fonction de ce qu'il y'a dans la cbx pour pouvoir utiliser la variable après

            try
            {
                if (Convert.ToString(cbxCreneau.SelectedItem) == "Matin")
                {
                    codeCren = 1;
                }
                else if (Convert.ToString(cbxCreneau.SelectedItem) == "Après-midi")
                {
                    codeCren = 2;
                }
                else if (Convert.ToString(cbxCreneau.SelectedItem) == "Journée Entière")
                {
                    codeCren = 3;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connex.Close();
            }
            
            
        }

        private void lblCréneau_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblLigues_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        private void LoadLV()
        {

            if (DbConnex.etatConnection() != ConnectionState.Open)
            {
                DbConnex.connexionBase();
            }

            OleDbDataReader drmp = DbConnex.GetDataReader("select * from participer");

            lvIMembre.Items.Clear();
            lvIMembre.Columns.Clear();
              
            lvIMembre.FullRowSelect = true;
            
            lvIMembre.Sorting = SortOrder.Ascending;
              
              
            lvIMembre.Columns.Add("Code Créneau", 0, HorizontalAlignment.Left);
            lvIMembre.Columns.Add("Code Membre", 0, HorizontalAlignment.Left);
            

            int i = 0;

            //boucle qui récupère données de la table participer pour les mettre dans une ListViewItem et qui va les ajouter dans une ListView

            while (drmp.Read())
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = drmp.GetInt32(1).ToString();
                lst.SubItems.Add(drmp.GetInt32(0).ToString());
                lst.ImageIndex = 0;
                lvIMembre.Items.Add(lst);
                i++;
            }

            DbConnex.connexionClose();
            lvIMembre.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvIMembre.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void lbxAnnuler_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //pour annuler une saisie
            RefreshConnection();
            disable();
            lbxModif.Visible = false;
        }

        private void disable()
        {
            //désactive les combobox

            cbxCreneau.Enabled = false;
            cbxLigues.Enabled = false;
            cbxMembre.Enabled = false;
        }
        private void enable()
        {
            //active les combobox

            cbxCreneau.Enabled =true;
            cbxLigues.Enabled = true;
            cbxMembre.Enabled =true;
        }
        private void lbxNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //active les combobox
            enable();
            
        }
        private void RefreshConnection()
        {
            //fonction pour reset la connection en cas de bug
            connex.Close();
            connex.Open();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblInscrire_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //initialisation des variable pour récupérerées clefs primaires
            int codelui = 0;
            int codeCren = 0;
            int codeMembre = 0;
            int il = 0;
            int im= 0;
            int ic = 0;
            RefreshConnection();

            //déclaration des requete select en sql

            OleDbCommand commandLigue = new OleDbCommand();
            commandLigue.CommandText = "select * from Ligues";
            commandLigue.Connection = connex;
            OleDbDataReader DtReaderLigues = commandLigue.ExecuteReader();

            OleDbCommand commandC = new OleDbCommand();
            commandC.CommandText = "select * from Creneau";
            commandC.Connection = connex;
            OleDbDataReader DtC = commandC.ExecuteReader();

            OleDbCommand commandm = new OleDbCommand();
            commandm.CommandText = "select * from Membre";
            commandm.Connection = connex;
            OleDbDataReader DtM = commandm.ExecuteReader();

            //boucle "tant que" pour affecter la valeur de la clef primaire dans la variable

            while (DtM.Read())
            {

                    codeMembre = DtM.GetInt32(0);

                im++;
            }

            //boucle "tant que" pour affecter la valeur de la clef primaire dans la variable

            while (DtReaderLigues.Read())
            {

                if (Convert.ToString(DtReaderLigues.GetValue(1)) == cbxLigues.Text)
                    codelui = DtReaderLigues.GetInt32(0);

                il++;
            }

            //boucle "tant que" pour affecter la valeur de la clef primaire dans la variable

            while (DtC.Read())
            {

                if (Convert.ToString(DtC.GetValue(1)) == cbxCreneau.Text)
                    codeCren = DtC.GetInt32(0);

                ic++;
            }

            //requete insertion dans participer pour créer enregistrement
            string uneRequete = "insert into participer (codeMembre, codeCreneau) values('" + codeMembre +
                "', '" + codeCren + "'); ";

            //try catch pour gérer les doublons de la clef primaire concaténée
            try
            {

                OleDbCommand oleCommande = new OleDbCommand(uneRequete, connex);
                int reponse = oleCommande.ExecuteNonQuery();

            }
            catch
            {
                connex.Close();
                MessageBox.Show("Risque de doublons, enrengistrement non effectué");
            }

            

            //fermeture connexion avec BDD
            connex.Close();

            disable();

            //refresh de la ListView
            LoadLV();
        }

        private void lvIMembre_SelectedIndexChanged(object sender, EventArgs e)
        {

           

            if (lvIMembre.SelectedItems.Count > 0)
            {
                ListViewItem itiem = lvIMembre.SelectedItems[lvIMembre.SelectedItems.Count - 1];
                if (itiem != null)

                    //boucle qui permet de mettre l'enregistrement séléctionné dans la ListView à l'intérieur des cbx

                    foreach (ListViewItem lv in lvIMembre.SelectedItems)
                    {

                        cbxMembre.Text = lv.SubItems[1].Text;
                        cbxCreneau.Text = lv.SubItems[0].Text;

                    }
            }

            //fermeture connexion avec BDD
            connex.Close();
        }

        private void lbxDel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            disable();
            try
            {
                if (lvIMembre.SelectedItems.Count > 0)
                {
                    //message qui indique si pour assurer la supression
                    DialogResult dialogResult = MessageBox.Show("Êtes vous sûres de vouloir supprimer ce créneau ?", "Suppression du créneau !", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ListViewItem itiem = lvIMembre.SelectedItems[lvIMembre.SelectedItems.Count - 1];
                        if (itiem != null)
                            foreach (ListViewItem lv in lvIMembre.SelectedItems)
                            {

                                //requete qui recupere les valeur de la ListViewItem
                                string uneRequete = "delete from participer where codeMembre = " + lv.SubItems[1].Text + " AND codeCreneau = " + lv.SubItems[0].Text;
                                OleDbCommand oleCommande = new OleDbCommand(uneRequete, connex);
                                connex.Open();
                                int reponse = oleCommande.ExecuteNonQuery();
                                connex.Close();


                            }

                        lvIMembre.Items.Clear();

                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un créneau !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message);
            }
           

            //met a jour la ListView

            LoadLV();
        }

        private void lbxModifier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            enable();
            cbxMembre.Enabled = false;
            cbxLigues.Enabled = false;
            lbxModif.Visible = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblDarkMode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblDarkMode.Text == "&White mode")
            {
                lblDarkMode.Text = "&Dark mode";


                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));

                this.plTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
                this.plTop2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));

                this.plBtoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
                this.plBtoom2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));

                this.lblLigues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                this.lblMembres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                this.lblCréneau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));

                this.lblEnregistrement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                this.M2L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));

                this.lbxModif.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                this.lbxAnnuler.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                this.lbxModifier.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                this.lbxDel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                this.lbxNew.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                this.lblDarkMode.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                this.lblInscrire.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));


            }
            else if (lblDarkMode.Text == "&Dark mode")
            {
                lblDarkMode.Text = "&White mode";

                this.plTop.BackColor = System.Drawing.Color.White;
                this.plTop2.BackColor = System.Drawing.Color.DimGray;

                this.plBtoom2.BackColor = System.Drawing.Color.DimGray;
                this.plBtoom.BackColor = System.Drawing.Color.White;

                this.BackColor = System.Drawing.Color.White;

                //   this.lbxSave.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                this.lblLigues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                this.lblMembres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                this.lblCréneau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                this.lblEnregistrement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                this.M2L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));


                this.lbxModif.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                this.lbxAnnuler.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                this.lbxModifier.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                this.lbxDel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                this.lbxNew.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                this.lblDarkMode.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                this.lblInscrire.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));

            }
        }

        private void lbxModif_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //déclaration variable pour récupere valeur des clefs primaires
            disable();
            lbxModifier.Enabled = true;

            try
            {
                

                connex.Open();

                OleDbCommand command = new OleDbCommand();
                command.CommandText = "select * from participer";
                command.Connection = connex;
                OleDbDataReader DtReader = command.ExecuteReader();

                

                if (lvIMembre.SelectedItems.Count > 0)
                {
                    ListViewItem itiem = lvIMembre.SelectedItems[lvIMembre.SelectedItems.Count - 1];
                    if (itiem != null)

                        //boucle qui permet de mettre le numéro de tel dans une variable mémoire

                        foreach (ListViewItem lv in lvIMembre.SelectedItems)
                        {


                            mCreneau = Convert.ToInt32(lv.SubItems[0].Text);
                            mMembre = Convert.ToInt32(lv.SubItems[1].Text);

                        }
                }

                
                //requete de mis a jour pour un nouvel enregistrement dans la table participer
                string uneRequete = "UPDATE participer SET codeCreneau = "
                            + codeCren
                            + " WHERE codeCreneau = "
                            + mCreneau +
                            " AND codeMembre = "
                            + mMembre + ";";


                OleDbCommand oleCommande = new OleDbCommand(uneRequete, connex);
                int reponse = oleCommande.ExecuteNonQuery();

                //fermeture connexion
                connex.Close();
                disable();
                //refresh de la ListView
                LoadLV();

                lbxModif.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connex.Close();
            }

            
        }
    }
}
