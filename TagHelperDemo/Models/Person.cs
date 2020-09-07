using System.ComponentModel.DataAnnotations;

namespace TagHelperDemo.Models
{
    public class Person
    {
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Address { get; set; }

        [Required]
        [Range(0, 120, ErrorMessage = "Please enter whole number between 0 and 120")]
        public int Age { get; set; }
    }
   
}
