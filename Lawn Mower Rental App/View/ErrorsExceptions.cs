using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.View
{
    public class ErrorsExceptions
    {
        public static void CustomerFileNotFoundException()
        {
            Console.WriteLine("Customer file not found");
        }

        public static void LawnMowerFileNotFoundException()
        {
            Console.WriteLine("Lawn Mower file not found");
        }
    }
}
