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
            loadProducts(listBox1);
        }

        private static void loadProducts(ListBox listbox)
        {
            string url = "http://20.234.113.211:8100/";
            string key = "1-67944b35-32ec-4185-83f1-22018c9a1ed1";

            Api proxy = new Api(url, key);

            // find all categories in the store
            ApiResponse<List<ProductDTO>> response = proxy.ProductsFindAll();

            listbox.DataSource = response.Content.ToList();
            listbox.DisplayMember = "ProductName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "http://20.234.113.211:8100/";
            string key = "1-67944b35-32ec-4185-83f1-22018c9a1ed1";

            Api proxy = new Api(url, key);

            // find all categories in the store
            ApiResponse<List<ProductDTO>> response = proxy.ProductsFindAll();

            var matches = response.Content.Where(r => r.ProductName.Contains(textBoxName.Text) && r.Sku.Contains(textBoxSKU.Text));
            listBox1.DataSource = matches.ToList();
            listBox1.DisplayMember = "ProductName";
        }
    }
}
