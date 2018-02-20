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

namespace FileChecker
{
    public partial class FileChecker : Form
    {
        public FileChecker()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolTipForLanguagesField_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {

                // Смотрим в поле с именами файлов и ищем по порядку 
                string[] fileNames = fileNamesField.Text.Split(','); // из поля с именами файлов через запятую достали массив строк.
                string[] languageIDs = languagesField.Text.Split(','); //Аналогично для ID языков
                List<string> results = new List<string>(); //объявим тут авторазмерный массив для результатов.

                //сформируем ожидаемый массив строк
                List<string> expectedResults = new List<string>();

                resultsField.Text = "";

                for (int i = 0; i < fileNames.Length; i++) //делаем цикл по именам файлов
                {
                    string[] foundFileNames = Directory.GetFiles(pathToFolderField.Text, fileNames[i] + "*.dll"); //команда ищет в заданной папке по заданной маске и возвращает массив путей до файлов.
                    if (foundFileNames.Length != 0)
                    {

                        //Теперь берем этот массив и по нему идем, проверяем, что все коды языков присутствуют. 
                        for (int j = 0; j < foundFileNames.Length; j++)
                        {
                            for (int k = 0; k < languageIDs.Length; k++) //и надо пройти по каждому ID языка
                            {
                                //Console.WriteLine("i = " + i + "   j = " + j + "   k = " + k);
                                //Console.WriteLine(foundFileNames[j]);
                                int maskPosition = pathToFolderField.Text.Length + fileNames[i].Length + 1; //начало маски
                                int tmp = foundFileNames[j].IndexOf(".dll");
                                int maskLenght = tmp - maskPosition; //длина
                                if (foundFileNames[j].Substring(maskPosition, maskLenght) == languageIDs[k]) //вырезаем строку, которая была в маске под звездочкой.
                                {
                                    results.Add(foundFileNames[j]); //если ID равны, до добавляем запись в результирующий список.
                                }
                            }
                        }
                    }

                }

                //Формируем полный ожидаемый список
                for (int i = 0; i < fileNames.Length; i++)
                {
                    for (int j = 0; j < languageIDs.Length; j++)
                    {
                        string expectedFile = pathToFolderField.Text + "\\" + fileNames[i] + languageIDs[j] + ".dll";
                        expectedResults.Add(expectedFile);
                        if (results.Contains(expectedFile) != true)
                        {
                            resultsField.Text = resultsField.Text + expectedFile + "\n";
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The process failed!");
            }
            }
        }
    }
