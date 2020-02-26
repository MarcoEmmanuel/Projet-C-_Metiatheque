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
       

        [STAThread]
        static void Main(string[] args)
        {
            datasetMedia.creercolonne();
            Application.Run(new Form1());
            
            
          
        }
    }
}
