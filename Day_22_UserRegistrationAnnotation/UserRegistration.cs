using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Day_22_UserRegistrationAnnotation
{
    class UserRegistration
    {
        [Required(ErrorMessage = "Users {0} is required")]
        [StringLength(100,MinimumLength =2,ErrorMessage="Name should contain minimum two characters.")]
        [DataType(DataType.Text)]
        public string firstName { get; set; }

        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name should contain minimum two characters.")]
        [DataType(DataType.Text)]
        public string lastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string phoneNumber { get; set; }

        [StringLength(15,MinimumLength =8,ErrorMessage = "Password should be between 8 to 15 characters")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
