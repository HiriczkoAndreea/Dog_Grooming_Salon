using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace Dog_Grooming_Salon.Models
{
    public class Dog
    {
        public int ID { get; set; }
        [Display(Name = "Dog Name")]
        public string Name { get; set; }
        public string Age { get; set; }

        public int? OwnerID { get; set; }
        public Owner? Owner { get; set; }
    }
}
