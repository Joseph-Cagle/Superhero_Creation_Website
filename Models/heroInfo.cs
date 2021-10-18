using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace superHero.Models
{
    public class heroInfo
    {
        [Required(ErrorMessage = "Please enter your heros name!")]
        [MinLength(5, ErrorMessage = "First Name must have at least 5 characters")]
        public String name { get; set; }

        [Required(ErrorMessage = "Please enter your heros place of orgin!")]
        public String origin { get; set; }

        [Required(ErrorMessage = "Please select your heros DOB")]
        [Range(typeof(DateTime), "1/1/1970", "11/20/2020")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dob { get; set; }

        [Required(ErrorMessage = "You must select a power ")]
        public String power1 { get; set; }

        [Required(ErrorMessage = "You must select a power ")]
        public String power2 { get; set; }

        [Required(ErrorMessage = "You must select a weakness ")]
        public String weaknes { get; set; }

        //https://stackoverflow.com/questions/48321261/validate-dropdown-item-does-not-occur-more-than-once-in-a-list-of-dropdown-field

        //   [Required(ErrorMessage = "Please select a color!")]
        //   //^\#?[A-Fa-f0-9]{3}([A-Fa-f0-9]{3})?$
        //   [RegularExpression(@"rgb\(\s*(?:(\d{1,3})\s*,?){3}\)")]
        //public   String color { get; set; }

      
        public List<SelectListItem> powers1 { get; set; }
      = new List<SelectListItem>
      {
            new SelectListItem{Value="Super Strength ", Text="Super Strength"},
             new SelectListItem{Value="Super Speed", Text="Super Speed! "},
              new SelectListItem{Value="Flying ", Text="Flying"},
               new SelectListItem{Value="Invisibility  ", Text="Invisibilty "},
                new SelectListItem{Value="Time Travel ", Text="Time Travel"},
             new SelectListItem{Value="Super Smart", Text="Super Smart "},
              new SelectListItem{Value="Billionair", Text="Billionair"},
               new SelectListItem{Value="Prep Time  ", Text="Prep Time"},
                new SelectListItem{Value="Energy manipulation", Text="Energy Manipulation"},
               new SelectListItem{Value="Breath Underwater  ", Text="Breath Underwater"}
      };

        
        public List<SelectListItem> powers2 { get; set; }
  = new List<SelectListItem>
  {
            new SelectListItem{Value="Super Strength ", Text="Super Strength"},
             new SelectListItem{Value="Super Speed", Text="Super Speed! "},
              new SelectListItem{Value="Flying ", Text="Flying"},
               new SelectListItem{Value="Invisibility  ", Text="Invisibilty "},
                new SelectListItem{Value="Time Travel ", Text="Time Travel"},
             new SelectListItem{Value="Super Smart", Text="Super Smart "},
              new SelectListItem{Value="Billionair", Text="Billionair"},
               new SelectListItem{Value="Prep Time  ", Text="Prep Time"},
                new SelectListItem{Value="Energy manipulation", Text="Energy Manipulation"},
               new SelectListItem{Value="Breath Underwater  ", Text="Breath Underwater"}
  };

    
        public List<SelectListItem> weakness { get; set; }
  = new List<SelectListItem>
  {
            new SelectListItem{Value="Sun sensitivity ", Text="Sun sensitivity"},
             new SelectListItem{Value="Water", Text="Water "},
              new SelectListItem{Value="Kryptonite ", Text="Kryptonite"},
               new SelectListItem{Value="Radiation  ", Text="Radiation "},
                new SelectListItem{Value="Loud noises ", Text="Loud noises"},
             new SelectListItem{Value="The Moon", Text="The Moon "},
              new SelectListItem{Value="The Force", Text="The Force"},
               new SelectListItem{Value="Children  ", Text="Children"},
                new SelectListItem{Value="Puppies", Text="Puppies"},
               new SelectListItem{Value="Fire  ", Text="Fire"}
  };
    }
}