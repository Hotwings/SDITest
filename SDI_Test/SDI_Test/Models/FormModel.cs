using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SDI_Test.Models
{
    public class FormModel
    {
		//Unique identifier for model
		[Key]
		public Guid ID { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Date of Birth")]
		//Set validation to be a date, no time
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DateOfBirth { get; set; } = DateTime.Now;

        [Required]
		//GPA must have a single-digit number which may or may not be followed by a "." and another didgit.
        [RegularExpression("^\\d(?:[.]\\d)?$", ErrorMessage = "Incorrect GPA format")]
        [DisplayName("GPA")]
        public decimal GPA { get; set; }


		public FormModel()
		{
			//Pre-instanciate Guid
			ID = Guid.NewGuid();
		}
    }
}