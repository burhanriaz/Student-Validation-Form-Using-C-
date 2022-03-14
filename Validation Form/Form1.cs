using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ValidationForm
{
    public partial class Form1 : Form
    {
        /*
         1)Here I'm Creating a sample form to store data about student
         2)form have 7 text box to input data
         3)All Textbox get specific data Accourding to given Requirement
         4)Every Texbox Labeled with proper name 
         5)If anywhere we are trying enter wrong data textbox will not accept
           
            Name           : Burhan Riaz
            Reg No         : SP20-MCS-036
            Subject        : Compiler construction
            Submitted To   : Husnain Khalid
            Assignment No  : 01
            Date           :04-03-2021
            */
        public Form1()
        {
            InitializeComponent();
            label1.Text = "First Name";
            label2.Text = "Last Name";
            label3.Text = "Roll Number";
            label4.Text = "Email";
            label5.Text = "Phone Number";
            label6.Text = "Gender";
            label7.Text = "CNIC";
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label12.Hide();
            label11.Hide();
            label14.Hide();
            label13.Hide();
            


        }


        private void button1_Click(object sender, EventArgs e)
        {
            // ensures TextBoxes are not empty  
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                // display popup box  
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus(); // set focus to Name TextBox  
                return;
            } // end if */
            //textbox1 name 
            // Name would be like (Burhan)
            if (!Regex.Match(textBox1.Text, @"^[A-Z][a-zA-Z]*$").Success)
            {
                label8.Show(); //label will be show 
                label8.Text = ("First Latter Capital");
                label8.ForeColor = Color.Red;//change label color
                textBox1.Focus(); // set focus to Name TextBox1 
                return;
            }  
            else
            {
                label8.Show();
                label8.ForeColor = Color.Green; // change lebel text color
                label8.Text = ("Confrim"); // change label text with new one
            }
            //textbox2 for father name 
            //Last name would be like (Riaz)
            if (!Regex.Match(textBox2.Text, @"^[A-Z][a-zA-Z]*$").Success)
            {
                label9.Show();
                label9.ForeColor = Color.Red;
                label9.Text = ("First Latter Capital");
                textBox2.Focus(); // set focus to Father Name TextBox2
                return;
            } // end if 
            else
            {
                label9.Show();
                label9.ForeColor = Color.Green;
                label9.Text = ("Confrim");
            }
            //textbox3 for Roll Number
            //Roll NO would be like (SP20-MCS-000)
            //Roll NO would be like (FA20-BCS-000)
            if (!Regex.Match(textBox3.Text, @"^SP[0-9]{2}-[a-zA-Z]{2,5}-[0-9]{2,3}$|^FA[0-9]{2}-[a-zA-Z]{2,5}-[0-9]{2,3}$").Success)
            {
                label10.Show();
                label10.ForeColor = Color.Red;
                label10.Text = ("Invalid Roll number (SP20-MCS-000)");
                textBox3.Focus();
                return;
            }
            else
            {
                label10.Show();
                label10.ForeColor = Color.Green;
                label10.Text = ("Confrim");
            }
            //textbox4 For Email
            //Email would be like (burhanriaz35@gmail.com)

            if (!Regex.Match(textBox4.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z").Success)
            {
                label11.Show();
                label11.ForeColor = Color.Red;
                label11.Text = ("Invalid Email (abc@gmail.com)");
                textBox4.Focus();
                return;
            }
            else
            {
                label11.Show();
                label11.ForeColor = Color.Green;
                label11.Text = ("Confrim");
            }
            //textbox5 for phone
            //Phone Number would be like (+923124567890)

            if (!Regex.Match(textBox5.Text, @"^((\+92)|(0092))-{0,1}\d{3}-{0,1}\d{7}$|^\d{11}$|^\d{4}-\d{7}$").Success)
            {
                label12.Show();
                label12.ForeColor = Color.Red;
                label12.Text = ("Invalid Phone Number (+923124567890)");
                textBox5.Focus();
                return;
            }
            else
            {
                label12.Show();
                label12.ForeColor = Color.Green;
                label12.Text = ("Confrim");
            }
            //textbox6 for gender
            //Gender ould be like (Male , Female, male,female)
            if (!Regex.Match(textBox6.Text, @"Male$|Female$|male$|female$").Success)
            {
                label13.Show();
                label13.ForeColor = Color.Red;
                label13.Text = ("Invalid .. Gender Type Like  Male  Female ");
                textBox6.Focus();
                return;
            }
            else
            {
                label13.Show();
                label13.ForeColor = Color.Green;
                label13.Text = ("Confrim");
            }
            //textbox7 national id card number
            // national id card number would be like (36609-2736647-9)
            if (!Regex.Match(textBox7.Text, @"^[0-9]{5}-[0-9]{7}-[0-9]{1}$").Success)
            {
                label14.Show();
                label14.ForeColor = Color.Red;
                label14.Text = ("ID Card Like (36609-2736647-9)");
                textBox7.Focus();
                return;
            }
            else
            {
                label14.Show();
                label14.ForeColor = Color.Green;
                label14.Text = ("Confrim");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
