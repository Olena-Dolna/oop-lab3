using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays2DWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double[,] arr;
        }
        public double[,] arr;
        public Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }
        private void generate_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(rowsCount.Value);
            int n = Convert.ToInt32(columnsCount.Value);
            if (n <= 0)
            {
                MessageBox.Show("Помилка введеня значення n!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (m <= 0)
            {
                MessageBox.Show("Помилка введеня значення m!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            arr = new double[n, m];
            dataGridViewMatrix.RowCount = n;
            dataGridViewMatrix.ColumnCount = m;
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                dataGridViewMatrix.Rows[j].HeaderCell.Value = j.ToString();
            }
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                dataGridViewMatrix.Columns[i].HeaderText = i.ToString();
                dataGridViewMatrix.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i,j] = random.Next(-142, 183) / 10.0;
                }
            }
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    dataGridViewMatrix[j,i].Value = arr[i,j];
                }
            }
        }

        private void solve_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(rowsCount.Value);
            int n = Convert.ToInt32(columnsCount.Value);
            double sum, maxsum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum = 0.0;
                for (int j = 0; j < m; j++)
                {
                    sum += arr[i,j];
                }
                if (maxsum < sum)
                {
                    maxsum = sum;
                }
            }
            sumValue.Text = maxsum.ToString("F1");
            for (int i = 0; i < n; i ++)
            {
                for (int j = 0, k = m - 1; j < m / 2; j++, k--)
                {
                    double temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    dataGridViewMatrix[j, i].Value = arr[i, j];
                }
            }

        }
    }
}
