using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)

                return Convert.ToSingle(rbSmall.Tag);
         
            else  if (rbMedium.Checked)

                return Convert.ToSingle(rbMedium.Tag);

            else
               return Convert.ToSingle(rbLarge.Tag);

        }


        float GetSelectedToppingsPrice()
        {
            float TotalPrice=0;

            if (chkExtraChees.Checked)

                TotalPrice+= Convert.ToSingle(chkExtraChees.Tag);

            if (chkGreenPeppers.Checked)

                TotalPrice += Convert.ToSingle(chkGreenPeppers.Tag);

            if (chkMshrooms.Checked)

                TotalPrice += Convert.ToSingle(chkMshrooms.Tag);

            if (chkOlives.Checked)

                TotalPrice += Convert.ToSingle(chkOlives.Tag);

            if (chkOnion.Checked)

                TotalPrice += Convert.ToSingle(chkOnion.Tag);

            if (chkTomatoes.Checked)

                TotalPrice += Convert.ToSingle(chkTomatoes.Tag);

            return TotalPrice;
        }

        float GetSelectedCrustTypePrice()
        {
            if (rbThinCrust.Checked)
            {
                return Convert.ToSingle(rbThinCrust.Tag);
            }


            else if (rbThickCrust.Checked)

                return Convert.ToSingle(rbThickCrust.Tag);

            else
                return Convert.ToSingle(0);
        }

        void UpdateCrustType()
        {
            UpdateTotalPrice();

            if (rbThinCrust.Checked)

                lblCrystType.Text = "Thin Crust";

             if (rbThickCrust.Checked)

                lblCrystType.Text = "Thick Crust";

        }


            void UpdateToppings()
        {
            UpdateTotalPrice();

            string AllToppings = "";

            if (chkExtraChees.Checked)
            {
                AllToppings += "Extra Chees, ";
            }

            if (chkOnion.Checked)
            {
                AllToppings += "Onion, ";
            }

            if (chkMshrooms.Checked)
            {
                AllToppings += "Mshrooms, ";
            }

            if (chkOlives.Checked)
            {
                AllToppings += "Olives, ";
            }

            if (chkTomatoes.Checked)
            {
                AllToppings += "Tomatoes, ";
            }

            if (chkGreenPeppers.Checked)
            {
                AllToppings += "Green Peppers, ";
            }

            if (AllToppings.StartsWith(","))
            {
                AllToppings = AllToppings.Substring(1, AllToppings.Length - 1).Trim();
            }

            if (AllToppings == "")
            {
                AllToppings = "No Toppings";
                lblToppings.Text = AllToppings;
            }
            else

                lblToppings.Text = AllToppings;
        }

        float ClculateTotalPrice()
        {
          return   GetSelectedSizePrice() + GetSelectedToppingsPrice() +
                GetSelectedCrustTypePrice();

        }


        void UpdateTotalPrice()
        {

            lblTotalPrice.Text =" $ "+ ClculateTotalPrice().ToString();

        }



        void UpdateSize()
        {
              UpdateTotalPrice();
            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }


            if (rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                return;
            }

            if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }

            else
            {
                lblSize.Text = "Medium";
                return;

            }
               

        }

        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
                lblWhereToEat.Text = "Eat In";

            else if(rbEatOut.Checked)
                lblWhereToEat.Text = "Eat Out";

            else
            {
                lblWhereToEat.Text = "Eat Out";

            }

        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void RadioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void LbWhereToEat_Click(object sender, EventArgs e)
        {

        }

        private void RbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void RbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();

        }
      
        private void RbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void RbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void GbSize_Enter(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Pizza Order";

            UpdateToppings();
            UpdateSize();
            UpdateCrustType();
            UpdateWhereToEat();
            UpdateTotalPrice();


        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ChkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void ChkMshrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void ChkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void ChkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void ChkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void RbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void BtnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order", "Confirm",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnOrderPizza.Enabled = false;
                gbSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;


            }

            else
                MessageBox.Show("Update Your Order ", "Update",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void BtnResetForm_Click(object sender, EventArgs e)
        {
            btnOrderPizza.Enabled = true;

            //reset Toppings
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;

            //reset Size
          
            rbMedium.Checked = true;
            

            //reset Crust Type
            rbThickCrust.Checked = true;
           

            //reset Where to Eat
            rbEatIn.Checked = true;
            

            //reset Toppings
            chkExtraChees.Checked = false;
            chkGreenPeppers.Checked = false;
            chkMshrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;



        }

        private void GbToppings_Enter(object sender, EventArgs e)
        {

        }

        private void LbCrustType_Click(object sender, EventArgs e)
        {

        }

        private void LbSize_Click(object sender, EventArgs e)
        {

        }

        private void LbToppings_Click(object sender, EventArgs e)
        {

        }
    }
}
