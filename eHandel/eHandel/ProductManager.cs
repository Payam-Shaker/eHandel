using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHandel
{
    class ProductManager
    {
        Products[] ArrayOfProducts = new Products[5];

        public Products[] BasicProducts()
        {
            //Products Header = new Products();
            ArrayOfProducts[0] = new Products(1, "Canada Goose", "En varm vinterjacka.", 9999.00);
            ArrayOfProducts[1] = new Products(2, "Air Max Pro X", "Snabba skor för den som tränar!", 1299.00);
            ArrayOfProducts[2] = new Products(3, "G-Star Warp", "Stilrena byxor för den modemedvetna.", 1899.00);
            ArrayOfProducts[3] = new Products(4, "Hilfiger Star", "Snyggare T-Shirt är svårare att hitta.", 1099.00);
            ArrayOfProducts[4] = new Products(5, "Gant Hoodie", "För värme och komfort.", 1400.00);

            return ArrayOfProducts;
        }
    }
}
