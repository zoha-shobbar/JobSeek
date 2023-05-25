
﻿using JobSeek.Api.Validations;
using System.ComponentModel;

using System.ComponentModel.DataAnnotations;

namespace JobSeek.Api.Models.Input
{
    public abstract class UserInput
    {
        [EmailAddress]
        public string Email { get; set; }
        
      [PhoneNum]
        public string PhoneNumber { get; set; }
       
      [StringLength(12,ErrorMessage = "Maximum length is 12 and Minimum Length is 4", MinimumLength =4)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
       
      [Phone]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
