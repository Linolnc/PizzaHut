using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PizzaHut
{
    public partial class Form1 : Form
    {
        double sliceRate = 9.00;
        double saladRate = 6.00;
        double cookieRate = 3.00;
        double slices;
        double salad;
        double cookie;
        double preTax;
        double postTax; 
        public Form1()
        {
            InitializeComponent();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                slices = Convert.ToDouble(IMPUT.Text);
                 salad = Convert.ToDouble(textBox1.Text);
                 cookie = Convert.ToDouble(textBox2.Text);
                double taxRate = .13;
                //calculate totals
                 preTax = sliceRate * slices + saladRate * salad + cookieRate * cookie;
                 postTax = preTax * taxRate + preTax;

                pretax.Text = pretax.Text + preTax;
                AfterTax.Text = AfterTax.Text + postTax;
            }
            catch
            {

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            receiptBox.Text = "Thank you for shoppping at Pizza Place";
            Refresh();
            Thread.Sleep(400);

            receiptBox.Text += $"\n# of slices: {slices}";
            Refresh();
            Thread.Sleep(400);

            receiptBox.Text += $"\n# of salads: {salad}";
            Refresh();
            Thread.Sleep(400);

            receiptBox.Text += $"\n# of cookies:{cookie} ";
            Refresh();
            Thread.Sleep(400);

            receiptBox.Text += $"\nPrice before tax: ${preTax}";
            Refresh();
            Thread.Sleep(400);

            receiptBox.Text += $"\nPrice after tax: ${postTax}";
            Refresh();
            Thread.Sleep(400);

            receiptBox.Text += "\n\nHave a nice day :3";
            Refresh();
            Thread.Sleep(20000);

            receiptBox.Text = "You can uh,,, Leave now yknow..";
            Refresh();
            Thread.Sleep(20000);

            receiptBox.Text += "\n Seriously? YOU are STILL around?! What are you even doing? Marking?";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void receiptBox_Click(object sender, EventArgs e)
        {

        }
    }
}
