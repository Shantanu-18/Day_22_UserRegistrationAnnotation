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
    }
}
