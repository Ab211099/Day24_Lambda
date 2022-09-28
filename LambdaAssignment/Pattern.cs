﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    public class Pattern
    {
        public static Func<string, string> CheckFirstName = (firstName) =>
        {
            string pattern = "(^[^a-z][A-z]{1}[a-z]{2,}$)";
            if (Regex.IsMatch(firstName, pattern))
            {
                Console.WriteLine("entered name is valid");
                return firstName;
            }
            else
            {
                Console.WriteLine("Entered name is Invalid\n please give first character in capital and minimum 3 characters name");
            }
            return firstName;
        };
        public static Func<string, string> CheckLastName = (lastName) =>
        {
            string pattern = "^[A-Z][a-z]{3,}$";
            if (Regex.IsMatch(lastName, pattern))
            {
                Console.WriteLine("entered name is valid");
                return lastName;
            }
            else
            {
                Console.WriteLine("Entered name is Invalid\n Please enter first character of your lastname in capital and minimum 3 characters name");
            }
            return lastName;
        };
        public static Func<string, string> CheckEmail = (email) =>
        {
            string pattern = "^[0-9a-zA-Z]+([+#%&_.][a-zA-Z0-9]+)*[@][a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine("entered email is valid");
                
                return email;
            }
            else
            {
                Console.WriteLine("Entered email is not valid");
                
            }
            return email;
        };
        public static Func<string, string> CheckMobileNumber = (mobileNumber) =>
        {
            string pattern = "^91[ ][1-9][0-9]{9}$";
            if (Regex.IsMatch(mobileNumber, pattern))
            {
                Console.WriteLine("Mobile number is valid");               
                return mobileNumber;
            }
            else
            {
                Console.WriteLine("Entered mobile number is not valid");
                return mobileNumber;
            }
        };
        public static Func<string, string> CheckPassword = (password) =>
        {
            string pattern = "^[a-zA-Z0-9@$!%*#?&]{1,}[a-zA-Z0-9@$!%*#?&]{7,}$";
            if (Regex.IsMatch(password, pattern))
            {
                Console.WriteLine("Entered password is valid");
                return password;
            }
            else
            {
                Console.WriteLine("Entered password not valid. Try again!!");
                return password;
            }
        };
    }
}
