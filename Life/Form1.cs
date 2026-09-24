using System;
using System.Drawing;
using System.Windows.Forms;

namespace Life
{
    public partial class Form1 : Form
    {
        private const int MaxGridSize = 100;

        private Population currentPopulation;

        public Form1()
        {
            InitializeComponent();

            stepButton.Enabled = false;
            toggleTimerButton.Enabled = false;
        }

        private void initializeButton_Click(object sender, EventArgs e)
        {
            if (!TryReadPositiveInt(textBox1, "не то количество", out int initialCount))
            {
                return;
            }

            if (!TryReadPositiveInt(textBox2, "не тот размер", out int gridSize))
            {
                return;
            }

            if (gridSize > MaxGridSize)
            {
                MessageBox.Show($"Размер поля не должен превышать {MaxGridSize}.");
                textBox2.Clear();
                return;
            }

            SetupGrids(gridSize);

            currentPopulation = new Population(initialCount, gridSize);
            RenderPopulation(currentPopulation, DGV1);

            stepButton.Enabled = true;
            toggleTimerButton.Enabled = true;
        }

        private void stepButton_Click(object sender, EventArgs e)
        {
            DGV1.Visible = true;
            AdvanceGeneration();
        }

        private void toggleTimerButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            toggleTimerButton.Text = timer1.Enabled ? "Пауза" : "Жизнь";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DGV1.Visible = false;
            AdvanceGeneration();
        }

        private void AdvanceGeneration()
        {
            RenderPopulation(currentPopulation, DGV1);
            currentPopulation = currentPopulation.CalculateNextState();
            RenderPopulation(currentPopulation, DGV2);
        }

        private void SetupGrids(int gridSize)
        {
            DGV1.RowCount = gridSize;
            DGV1.ColumnCount = gridSize;
            DGV2.RowCount = gridSize;
            DGV2.ColumnCount = gridSize;

            DGV1.Rows[0].Cells[0].Selected = false;
            DGV2.Rows[0].Cells[0].Selected = false;

            int cellSize = DGV1.Size.Width / gridSize;

            for (int i = 0; i < gridSize; i++)
            {
                DGV1.Rows[i].Height = cellSize;
                DGV1.Columns[i].Width = cellSize;
                DGV2.Rows[i].Height = cellSize;
                DGV2.Columns[i].Width = cellSize;
            }
        }

        private void RenderPopulation(Population population, DataGridView grid)
        {
            for (int row = 0; row < population.Size; row++)
                for (int column = 0; column < population.Size; column++)
                {
                    grid.Rows[row].Cells[column].Style.BackColor =
                        population[row, column] ? Color.ForestGreen : Color.White;
                }
        }

        private bool TryReadPositiveInt(TextBox textBox, string errorMessage, out int value)
        {
            if (!int.TryParse(textBox.Text, out value) || value <= 0)
            {
                MessageBox.Show(errorMessage);
                textBox.Clear();
                return false;
            }

            return true;
        }

        private void DGV1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // 2. Игнорируем клики по заголовкам и служебной строке
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (e.RowIndex >= currentPopulation.Size || e.ColumnIndex >= currentPopulation.Size)
                return;

            // 3. Инвертируем клетку
            bool newValue = !currentPopulation[e.RowIndex, e.ColumnIndex];
            currentPopulation[e.RowIndex, e.ColumnIndex] = newValue;

            // 4. Перекрашиваем только эту клетку
            DGV1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor =
                newValue ? Color.ForestGreen : Color.White;

            // 5. Снимаем выделение, чтобы клетка не выглядела синей
            DGV1.ClearSelection();
        }
    }
}