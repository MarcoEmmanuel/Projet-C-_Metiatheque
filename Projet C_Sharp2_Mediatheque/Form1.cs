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
        Video maVideo = new Video();
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
            if (radioButton1.Checked)
            {

                    textBox1.Text = "";
            double taille;
            openFileDialog1.FileName = null;
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != null)
            {
                this.textBox1.Text = openFileDialog1.FileName;
                fichier = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read);
                monTexte.Lien = textBox1.Text;
                monTexte.Nom = openFileDialog1.SafeFileName;
                taille = fichier.Length;
                string extension = "";
                monTexte.Taille = taille;
                int pos = textBox1.Text.IndexOf('.') + 1;
                extension = textBox1.Text.Substring(pos, 3);

                monTexte.Format = extension;
                label3.Text = monTexte.Nom;
                label4.Text = monTexte.Format;
                label5.Text = monTexte.Taille.ToString();
                label6.Text = monTexte.Lien;


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

            if (radioButton2.Checked)
            {

                textBox1.Text = "";
                double taille;
                openFileDialog1.FileName = null;
                openFileDialog1.ShowDialog();

                if (openFileDialog1.FileName != null)
                {
                    this.textBox1.Text = openFileDialog1.FileName;
                    fichier = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read);
                    monAudio.Lien = textBox1.Text;
                    monAudio.Nom = openFileDialog1.SafeFileName;
                    taille = fichier.Length;
                    string extension = "";
                    monAudio.Taille = taille;
                    int pos = textBox1.Text.IndexOf('.') + 1;
                    extension = textBox1.Text.Substring(pos, 3);

                    maVideo.Format = extension;
                    label3.Text = monAudio.Nom;
                    label4.Text = monAudio.Format;
                    label5.Text = monAudio.Taille.ToString();
                    label6.Text = monAudio.Lien;


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

            if (radioButton3.Checked)
            {

                textBox1.Text = "";
                double taille;
                openFileDialog1.FileName = null;
                openFileDialog1.ShowDialog();

                if (openFileDialog1.FileName != null)
                {
                    this.textBox1.Text = openFileDialog1.FileName;
                    fichier = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read);
                    maVideo.Lien = textBox1.Text;
                    maVideo.Nom = openFileDialog1.SafeFileName;
                    taille = fichier.Length;
                    string extension = "";
                    maVideo.Taille = taille;
                    int pos = textBox1.Text.IndexOf('.') + 1;
                    extension = textBox1.Text.Substring(pos, 3);

                    maVideo.Format = extension;
                    label3.Text = maVideo.Nom;
                    label4.Text = maVideo.Format;
                    label5.Text = maVideo.Taille.ToString();
                    label6.Text = maVideo.Lien;


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
            
            if (radioButton1.Checked) {
                monTexte.Enregistrer(Program.dtTexte);
                monTexte.copierFichier("MesTextes");
            }

            if (radioButton2.Checked)
            {
                 monAudio.Enregistrer(Program.dtAudio);
                 monAudio.copierFichier("MesAudios");
            }

            if (radioButton3.Checked)
            {
                 maVideo.Enregistrer(Program.dtVideo);
                 maVideo.copierFichier("MesVideos");
            }
            //monMedia.Enregistrer(Program.dtTexte);
            
            //monThread = new Thread(copierFichier(monAudio));
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add(monTexte.TrierParMedia(Program.dtTexte));
        }

        }
    }


