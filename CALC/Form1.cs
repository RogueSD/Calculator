using System;
using System.Windows.Forms;
using Calculator.Evaluations;
using ClassLibrary1;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void resultButton_Click(object sender, EventArgs e)
        {
            Func<double, double, double> func;
            double param1, param2;

            if (addRB.Checked)
            {
                func = Evaluator.Add;
            }
            else if (multiplyRB.Checked)
            {
                func = Evaluator.Multiply;
            }
            else if(subRB.Checked)
            {
                func = Class1.minus;
            }
            else if(divRB.Checked)
            {
                func = Class1.delenie;
            }    
            else
            {
                MessageBox.Show("Не выбрана операция!");
                return;
            }

            if (!double.TryParse(arg1TB.Text, out param1))
            {
                MessageBox.Show("1-ый аргумент не является числом!");
                return;
            }
               
            if (!double.TryParse(arg2TB.Text, out param2))
            {
                MessageBox.Show("2-ой аргумент не является числом!");
                return;
            }

            try
            {
                resultLabel.Text = "=";
                double result = func(param1, param2);
                resultLabel.Text += "   " + result.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resultLabel_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "=";
        }

        private void addRB_CheckedChanged(object sender, EventArgs e)
        {
            operationLabel.Text = "+";
        }

        private void multiplyRB_CheckedChanged(object sender, EventArgs e)
        {
            operationLabel.Text = "*";
        }

        private void subRB_CheckedChanged(object sender, EventArgs e)
        {
            operationLabel.Text = "-";
        }

        private void divRB_CheckedChanged(object sender, EventArgs e)
        {
            operationLabel.Text = "/";
        }
    }
}
