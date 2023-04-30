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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static void loadProducts(ListBox listbox)
        {
            string url = "http://20.234.113.211:8100/";
            string key = "1-67944b35-32ec-4185-83f1-22018c9a1ed1";

            Api proxy = new Api(url, key);

            // find all categories in the store
            try
            {
                ApiResponse<List<ProductDTO>> response = proxy.ProductsFindAll();

                listbox.DataSource = response.Content.ToList();
                listbox.DisplayMember = "ProductName";
            }
            catch (Exception ex)
            {

                if(DialogResult.Retry == MessageBox.Show(ex.Message, "Hiba történt az adatok betöltésekor", MessageBoxButtons.RetryCancel))
                {
                    loadProducts(listbox);
                }
                else
                {
                    Application.Exit();
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndexChanged -= listBox1_SelectedIndexChanged;
            string url = "http://20.234.113.211:8100/";
            string key = "1-67944b35-32ec-4185-83f1-22018c9a1ed1";

            Api proxy = new Api(url, key);

            // find all categories in the store
            ApiResponse<List<ProductDTO>> response = proxy.ProductsFindAll();

            var matches = response.Content.Where(r => r.ProductName.Contains(textBoxName.Text) && r.Sku.Contains(textBoxSKU.Text));
            listBox1.DataSource = matches.ToList();
            listBox1.DisplayMember = "ProductName";
            listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndexChanged -= listBox1_SelectedIndexChanged;
            loadProducts(listBox1);
            listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductDTO product = (ProductDTO)listBox1.SelectedItem;

            FormInventory form = new FormInventory(product.Bvin, product.ProductName);
            if(DialogResult.OK == form.ShowDialog())
            {
                MessageBox.Show($"{product.ProductName} sikeressen frissítve");
            }
        }
    }
}
