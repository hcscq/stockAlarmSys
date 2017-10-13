using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace stockAlarmSys.Models.Mapping
{
    public class sphwph_tMap : EntityTypeConfiguration<sphwph_t>
    {
        public sphwph_tMap()
        {
            // Primary Key
            this.HasKey(t => new { t.spid, t.hw, t.pihao });

            // Properties
            this.Property(t => t.spid)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            this.Property(t => t.hw)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            this.Property(t => t.pihao)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.baozhiqi)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.dangqzht)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.miejph)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.sxrq)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.yanghriqi)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.jwh)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("sphwph_t");
            this.Property(t => t.spid).HasColumnName("spid");
            this.Property(t => t.hw).HasColumnName("hw");
            this.Property(t => t.pihao).HasColumnName("pihao");
            this.Property(t => t.baozhiqi).HasColumnName("baozhiqi");
            this.Property(t => t.dangqzht).HasColumnName("dangqzht");
            this.Property(t => t.shl).HasColumnName("shl");
            this.Property(t => t.gebjj).HasColumnName("gebjj");
            this.Property(t => t.miejph).HasColumnName("miejph");
            this.Property(t => t.sxrq).HasColumnName("sxrq");
            this.Property(t => t.yanghriqi).HasColumnName("yanghriqi");
            this.Property(t => t.xsshl).HasColumnName("xsshl");
            this.Property(t => t.Bkxshl).HasColumnName("Bkxshl");
            this.Property(t => t.ykpshl).HasColumnName("ykpshl");
            this.Property(t => t.bukxshl).HasColumnName("bukxshl");
            this.Property(t => t.jwh).HasColumnName("jwh");
            this.Property(t => t.lastModifyTime).HasColumnName("lastModifyTime");
            this.Property(t => t.uploadTime).HasColumnName("uploadTime");
        }
    }
}
