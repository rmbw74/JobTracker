﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracker.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Job Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        [Display(Name = "Salary or Salary Range")]
        public string SalaryRange { get; set; }

        public string Notes { get; set; }

        //Foreign Keys

        public virtual ICollection<Company> Company { get; set; }

    }
}