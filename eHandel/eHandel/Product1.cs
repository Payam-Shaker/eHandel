using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHandel
{
    class Product1 : Product
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        //en array av 5 element 
        Product1[] products = new Product1[5];
        //en metod för att fylla in products array med Dummy Data!
        public Product1[] InitializeArrayOfProducts()
        {
            Product1 prod1 = new Product1();
            prod1.Id = 1;
            prod1.Name = "Jeans";
            prod1.Description = "bla balaaa";
            prod1.Price = 400;

            Product1 prod2 = new Product1();
            prod2.Id = 2;
            prod2.Name = "T-Shirt";
            prod2.Description = "blaAA balaaa";
            prod2.Price = 250;

            Product1 prod3 = new Product1();
            prod3.Id = 3;
            prod3.Name = "Hat";
            prod3.Description = "blaaaaa balaaa";
            prod3.Price = 200;

            Product1 prod4 = new Product1();
            prod4.Id = 4;
            prod4.Name = "Short";
            prod4.Description = "blaaaa balaaaaa";
            prod4.Price = 300;

            Product1 prod5 = new Product1();
            prod5.Id = 5;
            prod5.Name = "Shoes";
            prod5.Description = "blaaa baalaaaa";
            prod5.Price = 700;

            products[0] = prod1;
            products[1] = prod2;
            products[2] = prod3;
            products[3] = prod4;
            products[4] = prod5;
            return products;
        }

        //metoden skapar en ny array enligt dummy data i InitializeArrayOfProducts och returnerar alla produkter genom foreach loop
        public void GetAllProducts()
        {
            Product1[] allProducts = InitializeArrayOfProducts();
            Console.WriteLine("\tName \tDescription \tPrice");

            foreach (var p in allProducts)
            {
                Console.WriteLine(p.Id + "\t" + p.Name + "\t" + p.Description + "\t" + p.Price + "SEK");
            }

        }
        //metoden skapar en ny array enligt dummy data i InitializeArrayOfProducts och returnerar en viss produkt 
        //Paramtren int id är userInput från Appmanager
        public void GetProductById(int id)
        {
            Product1[] productById = InitializeArrayOfProducts();
            int i = id;
            Console.WriteLine("Name \tDescription \tPrice");
            Console.WriteLine("*********************************");



            Console.WriteLine(productById[i - 1].Name + "\t" + productById[i - 1].Description + "\t" + productById[i - 1].Price + " SEK");




        }
    }
}
