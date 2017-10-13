using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace stockAlarmSys.Models.Mapping
{
    public class stock_alarm_GSA_hisMap : EntityTypeConfiguration<stock_alarm_GSA_his>
    {
        public stock_alarm_GSA_hisMap()
        {
            // Primary Key
            //, t.spid, t.spbh, t.hw, t.alarm_type, t.threshold_value, t.add_date, t.stock_5DLatter, t.last_alarmDate, t.alarm_state, t.saledIn1Month, t.saledIn1Month, t.lastCalcuDate 
            this.HasKey(t => new { t.IDS,t.spid,t.last_alarmDate,t.lastCalcuDate });
            // Properties
            this.Property(t => t.IDS)
                .IsRequired();

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

            this.Property(t => t.saledIn1Month)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.saledIn7Days)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("stock_alarm_GSA_his");
            this.Property(t => t.IDS).HasColumnName("ID");
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
            this.Property(t => t.saledIn1Month).HasColumnName("saledIn1Month");
            this.Property(t => t.saledIn7Days).HasColumnName("saledIn7Days");
            this.Property(t => t.lastCalcuDate).HasColumnName("lastCalcuDate");
            this.Property(t => t.alarmSpan).HasColumnName("alarmSpan");//amount_static
            this.Property(t => t.amount_static).HasColumnName("amount_static");

            this.Property(t => t.ordering_cycle).HasColumnName("ordering_cycle");
            this.Property(t => t.restock_count).HasColumnName("restock_count");
            this.Property(t => t.delivery_cycle).HasColumnName("delivery_cycle");
            this.Property(t => t.safty_days).HasColumnName("safty_days");//stock_transit
            this.Property(t => t.stock_transit).HasColumnName("stock_transit");
        }
    }
}
