
namespace MasterForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.createFileText = new System.Windows.Forms.Button();
            this.importMovies = new System.Windows.Forms.Button();
            this.readFile = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // createFileText
            // 
            this.createFileText.Location = new System.Drawing.Point(59, 56);
            this.createFileText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createFileText.Name = "createFileText";
            this.createFileText.Size = new System.Drawing.Size(110, 22);
            this.createFileText.TabIndex = 0;
            this.createFileText.Text = "Create text file";
            this.createFileText.UseVisualStyleBackColor = true;
            this.createFileText.Click += new System.EventHandler(this.createFileText_Click);
            // 
            // importMovies
            // 
            this.importMovies.Location = new System.Drawing.Point(59, 97);
            this.importMovies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.importMovies.Name = "importMovies";
            this.importMovies.Size = new System.Drawing.Size(110, 22);
            this.importMovies.TabIndex = 1;
            this.importMovies.Text = "Import file";
            this.importMovies.UseVisualStyleBackColor = true;
            this.importMovies.Click += new System.EventHandler(this.importMovies_Click);
            // 
            // readFile
            // 
            this.readFile.Location = new System.Drawing.Point(59, 134);
            this.readFile.Name = "readFile";
            this.readFile.Size = new System.Drawing.Size(110, 23);
            this.readFile.TabIndex = 2;
            this.readFile.Text = "Read file";
            this.readFile.UseVisualStyleBackColor = true;
            this.readFile.Click += new System.EventHandler(this.readFile_Click);
            // 
            // filePath
            // 
            this.filePath.Enabled = false;
            this.filePath.Location = new System.Drawing.Point(192, 134);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(293, 23);
            this.filePath.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.readFile);
            this.Controls.Add(this.importMovies);
            this.Controls.Add(this.createFileText);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button createFileText;
        private System.Windows.Forms.Button importMovies;
        private System.Windows.Forms.Button readFile;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

