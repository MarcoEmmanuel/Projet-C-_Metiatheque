using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace Projet_C_Sharp2_Mediatheque
{
    class Media
    {
        private string id;
        private string nom;
        private string format;
        private double taille;
        private string lien;

        public Media()
        {
            
            this.Nom = "";
            this.Format = "";
            this.Taille = 0;
            this.Lien = "";
        }

        public Media(string n, string f, double t, string l)
        {
            
            this.Nom = n;
            this.Format = f; 
            this.Taille = t; 
            this.Lien = l;
        }

        public string Id {
            get { return id; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom= value; }
        }

        public string Format
        {
            get { return format; }
            set { format = value; }
        }

        public double Taille
        {
            get { return taille; }
            set { taille = value; }
        }

        public string Lien
        {
            get { return lien; }
            set {lien = value; }
        }


        public void Enregistrer(DataTable TableMedia)
        {
             DataRow dr = TableMedia.NewRow();
            dr["Nom"] = this.Nom;
            dr["Taille"] = this.Taille;
            dr["Format"] = this.Format;
            dr["Lien"] = this.Lien;
            TableMedia.Rows.Add(dr);
            TableMedia.AcceptChanges();
            
        }

        public void copierFichier(string DossierFichier)
        {
            string fileName = this.Nom;
            string sourcePath = this.Lien;
            string targetPath = @"C:\Users\MARCO\Documents\Visual Studio 2012\Projects\Projet C_Sharp2_Mediatheque\Projet C_Sharp2_Mediatheque\bin\Debug\Mes_Medias\"+ DossierFichier;

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            // To copy a folder's contents to a new location:
            // Create a new target folder. 
            // If the directory already exists, this method does not create a new directory.
            System.IO.Directory.CreateDirectory(targetPath);

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);

        }


        public string AfficheInfo()
        {
            string Afficher = "Lien :" + this.Lien + " " + " Nom :" + this.Nom + " " + "Taille:" + this.Taille + " " + "Format:" + this.Format;
            return Afficher;
        }

         public void TrierParNom( DataTable TableChoisie ,string noms)
        {
            foreach (DataRow dr in TableChoisie.Rows)
            {
                if (dr["Nom"] == noms) {
                    for (int i = 0; i < TableChoisie.Columns.Count; i++)
                    {
                        Console.Write(dr[i]);
                        Console.Write("\n");
                    }
                
                }
            }
        }
         public string TrierParMedia(DataTable TableChoisie)
        {
            string lignes="";
                foreach (DataRow dr in TableChoisie.Rows)
            {
                
                    for (int i = 0; i < TableChoisie.Columns.Count; i++)
                    {
                        lignes= dr[i].ToString();
                    }
                
            }

                return lignes;
        }
         public void Trier(DataTable TableChoisie, string taille)
        {
                foreach (DataRow dr in TableChoisie.Rows)
            {
                if (dr["Taille"] == taille) {
                    for (int i = 0; i < TableChoisie.Columns.Count; i++)
                    {
                        Console.Write(dr[i]);
                        Console.Write("\n");
                    }
                
                }
            }
        }
    }
}
