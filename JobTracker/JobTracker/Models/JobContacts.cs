using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracker.Models
{
    public class JobContacts
    {
        [Key]
        public int Id { get; set; }

        //foreign keys
        public virtual ICollection<Job> Jobs { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
