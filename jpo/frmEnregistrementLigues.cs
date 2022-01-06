using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace jpo
{
    public partial class frmEnregistrementLigues : Form
    {
        public frmEnregistrementLigues()
        {
            InitializeComponent();
        }
        private bool newLigue = false, newEdit = false;
        private string nomLigue = "";

        OleDbConnection connex = new System.Data.OleDb.OleDbConnection();
        private void Set()
        {
            String connexString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source="+ Program.dbPatch;
            connex.ConnectionString = connexString;
        } // ...


        private void LoadLigueLV()
        {

            lvLigue.Items.Clear();
            lvLigue.Columns.Clear();

            lvLigue.FullRowSelect = true;
            //lvLigue.GridLines = true;
            lvLigue.Sorting = SortOrder.Ascending;

            lvLigue.Columns.Add("Nom Ligue", 0, HorizontalAlignment.Left);
            lvLigue.Columns.Add("Adresse", 0, HorizontalAlignment.Left);
            lvLigue.Columns.Add("CP", 0, HorizontalAlignment.Left);
            lvLigue.Columns.Add("Ville", 0, HorizontalAlignment.Left);
            lvLigue.Columns.Add("Discipline", 0, HorizontalAlignment.Left);

            try
            {
                if (DbConnex.etatConnection() != ConnectionState.Open)
                {
                    DbConnex.connexionBase();
                }
                OleDbDataReader drLigues = DbConnex.GetDataReader("select * from ligues");

                int i = 0;
                while (drLigues.Read())
                {
                    ListViewItem lst = new ListViewItem();
                    lst.Text = drLigues.GetString(1);
                    lst.SubItems.Add(drLigues.GetString(2));
                    lst.SubItems.Add(drLigues.GetString(3));
                    lst.SubItems.Add(drLigues.GetString(4));
                    lst.SubItems.Add(drLigues.GetString(5));
                    lst.ImageIndex = 0;
                    lvLigue.Items.Add(lst);
                    i++;
                }
                drLigues.Close();
                DbConnex.connexionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Program.WriteError(ex.ToString(), "WriteConsole");
            }


            lvLigue.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvLigue.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        } // Charger le listview Ligue

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
                        this.lbxNewLigue.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lbxModifier.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lbxSupp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lbxCancel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lbxSave.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lbxRecharger.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));

                        //Labels
                        this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lblDiscipline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lblCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lblVille.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lblAdresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.lblNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
                        this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
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
                        this.lbxNewLigue.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lbxModifier.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lbxSupp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lbxCancel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lbxSave.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lbxRecharger.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));

                        //Labels
                        this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lblDiscipline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lblCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lblVille.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lblAdresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.lblNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
                        break;
                    }
            }

        } // MODE : 2 = White 1 = Dark

        private void frmEnregistrementLigues_Load(object sender, EventArgs e)
        {
            // 2 = White 
            // 1 = Dark
            Mode(2);

            //
            Set();

            //
            LoadLigueLV();
        }


        private void lvLigue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLigue.SelectedItems.Count > 0)
            {
                ListViewItem itiem = lvLigue.SelectedItems[lvLigue.SelectedItems.Count - 1];
                if (itiem != null)
                    foreach (ListViewItem lv in lvLigue.SelectedItems)
                    {
                        nomLigue = lv.SubItems[0].Text;

                        tbxNom.Text = lv.SubItems[0].Text;
                        tbxAdresse.Text = lv.SubItems[1].Text;
                        tbxVille.Text = lv.SubItems[2].Text;
                        tbxCP.Text = lv.SubItems[3].Text;
                        tbxDiscipline.Text = lv.SubItems[4].Text;
                    }
            }
        } // Selection Ligue

        private void lbxRecharger_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadLigueLV();
        } // Recharger le listview Ligue

        private void lbxSave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tbxNom.Text != "" && tbxAdresse.Text != "" && tbxVille.Text != "" && tbxCP.Text != "" && tbxDiscipline.Text != "")
            {
                if (newLigue == true)
                {


                    //a faire verification ligue existe deja
                    /*  if ()
                      {

               
                      }
                      else
                      {
                          MessageBox.Show("Cette ligue existe déjà !");
                      }*/

                    try
                    {
                        string uneRequete = "insert into ligues (nomLigue, adresse, cp, ville, sport) values('" +
                    tbxNom.Text + "', '" +
                    tbxAdresse.Text + "', '" +
                    tbxVille.Text + "', '" +
                    tbxCP.Text + "', '" +
                    tbxDiscipline.Text + "'); ";

                        connex.Open();
                        OleDbCommand oleCommande = new OleDbCommand(uneRequete, connex);
                        int reponse = oleCommande.ExecuteNonQuery();
                        connex.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Program.WriteError(ex.ToString(), "WriteConsole");
                    }



                    LoadLigueLV();


                    tbxNom.Enabled = false;
                    tbxAdresse.Enabled = false;
                    tbxVille.Enabled = false;
                    tbxCP.Enabled = false;
                    tbxDiscipline.Enabled = false;

                    tbxNom.Text = "";
                    tbxAdresse.Text = "";
                    tbxVille.Text = "";
                    tbxCP.Text = "";
                    tbxDiscipline.Text = "";

                    lbxNewLigue.Enabled = true;
                    lbxModifier.Enabled = true;
                    lbxSupp.Enabled = true;

                    lvLigue.Enabled = true;

                    lbxSave.Enabled = false;
                    // lbxCancel.Enabled = false;

                    newLigue = false;


                }
                else if (newEdit == true)
                {
                    //validation de saisie a faire

                    try
                    {
                        string uneRequete = "UPDATE ligues SET nomLigue = '" + tbxNom.Text
                     + "', adresse = '" + tbxAdresse.Text
                     + "', cp = '" + tbxCP.Text
                     + "', ville = '" + tbxVille.Text
                     + "', sport = '" + tbxDiscipline.Text
                     + "' WHERE nomLigue = '" + nomLigue + "';";

                        connex.Open();
                        OleDbCommand oleCommande = new OleDbCommand(uneRequete, connex);
                        int reponse = oleCommande.ExecuteNonQuery();
                        connex.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Program.WriteError(ex.ToString(), "WriteConsole");
                    }

                    LoadLigueLV();


                    tbxNom.Enabled = false;
                    tbxAdresse.Enabled = false;
                    tbxVille.Enabled = false;
                    tbxCP.Enabled = false;
                    tbxDiscipline.Enabled = false;

                    tbxNom.Text = "";
                    tbxAdresse.Text = "";
                    tbxVille.Text = "";
                    tbxCP.Text = "";
                    tbxDiscipline.Text = "";

                    lvLigue.Enabled = true;

                    lbxNewLigue.Enabled = true;
                    lbxModifier.Enabled = true;
                    lbxSupp.Enabled = true;

                    lbxSave.Enabled = false;
                    //  lbxCancel.Enabled = false;
                    newEdit = false;

                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs !!");
            }

        } // Enregister modifie ou ajouete une nouvelle Ligue  


        private void lbxSupp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lvLigue.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Êtes vous sûres de vouloir supprimer cette ligue ?", "Suppression ligue !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ListViewItem itiem = lvLigue.SelectedItems[lvLigue.SelectedItems.Count - 1];
                    if (itiem != null)
                        foreach (ListViewItem lv in lvLigue.SelectedItems)
                        {
                            try
                            {
                                connex.Open();
                                string uneRequete = "delete from ligues where nomLigue = '" + lv.SubItems[0].Text + "'";
                                OleDbCommand oleCommande = new OleDbCommand(uneRequete, connex);
                                int reponse = oleCommande.ExecuteNonQuery();
                                connex.Close();
                                LoadLigueLV();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                Program.WriteError(ex.ToString(), "WriteConsole");
                            }

                        }

                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligue !!");
            }
        } // Supprimer une ligues

        private void frmMode_Click(object sender, EventArgs e)
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

        private void lbxNewLigue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //enable edit
            tbxNom.Enabled = true;
            tbxAdresse.Enabled = true;
            tbxVille.Enabled = true;
            tbxCP.Enabled = true;
            tbxDiscipline.Enabled = true;

            tbxNom.Text = "";
            tbxAdresse.Text = "";
            tbxVille.Text = "";
            tbxCP.Text = "";
            tbxDiscipline.Text = "";


            lvLigue.Enabled = false;
            lbxSave.Enabled = true;
            lbxCancel.Enabled = true;

            lbxNewLigue.Enabled = false;
            lbxModifier.Enabled = false;
            lbxSupp.Enabled = false;


            newLigue = true;
        } //...

        private void lbxModifier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lvLigue.SelectedItems.Count > 0)
            {
                //enable edit
                tbxNom.Enabled = true;
                tbxAdresse.Enabled = true;
                tbxVille.Enabled = true;
                tbxCP.Enabled = true;
                tbxDiscipline.Enabled = true;

                lvLigue.Enabled = false;

                lbxSave.Enabled = true;
                lbxCancel.Enabled = true;

                lbxNewLigue.Enabled = false;
                lbxModifier.Enabled = false;
                lbxSupp.Enabled = false;

                newEdit = true;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligue !!");
            }
        } // ...

        private void lbxCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbxNom.Enabled = false;
            tbxAdresse.Enabled = false;
            tbxVille.Enabled = false;
            tbxCP.Enabled = false;
            tbxDiscipline.Enabled = false;



            tbxNom.Text = "";
            tbxAdresse.Text = "";
            tbxVille.Text = "";
            tbxCP.Text = "";
            tbxDiscipline.Text = "";

            lvLigue.Enabled = true;

            lbxNewLigue.Enabled = true;
            lbxModifier.Enabled = true;
            lbxSupp.Enabled = true;

            lbxSave.Enabled = false;
            lbxCancel.Enabled = true;

            newLigue = false;
            newEdit = false;
        } // ...

    }
}
