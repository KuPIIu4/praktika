using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_IVT_152_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            double result;
            double firstValue = Convert.ToDouble(textBox1.Text);
            double secondValue = Convert.ToDouble(textBox2.Text);
            switch (((Button)sender).Name)
            {
                case "buttonAdd": 
                    result = firstValue + secondValue;
                    break;
                case "buttonSub":
                    result = firstValue - secondValue; 
                    break;
                case "buttonMult":
                    result = firstValue * secondValue;
                    break;
                case "buttonDiv":
                    result = firstValue / secondValue; 
                    break;
                default:
                    throw new Exception("Неизвестная мат. операция");
            }

            label1.Text = result.ToString();
        }
    }
}
