using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Name: Joseph Appiah
//Index: 00490112
//Program: ISS (L-200)Evening
 
namespace Point_of_Sell_POS_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal total =0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int qty = 0;
            if (cboItems.SelectedIndex == -1)
        {
                MessageBox.Show("No Item Selected!!!!!");
                cboItems.Focus();
                return;

        }

            if (!string.IsNullOrEmpty(txtQty.Text))
       {

                try
       {
                    qty = int.Parse(txtQty.Text);
                    total = total + decimal.Parse((2.5 * qty) + "");
                    txtDue.Text = total.ToString();


       }
                catch (Exception eex)
       {
                    MessageBox.Show("Invalid Quantity",
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(eex.Message + " occurred in btnAddtoCart");
                    return;
       }
       }

            else if (string.IsNullOrEmpty(txtQty.Text))
       {
                 MessageBox.Show("Please Input Quantity!!!!!");
                txtQty.Focus();
                return;

       }
            //calculation of items selected and quantities entered
            string item = cboItems.Text;
            decimal price = 2.5m;

            decimal ExtPrice = price * qty;

            string[] cartline = {
                                     item, 
                                     price.ToString("F2"),
                                     qty.ToString(),
                                     ExtPrice.ToString("F2")
                                 };
            dataGridView1.Rows.Add(cartline);

            //function call
            ClearEntry();
        }
        
        
   //furnction to clear selection and quantity entered
        private void ClearEntry()
        {
            cboItems.SelectedIndex = -1;
            txtQty.Text = "";
        }

        private void txtDue_TextChanged(object sender, EventArgs e)
        {
            try
        {
                int qty = int.Parse(txtQty.Text);
                string item = cboItems.Text;
                decimal price = 2.5m;
                decimal ExtPrice = price * qty;
        }

            catch (Exception xx)
        {
                MessageBox.Show("Invalid Entry!!!!!");
        }
        }

        private void btnFinish_Click_1(object sender, EventArgs e)
        {

            //amount entered by user for payment of price due
            decimal paid = decimal.Parse((txtPaid.Text) + "");
            if (paid >= total)
        {
                //change to been given to customer after payment
                decimal change = paid - total;
                txtChange.Text = change.ToString();
                MessageBox.Show("Successful Transaction!! Printing Receipt...");
        }
            else
        {
                // if payment is lower than the amount due for items purchase
                MessageBox.Show("Amount paid is below the due amount");

        }
        }

       private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        
        

        
        
    }
}
