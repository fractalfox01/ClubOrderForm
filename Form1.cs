using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter10Ex7
{
    public partial class Form1 : Form
    {
        string item = "";
        int typeCount = 0;
        int sizeCount = 0;
        int colorCount = 0;
        int amountCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void lstSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeCount != 0)
            {
                DialogResult result = MessageBox.Show("Only One Type Allowed Per Order\nWould You Like To Clear The Current Order?","Error", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.lstSelected.Items.Clear();
                    typeCount = 0;
                    sizeCount = 0;
                    colorCount = 0;
                    amountCount = 0;
                }
                return;
            }
            item += "Type: " + this.cmbType.SelectedItem + "\n";
            this.lstSelected.Items.Add(item);
            item = "";
            typeCount++;
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sizeCount != 0)
            {
                MessageBox.Show("Only One Size Allowed Per Order", "Error");
                return;
            }
            item = "";
            item += "Size: " + this.cmbSize.SelectedItem + "\n";
            this.lstSelected.Items.Add(item);
            item = "";
            sizeCount++;
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (colorCount != 0)
            {
                MessageBox.Show("Only One Color Allowed Per Order", "Error");
                return;
            }
            item = "";
            item += "Color: " + this.cmbColor.SelectedItem + "\n";
            this.lstSelected.Items.Add(item);
            item = "";
            colorCount++;
        }

        private void cmbAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (amountCount != 0)
            {
                MessageBox.Show("Only One Amount Allowed Per Order", "Error");
                return;
            }
            item = "";
            item += "Size: " + this.cmbAmount.SelectedItem + "\n";
            this.lstSelected.Items.Add(item);
            item = "";
            amountCount++;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            string ordered = "";
            ordered = Convert.ToString(this.cmbType.SelectedItem) + Convert.ToString(this.cmbSize.SelectedItem) + Convert.ToString(this.cmbColor.SelectedItem) + Convert.ToString(this.cmbAmount.SelectedItem);
            MessageBox.Show(ordered);
        }
    }
}
