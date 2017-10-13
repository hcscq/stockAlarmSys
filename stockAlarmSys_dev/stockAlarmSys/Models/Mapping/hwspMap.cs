using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace stockAlarmSys.Models.Mapping
{
    public class hwspMap : EntityTypeConfiguration<hwsp>
    {
        public hwspMap()
        {
            // Primary Key
            this.HasKey(t => new { t.hw, t.spid, t.C_MASK_FROM_V2 });

            // Properties
            this.Property(t => t.hw)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            this.Property(t => t.spid)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            this.Property(t => t.lsm)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.jwh)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.is_hege)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.lastmodifytime)
                .HasMaxLength(19);

            this.Property(t => t.is_tjsp)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.is_hyrdz)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.is_jifen)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.jwh_px)
                .HasMaxLength(20);

            this.Property(t => t.jwh2)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.C_MASK_FROM_V2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("hwsp");
            this.Property(t => t.hw).HasColumnName("hw");
            this.Property(t => t.spid).HasColumnName("spid");
            this.Property(t => t.lsm).HasColumnName("lsm");
            this.Property(t => t.jwh).HasColumnName("jwh");
            this.Property(t => t.is_hege).HasColumnName("is_hege");
            this.Property(t => t.chbdj).HasColumnName("chbdj");
            this.Property(t => t.hwshl).HasColumnName("hwshl");
            this.Property(t => t.hwje).HasColumnName("hwje");
            this.Property(t => t.zancsl).HasColumnName("zancsl");
            this.Property(t => t.jzshl).HasColumnName("jzshl");
            this.Property(t => t.jzje).HasColumnName("jzje");
            this.Property(t => t.lingsjzje).HasColumnName("lingsjzje");
            this.Property(t => t.kcsx).HasColumnName("kcsx");
            this.Property(t => t.kcxx).HasColumnName("kcxx");
            this.Property(t => t.jzdj).HasColumnName("jzdj");
            this.Property(t => t.xsshl).HasColumnName("xsshl");
            this.Property(t => t.oldshl).HasColumnName("oldshl");
            this.Property(t => t.oldje).HasColumnName("oldje");
            this.Property(t => t.lastmodifytime).HasColumnName("lastmodifytime");
            this.Property(t => t.cwsqjzsl).HasColumnName("cwsqjzsl");
            this.Property(t => t.cwsqjzje).HasColumnName("cwsqjzje");
            this.Property(t => t.Bkxshl).HasColumnName("Bkxshl");
            this.Property(t => t.helkc).HasColumnName("helkc");
            this.Property(t => t.lshj).HasColumnName("lshj");
            this.Property(t => t.hyj).HasColumnName("hyj");
            this.Property(t => t.hyj1).HasColumnName("hyj1");
            this.Property(t => t.hyj2).HasColumnName("hyj2");
            this.Property(t => t.hyj3).HasColumnName("hyj3");
            this.Property(t => t.is_tjsp).HasColumnName("is_tjsp");
            this.Property(t => t.ydj).HasColumnName("ydj");
            this.Property(t => t.is_hyrdz).HasColumnName("is_hyrdz");
            this.Property(t => t.is_jifen).HasColumnName("is_jifen");
            this.Property(t => t.jwh_px).HasColumnName("jwh_px");
            this.Property(t => t.jwh2).HasColumnName("jwh2");
            this.Property(t => t.C_MASK_FROM_V2).HasColumnName("_MASK_FROM_V2");
        }
    }
}
