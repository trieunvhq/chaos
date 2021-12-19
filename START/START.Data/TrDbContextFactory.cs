using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace START.Data
{
	class TrDbContextFactory : IDesignTimeDbContextFactory<TrDbContext>
	{
		public TrDbContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<TrDbContext>();
			optionsBuilder.UseSqlServer("Server=103.127.206.198;Database=TinTuc;User Id=tinluong;Password=1;");

			return new TrDbContext(optionsBuilder.Options);
		}
	}
}
