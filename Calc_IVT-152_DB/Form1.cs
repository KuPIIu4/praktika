using System;
using System.Windows.Forms;
using Calc_IVT_152_DB.OneArgsCalc;
using Calc_IVT_152_DB.TwoArgsCalc;

namespace Calc_IVT_152_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_ClickTwoArg(object sender, EventArgs e)
        {
            double firstValue = 0;
            double secondValue = 0;
            try
            {
                firstValue = Convert.ToDouble(textBox1.Text);
                secondValue = Convert.ToDouble(textBox2.Text);
            }
            catch 
            {
                throw new Exception("Неверный ввод");
            }
            ITwoArgumentsCalculator calc = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double result = calc.Calculate(firstValue, secondValue);
            label1.Text = result.ToString();
        }

        private void button_ClickOneArg(object sender, EventArgs e)
        {
            double firstValue = 0;
            try
            {
                firstValue = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception exp)
            {
                throw new Exception("Неверный ввод");
            }
            IOneArgumentCalculator calc = OneArgumentCalculator.CreateCalculator(((Button)sender).Name);
            double result = calc.Calculate(firstValue);
            label1.Text = result.ToString();
        }

    }
}
