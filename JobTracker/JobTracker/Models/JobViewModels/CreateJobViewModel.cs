using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using JobTracker.Data;
using System.Threading.Tasks;

namespace JobTracker.Models.JobViewModels
{
    public class CreateJobViewModel
    {
        [Required]
        public List<SelectListItem> CompanyList { get; set; }

        [Required]
        public Job Job { get; set; }

      

        public CreateJobViewModel(ApplicationDbContext ctx)
        {

            //create selectlist item for dropdown in job create
            this.CompanyList = ctx.Company
                .OrderBy(l => l.CompanyName)
                .AsEnumerable()
                .Select(li => new SelectListItem
            {
                Text = li.CompanyName,
                Value = li.Id.ToString()
            }).ToList();

            //add a prompt for user to select the company
            this.CompanyList.Insert(0, new SelectListItem
              {
                Text = "Choose Company...",
                Value = "0"
              });

        }
    }
}
