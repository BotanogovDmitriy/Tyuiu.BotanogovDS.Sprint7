using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BotanogovDS.Sprint7.V8.Lib;

namespace Tyuiu.BotanogovDS.Sprint7.V8
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public static string path = @"D:\source\repos\Tyuiu.BotanogovDS.Sprint7\Karshering.csv";
        public FormMain()
        {
            InitializeComponent();
            dataGridViewData_BDS.RowCount = 100;
            dataGridViewData_BDS.ColumnCount = 100;
            for (int i = 0; i < 100; i++)
            {
                dataGridViewData_BDS.Columns[i].Width = 150;
            }
        }

        private void buttonStats_BDS_Click(object sender, EventArgs e)
        {
            FormStatsAndAdd formsa = new FormStatsAndAdd();
            formsa.Show();
        }

        private void buttonLoadData_BDS_Click(object sender, EventArgs e)
        {
            openFileDialogData_BDS.ShowDialog();
            string FileName = openFileDialogData_BDS.FileName;

            string[,] DataMatrix = ds.GetMatrix(FileName); 

            int rows = DataMatrix.GetLength(0);
            int columns = DataMatrix.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewData_BDS.Rows[r].Cells[c].Value = DataMatrix[r, c];
                }
            }
            ToolStripMenuItemSortMin_BDS.Enabled = true;
            ToolStripMenuItemSortMax_BDS.Enabled = true;
            textBoxSearch_BDS.Enabled = true;
            buttonSearch_BDS.Enabled = true;
        }

        private void buttonBack_BDS_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);

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

        private void ToolStripMenuItemIDMin_BDS_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMax(DataMatrix, 0);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewData_BDS.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonBack_BDS.Enabled = true;
        }

        private void ToolStripMenuItemExperienceMin_BDS_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMax(DataMatrix, 2);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewData_BDS.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonBack_BDS.Enabled = true;
        }

        private void ToolStripMenuItemFuelMin_BDS_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMax(DataMatrix, 5);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewData_BDS.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonBack_BDS.Enabled = true;
        }

        private void ToolStripMenuItemKilometersMin_BDS_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMax(DataMatrix, 6);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewData_BDS.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonBack_BDS.Enabled = true;
        }

        private void ToolStripMenuItemIDMax_BDS_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMin(DataMatrix, 0);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewData_BDS.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonBack_BDS.Enabled = true;
        }

        private void ToolStripMenuItemExperienceMax_BDS_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMin(DataMatrix, 2);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewData_BDS.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonBack_BDS.Enabled = true;
        }

        private void ToolStripMenuItemFuelMax_BDS_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMin(DataMatrix, 5);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewData_BDS.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonBack_BDS.Enabled = true;
        }

        private void ToolStripMenuItemKilometersMax_BDS_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMin(DataMatrix, 6);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewData_BDS.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonBack_BDS.Enabled = true;
        }

        private void buttonSearch_BDS_Click(object sender, EventArgs e)
        {
            if (textBoxSearch_BDS.Text == "")
                MessageBox.Show("Поле поиска пустое!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string[,] DataMatrix = ds.GetMatrix(path);

                string[,] str = ds.Search(DataMatrix, textBoxSearch_BDS.Text);
                try
                {
                    if (str[0, 0] == null)
                        MessageBox.Show("Такого производителя нет в базе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        for (int r = 1; r < DataMatrix.GetLength(0); r++)
                        {
                            for (int c = 0; c < DataMatrix.GetLength(1); c++)
                            {
                                dataGridViewData_BDS.Rows[r].Cells[c].Value = "";
                            }
                        }
                        for (int i = 0; i < DataMatrix.GetLength(1); i++)
                        {
                            dataGridViewData_BDS.Rows[0].Cells[i].Value = DataMatrix[0, i];
                        }
                        for (int r = 0; r < str.GetLength(0); r++)
                        {
                            for (int c = 0; c < str.GetLength(1); c++)
                            {
                                dataGridViewData_BDS.Rows[r + 1].Cells[c].Value = str[r, c];
                            }
                        }

                        buttonBack_BDS.Enabled = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Такого производителя нет в базе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxSearch_BDS.Text = "";
                }

            }
        }

        private void buttonGuide_BDS_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.Show();
        }

        private void buttonInfo_BDS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }
    }
}
