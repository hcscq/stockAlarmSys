using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace stockAlarmSys.Models.Mapping
{
    public class stock_alarm_GSAMap : EntityTypeConfiguration<stock_alarm_GSA>
    {
        public stock_alarm_GSAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID});//, t.spid, t.spbh, t.hw, t.alarm_type, t.threshold_value, t.add_date, t.stock_5DLatter, t.last_alarmDate, t.alarm_state, t.saledIn2Month, t.saledIn1Month, t.lastCalcuDate 

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.spid)
                .IsRequired()
                .HasMaxLength(11);

            this.Property(t => t.spbh)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.hw)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.spmch)
                .HasMaxLength(150);

            this.Property(t => t.alarm_type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.threshold_value)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.stock_5DLatter)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.notice)
                .HasMaxLength(150);

            this.Property(t => t.alarm_state)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.saledIn2Month)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.saledIn1Month)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("stock_alarm_GSA");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.spid).HasColumnName("spid");
            this.Property(t => t.spbh).HasColumnName("spbh");
            this.Property(t => t.hw).HasColumnName("hw");
            this.Property(t => t.spmch).HasColumnName("spmch");
            this.Property(t => t.alarm_type).HasColumnName("alarm_type");
            this.Property(t => t.threshold_value).HasColumnName("threshold_value");
            this.Property(t => t.add_date).HasColumnName("add_date");
            this.Property(t => t.stock_5DLatter).HasColumnName("stock_5DLatter");
            this.Property(t => t.last_alarmDate).HasColumnName("last_alarmDate");
            this.Property(t => t.notice).HasColumnName("notice");
            this.Property(t => t.alarm_state).HasColumnName("alarm_state");
            this.Property(t => t.saledIn2Month).HasColumnName("saledIn2Month");
            this.Property(t => t.saledIn1Month).HasColumnName("saledIn1Month");
            this.Property(t => t.lastCalcuDate).HasColumnName("lastCalcuDate");
            this.Property(t => t.alarmSpan).HasColumnName("alarmSpan");
        }
    }
}
