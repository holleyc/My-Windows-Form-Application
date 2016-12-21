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

        //public class MaximumFinder
        //{
        //    // obtain five floating point values and determine the maximum value
        //    public static void Main(string[] args)
        //    { 
        //    //get the five inputs from the form
        //        //int number1 = int.Parse(textBox1.Text);

        //    }
        //}

        // This method clears the number value boxes
        public void resetTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        // This method resets the checkboxes to the default value
        public void resetCheckBoxes()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MessageBox.Show("Left Mouse Button was clicked!");
            else if (e.Button == MouseButtons.Middle)
                MessageBox.Show("Middle Mouse Button was clicked!");
        }

        // Submit button click event
        private void button1_Click(object sender, EventArgs e)
        {
            int valueOne;
            int valueTwo;
            int valueThree;
            int valueFour;
            int valueFive;

            //Text box one logic
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a value in the Value 1 text box.");
            }
            else {
                valueOne = int.Parse(textBox1.Text);
            }

            //Text box two logic
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter a value in the Value 2 text box.");
            }
            else { valueTwo = int.Parse(textBox2.Text); }

            //Text box three logic
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please enter a value in the Value 3 text box.");
            }
            else { valueThree = int.Parse(textBox3.Text); }

            //Text box four logic
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Please enter a value in the Value 4 text box.");
            }
            else { valueFour = int.Parse(textBox4.Text); }

            //Text box five logic
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Please enter a value in the Value 5 text box.");
            }
            else { valueFive = int.Parse(textBox5.Text); }

            //Checks to see if one of the checkboxlist items are checked
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                MessageBox.Show("Please select at least one option from the CheckBoxList");
            }

            //Checks for the checkbox one checked or not
            if (checkBox1.Checked == true) {

                //int maxValue = Math.Max(valueOne, valueTwo);

                // valueOne, valueTwo, valueThree, valueFour, valueFive 
                List<int> integers = new List<int>() { 4, 5, 6, 7, 8 };
                int intMax = integers.Max();

                MessageBox.Show(""+intMax+"");
            }

            if (checkBox2.Checked == true)
            {
                MessageBox.Show("Min Checked");
            }

            if (checkBox3.Checked == true)
            {
                MessageBox.Show("Mean Checked");
            }
            //MessageBox.Show("Submit");
        }

        // This is the about click
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Christopher Holley");
        }

        // Clear Form - This resets all the values to the default settings
        private void button2_Click(object sender, EventArgs e)
        {
            resetTextBoxes();
            resetCheckBoxes();
        }

        //Reset form - Menu Item - This resets all the values to the default settings
        private void resetFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetTextBoxes();
            resetCheckBoxes();
        }

        //Menu Item - This closes the application
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Reset Values - Menu Item - This resets all the values to the default settings
        private void resetValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetTextBoxes();
        }

        //Submit Button
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

        //Menu Item - Assign Random Values
        private void assignRandomValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random numGenerator = new Random(); int one; int two; int three; int four; int five;
            one = numGenerator.Next(0, 1000);
            two = numGenerator.Next(0, 1000);
            three = numGenerator.Next(0, 1000);
            four = numGenerator.Next(0, 1000);
            five = numGenerator.Next(0, 1000);
            textBox1.Text = one.ToString();
            textBox2.Text = two.ToString();
            textBox3.Text = three.ToString();
            textBox4.Text = four.ToString();
            textBox5.Text = five.ToString();
        }
    }
}
