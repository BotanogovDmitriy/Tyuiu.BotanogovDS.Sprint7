using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.BotanogovDS.Sprint7.V8.Lib;

namespace Tyuiu.BotanogovDS.Sprint7.V8
{
    public partial class FormStatsAndAdd : Form
    {
        DataService ds = new DataService();
        public static string path = @"D:\source\repos\Tyuiu.BotanogovDS.Sprint7\Karshering.csv";
        public FormStatsAndAdd()
        {
            InitializeComponent();
            dataGridViewData_BDS.RowCount = 100;
            dataGridViewData_BDS.ColumnCount = 100;
            for (int i = 0; i < 100; i++)
            {
                dataGridViewData_BDS.Columns[i].Width = 130;
            }
            dataGridViewData_BDS.Columns[2].Width = 180;
            string[,] DataMatrix = ds.GetMatrix(path); // данные из excel

            int rows = DataMatrix.GetLength(0);
            int columns = DataMatrix.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewData_BDS.Rows[r].Cells[c].Value = DataMatrix[r, c];
                }
            }
        }

        private void buttonViewChart_BDS_Click(object sender, EventArgs e)
        {
            chartInfo_BDS.Series[0].Points.Clear();

            this.chartInfo_BDS.ChartAreas[0].AxisX.Title = "Марка";
            this.chartInfo_BDS.ChartAreas[0].AxisY.Title = "Количество автомобилей";

            string[,] DataTable = ds.GetMatrix(path);

            string[] ArrayWords = ds.ArrayStrWordsElements(DataTable, 4);

            int[] ArraySumWords = ds.ArraySumWords(DataTable, ArrayWords, 4);

            for (int i = 0; i < ArrayWords.Length; i++)
            {
                chartInfo_BDS.Series[0].Points.AddXY(ArrayWords[i], ArraySumWords[i]);
            }
        }

        private void buttonViewStats_BDS_Click(object sender, EventArgs e)
        {
            string[,] DataTable = ds.GetMatrix(path);
            double AverageFuel = ds.Average(DataTable,5);
            double AverageKilometers = ds.Average(DataTable, 6);
            double AverageExperience = ds.Average(DataTable, 2);

            textBoxAverageExperience_BDS.Text = Convert.ToString(AverageExperience);
            textBoxAverageFuel_BDS.Text = Convert.ToString(AverageFuel);
            textBoxAverageKilometers_BDS.Text = Convert.ToString(AverageKilometers);


        }

        private void buttonRegRent_BDS_Click(object sender, EventArgs e)
        {
            if ((textBoxAddExperience_BDS.Text == "")||(textBoxAddFIO_BDS.Text == "")||(textBoxAddFuel_BDS.Text == "")||(textBoxAddKilometers_BDS.Text == "")||(textBoxAddMark_BDS.Text == "")||(textBoxAddSeries_BDS.Text==""))
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string str = "";

                bool SeriesExist = ds.Exist(path, textBoxAddSeries_BDS.Text, 3);

                if (SeriesExist)
                    MessageBox.Show("Данный регистрационный номер автомобиля уже есть в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string[,] DataMatrix = ds.GetMatrix(path);
                    string ID = Convert.ToString(DataMatrix.GetLength(0));

                    str = $"{ID};{textBoxAddFIO_BDS.Text};{textBoxAddExperience_BDS.Text};{textBoxAddSeries_BDS.Text};{textBoxAddMark_BDS.Text};{textBoxAddFuel_BDS.Text};{textBoxAddKilometers_BDS.Text}"; 
                    File.AppendAllText(path, str + "\n");

                    DataMatrix = ds.GetMatrix(path);

                    int rows = DataMatrix.GetLength(0);
                    int columns = DataMatrix.GetLength(1);

                    for (int r = 0; r <= rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewData_BDS.Rows[r].Cells[c].Value = "";
                        }
                    }

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewData_BDS.Rows[r].Cells[c].Value = DataMatrix[r, c];
                        }
                    }
                    textBoxAddExperience_BDS.Text = "";
                    textBoxAddFIO_BDS.Text = "";
                    textBoxAddFuel_BDS.Text = "";
                    textBoxAddKilometers_BDS.Text = "";
                    textBoxAddMark_BDS.Text = "";
                    textBoxAddSeries_BDS.Text = "";

                    MessageBox.Show("Новый арендатор зарегистрирован!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonDeleteRent_BDS_Click(object sender, EventArgs e)
        {
            if (textBoxDeleteRent_BDS.Text == "")
            {
                MessageBox.Show("Поле не заполнено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool FIOExist = ds.Exist(path, textBoxDeleteRent_BDS.Text, 1);

                if (FIOExist == false)
                    MessageBox.Show("Такого арендатора нет в базе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    /*string[] strRows = File.ReadAllLines(path);

                    for (int i = 0; i < strRows.Length; i++)
                    {
                        string[] strIndex = strRows[i].Split(';');
                        if (strIndex[1] == textBoxDeleteRent_BDS.Text)
                            strRows[i] = "";
                    }
                    strRows = strRows.Where(i => i != "").ToArray();

                    for (int i = 1; i < strRows.Length; i++)
                    {
                        strRows[i].Split(';')[0] = Convert.ToString(i);
                    }*/
                    string[,] DataTable = ds.GetMatrix(path);

                    for (int i = 0; i < DataTable.GetLength(0); i++)
                    {
                        if (DataTable[i,1] == textBoxDeleteRent_BDS.Text)
                            for (int j = 0; j < DataTable.GetLength(1); j++)
                            {
                                DataTable[i, j] = "";
                            }
                    }
                    bool b = false;
                    string[,] NewDataTable = new string[DataTable.GetLength(0) - 1, DataTable.GetLength(1)];
                    for (int i = 0; i < NewDataTable.GetLength(0); i++)
                    {
                        for (int j = 0; j < NewDataTable.GetLength(1); j++)
                        {
                            if (DataTable[i, j] == "")
                            {
                                b = true;
                                NewDataTable[i, j] = DataTable[i + 1, j];
                            }
                            if (b)
                                NewDataTable[i, j] = DataTable[i + 1, j];
                            else
                                NewDataTable[i, j] = DataTable[i, j];
                        }
                    }
                    for (int i = 1; i < NewDataTable.GetLength(0); i++)
                    {
                        NewDataTable[i, 0] = Convert.ToString(i);
                    }
                    string[] strRows = new string[NewDataTable.GetLength(0)];
                    for (int i = 0; i < strRows.Length; i++)
                    {
                        for (int j = 0; j < NewDataTable.GetLength(1); j++)
                        {
                            if (j == NewDataTable.GetLength(1)-1)
                                strRows[i] += NewDataTable[i, j];
                            else
                                strRows[i] += NewDataTable[i, j] + ";";

                        }
                    }


                    File.Delete("Каршеринг.csv");

                    saveFileDialogData_BDS.FileName = "Каршеринг.csv";
                    saveFileDialogData_BDS.ShowDialog();

                    path = saveFileDialogData_BDS.FileName;

                    File.WriteAllLines(path, strRows, Encoding.UTF8);

                    string[,] DataMatrix = ds.GetMatrix(path);

                    int rows = DataMatrix.GetLength(0);
                    int columns = DataMatrix.GetLength(1);

                    for (int r = 0; r <= rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewData_BDS.Rows[r].Cells[c].Value = "";
                        }
                    }

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewData_BDS.Rows[r].Cells[c].Value = DataMatrix[r, c];
                        }
                    }
                    MessageBox.Show("Арендатор удален из базы", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            textBoxDeleteRent_BDS.Text = "";
        }
    }
}
