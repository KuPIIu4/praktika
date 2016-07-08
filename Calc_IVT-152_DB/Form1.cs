using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Calc_IVT_152_DB.OneArgsCalculator;
using Calc_IVT_152_DB.SortArray;
using Calc_IVT_152_DB.TwoArgsCalculator;

namespace Calc_IVT_152_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_ClickSort(object sender, EventArgs e)
        {
            try
            {
                int length = dataGridView1.RowCount;
                double[] array = new double[length];
                for (int i = 0; i < length; i++)
                {
                    array[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value.ToString());
                }
                ISortArray sort = SortArrayFactory.Create(((Button)sender).Name);
                Int64 g = Environment.TickCount;
                sort.SortArray(array );
                g = Environment.TickCount - g;
                MessageBox.Show(g.ToString());
                for (int i = 0; i < length; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = array[i].ToString();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void button_ClickTwoArg(object sender, EventArgs e)
        {
            try
            {
                double firstValue = Convert.ToDouble(textBox1.Text);
                double secondValue = Convert.ToDouble(textBox2.Text);
                ITwoArgumentsCalculator calc = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
                double result = calc.Calculate(firstValue, secondValue);
                label1.Text = result.ToString();
            }
            catch (Exception exp) 
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button_ClickOneArg(object sender, EventArgs e)
        {
            try
            {
                double firstValue = Convert.ToDouble(textBox1.Text);
                IOneArgumentCalculator calc = OneArgumentCalculator.CreateCalculator(((Button)sender).Name);
                double result = calc.Calculate(firstValue);
                label1.Text = result.ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] array = new double[1111111];
            Random r1 = new Random();
            for (int i = 0; i < 1111111; i++)
            {
                array[i] = r1.Next();
            }
            dataGridView1.RowCount = 1111111;
            for (int i = 0; i < 1111111; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = array[i].ToString();
            }
            Int64 g = Environment.TickCount;
            Array.Sort(array);
            g = Environment.TickCount - g;
            MessageBox.Show(g.ToString());
        }
    }
}
