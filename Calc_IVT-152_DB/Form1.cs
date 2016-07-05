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
            double firstValue = Convert.ToDouble(textBox1.Text);
            double secondValue = Convert.ToDouble(textBox2.Text);
            ITwoArgumentsCalculator calc = TwoArgumentsFactory.CreateCalculator(((Button) sender).Name);
            double result = calc.Calculate(firstValue, secondValue);
            label1.Text = result.ToString();
        }

        private void button_ClickOneArg(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(textBox1.Text);
            IOneArgumentCalculator calc = OneArgumentCalculator.CreateCalculator(((Button)sender).Name);
            double result = calc.Calculate(firstValue);
            label1.Text = result.ToString();
        }

    }
}
