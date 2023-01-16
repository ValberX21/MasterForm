using Microsoft.Data.SqlClient;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MasterForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conneciton = new SqlConnection("Data Source=DESKTOP-ULLM2GO\\SQLEXPRESS;Initial Catalog=COMPANIES;User Id=issac;password=Wolverine12");


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
            SqlCommand command = new SqlCommand("SELECT Id, Titles, Author FROM MANGAS", conneciton);

            StringBuilder fileContant = new StringBuilder();

            fileContant.Append("Id");
            fileContant.Append("".PadLeft(15, ' '));
            fileContant.Append("Titles");
            fileContant.Append("".PadLeft(15, ' '));
            fileContant.Append("Author");
            fileContant.Append("\n");

            try
            {
                conneciton.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    fileContant.Append(reader["Id"].ToString());
                    fileContant.Append("".PadLeft(15, ' '));
                    fileContant.Append(reader["Titles"].ToString());
                    fileContant.Append("".PadLeft(15, ' '));
                    fileContant.Append(reader["Author"].ToString());
                    fileContant.Append("\n");
                }

                buildTxtFile(fileContant);
            }
            catch (SqlException eX)
            {
                MessageBox.Show(eX.ToString());
            }
            finally
            {
                conneciton.Close();
            }
        }

        private void buildTxtFile(StringBuilder fileContant)
        {
            string timeAJ = DateTime.Now.ToString();
            string time = timeAJ.Replace(":", "").Replace("/", "").Replace(" ", "");

            string pathFileAJ = @"C:\_developer\playground_C#\MasterForm\New-Files" + time;

            string pathFile = pathFileAJ.Replace("/", "");

            if (!Directory.Exists(pathFile))
            {
                Directory.CreateDirectory(pathFile);
            }

            if (!File.Exists(pathFile))
            {
                string addFormaFile = time + ".txt";
                string nameFile = addFormaFile.Replace("/", "").Replace(":", "").Replace(" ", "");

                // Writing in the file

                using (StreamWriter sw = File.CreateText(pathFile + "\\" + nameFile))
                {
                    sw.WriteLine(fileContant);
                }
                MessageBox.Show("File created successfully");
            }
        }
    }
}
