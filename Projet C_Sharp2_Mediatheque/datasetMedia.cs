using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace Projet_C_Sharp2_Mediatheque
{
    class datasetMedia
    {

        //Création du DataSet
        DataSet dsMedia = new DataSet();
        DataView dv = new DataView();

        //Création des DataTables
        public static DataTable dtTexte = new DataTable("Texte");
        public static DataTable dtAudio = new DataTable("Audio");
        public static DataTable dtVideo = new DataTable("Video");


        public static void creercolonne()
        {
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

        //public static void chargementDataSet(out string[] listefiles)
        //{
        //    string sourceDirName = @"C:\Users\MARCO\Documents\Visual Studio 2012\Projects\Projet C_Sharp2_Mediatheque\Projet C_Sharp2_Mediatheque\bin\Debug\Mes_Medias\MesTextes";
        //    listefiles = null;

        //    // Get the subdirectories for the specified directory.
        //    DirectoryInfo dir = new DirectoryInfo(sourceDirName);

        //    if (!dir.Exists)
        //    {
        //        throw new DirectoryNotFoundException(
        //            "Source directory does not exist or could not be found: "
        //            + sourceDirName);
        //    }

        //    // Get the files in the directory and copy them to the new location.
        //    FileInfo[] files = dir.GetFiles("*.SQL");
        //    string[] infoFichier = new string[4];
        //    infoFichier = null;
        //    DataRow dr;
        //    foreach (FileInfo file in files)
        //    {
        //        listefiles = files;
        //        //dr = new DataRow();
        //        //listefiles[0] = file.Name;
        //        //listefiles[1] = sourceDirName + file.Name;
        //        //listefiles[2] = file.Length.ToString();
        //        //listefiles[3] = Form1.extraireExtension(file.Name);
        //        //dr["Nom"] = file.Name;
        //        //dr["Taille"] = file.Length;
        //        //dr["Lien"] = sourceDirName + file.Name;
        //        //dr["Format"] = Form1.extraireExtension(file.Name);
        //    }
        //}

    }
}
