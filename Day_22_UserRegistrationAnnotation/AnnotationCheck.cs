using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Day_22_UserRegistrationAnnotation
{
    public class AnnotationCheck
    {
        public static void Display()
        {
            Console.Write("Enter First name: ");
            string Fname = Console.ReadLine();
            Console.Write("Enter Last name: ");
            string Lname = Console.ReadLine();
            Console.Write("Enter email address: ");
            string Email = Console.ReadLine();
            Console.Write("Enter Phone number: ");
            string number = Console.ReadLine();
            Console.Write("Enter password: ");
            string pass = Console.ReadLine();


            UserRegistration obj = new UserRegistration();
            obj.firstName = Fname;
            obj.lastName = Lname;
            obj.email = Email;
            obj.phoneNumber = number;
            obj.password = pass;

            ValidationContext context = new ValidationContext(obj);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(obj, context, results, true);

            if (!valid)
            {
                foreach (ValidationResult result in results)
                {
                    Console.WriteLine("\nInvalid : {0}", result.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("Error Message : {0} {1}", result.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("\nYour registred info is --> ");
                Console.WriteLine($"\nFirst name : {obj.firstName} \nLast name : {obj.lastName} \nEmail : {obj.email}" +
                    $"\nPhone number : {obj.phoneNumber} \nPassword : {obj.password}");
            }
            Console.ReadKey();
        }
    }
}
