using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace dotNETLabOne.Models
{
    public class UserContext : DbContext
    {
        public UserContext() : base("name=UsersEntities")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<dotNETLabOne.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<dotNETLabOne.Models.Disorder> Disorders { get; set; }
    }
}