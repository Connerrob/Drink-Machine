using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace DrinkMachineP6
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        //setting each text box to show the amount in stock before any button is pressed
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = colaStock.ToString();
            textBox3.Text = lemonStock.ToString();
            textBox4.Text = creamStock.ToString();
            textBox5.Text = rootbeerStock.ToString();
            textBox6.Text = grapeStock.ToString();
        }

        //setting amount of stock for each soda and the price
        int colaStock = 20;
        int lemonStock = 20;
        int creamStock = 20;
        int rootbeerStock = 20;
        int grapeStock = 20;
        decimal cola = 1, lemon = 1, cream = 1.50m, rootbeer = 1, grape = 1.50m, sodaSale, total = 0;


        //the button for the cola soda to update the amount in stock and get price to add to total
        private void button1_Click(object sender, EventArgs e)
        {
            //checking to see if still in stock
            if (colaStock > 0)
            {
                colaStock--;
                textBox2.Text = colaStock.ToString();
                sodaSale = cola;

                total += sodaSale;

                textBox1.Text = "$" + total.ToString();

            }
            //telling user it is out of stock when soda is not > 0
            else
            {
                textBox2.Text = "Out of stock";
            }
        }

        //the button for the lemon lime soda to update the amount in stock and get price to add to total
        private void button2_Click(object sender, EventArgs e)
        {
            if (lemonStock > 0)
            {
                lemonStock--;
                textBox3.Text = lemonStock.ToString();
                sodaSale = lemon;

                total += sodaSale;

                textBox1.Text = "$" + total.ToString();
            }
            else
            {
                textBox3.Text = "Out of stock";
            }
        }

        //the button for the cream soda to update the amount in stock and get price to add to total
        private void button3_Click(object sender, EventArgs e)
        {

            if (creamStock > 0)
            {
                creamStock--;
                textBox4.Text = creamStock.ToString();
                sodaSale = cream;

                total += cream;

                textBox1.Text = "$" + total.ToString();
            }
            else
            { 
                textBox4.Text = "Out of stock";
            }

        }
        //the button for the rootbeer to update the amount in stock and get price to add to total
        private void button4_Click(object sender, EventArgs e)
        {

            if (rootbeerStock > 0)
            {
                rootbeerStock--;
                textBox5.Text = rootbeerStock.ToString();
                sodaSale = rootbeer;

                total += sodaSale;

                textBox1.Text = "$" + total.ToString();
            }
            else
            {
                textBox5.Text = "Out of stock";
            }
        }

        //the button for the grape soda to update the amount in stock and get price to add to total
        private void button5_Click(object sender, EventArgs e)
        {

            if (grapeStock > 0)
            {
                grapeStock--;
                textBox6.Text = grapeStock.ToString();
                sodaSale = grape;

                total += sodaSale;

                textBox1.Text = "$" +total.ToString();
            }
            else
            {
                textBox6.Text = "Out of stock";
            }
        }
        //setting the exit button to close the app
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}