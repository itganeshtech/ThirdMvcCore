using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThirdMvcCore.Models
{
    public class EmployeeModel
    {
        [Display(Name="Full Name: ")]
        [Required (ErrorMessage ="Full Name is Required")]
        public string Fullname { get; set; }

        
        [Display(Name = "Date of Birth: ")]
        [Required(ErrorMessage = "Date of Birth is Required")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Email ID: ")]
        [Required(ErrorMessage = "Email ID is Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Mobile Number: ")]
        [Required(ErrorMessage = "Mobile Number is Required")]
        public string Mobile { get; set; }
        
        [Display(Name = "Your Address: ")]
        [Required(ErrorMessage = "Address is Required")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
       
        [Display(Name = "Salary Structure: ")]
        public decimal? Salary { get; set; }
       
        [Display(Name = "Web Site: ")]
        [DataType(DataType.Url)]
        public string Website { get; set; }

    }
}
