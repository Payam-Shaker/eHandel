using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHandel
{
    class Products : AppManager
    {
        //Instansvariabler för klasen Produkter.
        private int ProductID;
        private string ProduktName;
        private string ProduktInfo;
        private double ProduktPrice;




        public Products() { }

        // Konstruktor som tar emot 4st parametrar.
        public Products(int ProdID, string ProdName, string ProdInfo, double ProdPrice)
        {
            ProductID = ProdID;
            ProduktName = ProdName;
            ProduktInfo = ProdInfo;
            ProduktPrice = ProdPrice;

        }

        public static void PrintProducts()
        {
            // Skapar 6 olika objekt av klassen Produkter
            Products Header = new Products();

            Products Jacka = new Products(1, "Canada Goose ", "En varm vinterjacka", 9999.00);

            Products Skor = new Products(2, "Air Max Pro X", "Snabba skor perfekt för den som tränar", 1299.00);

            Products Byxor = new Products(3, "G-star warp  ", "Stilrena byxor för den mode-medvetna", 1899.00);

            Products Tshirt = new Products(4, "Hilfiger Star", "Snyggare T-shirt är svår att hitta", 1099.00);

            Products Hoodie = new Products(5, "Gant Blue    ", "För värme och komfort", 1400.00);


            // Skriver ut dessa samt Produktlayouten.
            // Krävs troligtvis bara en metod i en annan klass som heter tillexempel ProductHeader eller något i den stilen.

            Console.Clear();
            Header.PrintProductLayout();

            Jacka.PrintObjects();
            Skor.PrintObjects();
            Byxor.PrintObjects();
            Tshirt.PrintObjects();
            Hoodie.PrintObjects();

            Console.WriteLine("");

            Console.WriteLine("Press 0 to return to eCommerce Squads start menu");
            string input = Console.ReadLine();

            if (input == "0")
            {
                Console.Clear();
                DisplayMenu();
            }
        }

        // En produkt layout för produkterna.
        public void PrintProductLayout()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("| Product ID     |   Product Name                     |   Unit Price         |");
            Console.WriteLine("------------------------------------------------------------------------------");
        }

        // Metod som skriver ut varje enskilt objekt.
        public void PrintObjects()
        {

            Console.WriteLine($"| {ProductID}              |   {ProduktName}                    |  {ProduktPrice}                |");
            Console.WriteLine("------------------------------------------------------------------------------");

        }

        // Getters för varje enskild parameter som finns i produkterna.
        public int GetProdID()
        {
            return ProductID;
        }

        public string GetProdName()
        {
            return ProduktName;
        }

        public string GetProdInfo()
        {
            return ProduktInfo;
        }

        public double GetProdPrice()
        {
            return ProduktPrice;
        }


    }
}
