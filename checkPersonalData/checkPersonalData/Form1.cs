using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkPersonalData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkFN_Click(object sender, EventArgs e)
        {
            string input;
            input = firstName.Text;

            System.Text.RegularExpressions.Regex regex = new Regex(@"^[(a-zA-Z)]+$");

            if (regex.IsMatch(input))
            {
                MessageBox.Show("First name is valid.");
            }
            else
            {
                MessageBox.Show("First name is INVALID.\n\nRight format: one name " +
                    "without special characters or numbers.");
                firstName.Clear();
                firstName.Focus();
            }
        }

        private void checkLN_Click(object sender, EventArgs e)
        {
            string input;
            input = lastName.Text;

            System.Text.RegularExpressions.Regex regex = new Regex(@"^[(a-zA-Z)\s]+$");

            if (regex.IsMatch(input))
            {
                MessageBox.Show("Last name is valid.");
            }
            else
            {
                MessageBox.Show("Last name is INVALID.\n\nRight format: Many names" +
                    "without special characters or numbers.");
                lastName.Clear();
                lastName.Focus();
            }
        }

        private void checkAdd_Click(object sender, EventArgs e)
        {
            string input;
            input = address.Text;

            System.Text.RegularExpressions.Regex regex = new Regex(@"^([0-9]+)([\s?])\b([a-zA-Z\s]+)\b$");

            if (regex.IsMatch(input))
            {
                MessageBox.Show("Address is valid.");
            }
            else
            {
                MessageBox.Show("Address is INVALID.\n\nRight format: Number and text.\n\n" +
                    "Example: 2000 Av. Ste-Catherine.");
                address.Clear();
                address.Focus();
            }
        }

        private void checkCity_Click(object sender, EventArgs e)
        {
            string input;
            input = city.Text;

            System.Text.RegularExpressions.Regex regex = new Regex(@"^\b([a-zA-Z\s]+)\b$");

            if (regex.IsMatch(input))
            {
                MessageBox.Show("City is valid.");
            }
            else
            {
                MessageBox.Show("City is INVALID.\n\nRight format: Name without" +
                    "special characters or numbers.");
                city.Clear();
                city.Focus();
            }
        }

        private void checkProvince_Click(object sender, EventArgs e)
        {
            // string input;
            // input = province.Text;
            province.Text = comboProvince.SelectedItem.ToString();
            string input = Convert.ToString(comboProvince.SelectedItem);

            System.Text.RegularExpressions.Regex regex = new Regex(@"\b[A-Z][A-Z]\b$");

            if (regex.IsMatch(input))
            {
                MessageBox.Show("Province is valid.");
            }
            else
            {
                MessageBox.Show("Province is INVALID.\n\nRight format: Two capital letters." +
                    "\n\nExample: QC.");
                province.Clear();
                comboProvince.Focus();
            }
        }

        private void checkPC_Click(object sender, EventArgs e)
        {
            string input;
            input = postalCode.Text;

            System.Text.RegularExpressions.Regex regex = new Regex(@"\b[A-Z][0-9][A-Z][0-9][A-Z][0-9]\b$");

            if (regex.IsMatch(input))
            {
                MessageBox.Show("Postal code is valid.");
            }
            else
            {
                MessageBox.Show("Postal code is INVALID.\n\nRight format:" +
                    "Three capital leters and three digits alternated.\n\n" +
                    "Example: H5B3P1.");
                postalCode.Clear();
                postalCode.Focus();
            }
        }

        private void checkPN_Click(object sender, EventArgs e)
        {
            string input;
            input = phoneNumber.Text;

            System.Text.RegularExpressions.Regex regex = new Regex(@"\b[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]\b$");

            if (regex.IsMatch(input))
            {
                MessageBox.Show("Phone number is valid.");
            }
            else
            {
                MessageBox.Show("Phone number is INVALID.\n\nThree digits," +
                    " dash, three digits, dash, four digits.\n\n" +
                    "Example: 438-567-1234.");
                phoneNumber.Clear();
                phoneNumber.Focus();
            }
        }

        private void comboProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            province.Text = comboProvince.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboProvince.Items.Add("SK");
            comboProvince.Items.Add("MB");
            comboProvince.Items.Add("AB");
            comboProvince.Items.Add("BC");
            comboProvince.Items.Add("NL");
            comboProvince.Items.Add("PE");
            comboProvince.Items.Add("NS");
            comboProvince.Items.Add("NB");
            comboProvince.Items.Add("QC");
            comboProvince.Items.Add("ON");
            comboProvince.Items.Add("NT");
            comboProvince.Items.Add("NU");
            comboProvince.Items.Add("YT");
        }

        private void province_TextChanged(object sender, EventArgs e)
        {
            comboProvince.Text = province.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First Name: " + firstName.Text + "\nLast Name: " + lastName.Text +
                "\nAddress: " + address.Text + "\nCity: " + city.Text + "\nProvince: " +
                province.Text + "\nPostal Code: " + postalCode.Text + "\nPhone Number: " +
                phoneNumber.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the Application? ",
               "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}
