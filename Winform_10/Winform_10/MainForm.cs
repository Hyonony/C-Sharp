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

            // ItemsDataGridView에 열(Column) 추가
            ItemsDataGridView.Columns.Add("Column1", "Header1");
            ItemsDataGridView.Columns.Add("Column2", "Header2");
            ItemsDataGridView.Columns.Add("Column3", "Header3");

            // SuppliersDataGridView에 열(Column) 추가
            SuppliersDataGridView.Columns.Add("Column1", "Header1");
            SuppliersDataGridView.Columns.Add("Column2", "Header2");
            SuppliersDataGridView.Columns.Add("Column3", "Header3");

            // OrdersDataGridView에 열(Column) 추가
            OrdersDataGridView.Columns.Add("Column1", "Header1");
            OrdersDataGridView.Columns.Add("Column2", "Header2");
            OrdersDataGridView.Columns.Add("Column3", "Header3");
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