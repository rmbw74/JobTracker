using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracker.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string Street { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [StringLength(2)]
        public string State { get; set; }

        [Required]
        [StringLength(5)]
        public string Zipcode { get; set; }

        public string Industry { get; set; }

        //foreign key
        public virtual ICollection<Job> Jobs { get; set; }

    }
}
