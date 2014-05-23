using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
       public int number1;
       public int number2;
        textBox1.Text = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            show(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            show(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            show(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            show(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            show(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            show(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            show(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            show(9);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            show(0);
        }

        private void button11_Click(object sender, EventArgs e)//+
        {
  
            this.number1 = int.Parse(textBox1.Text);
            textBox1.Text = "+";
             
        }
       

        private void button12_Click(object sender, EventArgs e)//=
        {
            this.number2 = int.Parse(textBox1.Text);
            add(number1, number2);
        }

        private void button10_Click(object sender, EventArgs e)//c
        {
            textBox1.Text = "";
            this.number1 = 0;
            this.number2 = 0;
        }
        
        private void add(int a, int b)
        {
            int result = a + b;
            textBox1.Text = result.ToString();
           
        }

        private void show(int value)
        {
            if (textBox1.Text == "+")
                textBox1.Text = "" + value;
            else
                textBox1.Text = textBox1.Text + value;
        }
     
      }
}
