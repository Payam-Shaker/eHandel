using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHandel
{
    class AppManager
    {
        public static void DisplayMenu()    
        {
            Console.Title = "eCommerce Squad";

            MenuLayout myMenu = new MenuLayout();
            myMenu.DisplayMenuLayout();
            string Input = Console.ReadLine();

            if (Input == "1")
            {
                //Visa alla produkter
                Product OurProduct = new Product();
                OurProduct.PrintProducts();
            }
            else if (Input == "2")
            {
                //Visa en specifik produkt
                
            }
            else if (Input == "3")
            {
                //Visa kundvagnen
                //ShoppingCartAdd.CreateCart();
            }
            else if (Input == "4")
            {
                //Lägg till namn och adress till din profil före leverans
                Profile.AddInformation();
            }
            else if (Input == "5")
            {
                //Gör beställning
            }
            else if (Input == "0")
            {
                Environment.Exit(0);
            }
            else
            {
                /*Detta är en mindre sofistikerad lösning just nu, får se om vi kan göra något bättre här (tänker på .Sleep).
                 Om du fyller i något som inte är ett alternativ så kommer du få ett meddelande och systemet väntar 5 sekunder
                innan huvudmenyn återställer sig. .Thread.Sleep gör dock att hela programmet ej kommer att svara under tiden.
                
                 Inte särskilt snyggt, men det löser det. Kanske hade varit snyggare med en timer som räknar till t.ex. 5, 
                ska kika lite på det.*/
                Console.WriteLine("");
                Console.WriteLine("You have picked an invalid option, please select an existing one.");
                System.Threading.Thread.Sleep(5000);

                Console.Clear();
                DisplayMenu();
            }

        }

    }
}
