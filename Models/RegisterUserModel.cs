using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThirdMvcCore.Models
{
    public class RegisterUserModel
    {
        [Display(Name = "User Name: ")]
        [Required(ErrorMessage = "Full Name is Required")]
        [MinLength(6,ErrorMessage ="User Name should have atleast 6 character's")]
        [MaxLength(12)]
        public string UserName { get; set; }
        
        [Display(Name = "Password: ")]
        [Required(ErrorMessage = "Password is Required"),MaxLength(10)]
        [DataType(DataType.Password)]
        [MinLength(4, ErrorMessage = "Password should be atleast 4 character's")]

        public string Password { get; set; }
       
        [Display(Name = "Confirm Your Password: ")]
        [Required(ErrorMessage = "Confirm Password is Required"), MaxLength(10)]
        [DataType(DataType.Password)]
        [MinLength(4, ErrorMessage = "Confirm Password should be atleast 4 character's")]
        [Compare ("Password",ErrorMessage ="Password not matching")]
        public string ConfirmPassword { get; set; }
        
        [Display(Name = "You can't proceed further until you agree with our terms and conditions: ")]
        public bool IsAgreedToTerms { get; set; }
    }
}
