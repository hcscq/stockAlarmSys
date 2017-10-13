using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace stockAlarmSys.Models.Mapping
{
    public class alarmAddr_realationsMap : EntityTypeConfiguration<alarmAddr_realations>
    {
        public alarmAddr_realationsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.guid,t.relation_Type });

            // Properties
            this.Property(t => t.show_Name)
                .HasMaxLength(50);

            
            // Table & Column Mappings
            this.ToTable("alarmAddr_realations");
            this.Property(t => t.show_Name).HasColumnName("show_Name");            
            this.Property(t => t.addr_Id_Main).HasColumnName("addr_Id_Main");
            this.Property(t => t.guid).HasColumnName("guid");
            this.Property(t => t.relation_Type).HasColumnName("relation_Type");
        }
    }
}
