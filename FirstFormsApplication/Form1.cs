using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            int result = 0;

            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            String operationChoice = Convert.ToString(textBox3.Text);
            if (operationChoice.Equals("+"))
            {
                result = num1 + num2;
            }
            else if (operationChoice.Equals("-"))
            {
                result = num1 - num2;
            }
            else if (operationChoice.Equals("*"))
            {
                result = num1 * num2;
            }
            label5.Text = result.ToString();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
