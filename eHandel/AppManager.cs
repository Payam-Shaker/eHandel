using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHandel
{
    public class AppManager
    {
        public static Product1 product = new Product1();

        public static void DisplayMenu()
        {
            Console.Title = "eCommerce Squad";
            Console.WriteLine("Welcome to eCommerce Squads Online Shop.");
            Console.WriteLine("");
            Console.WriteLine("[1]Show all the products.");
            Console.WriteLine("[2]Show one specific product.");
            Console.WriteLine("[3]Show the shopping cart.");
            Console.WriteLine("[4]Add your name and adress to your profile.");
            Console.WriteLine("[5]Make the order.");
            Console.WriteLine("[0]Exit the online shop.");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Pick one option:");
            string Input = Console.ReadLine();

            if (Input == "1")
            {
                product.GetAllProducts();
                //Visa alla produkter
            }
            else if (Input == "2")
            {
                Console.WriteLine("Please enter the number of the product: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                product.GetProductById(userInput);
                //Visa en specifik produkt
            }
            else if (Input == "3")
            {
                //Visa kundvagnen
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
                AppManager.DisplayMenu();
            }

        }
    }
}
