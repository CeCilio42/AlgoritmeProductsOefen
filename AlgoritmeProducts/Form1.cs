using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmeProducts
{
    public partial class Form1 : Form
    {
        Order order = new Order();

        Product product1 = new Product(1);
        Product product2 = new Product(2);
        Product product3 = new Product(3);
        Product product4 = new Product(4);

        public Form1()
        {
            InitializeComponent();
        }

        private void AddProductsToList()
        {
            if (checkBox1.Checked == true)
            {
                order.AddProducts(product1);
            }
            else if (checkBox2.Checked == true)
            {
                order.AddProducts(product2);
            }
            else if (checkBox3.Checked == true)
            {
                order.AddProducts(product3);
            }
            else { order.AddProducts(product4);}
            
        }


        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            AddProductsToList();
        }

        private void buttonAvgPrice_Click(object sender, EventArgs e)
        {
            //labelPrice.Text = order.GiveAvgPrice();
            listBoxResult.Items.Clear();
            listBoxResult.Items.Add(order.GiveAvgPrice());
        }

        private void buttonMaxPrice_Click(object sender, EventArgs e)
        {
            
            listBoxResult.Items.Clear();
            listBoxResult.Items.Add(order.GiveMaxPrice());
        }

        private void buttonSortAll_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear();
            listBoxResult.Items.Add(order.SortProducts());
        }
    }
}
