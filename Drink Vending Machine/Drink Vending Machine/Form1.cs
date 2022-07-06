using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drink_Vending_Machine
{
    struct Drink
    {
        public string drinkName;
        public double drinkCost;
        public int drinksLeft;
    }


    public partial class DrinkMachine : Form
    {
        double total = 0;

        const int SIZE = 5;
        Drink[] soda = new Drink[SIZE];

        public DrinkMachine()
        {
            InitializeComponent();
        }

        private void DrinkMachine_Load(object sender, EventArgs e)
        {
            // COLA DRINK

            soda[0].drinkName = "Cola";
            soda[0].drinkCost = 1;
            soda[0].drinksLeft = 20;

            // ROOT BEER DRINK

            soda[1].drinkName = "Root Beer";
            soda[1].drinkCost = 1;
            soda[1].drinksLeft = 20;

            // LEMON LIME SODA

            soda[2].drinkName = "Lemon Lime";
            soda[2].drinkCost = 1;
            soda[2].drinksLeft = 20;

            // GRAPE SODA

            soda[3].drinkName = "Grape Soda";
            soda[3].drinkCost = 1.50;
            soda[3].drinksLeft = 20;

            // CREAM SODA

            soda[4].drinkName = "Cream Soda";
            soda[4].drinkCost = 1.50;
            soda[4].drinksLeft = 20;
        }

        private void colaPic_Click(object sender, EventArgs e)
        {
         //   double total = 0;
            

            if (soda[0].drinksLeft <= 20 && soda[0].drinksLeft >= 1)
            {
                soda[0].drinksLeft = +soda[0].drinksLeft - 1;

                leftCLbl.Text = soda[0].drinksLeft.ToString();

                total += soda[0].drinkCost;

                //totalLbl.Text = total.ToString("c");
            }

            else
            {
                MessageBox.Show("Uh oh! Looks like we ran out of " + soda[0].drinkName + " drinks");
            }

            totalLbl.Text = total.ToString("c");
        }

        private void rootPic_Click(object sender, EventArgs e)
        {
           // int clicks;
           // double total = 0;
            //double sales = 0;

            if (soda[1].drinksLeft <= 20 && soda[1].drinksLeft >= 1)
            {
                soda[1].drinksLeft = +soda[1].drinksLeft - 1;

                leftRLbl.Text = soda[1].drinksLeft.ToString();

                total += soda[1].drinkCost;

                //totalLbl.Text = total.ToString("c");
            }

            else
            {
                MessageBox.Show("Uh oh! Looks like we ran out of " + soda[1].drinkName + " drinks");
            }

            totalLbl.Text = total.ToString("c");
        }

        private void lemonPic_Click(object sender, EventArgs e)
        {
           // int clicks;
            //double sales = 0;
           // double total = 0;

            if (soda[2].drinksLeft <= 20 && soda[2].drinksLeft >= 1)
            {
                soda[2].drinksLeft = +soda[2].drinksLeft - 1;

                leftLLbl.Text = soda[2].drinksLeft.ToString();

                total += soda[2].drinkCost;

                //total += sales;

                //grandtotal += total;
            }

            else
            {
                MessageBox.Show("Uh oh! Looks like we ran out of " + soda[2].drinkName + " drinks");
            }

            totalLbl.Text = total.ToString("c");
        }

        private void grapePic_Click(object sender, EventArgs e)
        {
            //int clicks;
            //double sales = 0;
            //double total = 0;

            if (soda[3].drinksLeft <= 20 && soda[3].drinksLeft >= 1)
            {
                soda[3].drinksLeft = +soda[3].drinksLeft - 1;

                leftGLbl.Text = soda[3].drinksLeft.ToString();

                // clicks = 20 - soda[3].drinksLeft;

                total += soda[3].drinkCost;

                //total += sales;

                // grandtotal += total;
            }

            else
            {
                MessageBox.Show("Uh oh! Looks like we ran out of " + soda[3].drinkName + " drinks");
            }

            totalLbl.Text = total.ToString("c");
        }

        private void creamSodaPic_Click(object sender, EventArgs e)
        {
            //double total = 0;
            //int clicks;
            //double sales = 0;

            if (soda[4].drinksLeft <= 20 && soda[4].drinksLeft >= 1)
            {
                soda[4].drinksLeft = +soda[4].drinksLeft - 1;

                leftCSLbl.Text = soda[4].drinksLeft.ToString();

                //clicks = 20 - soda[4].drinksLeft;

                total += soda[4].drinkCost;

                //total += sales;

                //totalLbl.Text = grandtotal.ToString("c");

                //grandtotal += total;
            }

            else
            {
                MessageBox.Show("Uh oh! Looks like we ran out of " + soda[4].drinkName + " drinks");
            }

            totalLbl.Text = total.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
