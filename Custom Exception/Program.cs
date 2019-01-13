using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                throw new UserAlreadyLoggedInException("User is logged in -no duplicate session allowed");
            }
            catch(UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

    public class UserAlreadyLoggedInException : Exception
    {

        public UserAlreadyLoggedInException() :base()
        {


        }

        public UserAlreadyLoggedInException(string message): base(message)
        {

        } 
    }
}
