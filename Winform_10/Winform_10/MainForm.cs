using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_10
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            ItemsDataGridView.Rows.Add("Item1", "Item2", "Item3");
        }

        private void AddSupplierButton_Click(object sender, EventArgs e)
        {
            SuppliersDataGridView.Rows.Add("Supplier1", "Supplier2", "Supplier3");
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            OrdersDataGridView.Rows.Add("Order1", "Order2", "Order3");
        }
    }
}
