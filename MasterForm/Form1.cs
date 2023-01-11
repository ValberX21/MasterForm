using System;
using System.IO;
using System.Windows.Forms;

namespace MasterForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createFileText_Click(object sender, EventArgs e)
        {
            string path = @"C:\_developer\playground_C#\MasterForm\New-Files";
            string text = "Lord of the rings" + "\n" + "Hobbit" + "\n" + "Star wars";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!File.Exists(path))
            {
                //Create a file and write
                using (StreamWriter sw = File.CreateText(path + "\\file.txt"))
                {
                    sw.WriteLine(text);
                }
                MessageBox.Show("File created !!!");
            }
        }

        private void importMovies_Click(object sender, EventArgs e)
        {

        }
    }
}
