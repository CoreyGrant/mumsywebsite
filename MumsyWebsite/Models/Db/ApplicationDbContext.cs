using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Identity.EntityFramework;
using MumsyWebsite.Models.Admin;
using System.Data.Entity;
using MumsyWebsite.Models.Shop;

namespace MumsyWebsite.Models.Db
{
	public class DbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
	{
		protected override void Seed(ApplicationDbContext context)
		{
			base.Seed(context);
			//var users = new[]
			//{
			//	new ApplicationUser
			//	{
			//
			//	}
			//};
			//foreach(var user in users)
			//{
			//	context.Users.Add(user);
			//}
		}
	}

	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext()
			: base("DefaultConnection", throwIfV1Schema: false)
		{
			Database.SetInitializer(new DbInitializer());
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Item>().HasKey(x => x.Id);
		}

		public DbSet<Item> Items { get; set; }

		public static ApplicationDbContext Create()
		{
			return new ApplicationDbContext();
		}
	}
}