using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Day_22_UserRegistrationAnnotation
{
    class UserRegistration
    {
        [Required(ErrorMessage = "Users {0} is required")]
        [RegularExpression("^[A-Z][a-z]{2,}$", ErrorMessage = "Name should start with capital letters and" +
                                                                   "must have minimum 2 characters.")]
        [DataType(DataType.Text)]
        public string firstName { get; set; }

        [RegularExpression("^[A-Z][a-z]{2,}$", ErrorMessage = "Name should start with capital letters and" +
                                                                    "must have minimum 2 characters.")]
        [DataType(DataType.Text)]
        public string lastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string email { get; set; }
    }
}
