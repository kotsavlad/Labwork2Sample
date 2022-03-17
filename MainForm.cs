/*************************************************************************************************************
 *  Користувач вказує два файли, які містять елементи цілочислових матриць. Виконати наступні завдання:
 *      1.  Виділити кольором ті стовпці першої матриці, кожний елемент яких не менший за відповідний йому 
 *          елемент другої матриці, розташований у тій самій позиції.
 *      2.  Зобразити гістограму, поставивши кожній матриці у відповідність окремий ряд даних. На осі абсцис 
 *          треба відкласти натуральні числа від 0 до М ‒ 1, а на осі ординат — кількість різних елементів у 
 *          відповідному рядку матриці (М — кількість рядків матриці).
 **************************************************************************************************************/

using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MatrixSample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool TryFillGrid(DataGridView grid, string fileName = "")
        {
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.FileName = fileName;
            
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return false;

            grid.Rows.Clear();
            using var reader = new StreamReader(openFileDialog.FileName);
            var firstLine = reader.ReadLine();
            var row = firstLine?.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int columnCount = row?.Length ?? 0;
            if (columnCount == 0)
            {
                MessageBox.Show($"{openFileDialog.FileName} or its first line is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            grid.ColumnCount = columnCount;
            grid.Rows.Add(row);

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                //row = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                row = Regex.Split(line, @"\s+");
                if (row.Length != columnCount)
                {
                    int lineId = grid.RowCount + 1;
                    grid.Rows.Clear();
                    grid.Columns.Clear();
                    MessageBox.Show($"Invalid data in {openFileDialog.FileName}, line {lineId}", "Error");
                    return false;
                }
                columnCount = row.Length;
                grid.Rows.Add(row);
            }
            
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            return true;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select data for the first matrix", "Information", MessageBoxButtons.OK);
            var isValid1 = TryFillGrid(matrix1Grid, "matrix1.txt");
            var isValid2 = false;
            if (isValid1)
            {
                MessageBox.Show("Select data for the second matrix", "Information", MessageBoxButtons.OK);
                isValid2 = TryFillGrid(matrix2Grid, "matrix2.txt");
            }
            task1Button.Enabled = task2Button.Enabled = isValid1 && isValid2;
            saveFirstButton.Enabled = saveSecondButton.Enabled = true;
        }

        private bool TryParseGrid(DataGridView grid, out int[,] matrix)
        {
            matrix = new int[grid.RowCount, grid.ColumnCount];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    try
                    {
                        matrix[i, j] = Convert.ToInt32(grid[j, i].Value);
                    }
                    catch
                    {
                        MessageBox.Show($"Invalid value in cell ({i}, {j}) of {grid.Name}");
                        grid[j, i].Selected = true;
                        return false;
                    }
                }
            }
            return true;
        }

        private void Task1Button_Click(object sender, EventArgs e)
        {
            if (TryParseGrid(matrix1Grid, out var matrix1) && TryParseGrid(matrix2Grid, out var matrix2))
            {
                var m = matrix1.GetLength(0);
                var n = matrix1.GetLength(1);
                var m2 = matrix2.GetLength(0);
                var n2 = matrix2.GetLength(1);
                if ((m != m2 || n != n2) &&
                    MessageBox.Show("Do you want to continue?", "Matrices have different dimension",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                m = Math.Min(m, m2);
                n = Math.Min(n, n2);
                for (int j = 0; j < n; j++)
                {
                    var selectionRequired = true;
                    for (int i = 0; i < m; i++)
                    {
                        if (matrix1[i, j] < matrix2[i, j])
                        {
                            selectionRequired = false;
                            break;
                        }
                    }
                    matrix1Grid.Columns[j].DefaultCellStyle.BackColor = selectionRequired ? Color.Aqua : Color.White;
                    //matrix1Grid.Columns[j].DefaultCellStyle.Font = selectionRequired ? 
                    //    new Font(matrix1Grid.DefaultCellStyle.Font, FontStyle.Bold) : 
                    //    new Font(matrix1Grid.DefaultCellStyle.Font, FontStyle.Regular);
                }
            }
        }

        private void Task2Button_Click(object sender, EventArgs e)
        {
            if (TryParseGrid(matrix1Grid, out var matrix1) && TryParseGrid(matrix2Grid, out var matrix2))
            {
                var chartForm = new ChartForm(matrix1, matrix2);
                chartForm.Show();
            }
        }

        private void SaveFirstButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
                SaveGrid(button == saveFirstButton ? matrix1Grid : matrix2Grid);
        }

        private void SaveGrid(DataGridView grid)
        {
            saveFileDialog.InitialDirectory = Application.StartupPath;
            //saveFileDialog.InitialDirectory = @"d:\SampleData";
            saveFileDialog.FileName = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (DataGridViewRow row in grid.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            writer.Write(cell.Value.ToString() + "\t");
                        }
                        writer.WriteLine();
                    }
                }
            }
        }
    }
}
