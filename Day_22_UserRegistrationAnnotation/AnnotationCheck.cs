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
            UserRegistration obj = new UserRegistration();
            obj.firstName = "";

            ValidationContext context = new ValidationContext(obj);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(obj, context, results, true);

            if (!valid)
            {
                foreach (ValidationResult result in results)
                {
                    Console.WriteLine("Invalid : {0}",result.MemberNames.First(),Environment.NewLine);
                    Console.WriteLine("Error Message : {0} {1}",result.ErrorMessage,Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine($"First name : {obj.firstName}");
            }
            Console.ReadKey();

        }
    }
}
