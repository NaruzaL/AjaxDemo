using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AjaxDemo.Models
{
    public class AjaxDemoContext: DbContext
    {
        public virtual DbSet<Destination> Destinations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AjaxDemo;integrated security=True");
    }
    public AjaxDemoContext(DbContextOptions<AjaxDemoContext> options) : base(options)
        {
    }

    public AjaxDemoContext()
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

}
}
