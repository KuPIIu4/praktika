using System;
using System.Windows.Forms;
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
                int length = dataGridView1.RowCount-1;
                double[] array = new double[length];
                for (int i = 0; i < length; i++)
                {
                    array[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value.ToString());
                }
                ISortArray sort = SortArrayFactory.Create(((Button)sender).Name);
                sort.SortArray(array );
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
            
        }

    }
}
