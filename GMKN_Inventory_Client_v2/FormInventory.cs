using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotcakes.CommerceDTO.v1.Client;

namespace GMKN_Inventory_Client_v2
{
    public partial class FormInventory : Form
    {
        public string bvin;

        public FormInventory(string bvin_v, string productName_v)
        {
            InitializeComponent();
            this.bvin = bvin_v;
            Console.WriteLine(bvin);

            string url = "http://20.234.113.211:8100/";
            string key = "1-67944b35-32ec-4185-83f1-22018c9a1ed1";

            Api proxy = new Api(url, key); 

            // find all categories in the store
            var response = proxy.ProductInventoryFindForProduct(bvin_v);

            label_name.Text = productName_v;
            label_qoh.Text = response.Content[0].QuantityOnHand.ToString();
            label_qr.Text = response.Content[0].QuantityReserved.ToString();
            label_lsp.Text = response.Content[0].LowStockPoint.ToString();
            label_osp.Text = response.Content[0].OutOfStockPoint.ToString();
        }

        bool check_error()
        {
            bool hasErrors = false;

            foreach (Control control in groupBox1.Controls)
            {
                //Console.WriteLine($"Hiba: {errorProvider1.GetError(control)}");
                if (errorProvider1.GetError(control) != string.Empty)
                {
                    
                    hasErrors = true;
                    break;
                }
            }

            if (!hasErrors)
            {
                btn_save.Enabled = true;
            }
            return hasErrors;
        }

        void handel_change(Label targetLabel, TextBox textBox, bool allow_minus, bool add)
        {
            if (allow_minus == false && add)
            {
                try
                {
                    int v = int.Parse(textBox.Text);
                    if (int.Parse(targetLabel.Text) + v >= 0)
                        targetLabel.Text = $"{int.Parse(targetLabel.Text) + v}";
                    else
                        throw new Exception("Kisebb mint 0");
                    errorProvider1.SetError(textBox, string.Empty);
                    check_error();
                }
                catch (Exception)
                {
                    errorProvider1.SetError(textBox, "Hibás érték");
                    btn_save.Enabled = false;
                }
            }
            else if (allow_minus && add)
            {
                try
                {
                    int v = int.Parse(textBox.Text);
                    targetLabel.Text = $"{int.Parse(targetLabel.Text) + v}";
                    errorProvider1.SetError(textBox, string.Empty);
                    check_error();
                }
                catch (Exception)
                {
                    errorProvider1.SetError(textBox, "Hibás érték");
                    btn_save.Enabled = false;
                }
            }
            else if (allow_minus && add == false)
            {
                try
                {
                    int v = int.Parse(textBox.Text);
                    targetLabel.Text = $"{int.Parse(targetLabel.Text) - v}";
                    errorProvider1.SetError(textBox, string.Empty);
                    check_error();
                }
                catch (Exception)
                {
                    errorProvider1.SetError(textBox, "Hibás érték");
                    btn_save.Enabled = false;
                }
            }
            else if (allow_minus == false && add == false)
            {
                try
                {
                    int v = int.Parse(textBox.Text);
                    if (int.Parse(targetLabel.Text) - v >= 0)
                        targetLabel.Text = $"{int.Parse(targetLabel.Text) - v}";
                    else
                        throw new Exception("Kisebb mint 0");
                    errorProvider1.SetError(textBox, string.Empty);
                    check_error();
                }
                catch (Exception)
                {
                    errorProvider1.SetError(textBox, "Hibás érték");
                    btn_save.Enabled = false;
                }
            }
            
        }

        private void quatity_add_Click(object sender, EventArgs e)
        {
            handel_change(label_qoh, textBox1, false, true);
        }

        private void reserved_add_Click(object sender, EventArgs e)
        {
            handel_change(label_qr, textBox2, false, true);
        }

        private void low_add_Click(object sender, EventArgs e)
        {
            handel_change(label_lsp, textBox3, true, true);
        }

        private void out_add_Click(object sender, EventArgs e)
        {
            handel_change(label_osp, textBox4, true, true);
        }

        private void quantity_sub_Click(object sender, EventArgs e)
        {
            handel_change(label_qoh, textBox1, false, false);
        }

        private void reserved_sub_Click(object sender, EventArgs e)
        {
            handel_change(label_qr, textBox2, false, false);
        }

        private void low_sub_Click(object sender, EventArgs e)
        {
            handel_change(label_lsp, textBox3, true, false);
        }

        private void out_sub_Click(object sender, EventArgs e)
        {
            handel_change(label_osp, textBox4, true, false);
        }
    }
}
