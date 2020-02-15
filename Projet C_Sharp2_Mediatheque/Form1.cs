using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Projet_C_Sharp2_Mediatheque
{

    public partial class Form1 : Form
    {
        Thread monThread ;
        Media monMedia = new Media();
        Audio monAudio = new Audio();
        Texte monTexte = new Texte();
        static FileStream fichier;



        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fichier = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read);





        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            double taille;
            openFileDialog1.FileName = null;
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != null)
            {
                this.textBox1.Text = openFileDialog1.FileName;
                fichier = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read);
                monMedia.Lien = textBox1.Text;
                monMedia.Nom = openFileDialog1.SafeFileName;
                taille = fichier.Length;
                string extension = "";
                monMedia.Taille = taille;
                int pos = textBox1.Text.IndexOf('.') + 1;
                extension = textBox1.Text.Substring(pos, 3);

                monMedia.Format = extension;
                label3.Text = monMedia.Nom;
                label4.Text = monMedia.Format;
                label5.Text = monMedia.Taille.ToString();
                label6.Text = monMedia.Lien;

                if (taille > 1024)
                {

                    taille = taille / 1024;
                    this.label2.Text = "Taille originale du Fichier :" + taille + " " + "Ko";
                }

                else if (taille > Math.Pow(1024, 2))
                {
                    taille = taille / Math.Pow(1024, 2);
                    this.label2.Text = "Taille originale du Fichier :" + taille + " " + "Mo";
                }

                else if (taille > Math.Pow(1024, 3))
                {
                    taille = taille / Math.Pow(1024, 3);
                    this.label2.Text = "Taille originale du Fichier :" + taille + " " + "Go";
                }

                else
                {
                    this.label2.Text = "Taille originale du Fichier :" + taille + " " + "Octets";
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            monMedia.Enregistrer(Program.dtTexte);
            monThread = new Thread(copierFichier(Media monMedia));
            
        }

        
             public static void copierFichier(Media M)
            {
                string fileName = M.Nom;
                string sourcePath = M.Lien;
                string targetPath = @"C:\Users\MARCO\Documents\Visual Studio 2012\Projects\Projet C_Sharp2_Mediatheque\Projet C_Sharp2_Mediatheque\bin\Debug";

                // Use Path class to manipulate file and directory paths.
                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                string destFile = System.IO.Path.Combine(targetPath, fileName);

                // To copy a folder's contents to a new location:
                // Create a new target folder. 
                // If the directory already exists, this method does not create a new directory.
                System.IO.Directory.CreateDirectory(targetPath);

                // To copy a file to another location and 
                // overwrite the destination file if it already exists.
                System.IO.File.Copy(sourceFile, destFile, true);

            }

        }
    }


