using System.Text.RegularExpressions;


//Email

//namespace MySpace
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter email:");
//            string mail;
//            mail = Console.ReadLine();
//            var result = Regex.Match(mail, "[a-zA-Z0-9+-_~-]+[@]+[itstep.ua]+");

//            Console.WriteLine(result.Success);
//        }
//    }
//}

//Phone number

//namespace MySpace
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Ukrainian phone number:");
//            string tel;
//            tel = Console.ReadLine();
//            var result = Regex.Match(tel, "^[\\+][3][8][0][0-9]{9}$");

//            Console.WriteLine(result.Success);
//        }
//    }
//}


//Password

using System;
using System.Text.RegularExpressions;

namespace MySpace
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter password\nRequirements:\n- Minimum of 8 characters.\n- At least one capital letter.");
            Console.WriteLine("- Minimum is one small letter.\n- At least one digit.\n- At least one special character (!, @, #, $, %) :"); 
            string pass = Console.ReadLine();
            var result = Regex.Match(pass, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[!@#$%])[A-Za-z\\d!@#$%]{8,}$");

            Console.WriteLine(result.Success);
        }
    }
}
