using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double value;
        string soperator;
        bool check;

        public Form1()
        {


            InitializeComponent();
        }
        private void PNumber(object sender, EventArgs e)
        {
            if ((soperator == "+") || (soperator == "-") || (soperator == "*") || (soperator == "/")) ;
            {
                if(check)
                {
                    check = false;
                    textBox1.Text = "0";

                }
            }
            Button b = sender as Button;
            if (textBox1.Text == "0")
                textBox1.Text = b.Text;
            
            else
                textBox1.Text += b.Text;
        }
        private void POperator(object sender, EventArgs e)
        {
            Button b = sender as Button;
            value = double.Parse(textBox1.Text);
            soperator = b.Text;
            textBox1.Text += b.Text;
            check = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                
                switch (soperator)
                {
                    case "+":
                        textBox1.Text = (value + double.Parse(textBox1.Text)).ToString();
                        break;
                    case "-":
                        textBox1.Text = (value - double.Parse(textBox1.Text)).ToString();
                        break;
                    case "*":
                        textBox1.Text = (value * double.Parse(textBox1.Text)).ToString();
                        break;
                    case "/":
                        textBox1.Text = (value / double.Parse(textBox1.Text)).ToString();
                        break;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an simple calculator made by Macadelic from HF. Thanks for using it. :)");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
