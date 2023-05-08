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

        public ApiResponse<List<ProductDTO>> response { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        public void loadProducts(ListBox listbox)
        {
            string url = "http://20.234.113.211:8100/";
            string key = "1-67944b35-32ec-4185-83f1-22018c9a1ed1";

            Api proxy = new Api(url, key);

            try
            {
                response = proxy.ProductsFindAll();

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

            var matches = Filter(response.Content, textBoxName.Text, textBoxSKU.Text);
            listBox1.DataSource = matches.ToList();
            listBox1.DisplayMember = "ProductName";
            listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);
        }

        public List<ProductDTO> Filter(IEnumerable<ProductDTO> products, string name, string sku)
        { 
            return products.Where(r => r.ProductName.Contains(name) && r.Sku.Contains(sku)).ToList();
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
                MessageBox.Show($"{product.ProductName} sikeresen frissítve");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult.Cancel == MessageBox.Show("Bizotos, hogy be akarja zárni az alkalmazást?", "Üzenet", MessageBoxButtons.OKCancel))
            {
                e.Cancel = true;
            }
        }
    }
}
