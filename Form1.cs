using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Calc.Calc;

namespace WindowsFormsApp_Calc
{
    public partial class Form1 : Form
    {
        double tmp1, tmp2;
        ICalc Calc;

        public Form1()
        {
            InitializeComponent();
        }

        public void AddToTextBox(string a)
        {
            TextBox.Text += a;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            AddToTextBox("1");
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            AddToTextBox("2");
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            AddToTextBox("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddToTextBox("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddToTextBox("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddToTextBox("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddToTextBox("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddToTextBox("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddToTextBox("9");
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                if (Calc != null)
                {
                    tmp1 = Calc.DoMath(tmp1, Convert.ToDouble(TextBox.Text));
                    TextBox.Text = ""; // обнуление
                    Calc = new Adder();
                }
                else
                {
                    tmp1 = Convert.ToDouble(TextBox.Text);
                }
                TextBox.Text = "";
                Calc = new Adder();

            }
           
        
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            tmp1 = Convert.ToDouble(TextBox.Text);
            TextBox.Text = ""; // обнуление
            Calc = new Substracter();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            tmp1 = 0;
            tmp2 = 0;
            Calc = null;
            TextBox.Text = "";
        }

        private void solution_Click(object sender, EventArgs e)
        {
            if ( TextBox.Text != "" && Calc!= null)
            { 
                tmp2 = Convert.ToDouble(TextBox.Text);
                TextBox.Text = Calc.DoMath(tmp1, tmp2) + "";
            }
            
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            tmp1 = Convert.ToDouble(TextBox.Text);
            TextBox.Text = ""; // обнуление
            Calc = new Multiplication();
        }

        private void division_Click(object sender, EventArgs e)
        {
            tmp1 = Convert.ToDouble(TextBox.Text);
            TextBox.Text = ""; // обнуление
            Calc = new Division();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AddToTextBox("0");
        }

    }
}
