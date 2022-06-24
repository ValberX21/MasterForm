using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char aj1;
        SqlConnection conneciton = new SqlConnection("Data Source=DESKTOP-ULLM2GO\\SQLEXPRESS;Initial Catalog=COMPANIES;User Id=issac;password=Wolverine9");


        // _____________________ CLICK TO GENERATE A FILE .txt IN A PATH ________________________

        private void createTxtandPath_Click(object sender, EventArgs e)
        {
            string path = @"C:\playground_C#\MasterForm\HereisFileTxt\file.txt";
            string text = "Lord of the rings" + "\n" + "Hobbit" + "\n" + "Star wards";

            if (!File.Exists(path))
            {
                //Create a file and write
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(text);
                }
                MessageBox.Show("File created !!!");
            }
        }

        // _____________________ CLICK TO GENERATA A txt FILE WITH SQL SERVER ________________

        private void txtWithSql_Click(object sender, EventArgs e)
        {           
            SqlCommand command = new SqlCommand("SELECT Id_Empresa, NomeFantasia, CNPJ FROM Empresas", conneciton);

            StringBuilder fileContant = new StringBuilder();

            fileContant.Append("Nome fantasia");
            fileContant.Append("".PadLeft(15, ' '));
            fileContant.Append("CNPJ");
            fileContant.Append("\n");

            try
            {
                conneciton.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    fileContant.Append(reader["NomeFantasia"].ToString());
                    //fileContant.Append(" - ");
                    fileContant.Append("".PadLeft(15,' '));
                    fileContant.Append(reader["CNPJ"].ToString());
                    fileContant.Append("\n");
                }

                buildTxtFile(fileContant);
            }
            catch(SqlException eX)
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

            string pathFileAJ = @"C:\playground_C#\MasterForm\ListaEmpresas\" + time;

            string pathFile = pathFileAJ.Replace("/", "");

            if (!Directory.Exists(pathFile))
            {
                Directory.CreateDirectory(pathFile);
            }

            if (!File.Exists(pathFile))
            {
                string addFormaFile = time + ".txt";
                string nameFile = addFormaFile.Replace("/", "").Replace(":", "").Replace(" ","");

                // Writing in the file

                using (StreamWriter sw = File.CreateText(pathFile + "\\" + nameFile))
                {
                    sw.WriteLine(fileContant);
                }
                MessageBox.Show("File created successfully");
            }
        }

        //SAVE SOME DATAS IN SQL
        private void savesql_Click(object sender, EventArgs e)
        {
            string nomeFantasia = txtNomeFant.Text.ToString();
            string razaoSocial = txtRazaoSocial.Text.ToString();
            string CNPJaj = txtCNPJ.Text.ToString();

            string CNPJ = formatCNPJ(CNPJaj);

            if (nomeFantasia == "" || razaoSocial == "" || CNPJ == "")
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                String queryInsert = "INSERT INTO Empresas (NomeFantasia, RazaoSocial , CNPJ, Email) " +
                                     " values             (@NomeFantasia, @RazaoSocial, @CNPJ, @Email)";
                try
                {
                    conneciton.Open();
                    SqlCommand command = new SqlCommand(queryInsert, conneciton);
                    command.Parameters.Add("@NomeFantasia", nomeFantasia);
                    command.Parameters.Add("@RazaoSocial", razaoSocial);
                    command.Parameters.Add("@CNPJ", CNPJ);
                    command.Parameters.Add("@Email", "emailtest@hotmail.com");

                    command.ExecuteNonQuery();

                    MessageBox.Show("Data saved with successufully");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conneciton.Close();
                }
            }
        }

        private string formatCNPJ(string cnpjaj)
        {
            var builder = new StringBuilder();
            int count = 0;
            foreach (var c in cnpjaj)
            {
                count++;
                builder.Append(c);

                Console.WriteLine(cnpjaj.IndexOf(c));
                if (count == 2)
                {
                    builder.Append('.');
                }
                else if (count == 5)
                {
                    builder.Append('.');
                }
                else if (count == 8)
                {
                    builder.Append('/');
                }
                else if (count == 12)
                {
                    builder.Append('-');
                }
            }
            return builder.ToString();
        }
    }
}
