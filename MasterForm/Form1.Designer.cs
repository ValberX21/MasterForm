
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
            this.SuspendLayout();
            // 
            // createFileText
            // 
            this.createFileText.Location = new System.Drawing.Point(67, 75);
            this.createFileText.Name = "createFileText";
            this.createFileText.Size = new System.Drawing.Size(126, 29);
            this.createFileText.TabIndex = 0;
            this.createFileText.Text = "Create text file";
            this.createFileText.UseVisualStyleBackColor = true;
            this.createFileText.Click += new System.EventHandler(this.createFileText_Click);
            // 
            // importMovies
            // 
            this.importMovies.Location = new System.Drawing.Point(67, 129);
            this.importMovies.Name = "importMovies";
            this.importMovies.Size = new System.Drawing.Size(126, 29);
            this.importMovies.TabIndex = 1;
            this.importMovies.Text = "Import file";
            this.importMovies.UseVisualStyleBackColor = true;
            this.importMovies.Click += new System.EventHandler(this.importMovies_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.importMovies);
            this.Controls.Add(this.createFileText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button createFileText;
        private System.Windows.Forms.Button importMovies;
    }
}

