using Microsoft.EntityFrameworkCore;
using START.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace START.Data
{
	public class TrDbContext : DbContext
	{
		public TrDbContext(DbContextOptions<TrDbContext> options) : base(options)
		{
		}

		public DbSet<SinhVien> SinhViens { get; set; }
		public DbSet<Lop> Lops { get; set; }

	}
}
