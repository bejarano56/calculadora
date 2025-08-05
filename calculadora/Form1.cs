using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "+";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double contenido = double.Parse(textBox1.Text);
            double contenido2 = double.Parse(textBox2.Text);


            double num1 = contenido;
            double num2 = contenido2;

            string seleccion = comboBox1.SelectedItem.ToString();

            double res = 0;

            switch (seleccion)
            {
                case "+":
                    {
                        res = num1 + num2;
                        break;
                    }

                case "-":
                    {
                        res = num1 - num2;
                        break;
                    }
                case "*":
                    {
                        res = num1 * num2;
                        break;
                    }
                case "/":
                    {
                        res = num1 / num2;
                        break;
                    }

            }
            string final = res.ToString();
            MessageBox.Show(final);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
