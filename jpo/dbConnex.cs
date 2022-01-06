using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jpo
{
    class DbConnex
    {
        private static OleDbConnection connex = new System.Data.OleDb.OleDbConnection();
        private static string connexString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source=" + Program.dbPatch;

        public static void connexionBase()
        {
            try
            {
                connex.ConnectionString = connexString;
                connex.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static System.Data.ConnectionState etatConnection()
        {
            return connex.State;
        }

        public static void connexionClose()
        {
            connex.Close();
        
        }

        public static OleDbDataReader GetDataReader(string uneRequete)
        {
            try
            {
                OleDbCommand oleCommande = new OleDbCommand(uneRequete, connex);
                OleDbDataReader reader = oleCommande.ExecuteReader();
                return reader;
            }

            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        public static int Unscalar(string uneRequete)
        {
            connex.Open();
            OleDbCommand oleCommande = new OleDbCommand(uneRequete, connex);
            int unNB = (Int32)oleCommande.ExecuteScalar();
            connex.Close();
            return unNB;
        }

        public static int nonQuery(string uneRequete)
        {
            try
            {
                connex.Open();
                OleDbCommand oleCommande = new OleDbCommand(uneRequete, connex);
                int reponse = oleCommande.ExecuteNonQuery();
                connex.Close();
                return reponse;
            }
            catch //(Exception ex)
            {
                return -1;
            }


        }

        //
        public static int codeLigue(string ligue)
        {
            int codeLigue = 0;
            DbConnex.connexionBase();
            OleDbDataReader drLigues = DbConnex.GetDataReader("select * from ligues");

            while (drLigues.Read())
            {
                if (Convert.ToString(drLigues.GetString(1)) == ligue)
                {
                    codeLigue =  drLigues.GetInt32(0);
                }

            }
            drLigues.Close();
            DbConnex.connexionClose();
            return codeLigue;
        }

        public static int codeEquipement(string libelle)
        {
            int codeEquipement = 0;
            DbConnex.connexionBase();
            OleDbDataReader drEquip = DbConnex.GetDataReader("select * from Equipement");

            while (drEquip.Read())
            {
                if (drEquip.GetString(1) == libelle)
                    codeEquipement = drEquip.GetInt32(0);
            }
            drEquip.Close();
            DbConnex.connexionClose();
            return codeEquipement;
        }


        public static int codeInscription(int codeLigue)
        {
            int codeInscription = 0;
            DbConnex.connexionBase();
            OleDbDataReader drInscription = DbConnex.GetDataReader("select * from Inscription");

            while (drInscription.Read())
            {
                if (drInscription.GetInt32(3) == codeLigue)
                {
                    codeInscription = drInscription.GetInt32(0);
                }
            }
            drInscription.Close();
            DbConnex.connexionClose();
            return codeInscription;
        }

     
    }
}
