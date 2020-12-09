using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHandel
{
    class ProductManager
    {
       
        public ProductManager() { }

        public void CreateObjekt() 
        {
            Product OneObjekt = new Product();
        }


        public void CreateObjects() 
        {
            Product Header = new Product();

            Product Jacka = new Product(1, "Canada Goose ", "En varm vinterjacka", 9999.00);

            Product Skor = new Product(2, "Air Max Pro X", "Snabba skor perfekt för den som tränar", 1299.00);

            Product Byxor = new Product(3, "G-star warp  ", "Stilrena byxor för den mode-medvetna", 1899.00);

            Product Tshirt = new Product(4, "Hilfiger Star", "Snyggare T-shirt är svår att hitta", 1099.00);

            Product Hoodie = new Product(5, "Gant Blue    ", "För värme och komfort", 1400.00);

            Console.Clear();
            Header.PrintProductLayout();

            Jacka.PrintObjects();
            Skor.PrintObjects();
            Byxor.PrintObjects();
            Tshirt.PrintObjects();
            Hoodie.PrintObjects();

            Console.WriteLine("");
        }
    }
}
