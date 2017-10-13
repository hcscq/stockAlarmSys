using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using stockAlarmSys.Models.Mapping;

namespace stockAlarmSys.Models
{
    public partial class ksoaContext : DbContext
    {
        static ksoaContext()
        {
            Database.SetInitializer<ksoaContext>(null);
        }

        public ksoaContext()
            : base("Name=ksoaContext")
        {
        }

        public DbSet<huoweizl> huoweizls { get; set; }
        public DbSet<hwsp> hwsps { get; set; }
        public DbSet<sphwph> sphwphs { get; set; }
        public DbSet<spkfk> spkfks { get; set; }
        public DbSet<stock_alarm_GSA> stock_alarm_GSA { get; set; }
        public DbSet<alarm_mailaddr> alarm_MailAddr { get; set; }//alarm_mailaddr

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new huoweizlMap());
            modelBuilder.Configurations.Add(new hwspMap());
            modelBuilder.Configurations.Add(new sphwphMap());
            modelBuilder.Configurations.Add(new spkfkMap());
            modelBuilder.Configurations.Add(new stock_alarm_GSAMap());
            modelBuilder.Configurations.Add(new alarm_mailaddrMap());
        }
    }
}
