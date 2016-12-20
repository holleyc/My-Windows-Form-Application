using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP1600029_CPD_lesson_16
{
    public partial class Form1 : Form
    {






        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valueOne;
            int valueTwo;
            int valueThree;
            int valueFour;
            int valueFive;

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a value in the Value 1 text box.");
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter a value in the Value 2 text box.");
            }

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please enter a value in the Value 3 text box.");
            }

            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Please enter a value in the Value 4 text box.");
            }

            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Please enter a value in the Value 5 text box.");
            }

            //Checks to see if one of the checkboxlist items are checked
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                MessageBox.Show("Please select at least one option from the CheckBoxList");
            }

            valueOne = int.Parse(textBox1.Text);
            valueTwo = int.Parse(textBox2.Text);
            valueThree = int.Parse(textBox3.Text);
            valueFour = int.Parse(textBox4.Text);
            valueFive = int.Parse(textBox5.Text);


            MessageBox.Show("Submit");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void showMax(object sender, EventArgs e)
        {

        }

        private void showMin(object sender, EventArgs e)
        {

        }

        private void showMean(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void resetFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int valueOne;
            int valueTwo;
            int valueThree;
            int valueFour;
            int valueFive;

            valueOne = int.Parse(textBox1.Text);
            valueTwo = int.Parse(textBox2.Text);
            valueThree = int.Parse(textBox3.Text);
            valueFour = int.Parse(textBox4.Text);
            valueFive = int.Parse(textBox5.Text);

            MessageBox.Show(valueOne.ToString());
        }
    }
}
