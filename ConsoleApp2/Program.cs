using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Products
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.name = "Nail Polish";
            product1.color = "Red";
            product1.quantity = 5;

            Product product2 = new Product();
            product2.name = "Hair Dye";
            product2.color = "Black";
            product2.quantity = 10;

            Product product3 = new Product();
            product3.name = "Bronzer";
            product3.color = "Dark";
            product3.quantity = 15;

   
            Product[] products = new Product[] { product1, product2, product3 };
            foreach (Product product in products)
            {
                Console.WriteLine(product.name+ ":" + product.color+ ":" + product.quantity);
            }

            Console.WriteLine("End of the foreach");

                for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].name +" " + products[i].color + " "  + products[i].quantity+ " " );
            }

            Console.WriteLine("End of the second for loop.");

            int j = 0;
            while (j < products.Length)
            {
                Console.WriteLine(products[j].name + " " + products[j].color + " " + products[j].quantity + " ");
                j++;
            }

            Console.WriteLine("End of the while loop.");
            Console.ReadKey();
        }

    }

    class Product
    { 
        public string name { get; set; }
        public string color { get; set; }
        public int quantity { get; set; }
    }
}
    


