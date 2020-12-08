    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHandel
{
    class Program
    {
        static void Main(string[] args)
        {
            AppManager.DisplayMenu();

            ShoppingCart[] MyCart = new ShoppingCart[5];

            ShoppingCart prod1 = new ShoppingCart();
            prod1.Quantity = 1;
            ShoppingCart prod2 = new ShoppingCart();
            prod2.Quantity = 1;
            ShoppingCart prod3 = new ShoppingCart();
            prod3.Quantity = 1;
            ShoppingCart prod4 = new ShoppingCart();
            prod4.Quantity = 1;
            ShoppingCart prod5 = new ShoppingCart();
            prod5.Quantity = 1;

            MyCart[0] = prod1;
            MyCart[1] = prod2;
            MyCart[2] = prod3;
            MyCart[3] = prod4;
            MyCart[4] = prod5;

            ShoppingCart prod6 = new ShoppingCart();
            prod6.Quantity = 1;
            MyCart = AddProductToCart(MyCart, prod6);
            MyCart[5] = prod6;
        }

        static ShoppingCart[] AddProductToCart(ShoppingCart[] Cart, ShoppingCart Cart1)
        {
            ShoppingCart[] NewCart = new ShoppingCart[Cart.Length + 1];
            for (int i = 0; i < Cart.Length; i++)
            {
                NewCart[i] = Cart[i];
            }
            NewCart[NewCart.Length - 1] = Cart1;
            return NewCart;
        }
    }
}
