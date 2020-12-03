using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHandel
{
    class Profile
    {

        private static string firstName;
        private static string lastName;
        private static string deliveryAdress;


        public static void AddInformation()
        {
            /*Följande kod ber kund fylla i förnamn, efternamn, och leveransadress. Värdena sparas i tre privata variabler.*/
            Console.Clear();
            Console.WriteLine("Add information to your customer profile.");
            Console.WriteLine("");

            Console.WriteLine("What is your first name?");
            SetFirstName(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("What is your last name?");
            SetLastName(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("What is the delivery adress?");
            SetDeliveryAdress(Console.ReadLine());


            /*Ber kund dubbelkolla den ifyllda informationen. Om den är korrekt fyller kund i "Yes" och kan därefter återgå till
             huvudmenyn. Fyller kund i "No" (eller valrfritt annat just nu) så får kund fylla i informationen på nytt.*/
            Console.Clear();
            Console.WriteLine("You have entered the following: ");
            Console.WriteLine("First name: " + GetFirstName());
            Console.WriteLine("Last name: " + GetLastName());
            Console.WriteLine("Delivery adress: " + GetDeliveryAdress());

            Console.WriteLine("");
            Console.WriteLine("Is the delivert information correct (Yes or no)?");
            string input = Console.ReadLine();

            if (input == "Yes")
            {
                Console.Clear();
                AppManager.DisplayMenu();
            }
            else
            {
                Console.Clear();
                Profile.AddInformation();
            }
        }


        /*Getters och setters för de privata variablerna som innehåller namn och leveransadress.*/
        private static void SetFirstName(string _firstName)
        {
            firstName = _firstName;
        }

        private static void SetLastName(string _lastName)
        {
            lastName = _lastName;
        }

        private static void SetDeliveryAdress(string _deliveryAdress)
        {
            deliveryAdress = _deliveryAdress;
        }

        public static string GetFirstName()
        {
            return firstName;
        }

        public static string GetLastName()
        {
            return lastName;
        }

        public static string GetDeliveryAdress()
        {
            return deliveryAdress;
        }
    }
}
