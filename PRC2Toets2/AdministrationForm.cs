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

namespace PRC2Toets2
{
    public partial class AdministrationForm : Form
    {
        private Administration admin;
        private Animal animal;
        private int maxNumberPets = 100000;
        Random newNumber = new Random();
    

        public AdministrationForm()
        {
            InitializeComponent();
            animalTypeComboBox.SelectedIndex = 0;
            admin = new Administration();
            AnimalDump();
            SecondAnimalDump();
            UpdateListBox();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog folder = new SaveFileDialog();
            DialogResult resultfolder = folder.ShowDialog();

            try
            {
                if (resultfolder == DialogResult.OK)
                {
                    string foldername = folder.FileName;
                    if (foldername.Substring(foldername.Length - 4) != ".txt")
                    {
                        foldername = String.Concat(foldername, ".txt");
                    }
                    admin.Save(foldername);
                    MessageBox.Show(String.Format("File saved as {0}", foldername), "Succes!");
                }
                else if (resultfolder == DialogResult.Cancel) return;
            }
            catch (SerializationException ex)
            {
                MessageBox.Show($"Could not Serialize: {ex.Message}");
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show($"Directory not found: {ex.Message}");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"IO Exception: {ex.Message}");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"This is not a good location to save:{ex.Message}");
            }
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog folder = new OpenFileDialog();
            DialogResult resultfolder = folder.ShowDialog();


            try
            {
                if (resultfolder == DialogResult.OK)
                {
                    string foldername = folder.FileName;
                    admin.Load(foldername);
                    MessageBox.Show(String.Format("Load of current file: {0}", foldername));
                }
                else if (resultfolder == DialogResult.Cancel) return;
            }
            catch (SerializationException ex)
            {
                MessageBox.Show($"Could not Serialize: {ex.Message}");
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show($"Directory not found: {ex.Message}");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"IO Exception: {ex.Message}");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"This is file was not found:{ex.Message}");
            }

            UpdateListBox();
        }

        private void ButtonExport_Click(object sender, EventArgs e)
        {

            SaveFileDialog folder = new SaveFileDialog();
            DialogResult resultfolder = folder.ShowDialog();
            folder.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            try
            {
                if (resultfolder == DialogResult.OK)
                {
                    string foldername = folder.FileName;
                    if (foldername.Substring(foldername.Length - 4) != ".txt")
                    {
                        foldername = String.Concat(foldername, ".txt");
                    }
                    admin.Export(foldername);
                    MessageBox.Show(String.Format("Exported file saved as {0}", foldername), "Succes!");
                }
                else if (resultfolder == DialogResult.Cancel) return;
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show($"Directory not found: {ex.Message}");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"IO Exception: {ex.Message}");
            }
            catch (SerializationException ex)
            {
                MessageBox.Show($"Serializing did not go succesfull:{ex.Message}");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"This is not a good location to export:{ex.Message}");
            }

        }


        private void UpdateListBox()
        {
            listBoxAnimalsNotReserved.Items.Clear();
            listBoxAnimalsReserved.Items.Clear();
            comboBoxFindAnimal.Items.Clear();
            foreach(Animal a in admin.AllAnimals)
            {
                if(a.IsReserved)
                {
                    listBoxAnimalsReserved.Items.Add(a);
                    comboBoxFindAnimal.Items.Add(a.ChipRegistrationNumber);
                }
                else
                {
                    listBoxAnimalsNotReserved.Items.Add(a);
                    comboBoxFindAnimal.Items.Add(a.ChipRegistrationNumber);
                }
            }
        }

        private void DeleteAnimal()
        {
            foreach(Animal a in admin.AllAnimals.ToList())
            {
                if (a.ChipRegistrationNumber == Convert.ToInt32(comboBoxFindAnimal.Text))
                {
                    admin.AllAnimals.Remove(a);
                }
            }
        }

        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            try
            {
                SimpleDate birthDate = new SimpleDate(birthdatePickerAnimal.Value.Day, birthdatePickerAnimal.Value.Month
                       , birthdatePickerAnimal.Value.Year);
                SimpleDate walkDate = new SimpleDate(lastWalkDate.Value.Day, lastWalkDate.Value.Month
                    , lastWalkDate.Value.Year);

                string selectedAnimal = animalTypeComboBox.SelectedItem.ToString();

                if (string.IsNullOrWhiteSpace(animalNameTextBox.Text) || string.IsNullOrEmpty(animalNameTextBox.Text))
                {
                    MessageBox.Show("Geef dit arme beestje een naam!");
                }

                if (!string.IsNullOrWhiteSpace(animalNameTextBox.Text))
                {
                    string name = animalNameTextBox.Text;
                    if (selectedAnimal == "Cat")
                    {
                        string problems = problemsCatTextBox.Text;
                        AddingCat(name, birthDate, problems);
                    }
                    if (selectedAnimal == "Dog")
                    {
                        AddingDog(name, birthDate, walkDate);
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"This item is not in the correct format:{ex.Message}");
            }
            catch(NoNullAllowedException ex)
            {
                MessageBox.Show($"This item cannot be null {ex.Message}");
            }
            UpdateListBox();
        }

        private void AddingCat(string name, SimpleDate date, string behaviour)
        {
            int nextnumber = newNumber.Next(maxNumberPets);
            string problems = "no";

            if (!string.IsNullOrWhiteSpace(behaviour))
            {
                problems = behaviour;
            }
            else
            {
                problems = null;
            }

            animal = new Cat(nextnumber, date, name, problems);
            while (!admin.Add(animal))
            {
                int anothernumber = newNumber.Next(maxNumberPets);
                animal = new Cat(anothernumber, date, name, problems);
            }
            admin.Add(animal);
        }

        private void AddingDog(string name, SimpleDate date, SimpleDate walk)
        {
            int nextnumber = newNumber.Next(maxNumberPets);
            SimpleDate walkDate = new SimpleDate(walk.Day, walk.Month, walk.Year);

            if (lastWalkDate.Value.Date == DateTime.Today)
            {
                DialogResult result = MessageBox.Show("Was the dog walked today?", "Walk the dog", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    walkDate = walk;
                }
                else if (result == DialogResult.No)
                {
                    walk = null;
                }
            }
            else
            {
                walkDate = walk;
            }

            animal = new Dog(nextnumber, date, name, walkDate);
            while (!admin.Add(animal))
            {
                int anothernumber = newNumber.Next(maxNumberPets);
                animal = new Dog(anothernumber, date, name, walkDate);
            }
            admin.Add(animal);
        }


        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (comboBoxFindAnimal.SelectedIndex != -1)
            {
                Animal currentanimal = admin.FindAnimal(Convert.ToInt32(comboBoxFindAnimal.Text));
                if (currentanimal != null)
                {
                    MessageBox.Show(currentanimal.ToString());
                }
                UpdateListBox();
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxFindAnimal.SelectedIndex != -1)
            {
                if (admin.RemoveAnimal(Convert.ToInt32(comboBoxFindAnimal.Text)))
                {
                    DeleteAnimal();
                    MessageBox.Show("Deleted!");
                }
                UpdateListBox();
            }       
        }
        private void buttonSell_Click(object sender, EventArgs e)
        {
            if(comboBoxFindAnimal.SelectedIndex != -1)
            {
                Animal currentAnimal = admin.FindAnimal(Convert.ToInt32(comboBoxFindAnimal.Text));
                MessageBox.Show("Animal sold for this amount: " + currentAnimal.Price, "Sale");
                DeleteAnimal();
                UpdateListBox();
            }
        }
        private void ButtonReserve_Click(object sender, EventArgs e)
        {
            Animal currentAnimal = listBoxAnimalsNotReserved.SelectedItem as Animal;
            if (currentAnimal != null)
            {
                currentAnimal.IsReserved = true;
                UpdateListBox();
            }
        }
        private void buttonUnReserve_Click(object sender, EventArgs e)
        {
            Animal currentAnimal = listBoxAnimalsReserved.SelectedItem as Animal;
            if (currentAnimal != null)
            {
                currentAnimal.IsReserved = false;
                UpdateListBox();
            }
        }
        private void buttonShowinfo_Click(object sender, EventArgs e)
        {
            Animal currentAnimal = listBoxAnimalsNotReserved.SelectedItem as Animal;
            if (currentAnimal != null)
            {
                MessageBox.Show(currentAnimal.ToString());
            }
        }


        private void animalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (animalTypeComboBox.Text == "Cat")
            {
                lblProblems.Visible = true;
                problemsCatTextBox.Visible = true;
                lblWalkDate.Visible = false;
                lastWalkDate.Visible = false;
            }
            if (animalTypeComboBox.Text == "Dog")
            {
                lblProblems.Visible = false;
                problemsCatTextBox.Visible = false;
                lblWalkDate.Visible = true;
                lastWalkDate.Visible = true;
            }
        }



        private void AnimalDump()
        {
            Animal one = new Cat(34509, new SimpleDate(1, 04, 2018), "Klaartje", "Bites");
            admin.Add(one);
            Animal two = new Cat(230, new SimpleDate(12, 8, 2014), "Puck", "Howls");
            admin.Add(two);
            Animal three = new Cat(1298, new SimpleDate(21, 11, 2016), "Bor", "");
            admin.Add(three);
            Animal four = new Dog(98, new SimpleDate(6, 5, 2013), "Kinga", new SimpleDate(1, 1, 1980));
            admin.Add(four);
            Animal five = new Dog(55412, new SimpleDate(17, 12, 2016), "Bijke", new SimpleDate(1, 1, 1980));
            admin.Add(five);
            one.IsReserved = true;
            two.IsReserved = false;
            three.IsReserved = true;
            four.IsReserved = true;
            five.IsReserved = false;
        }

        private void SecondAnimalDump()
        {
            Animal one = new Cat(45, new SimpleDate(1, 04, 2018), "Piet", "");
            admin.Add(one);
            Animal two = new Cat(2, new SimpleDate(12, 8, 2014), "Piet", "");
            admin.Add(two);
            Animal three = new Cat(1, new SimpleDate(21, 11, 2016), "Piet", "");
            admin.Add(three);
            Animal four = new Dog(5, new SimpleDate(6, 5, 2013), "Piet", new SimpleDate(1, 1, 1980));
            admin.Add(four);
            Animal five = new Dog(89, new SimpleDate(17, 12, 2016), "Piet", new SimpleDate(1, 1, 1980));
            admin.Add(five);
            one.IsReserved = true;
            two.IsReserved = false;
            three.IsReserved = true;
            four.IsReserved = true;
            five.IsReserved = false;
        }

        
    }
}
