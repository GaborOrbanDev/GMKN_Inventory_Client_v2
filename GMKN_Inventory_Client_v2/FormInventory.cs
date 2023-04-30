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
    }
}
