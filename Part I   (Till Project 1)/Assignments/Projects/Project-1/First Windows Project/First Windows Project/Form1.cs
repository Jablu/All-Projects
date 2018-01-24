using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Windows_Project
{
    public partial class Form1 : Form
    {

        public string Msg { get; set; }


        public Form1()
        {
            InitializeComponent();
           


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbN.Text = Msg;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt_Click(object sender, EventArgs e)

        {
            //Validation
            if (tbN.Text == "")
            {
                errorProvider1.SetError(tbN, "THIS CAN'T BE EMPTY");
            }
            else
            {
                errorProvider1.SetError(tbN, "");
            }

            string name, city, country, state,  gender;
            List<string> payment;
            string msg = "";

            name = tbN.Text;
            city = tbC.Text;
            state = tbS.Text;
            country = cbC.SelectedText;

            if (rbM.Checked)
            {
                gender = "Male";
            }
            else { gender = "Female"; }

            payment = new List<string>();
            if (cbCash.Checked)
                payment.Add("Cash");
            if (cbCard.Checked)
                payment.Add("Card");
            if (cbWallet.Checked)
                payment.Add("Wallet");

            msg += "Customer Details: \n";
            msg += "Name: " + name + "\n";
            msg += "City: " + city + "\n";
            msg += "State: " + state + "\n";
            msg += "Country: " + country + "\n";
            msg += "Gender: " + gender + "\n";
            foreach (var item in payment)
            {
                msg += item + "\t";
            }
            MessageBox.Show(msg);
        }

        private void btE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
