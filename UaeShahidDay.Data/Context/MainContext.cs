using GoTech.Framework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using UaeShahidDay.Data.Entity;

namespace UaeShahidDay.Data.Context
{
    public class MainContext : BaseGoTechContext
    {

        public DbSet<Shahid> Shahids { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

    }
}
