using Microsoft.Data.SqlClient;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySqlConnector;

namespace MasterForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //SqlConnection conneciton = new SqlConnection("Data Source=DESKTOP-ULLM2GO\\SQLEXPRESS;Initial Catalog=DATA-BASE-NAME;User Id=YOUR-USER;password=YOUR-USER-PASSWORD");       
        SqlConnection conneciton = new SqlConnection("Data Source=END-POINT-OF-DATABSE-IN-CLOUD;Initial Catalog=DATA-BASE-NAME;User Id=YOUR-USER;password=YOUR-USER-PASSWORD;Trusted_Connection=False;Encrypt=False;MultipleActiveResultSets=true");

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
            SqlCommand command = new SqlCommand("SELECT * FROM MOVIES", conneciton);

            StringBuilder fileContant = new StringBuilder();
                                     
            fileContant.Append("ID");
            fileContant.Append("".PadLeft(15, ' '));
            fileContant.Append("NAME");
            fileContant.Append("".PadLeft(15, ' '));
            fileContant.Append("Directors");
            fileContant.Append("\n");

            try
            {
                conneciton.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    fileContant.Append(reader["ID"].ToString());
                    fileContant.Append("".PadLeft(15, ' '));
                    fileContant.Append(reader["Title"].ToString());
                    fileContant.Append("".PadLeft(15, ' '));
                    fileContant.Append(reader["Directors"].ToString());
                    fileContant.Append("\n");
                }                

                buildTxtFile(fileContant);
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.ToString());
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

            string pathFileAJ = @"C:\Users\YOUR-USER-NAME\source\repos\MasterForm\New-Files\MOVIES" + time;

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

        private void readFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = openFileDialog1.FileName;

                string fPath = openFileDialog1.FileName;

                FileInfo fi = new FileInfo(fPath);

                string nameFile = fi.Name;

                string fnameFile = getFileName(nameFile);

                string idFile = "132568";

                if (fnameFile == idFile)
                {
                    string fileContent = File.ReadAllText(fPath, Encoding.UTF8);

                    MessageBox.Show(fileContent);
                }
                else
                {
                    MessageBox.Show("File code is unknown");
                }
            }
        }

        private string getFileName(string x)
        {
            string check = x.Replace("txt", "").Replace(".", "");
            return check;
        }
    }
}
