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

        // This method clears the number value boxes and clears the message box
        public void resetTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            richTextBox1.Clear();
        }

        // This method resets the checkboxes to the default value and clears the message box
        public void resetCheckBoxes()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            richTextBox1.Clear();
        }

        // Submit button click event
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            //Check if all values are blank
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrEmpty(textBox3.Text) && string.IsNullOrEmpty(textBox4.Text) && string.IsNullOrEmpty(textBox5.Text))
            {
                richTextBox1.AppendText("No Values Input!");
                return;
            }

            //Check if any values are blank
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                richTextBox1.AppendText("Please enter value for every textbox");
                return;
            }

            //Checks to see if one of the checkboxlist items are checked
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                richTextBox1.AppendText("Please choose at least one function to perform against the provided values");
                return;
            }

            // List of numbers
            List<int> integerList = new List<int>();

            //Try catch for each textbox1 value
            try
            {
                int valueOne = int.Parse(textBox1.Text);
                integerList.Add(valueOne);
            }
            catch (Exception ee)
            {
                richTextBox1.AppendText("" + ee + "");
            }

            //Try catch for each textbox2 value
            try
            {
                int valueTwo = int.Parse(textBox2.Text);
                integerList.Add(valueTwo);
            }
            catch (Exception ee)
            {
                richTextBox1.AppendText(""+ ee +"");
            }

            //Try catch for each textbox3 value
            try
            {
                int valueThree = int.Parse(textBox3.Text);
                integerList.Add(valueThree);
            }
            catch (Exception ee)
            {
                richTextBox1.AppendText("" + ee + "");
            }

            //Try catch for each textbox4 value
            try
            {
                int valueFour = int.Parse(textBox4.Text);
                integerList.Add(valueFour);
            }
            catch (Exception ee)
            {
                richTextBox1.AppendText("" + ee + "");
            }

            //Try catch for each textbox5 value
            try
            {
                int valueFive = int.Parse(textBox5.Text);
                integerList.Add(valueFive);
            }
            catch (Exception ee)
            {
                richTextBox1.AppendText("" + ee + "");
            }

            // If Man checkbox checked 
            if (checkBox1.Checked == true)
            // Finds the maximum number in the list of numbers
            {
                int maxValue = integerList.Max();

                richTextBox1.AppendText("Show Max: " + maxValue + "\r\n");
            }

            // If Min checkbox checked
            if (checkBox2.Checked == true)
            // Finds the minimum number in the list of numbers
            {
                int minValue = integerList.Min();

                richTextBox1.AppendText("Show Min: " + minValue + "\r\n");
            }

            // If Mean checkbox checked
            if (checkBox3.Checked == true)
            // Finds the sum of the list of numbers then divides by five to get mean
            {
                int sum = integerList.Sum();
                int avg = (sum / 5);

                richTextBox1.AppendText("Show Mean: " + avg + "\r\n");
            }
        }

        //Menu Item - About click - Shows the about message.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed By Christopher Holley, Ashworth College");
        }

        //Reset Values - Menu Item - This resets all the values to the default settings
        private void resetValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetTextBoxes();
        }

        //Reset Checkboxes - Menu Item - Resets the check boxes
        private void resetCheckboxesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetCheckBoxes();
        }

        //Clear Form - Button - This resets all the values to the default settings
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

        //Menu Item - Assign Random Values
        private void assignRandomValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Generates random numbers and sets them to string
            Random intGenerator = new Random(); int one; int two; int three; int four; int five;
            one = intGenerator.Next(1, 999);
            two = intGenerator.Next(1, 999);
            three = intGenerator.Next(1, 999);
            four = intGenerator.Next(1, 999);
            five = intGenerator.Next(1, 999);
            textBox1.Text = one.ToString();
            textBox2.Text = two.ToString();
            textBox3.Text = three.ToString();
            textBox4.Text = four.ToString();
            textBox5.Text = five.ToString();
        }

        // Picture click event
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //Picture left click event and clear message box
            if (e.Button == MouseButtons.Left)
            {
                richTextBox1.Clear();
                richTextBox1.AppendText("X: " + e.Location.X + ", Y: " + e.Location.Y + ". Clicked with the Left button.");
            }
            //Picture right click event and clear message box
            if (e.Button == MouseButtons.Right)
            {
                richTextBox1.Clear();
                richTextBox1.AppendText("X: " + e.Location.X + ", Y: " + e.Location.Y + ". Clicked with the Right button.");
            }
        }

        //Main form double click event
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Double click was performed.");
        }

        //Checking textbox1 for numbers only and clear message box
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            richTextBox1.Clear();
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                richTextBox1.AppendText("Number only allowed");
            }
        }

        //Checking textbox2 for numbers only and clear message box
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            richTextBox1.Clear();
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                richTextBox1.AppendText("Number only allowed");
            }
        }

        //Checking textbox3 for numbers only and clear message box
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            richTextBox1.Clear();
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                richTextBox1.AppendText("Number only allowed");
            }
        }

        //Checking textbox4 for numbers only and clear message box
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            richTextBox1.Clear();
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                richTextBox1.AppendText("Number only allowed");
            }
        }

        //Checking textbox5 for numbers only and clear message box
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            richTextBox1.Clear();
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                richTextBox1.AppendText("Number only allowed");
            }
        }

        //Clear the message box on textbox1 click
        private void textBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        //Clear the message box on textbox2 click
        private void textBox2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        //Clear the message box on textbox3 click
        private void textBox3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        //Clear the message box on textbox4 click
        private void textBox4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        //Clear the message box on textbox5 click
        private void textBox5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
