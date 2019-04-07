using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrepForOnSite.Models
{
    public class Person
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
                   
        public int ID { get; set; } //will be used as a key in db can be string aswell, will be generated, the above stuff implicit 

        [Required]
        [RegularExpression(@"\d{7}([a-z]{1,2}|[A-Z]{1,2})", ErrorMessage = "PPS must start with 7 numbers and followed by 2 letters.")]
        [Display(Name = "PPS Number")]
        public string Pps { get; set; } 

        [Required]
        [RegularExpression(@"([\w\s'.-]){2,50}", ErrorMessage = "Last name must be between 2 and 50 characters. ")] //validation regular expression
        [Display(Name = "First Name")]
        public string FirstName { get; set; } 

        [Required]
        [RegularExpression(@"([\w\s'.-]){2,50}", ErrorMessage = "Last name must be between 2 and 50 characters. ")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Dob]
        public DateTime Dob { get; set; }

        [Required]
        [Display(Name = "Gender")]      
        public string Gender { get; set; }
       
        [Display(Name = "Drivers Licence")]
        public string DriversLicence { get; set; }

        [Required(ErrorMessage ="Please enter drivers experience")]
        [Display(Name = "Years of Driving Experience")]
        [Range(0,10, ErrorMessage ="Please enter a number between 1 and 10")] //validation range
        public int YearsOfExperience { get; set; }

    }
}
