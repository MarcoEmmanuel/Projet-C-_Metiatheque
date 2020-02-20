using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Media;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;


namespace Projet_C_Sharp2_Mediatheque
{
    public class Program
    {
       
            //Création du DataSet
            DataSet dsMedia = new DataSet();

            //Création des DataTables
          public static DataTable dtTexte = new DataTable("Texte");
            public static DataTable dtAudio = new DataTable("Audio");
          public static  DataTable dtVideo = new DataTable("Video");


        public static void creercolonne(){
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
            dtTexte.PrimaryKey = new DataColumn[] {colidT};
            colidT.AutoIncrement = true;


            //Ajout des Colonnes  dans DataTable dtAudio
            DataColumn colidA = new DataColumn("Id", Type.GetType("System.String"));
            DataColumn colnomA = new DataColumn("Nom", Type.GetType("System.String"));
            DataColumn colFormatA = new DataColumn("Format", Type.GetType("System.String"));
            DataColumn colTailleA = new DataColumn("Taille", Type.GetType("System.Double"));
            DataColumn colLienA = new DataColumn("Lien", Type.GetType("System.String"));
            
            //Ajout des colonnes au DataTable
            dtAudio.Columns.Add(colidA);
            dtAudio.Columns.Add(colnomA);
            dtAudio.Columns.Add(colFormatA);
            dtAudio.Columns.Add(colTailleA);
            dtAudio.Columns.Add(colLienA);
            
            //Définition de la clé primaire
            dtAudio.PrimaryKey = new DataColumn[] { colidA };
            colidA.AutoIncrement = true;

            //Ajout des Colonnes  dans DataTable dtVideo
            DataColumn colidV = new DataColumn("Id", Type.GetType("System.String"));
            DataColumn colnomV = new DataColumn("Nom", Type.GetType("System.String"));
            DataColumn colFormatV = new DataColumn("Format", Type.GetType("System.String"));
            DataColumn colTailleV = new DataColumn("Taille", Type.GetType("System.Double"));
            DataColumn colLienV = new DataColumn("Lien", Type.GetType("System.String"));
            
            //Ajout des colonnes au DataTable
            dtVideo.Columns.Add(colidV);
            dtVideo.Columns.Add(colnomV);
            dtVideo.Columns.Add(colFormatV);
            dtVideo.Columns.Add(colTailleV);
            dtVideo.Columns.Add(colLienV);
            //Définition de la clé primaire
            dtVideo.PrimaryKey = new DataColumn[] { colidV };
            colidV.AutoIncrement = true;

        }

        [STAThread]
        static void Main(string[] args)
        {
            creercolonne();
            Application.Run(new Form1());
            
            
          
        }
    }
}
