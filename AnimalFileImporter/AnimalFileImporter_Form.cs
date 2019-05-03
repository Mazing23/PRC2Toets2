using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalFileImporter
{
    public partial class AnimalFileImporter_Form : Form
    {
        private List<string> allAnimals = new List<string>();

        public AnimalFileImporter_Form()
        {
            InitializeComponent();
        }

        private string ChooseFolderPath()
        {
            OpenFileDialog folder = new OpenFileDialog();
            DialogResult resultfolder = folder.ShowDialog();

            if (resultfolder == DialogResult.OK)
            {
                return folder.FileName;
            }
            else if (resultfolder == DialogResult.Cancel) return null;

            return null;
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            string result = ChooseFolderPath();
            if (result == null) throw new ArgumentNullException(nameof(result));
            CheckContentsFile(result);
        }

        private void CheckContentsFile(string filename)
        {
            if (File.Exists(filename))
            {
                string lines;
                StreamReader reader = new StreamReader(filename);
                List<string> animal = new List<string>();
                while (!reader.EndOfStream)
                {
                    while((lines = reader.ReadLine()) != null)
                    {
                        allAnimals.Add(lines);
                    }
                }
            }

            foreach (string s in allAnimals)
            {
                string first = (s.Split(':')[0]);
                if (first == "Cat") lbCats.Items.Add(s);
                if (first == "Dog") lbDogs.Items.Add(s);
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            //string filename = txtFilename.Text;
            //try
            //{
            //    string[] dirs = Directory.GetDirectories(@"c:\", "p*");
            //    foreach (string d in dirs)
            //    {
            //        if (d == null) throw new ArgumentNullException(d);
            //        //CheckContentsFile(d);
            //        MessageBox.Show(d);
            //    }
            //}
            //catch (ArgumentNullException ex)
            //{
            //    MessageBox.Show("No directories found\n" + ex.Message);
            //}
        }
    }
}
