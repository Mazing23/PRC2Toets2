//using PRC2Toets2;
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
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

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
            if (result == null) MessageBox.Show("No file was selected for importation");
            CheckContentsFile(result);

        }

        public void CheckContentsFile(string filename)
        {
            try
            {
                if (File.Exists(filename))
                {
                    string lines;
                    using (StreamReader reader = new StreamReader(filename))
                    {
                        List<string> animal = new List<string>();
                        while (!reader.EndOfStream)
                        {
                            while ((lines = reader.ReadLine()) != null)
                            {
                                allAnimals.Add(lines);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("FileName given was not found, please try again");
                }

            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show($"Directory not found: {ex.Message}");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"IO Exception: {ex.Message}");
            }

            foreach (string s in allAnimals)
            {
                string first = (s.Split(':')[0]);
                if (first == "Cat") lbCats.Items.Add(s);
                if (first == "Dog") lbDogs.Items.Add(s);
            }
        }

    }
}
