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

        public Media(string i,string n, string f, double t, string l)
        {
            this.Id = i;
            this.Nom = n;
            this.Format = f; 
            this.Taille = t; 
            this.Lien = l;
        }

        public string Id {
            get { return id; }
            set { id = value; }
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


            DataRow dr = new DataRow();
            dr["Id"] = this.Id;
            dr["Nom"] = this.Nom;
            dr["Taille"] =this.Nom;
            dr["Format"] = this.Nom;
            dr["Lien"] = this.Nom;
           TableMedia.Rows.Add(dr);
 
        }

        public void Trier(string id)
        {
 
        }

         public void TrierParNom( DataTable TableChoisie ,string nom)
        {
            foreach (DataRow dr in TableChoisie.Rows)
            {
                if (dr["Nom"] == nom) {
                    for (int i = 0; i < TableChoisie.Columns.Count; i++)
                    {
                        Console.Write(dr[i]);
                        Console.Write("\n");
                    }
                
                }
            }
        }
         public void TrierParMedia(DataTable TableChoisie)
        {
                foreach (DataRow dr in TableChoisie.Rows)
            {
                
                    for (int i = 0; i < TableChoisie.Columns.Count; i++)
                    {
                        Console.Write(dr[i]);
                        Console.Write("\n");
                    }
                
            }
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
