using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace dotNETLabOne.Models
{
    public class Disorder
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [DisplayName("Disorder name")]
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}