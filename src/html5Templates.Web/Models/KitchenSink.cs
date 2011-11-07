using System;
using System.ComponentModel.DataAnnotations;

namespace html5Templates.Web.Models
{
    public class KitchenSink
    {
        /* Note: [DataType("TemplateName")] and Mvc's [UIHint("TemplateName")] are equivalent for our purposes */

        [Display(Prompt = "Enter your string...")]
        [Required]
        public string RegularString { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Prompt = "Enter your email...")]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.Url)]
        [Display(Prompt = "Enter a url...")]
        [Required]
        public string Url { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Prompt = "Enter your phone...")]
        [Required]
        public string Phone { get; set; }

        [DataType("Search")]
        [Display(Prompt = "Enter your search...")]
        public string Search { get; set; }

        //[DataType(DataType.DateTime)] //Redundant
        [Required]
        public DateTime DateTime { get; set; }
        
        [DataType("DateTime-Local")]
        [Required]
        public DateTime DateTimeLocal { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOnly { get; set; }

        [DataType(DataType.Time)]
        [Required]
        public string TimeOnly { get; set; }

        [DataType("Month")]
        [Required]
        public string Month { get; set; }

        [DataType("Week")]
        [Required]
        public string Week { get; set; }

        [DataType("Number")] //On Opera number uses a spinbox, so this will only work with integers
        [Required]
        public int Number { get; set; }

        [DataType("Color")]
        public string Color { get; set; }
        
        [DataType(DataType.Text)]
        [Display(Prompt = "Enter your text...")]
        [Required]
        public string Text { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Prompt = "Enter your multiline text...")]
        [Required]
        public string MultilineText { get; set; }
    }
}