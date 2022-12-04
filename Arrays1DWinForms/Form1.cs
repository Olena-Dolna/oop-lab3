using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays1DWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double[] arr;
        }
        double[] arr;
        public Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            int n = Convert.ToInt32(numericUpDownCount.Value);
            if (n <= 0)
            {
                MessageBox.Show("Помилка введеня значення n!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            arr = new double[n];
            dataGridViewArray.RowCount = 1;
            dataGridViewArray.ColumnCount = n;
            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(-123, 163) / 10.0;
                dataGridViewArray[i, 0].Value = arr[i];
                dataGridViewArray.Columns[i].HeaderText = i.ToString();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDownCount.Value);
            int sum = 0, counter = 0, firstIndex = 0, lastIndex = 0, nomatch = 0;
            summValue.Clear();
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0 && i % 2 == 0)
                {
                    sum += i;
                }
                else if (arr[i] >= 0 || i % 2 != 0)
                {
                    nomatch++;
                }
            }
            if (nomatch == n)
            {
                MessageBox.Show("Масив не містить від'ємних елементів, індекси яких діляться на 2!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                summValue.Clear();
            }
            else
            {
                summValue.Text = sum.ToString();
            }
             for (int i = 0; counter < 2 && i < n; i++)
             {
                if (arr[i] > 0)
                {
                    counter++;
                    if (counter == 1)
                    {
                        firstIndex = i;
                    }
                    if (counter == 2)
                    {
                        lastIndex = i;
                    }

                }
             }   
            try
            {   
                if (counter < 2)
                {
                    throw new Exception();
                }
                Array.Sort(arr, firstIndex, (lastIndex - firstIndex + 1));
                
                for (int i = 0; i < n; i++)
                {
                    dataGridViewArray[i, 0].Value = arr[i];
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Масив не містить 2 додатних елементи!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
