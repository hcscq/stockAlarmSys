using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace stockAlarmSys.Models.Mapping
{
    public class alarmAddr_realationsDMap : EntityTypeConfiguration<alarmAddr_realationsD>
    {
        public alarmAddr_realationsDMap()
        {
            // Primary Key
            this.HasKey(t => new { t.guid,t.addr_Id_attached});

            // Properties
            
            // Table & Column Mappings
            this.ToTable("alarmAddr_realationsd");
            this.Property(t => t.addr_Id_attached).HasColumnName("addr_Id_attached");
            this.Property(t => t.guid).HasColumnName("guid");
            this.Property(t => t.bol_copy).HasColumnName("bol_copy");

        }
    }
}
