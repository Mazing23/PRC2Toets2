namespace PRC2Toets2
{
    partial class AdministrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonUnReserve = new System.Windows.Forms.Button();
            this.Reserved = new System.Windows.Forms.Label();
            this.listBoxAnimalsReserved = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxAnimalsNotReserved = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.comboBoxFindAnimal = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lastWalkDate = new System.Windows.Forms.DateTimePicker();
            this.lblWalkDate = new System.Windows.Forms.Label();
            this.lblProblems = new System.Windows.Forms.Label();
            this.problemsCatTextBox = new System.Windows.Forms.TextBox();
            this.birthdatePickerAnimal = new System.Windows.Forms.DateTimePicker();
            this.animalNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.animalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.buttonShowinfo = new System.Windows.Forms.Button();
            this.ButtonReserve = new System.Windows.Forms.Button();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonExport = new System.Windows.Forms.Button();
            this.browseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSell
            // 
            this.buttonSell.Location = new System.Drawing.Point(415, 444);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(93, 28);
            this.buttonSell.TabIndex = 46;
            this.buttonSell.Text = "Sell";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // buttonUnReserve
            // 
            this.buttonUnReserve.Location = new System.Drawing.Point(961, 380);
            this.buttonUnReserve.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUnReserve.Name = "buttonUnReserve";
            this.buttonUnReserve.Size = new System.Drawing.Size(102, 31);
            this.buttonUnReserve.TabIndex = 45;
            this.buttonUnReserve.Text = "Unreserve";
            this.buttonUnReserve.UseVisualStyleBackColor = true;
            this.buttonUnReserve.Click += new System.EventHandler(this.buttonUnReserve_Click);
            // 
            // Reserved
            // 
            this.Reserved.AutoSize = true;
            this.Reserved.Location = new System.Drawing.Point(702, 26);
            this.Reserved.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Reserved.Name = "Reserved";
            this.Reserved.Size = new System.Drawing.Size(73, 17);
            this.Reserved.TabIndex = 43;
            this.Reserved.Text = "Reserved:";
            // 
            // listBoxAnimalsReserved
            // 
            this.listBoxAnimalsReserved.FormattingEnabled = true;
            this.listBoxAnimalsReserved.ItemHeight = 16;
            this.listBoxAnimalsReserved.Location = new System.Drawing.Point(699, 52);
            this.listBoxAnimalsReserved.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAnimalsReserved.Name = "listBoxAnimalsReserved";
            this.listBoxAnimalsReserved.Size = new System.Drawing.Size(364, 324);
            this.listBoxAnimalsReserved.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Not reserved:";
            // 
            // listBoxAnimalsNotReserved
            // 
            this.listBoxAnimalsNotReserved.FormattingEnabled = true;
            this.listBoxAnimalsNotReserved.ItemHeight = 16;
            this.listBoxAnimalsNotReserved.Location = new System.Drawing.Point(320, 52);
            this.listBoxAnimalsNotReserved.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAnimalsNotReserved.Name = "listBoxAnimalsNotReserved";
            this.listBoxAnimalsNotReserved.Size = new System.Drawing.Size(364, 324);
            this.listBoxAnimalsNotReserved.TabIndex = 40;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(311, 444);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(85, 28);
            this.buttonDelete.TabIndex = 39;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(209, 444);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(85, 28);
            this.buttonFind.TabIndex = 38;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // comboBoxFindAnimal
            // 
            this.comboBoxFindAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFindAnimal.FormattingEnabled = true;
            this.comboBoxFindAnimal.Location = new System.Drawing.Point(26, 448);
            this.comboBoxFindAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFindAnimal.Name = "comboBoxFindAnimal";
            this.comboBoxFindAnimal.Size = new System.Drawing.Size(160, 24);
            this.comboBoxFindAnimal.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lastWalkDate);
            this.groupBox1.Controls.Add(this.lblWalkDate);
            this.groupBox1.Controls.Add(this.lblProblems);
            this.groupBox1.Controls.Add(this.problemsCatTextBox);
            this.groupBox1.Controls.Add(this.birthdatePickerAnimal);
            this.groupBox1.Controls.Add(this.animalNameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.animalTypeComboBox);
            this.groupBox1.Controls.Add(this.createAnimalButton);
            this.groupBox1.Location = new System.Drawing.Point(19, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 287);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Animal";
            // 
            // lastWalkDate
            // 
            this.lastWalkDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lastWalkDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lastWalkDate.Location = new System.Drawing.Point(90, 206);
            this.lastWalkDate.Name = "lastWalkDate";
            this.lastWalkDate.RightToLeftLayout = true;
            this.lastWalkDate.Size = new System.Drawing.Size(160, 22);
            this.lastWalkDate.TabIndex = 11;
            // 
            // lblWalkDate
            // 
            this.lblWalkDate.AutoSize = true;
            this.lblWalkDate.Location = new System.Drawing.Point(14, 206);
            this.lblWalkDate.Name = "lblWalkDate";
            this.lblWalkDate.Size = new System.Drawing.Size(70, 17);
            this.lblWalkDate.TabIndex = 10;
            this.lblWalkDate.Text = "Last Walk";
            // 
            // lblProblems
            // 
            this.lblProblems.AutoSize = true;
            this.lblProblems.Location = new System.Drawing.Point(19, 204);
            this.lblProblems.Name = "lblProblems";
            this.lblProblems.Size = new System.Drawing.Size(67, 17);
            this.lblProblems.TabIndex = 9;
            this.lblProblems.Text = "Problems";
            // 
            // problemsCatTextBox
            // 
            this.problemsCatTextBox.Location = new System.Drawing.Point(92, 206);
            this.problemsCatTextBox.Name = "problemsCatTextBox";
            this.problemsCatTextBox.Size = new System.Drawing.Size(160, 22);
            this.problemsCatTextBox.TabIndex = 8;
            // 
            // birthdatePickerAnimal
            // 
            this.birthdatePickerAnimal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.birthdatePickerAnimal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdatePickerAnimal.Location = new System.Drawing.Point(91, 148);
            this.birthdatePickerAnimal.Name = "birthdatePickerAnimal";
            this.birthdatePickerAnimal.RightToLeftLayout = true;
            this.birthdatePickerAnimal.Size = new System.Drawing.Size(160, 22);
            this.birthdatePickerAnimal.TabIndex = 5;
            // 
            // animalNameTextBox
            // 
            this.animalNameTextBox.Location = new System.Drawing.Point(91, 99);
            this.animalNameTextBox.Name = "animalNameTextBox";
            this.animalNameTextBox.Size = new System.Drawing.Size(160, 22);
            this.animalNameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Birthdate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type";
            // 
            // animalTypeComboBox
            // 
            this.animalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalTypeComboBox.FormattingEnabled = true;
            this.animalTypeComboBox.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.animalTypeComboBox.Location = new System.Drawing.Point(91, 51);
            this.animalTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.animalTypeComboBox.Name = "animalTypeComboBox";
            this.animalTypeComboBox.Size = new System.Drawing.Size(160, 24);
            this.animalTypeComboBox.TabIndex = 0;
            this.animalTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.animalTypeComboBox_SelectedIndexChanged);
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(166, 244);
            this.createAnimalButton.Margin = new System.Windows.Forms.Padding(4);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(85, 27);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // buttonShowinfo
            // 
            this.buttonShowinfo.Location = new System.Drawing.Point(229, 348);
            this.buttonShowinfo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowinfo.Name = "buttonShowinfo";
            this.buttonShowinfo.Size = new System.Drawing.Size(85, 28);
            this.buttonShowinfo.TabIndex = 48;
            this.buttonShowinfo.Text = "Show info";
            this.buttonShowinfo.UseVisualStyleBackColor = true;
            this.buttonShowinfo.Click += new System.EventHandler(this.buttonShowinfo_Click);
            // 
            // ButtonReserve
            // 
            this.ButtonReserve.Location = new System.Drawing.Point(582, 380);
            this.ButtonReserve.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonReserve.Name = "ButtonReserve";
            this.ButtonReserve.Size = new System.Drawing.Size(102, 31);
            this.ButtonReserve.TabIndex = 44;
            this.ButtonReserve.Text = "Reserve";
            this.ButtonReserve.UseVisualStyleBackColor = true;
            this.ButtonReserve.Click += new System.EventHandler(this.ButtonReserve_Click);
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Location = new System.Drawing.Point(961, 457);
            this.ButtonLoad.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(102, 31);
            this.ButtonLoad.TabIndex = 49;
            this.ButtonLoad.Text = "Load";
            this.ButtonLoad.UseVisualStyleBackColor = true;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(846, 457);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(102, 31);
            this.ButtonSave.TabIndex = 50;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonExport
            // 
            this.ButtonExport.Location = new System.Drawing.Point(663, 457);
            this.ButtonExport.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonExport.Name = "ButtonExport";
            this.ButtonExport.Size = new System.Drawing.Size(102, 31);
            this.ButtonExport.TabIndex = 51;
            this.ButtonExport.Text = "Export";
            this.ButtonExport.UseVisualStyleBackColor = true;
            this.ButtonExport.Click += new System.EventHandler(this.ButtonExport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 499);
            this.Controls.Add(this.ButtonExport);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.buttonShowinfo);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.buttonUnReserve);
            this.Controls.Add(this.ButtonReserve);
            this.Controls.Add(this.Reserved);
            this.Controls.Add(this.listBoxAnimalsReserved);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxAnimalsNotReserved);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.comboBoxFindAnimal);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdministrationForm";
            this.Text = "Animal Shelter Administration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button buttonUnReserve;
        private System.Windows.Forms.Label Reserved;
        private System.Windows.Forms.ListBox listBoxAnimalsReserved;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxAnimalsNotReserved;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.ComboBox comboBoxFindAnimal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker lastWalkDate;
        private System.Windows.Forms.Label lblWalkDate;
        private System.Windows.Forms.Label lblProblems;
        private System.Windows.Forms.TextBox problemsCatTextBox;
        private System.Windows.Forms.DateTimePicker birthdatePickerAnimal;
        private System.Windows.Forms.TextBox animalNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox animalTypeComboBox;
        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.Button buttonShowinfo;
        private System.Windows.Forms.Button ButtonReserve;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonExport;
        private System.Windows.Forms.FolderBrowserDialog browseFolder;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

