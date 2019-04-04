using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRC2Toets2
{
    public partial class AdministrationForm : Form
    {
        private Administration admin;
        private Animal animal;
        private List<Animal> nonReserved;
        private List<Animal> reserved;
        private int maxNumberPets = 100000;
        Random newNumber = new Random();
    

        public AdministrationForm()
        {
            InitializeComponent();
            animalTypeComboBox.SelectedIndex = 0;

            admin = new Administration();
            nonReserved = new List<Animal>();
            reserved = new List<Animal>();

            AnimalDump();
            UpdateListBox();
        }
        

        
        private void UpdateListBox()
        {
            listBoxAnimalsNotReserved.Items.Clear();
            listBoxAnimalsReserved.Items.Clear();
            comboBoxFindAnimal.Items.Clear();
            nonReserved.Sort();
            reserved.Sort();
            foreach(Animal a in nonReserved)
            {
                listBoxAnimalsNotReserved.Items.Add(a);
                comboBoxFindAnimal.Items.Add(a.ChipRegistrationNumber);
            }
            foreach(Animal a in reserved)
            {
                listBoxAnimalsReserved.Items.Add(a);
                comboBoxFindAnimal.Items.Add(a.ChipRegistrationNumber);
            }
        }
        private void DeleteAnimal()
        {
            foreach (Animal a in reserved.ToList())
            {
                if (a.ChipRegistrationNumber == Convert.ToInt32(comboBoxFindAnimal.Text))
                {
                    reserved.Remove(a);
                }
            }
            foreach (Animal a in nonReserved.ToList())
            {
                if (a.ChipRegistrationNumber == Convert.ToInt32(comboBoxFindAnimal.Text))
                {
                    nonReserved.Remove(a);
                }
            }
        }



        private void createAnimalButton_Click(object sender, EventArgs e)
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
            nonReserved.Add(animal);
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
            nonReserved.Add(animal);
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
                MessageBox.Show("Animal sold for this amount: " + currentAnimal.GetPrice(), "Sale");
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
                nonReserved.Remove(currentAnimal);
                reserved.Add(currentAnimal);
                UpdateListBox();
            }
        }
        private void buttonUnReserve_Click(object sender, EventArgs e)
        {
            Animal currentAnimal = listBoxAnimalsReserved.SelectedItem as Animal;
            if (currentAnimal != null)
            {
                currentAnimal.IsReserved = false;
                nonReserved.Add(currentAnimal);
                reserved.Remove(currentAnimal);
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
            Animal one = new Cat(34509, new SimpleDate(1, 04, 2018), "Klaartje", "");
            admin.Add(one);
            Animal two = new Cat(230, new SimpleDate(12, 8, 2014), "Puck", "");
            admin.Add(two);
            Animal three = new Cat(1298, new SimpleDate(21, 11, 2016), "Bor", "");
            admin.Add(three);
            Animal four = new Dog(98, new SimpleDate(6, 5, 2013), "Kinga", new SimpleDate(1, 1, 1980));
            admin.Add(four);
            Animal five = new Dog(55412, new SimpleDate(17, 12, 2016), "Bijke", new SimpleDate(1, 1, 1980));
            admin.Add(five);
            nonReserved.Add(one);
            nonReserved.Add(two);
            nonReserved.Add(three);
            nonReserved.Add(four);
            nonReserved.Add(five);
        }
       
    }
}
