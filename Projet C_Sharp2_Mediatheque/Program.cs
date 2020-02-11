using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Media;

namespace Projet_C_Sharp2_Mediatheque
{
    public class Program
    {
        Audio monAudio = new Audio();
        Texte monTexte= new Texte();

        public static void creation_DataSet()
        {
            //Création du DataSet
            DataSet dsMedia = new DataSet();

            //Création des DataTables
            DataTable dtTexte = new DataTable("Texte");
            DataTable dtAudio = new DataTable("Audio");
            DataTable dtVideo = new DataTable("Video");



            //Ajout des Colonnes  dans DataTable dtTexte
            DataColumn colidT = new DataColumn("Id", Type.GetType("System.String"));
            DataColumn colnomT = new DataColumn("Nom", Type.GetType("System.String"));
            DataColumn colFormatT = new DataColumn("Format", Type.GetType("System.String"));
            DataColumn colTailleT = new DataColumn("Taille", Type.GetType("System.Double"));
            //Ajout des colonnes au DataTable
            dtTexte.Columns.Add(colidT);
            dtTexte.Columns.Add(colnomT);
            dtTexte.Columns.Add(colFormatT);
            dtTexte.Columns.Add(colTailleT);
            dtTexte.Columns.Add("Lien", Type.GetType("System.String"));
            //Définition de la clé primaire
            dtTexte.PrimaryKey = new DataColumn[] { colidT };



            //Ajout des Colonnes  dans DataTable dtAudio
            DataColumn colidA = new DataColumn("Id", Type.GetType("System.String"));
            DataColumn colnomA = new DataColumn("Nom", Type.GetType("System.String"));
            DataColumn colFormatA = new DataColumn("Format", Type.GetType("System.String"));
            DataColumn colTailleA = new DataColumn("Taille", Type.GetType("System.Double"));
            DataColumn colLienA = new DataColumn("Lien", Type.GetType("System.Double"));
            //Définition de la clé primaire
            dtTexte.PrimaryKey = new DataColumn[] { colidA };
            //Ajout des colonnes au DataTable
            dtTexte.Columns.Add(colidA);
            dtTexte.Columns.Add(colnomA);
            dtTexte.Columns.Add(colFormatA);
            dtTexte.Columns.Add(colTailleA);
            dtTexte.Columns.Add(colLienA);


            //Ajout des Colonnes  dans DataTable dtVideo
            DataColumn colidV = new DataColumn("Id", Type.GetType("System.String"));
            DataColumn colnomV = new DataColumn("Nom", Type.GetType("System.String"));
            DataColumn colFormatV = new DataColumn("Format", Type.GetType("System.String"));
            DataColumn colTailleV = new DataColumn("Taille", Type.GetType("System.Double"));
            DataColumn colLienV = new DataColumn("Lien", Type.GetType("System.Double"));
            //Définition de la clé primaire
            dtTexte.PrimaryKey = new DataColumn[] { colidV };
            //Ajout des colonnes au DataTable
            dtTexte.Columns.Add(colidV);
            dtTexte.Columns.Add(colnomV);
            dtTexte.Columns.Add(colFormatV);
            dtTexte.Columns.Add(colTailleV);
            dtTexte.Columns.Add(colLienV);
        }

        static void Main(string[] args)
        {
            
           
        }
    }
}
