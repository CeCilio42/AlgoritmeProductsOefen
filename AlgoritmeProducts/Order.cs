using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmeProducts
{
    public class Order
    {
        List<Product> products;


        

        public Order()
        {
            products = new List<Product>();
        }

        public string AddProducts(Product product)
        {
            products.Add(product);

            Product firstProduct = products[0];
            return($"Price: {firstProduct.price}");
        }


        public string GiveAvgPrice() 
        {
            if (products.Count == 0)
            {
                return "No products in the order.";
            }

            double totalPrice = 0;

            foreach (Product product in products)
            {
                totalPrice += product.price;
            }

            double averagePrice = totalPrice / products.Count;
            return(averagePrice.ToString());
        }

        public string GiveMaxPrice()
        {
            if (products.Count == 0)
            {
                return "No products in the order.";
            }

            double maxPrice = double.MinValue; 

            foreach (Product product in products)
            {
                if (product.price > maxPrice)
                {
                    maxPrice = product.price;
                }
            }

            return maxPrice.ToString();
        }


        public string SortProducts()
        {
            if (products.Count == 0)
            {
                return "No products in the order.";
            }

            
            var sortedProducts = products.OrderByDescending(p => p.price);

            
            string sortedPrices = string.Join(", ", sortedProducts.Select(p => p.price.ToString()));

            return sortedPrices;
        }
    }
}
