using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaPage
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        float GetselectedSizePrice()
        {
            if (radioSmall.Checked)
            {
                return Convert.ToSingle(radioSmall.Tag);
            }
            else if (radioMedium.Checked)
            {
                return Convert.ToSingle(radioMedium.Tag);
            }
            else if (radioLarge.Checked)
            {
                return Convert.ToSingle(radioLarge.Tag);
            }

            else return 0;
        }
        float GetselectedCrustPrice()
        {
            if (thinCrust.Checked)
            {
                return Convert.ToSingle(thinCrust.Tag);
            }
            else if (ThickCrust.Checked)
                return Convert.ToSingle(ThickCrust.Tag);
            else
                return 0;
        }
        float CalculateToppingsPrice()
        {
            float Toppings = 0;
            if (ExtraChesse.Checked)
            {
                Toppings += Convert.ToSingle(ExtraChesse.Tag);
            }
            if (Mushrooms.Checked)
            {
                Toppings += Convert.ToSingle(Mushrooms.Tag);
            }
            if (Tomatos.Checked)
            {
                Toppings += Convert.ToSingle(Tomatos.Tag);
            }
            if (Onion.Checked)
            {
                Toppings += Convert.ToSingle(Onion.Tag);
            }
            if (Olives.Checked)
            {
                Toppings += Convert.ToSingle(Olives.Tag);
            }
            if (Green_Peppers.Checked)
            {
                Toppings += Convert.ToSingle(Green_Peppers.Tag);
            }
            return Toppings;
        }
        float CalculateTotalPrice()
        {
           return GetselectedCrustPrice()+GetselectedSizePrice()+CalculateToppingsPrice(); 
        }


        void UpdateTotalPrice()
        {
            lblTotalPrice.Text = CalculateTotalPrice().ToString() + "$";
        }
        void UpdateSize()
        {
            UpdateTotalPrice();
            if (radioSmall.Checked)
            {
                LabelSize.Text = "Small";
            }
            else if (radioMedium.Checked)
            {
                LabelSize.Text = "Medium";
            }
            else if (radioLarge.Checked)
            {
                LabelSize.Text = "Large";
            }
        }
        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (thinCrust.Checked)
            {
                labelCrustType.Text = "Thin";
            }
            else
            {
                labelCrustType.Text = "Think";
            }

        }
        void UpdateWhereToEat()
        {
            if (EatIn.Checked)
            {
                labelWhereToEat.Text = "Eat In";
            }
            else
            {
                labelWhereToEat.Text = "Eat Out";
            }
        }
        void UpdateToppings()
        {
            string Topp = "";
            UpdateTotalPrice();
            if (ExtraChesse.Checked)
            {
                Topp += ", Extra Chess";
            }
            if (Mushrooms.Checked)
            {
                Topp += ", Mushrooms";
            }
            if (Tomatos.Checked)
            {
                Topp += ", Tomatos";
            }
            if (Onion.Checked)
            {
                Topp += ", Onion";
            }
            if (Olives.Checked)
            {
                Topp += ", Olives";
            }
            if (Green_Peppers.Checked)
            {
                Topp += ", Green Peppers";
            }
            if(Topp.StartsWith(", "))
            {
                Topp = Topp.Substring(1, Topp.Length - 1).Trim();
            }
            labelToppings.Text = Topp;
        }

        void LoadByDefault()
        {
            radioSmall.Checked = true;
            thinCrust.Checked = true;
            TakeOut.Checked = true;
        }

        void ResetPage()
        {
            //Reset Size
            radioSmall.Checked = true;
            radioMedium.Checked = false;
            radioLarge.Checked = false;
            //Reset Crust
            thinCrust.Checked = true;
            ThickCrust.Checked = false;
            //Reset Toppings
            ExtraChesse.Checked = false;
            Mushrooms.Checked = false;
            Tomatos.Checked = false;
            Onion.Checked = false;
            Olives.Checked = false;
            Green_Peppers.Checked = false;
            //Reset Where To Eat
            EatIn.Checked = false;
            TakeOut.Checked = true;
            //Reset Groups
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppingsChecks.Enabled = true;
            gbWhere_To_Eat.Enabled = true;
            //Reset Buttons
            btnOrderPizza.Enabled = true;
            //Reset Summary
            LabelSize.Text = "";
            labelToppings.Text = "";
            labelCrustType.Text = "";
            labelWhereToEat.Text = "";
            UpdateCrust();
            UpdateSize();
            UpdateWhereToEat();
           
        }

        private void OrderPizza_Click(object sender, EventArgs e)
                {
                    if (MessageBox.Show("Confirm Order?", "Pizza Store", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("Order Confirmed successfully", "Pizza Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnOrderPizza.Enabled = false;
                        gbSize.Enabled = false;
                        gbCrustType.Enabled = false;
                        gbWhere_To_Eat.Enabled = false;
                        gbToppingsChecks.Enabled = false;

                    }
                }

        private void radioSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void radioMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void radioLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void thinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void ThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void EatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void TakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void ExtraChess_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void Mushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void Tomatos_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void Onion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void Olives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void Green_Peppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void ResetForm_Click(object sender, EventArgs e)
        {
            ResetPage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadByDefault();
        }
    }
}
