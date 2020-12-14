using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace dotNETLabOne.Models
{
    public class User
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Please, enter the user name")]
        [DisplayName("User name")]
        public string Name { get; set; }
        [Required]
        [MyDate(ErrorMessage = "Please, enter the correct date of birth")]
        [DisplayName("Date of birth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [DisplayName("Disorder type")]
        public int? DisorderId { get; set; }
        public virtual Disorder Disorder { get; set; }
    }
}