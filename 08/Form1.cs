using System.Drawing.Drawing2D;
namespace _08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 5; // Устанавливаем количество строк в dataGridView1
            dataGridView1.ColumnCount = 5; // Устанавливаем количество столбцов в dataGridView1

            int[,] a = new int[5, 5]; // Инициализируем двумерный массив размером 5x5
            int i, j;

            // Заполняем матрицу случайными числами
            Random rand = new Random();
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    a[i, j] = rand.Next(-100, 100); // Генерируем случайное число и помещаем его в матрицу
                }
            }

            // Выводим матрицу в dataGridView1
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString(); // Выводим элементы матрицы в ячейки dataGridView1
                }
            }

            int minColumn = 0; // Индекс столбца с наименьшим количеством положительных элементов
            int minCount = int.MaxValue; // Количество положительных элементов в столбце с наименьшим количеством

            // Находим столбец с наименьшим количеством положительных элементов
            for (int column = 0; column < 5; column++)
            {
                int count = 0; // Счетчик положительных элементов в столбце

                for (int row = 0; row < 5; row++)
                {
                    if (a[row, column] > 0)
                    {
                        count++; // Увеличиваем счетчик, если элемент положительный
                    }
                }

                if (count < minCount)
                {
                    minColumn = column; // Обновляем индекс столбца с наименьшим количеством
                    minCount = count; // Обновляем количество положительных элементов
                }
            }

            textBox1.Text = Convert.ToString("Номер столбца с наименьшим количеством положительных элементов (отсчёт с нуля): " + minColumn);
        }
    }
}
