namespace AnimalFileImporter
{
    partial class AnimalFileImporter_Form
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
            this.buttonImport = new System.Windows.Forms.Button();
            this.lbDogs = new System.Windows.Forms.ListBox();
            this.lbCats = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Files = new System.Windows.Forms.OpenFileDialog();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(556, 375);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(260, 56);
            this.buttonImport.TabIndex = 0;
            this.buttonImport.Text = "Import Files";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // lbDogs
            // 
            this.lbDogs.FormattingEnabled = true;
            this.lbDogs.ItemHeight = 16;
            this.lbDogs.Location = new System.Drawing.Point(12, 43);
            this.lbDogs.Name = "lbDogs";
            this.lbDogs.Size = new System.Drawing.Size(266, 388);
            this.lbDogs.TabIndex = 1;
            // 
            // lbCats
            // 
            this.lbCats.FormattingEnabled = true;
            this.lbCats.ItemHeight = 16;
            this.lbCats.Location = new System.Drawing.Point(284, 43);
            this.lbCats.Name = "lbCats";
            this.lbCats.Size = new System.Drawing.Size(266, 388);
            this.lbCats.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dogs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cats:";
            // 
            // Files
            // 
            this.Files.DefaultExt = "txt";
            this.Files.FileName = "openFileDialog1";
            this.Files.RestoreDirectory = true;
            this.Files.Title = "File Searching";
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(582, 43);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(234, 22);
            this.txtFilename.TabIndex = 5;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(582, 80);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(234, 36);
            this.buttonFind.TabIndex = 6;
            this.buttonFind.Text = "Find File";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // AnimalFileImporter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 447);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCats);
            this.Controls.Add(this.lbDogs);
            this.Controls.Add(this.buttonImport);
            this.Name = "AnimalFileImporter_Form";
            this.Text = "File Importer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.ListBox lbDogs;
        private System.Windows.Forms.ListBox lbCats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog Files;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Button buttonFind;
    }
}

