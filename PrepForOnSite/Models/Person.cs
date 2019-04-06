using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrepForOnSite.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [RegularExpression(@"\d{7}([a-z]{1,2}|[A-Z]{1,2})", ErrorMessage = "PPS must start with 7 numbers and followed by 2 letters.")]
        [Display(Name = "PPS Number")]
        public string Pps { get; set; } 

        [Required]
        [RegularExpression(@"^[\w\s'.-]+$", ErrorMessage = "First name must be between2 and 50 characters. ")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } 

        [Required]
        [RegularExpression(@"^[\w\s'.-]+$", ErrorMessage = "Last name must be between2 and 50 characters. ")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }

    }
}
