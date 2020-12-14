using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dotNETLabOne.Models
{
    public class DisorderInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            var disorders = new List<Disorder>
            {
                new Disorder {Name = "Glaucoma"},
                new Disorder {Name = "Cataract"},
                new Disorder {Name = "Color blindness"},
                new Disorder {Name = "Myopia"},
            };

            disorders.ForEach(s => context.Disorders.Add(s));
            context.SaveChanges();
        }
    }
}