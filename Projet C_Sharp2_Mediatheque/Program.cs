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
        
        public static FileStream fichier;
         static Thread monThread;

       static  void SelectionFichier()
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();

            op.FileName = null;


            if (op.FileName != null)
            {
                Media monMedia = new Media();
                monMedia.Lien = op.FileName;
                fichier = new FileStream(monMedia.Lien, FileMode.Open, FileAccess.Read);
                monMedia.Taille = fichier.Length * 8;
                monMedia.Nom = op.SafeFileName;
                string extension = "";
                for (int i = 0; i < monMedia.Lien.Length; i++)
                {
                    if (i == '.')
                    {
                        extension = extension + (i++);
                    }
                }
                monMedia.Format = extension;
            }

        }
       

         static void creation_DataSet()
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

        [STAThread]
        static void Main(string[] args)
        {
            
            Application.Run(new Form1());
            //Media monMedia = new Media();
            //Audio monAudio = new Audio();
            //Texte monTexte = new Texte();
            //Console.WriteLine("Bienvenue dans votre Mediatheque");
            //Console.WriteLine("1: Pour selectionner un fichier");
            //Console.WriteLine("2: Pour Faire un tri");

            //int choix = Console.Read();

            //switch (choix)
            //{
            //    case '1':
                    
            //        monThread = new Thread(SelectionFichier);
            //        monThread.Start();
            //        //Form1 f1 = new Form1();
            //        // f1.ShowDialog();
            //        monMedia.AfficheInfo();
            //        Console.Read();
            //        break;

            //    case '2':

            //        monMedia.AfficheInfo();
            //        Console.Read();
            //        Console.Read();
            //        Console.Read();
            //        break;

            //}


            //Console.Read();
            
          
        }
    }
}
