using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace strategy_design_pattern
{
    public class PayByPaypal : IPayStrategy
    {
        private string emailAddress;
        private string password;
        private bool isSignedIn;
        public void collectDetails()
        {
            try
            {
                while (!isSignedIn)
                {
                    Console.Write("email: ");
                    var currentEmailAddress = Console.ReadLine();
                    emailAddress = Convert.ToString(currentEmailAddress);
                    Console.Write("password: ");
                    var currentpassword = Console.ReadLine();
                    password = Convert.ToString(currentpassword);
                    Console.WriteLine("Your data is: password {0} for username {1}", password, emailAddress);
                    setSignedIn(true);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
        private void setSignedIn(bool signedIn)
        {
            isSignedIn = signedIn;
        }


        public bool pay(int amount)
        {
          

            if (isSignedIn)
            {
                Console.WriteLine("User paid {0}", amount);
                return true;
            }
            Console.WriteLine("User is not signed in, he couldn't pay {0}", amount);
            return false;

        }
    }
}
