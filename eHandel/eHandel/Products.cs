using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHandel
{
    class Products
    {
        private int productID;
        private string productName;
        private string productInfo;
        private double productPrice;
        ProductManager myProdManager = new ProductManager();
        AppManager instance = new AppManager();

        public Products() { }

        public Products(int id, string name, string info, double price)
        {
            this.productID = id;
            this.productName = name;
            this.productInfo = info;
            this.productPrice = price;
        }

        public void PrintProducts()
        {
            Products[] OurProducts = new Products[5];

            OurProducts = myProdManager.BasicProducts();

            for(int i = 0; i < OurProducts.Length; i++)
            {
                OurProducts[i].PrintObjects();
            }
            
        }


        public void PrintProductLayout()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("| Product ID     |   Product Name                     |   Unit Price         |");
            Console.WriteLine("------------------------------------------------------------------------------");
        }

        public void PrintObjects()
        {
            Console.WriteLine($"| {GetProductID()}              |   {productName}                    |  {productPrice}                |");
            Console.WriteLine("------------------------------------------------------------------------------");
        }

        public void GetAllProducts()
        {
            Console.Clear();
            Products[] allProducts = myProdManager.BasicProducts();
            Console.WriteLine("Product ID \tProduct Name \t\t\tPrice");
            Console.WriteLine("---------------------------------------------------------");

            foreach (var p in allProducts)
            {
                Console.WriteLine(p.GetProductID() + "\t\t" + p.GetProductName() + "\t\t\t" + p.GetProductPrice() + " SEK");
            }
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("\n\n[1]Pick an item to view. \n[2]Add an item to your shopping cart. \n[3]View your shopping cart. \n[0]Return to main menu. \n\nPlease, pick an option.");

            string UserInput = Console.ReadLine();

            switch(UserInput)
            {
                case "1":
                    //Visa produkt
                    Console.WriteLine("\nWhich item would you like to view?");
                    string UserItem = Console.ReadLine();
                    int UserItemInt = Int32.Parse(UserItem);
                    Console.Clear();
                    GetProductById(UserItemInt);
                    break;
                case "2":
                    //Lägg till produkt i varukorg
                    break;
                case "3":
                    //Visa varukorg
                    break;
                case "0":
                    //Återvänd till huvudmeny
                    instance.RunProgram();
                    break;
            }
        }

        public void GetProductById(int id)
        {
            Products[] ProductById = myProdManager.BasicProducts();
            int i = id;

            Console.WriteLine("Product Name \t\tProduct Description \t\t\t\tPrice");
            Console.WriteLine("-----------------------------------------------------------------------------------");

            Console.WriteLine(ProductById[i-1].GetProductName() + "\t\t" + ProductById[i-1].GetProductInfo() + "\t\t" + ProductById[i-1].GetProductPrice());
            Console.WriteLine("-----------------------------------------------------------------------------------");

            Console.WriteLine("\n\n[1]Add item to your shopping cart. \n[2]Return to \"Show all items\". \n[0]Return to main menu. \n\nPlease, pick an option.");

            string UserInput = Console.ReadLine();

            switch(UserInput)
            {
                case "1":
                    //Lägg till vara i varukorg
                    break;
                case "2":
                    //Återvänd till visa alla produkter
                    Console.Clear();
                    GetAllProducts();
                    break;
                case "0":
                    //Återvänd till huvudmenyn
                    instance.RunProgram();
                    break;
            }
                
        }



        public int GetProductID()
        {
            return this.productID;
        }

        public string GetProductName()
        {
            return this.productName;
        }

        public string GetProductInfo()
        {
            return this.productInfo;
        }

        public double GetProductPrice()
        {
            return this.productPrice;
        }

    }
}
