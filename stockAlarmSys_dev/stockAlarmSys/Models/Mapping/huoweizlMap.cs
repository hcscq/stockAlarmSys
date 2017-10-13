using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace stockAlarmSys.Models.Mapping
{
    public class huoweizlMap : EntityTypeConfiguration<huoweizl>
    {
        public huoweizlMap()
        {
            // Primary Key
            this.HasKey(t => new { t.hw, t.hwbh, t.huowname, t.C_MASK_FROM_V2 });

            // Properties
            this.Property(t => t.hw)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            this.Property(t => t.hwbh)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.huowname)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.beactive)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.fuzr)
                .HasMaxLength(10);

            this.Property(t => t.kemuhao)
                .HasMaxLength(20);

            this.Property(t => t.isglph)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.isljfkc)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.is_dd)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.is_hj)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.is_sqjhd)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.is_ykzdxj)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.ckzht)
                .HasMaxLength(16);

            this.Property(t => t.type)
                .HasMaxLength(11);

            this.Property(t => t.shenhe)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.duifbsh)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.lastmodifytime)
                .HasMaxLength(19);

            this.Property(t => t.is_ykzdsj)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.isfthw)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.is_guizu)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.hw_quyu)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.is_zb)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.factory)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.quyufl)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.is_pdph)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.is_psck)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.ghdw)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.C_MASK_FROM_V2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            this.Property(t => t.ysy)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.yjjk_dwmch)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.stockCode)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.stateId)
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("huoweizl");
            this.Property(t => t.hw).HasColumnName("hw");
            this.Property(t => t.hwbh).HasColumnName("hwbh");
            this.Property(t => t.huowname).HasColumnName("huowname");
            this.Property(t => t.beactive).HasColumnName("beactive");
            this.Property(t => t.fuzr).HasColumnName("fuzr");
            this.Property(t => t.otd).HasColumnName("otd");
            this.Property(t => t.area).HasColumnName("area");
            this.Property(t => t.cubage).HasColumnName("cubage");
            this.Property(t => t.guanlrys).HasColumnName("guanlrys");
            this.Property(t => t.kecfpzs).HasColumnName("kecfpzs");
            this.Property(t => t.guidcfpzs).HasColumnName("guidcfpzs");
            this.Property(t => t.jzsl).HasColumnName("jzsl");
            this.Property(t => t.jzje).HasColumnName("jzje");
            this.Property(t => t.lingsjzje).HasColumnName("lingsjzje");
            this.Property(t => t.kemuhao).HasColumnName("kemuhao");
            this.Property(t => t.isglph).HasColumnName("isglph");
            this.Property(t => t.isljfkc).HasColumnName("isljfkc");
            this.Property(t => t.is_dd).HasColumnName("is_dd");
            this.Property(t => t.is_hj).HasColumnName("is_hj");
            this.Property(t => t.is_sqjhd).HasColumnName("is_sqjhd");
            this.Property(t => t.is_ykzdxj).HasColumnName("is_ykzdxj");
            this.Property(t => t.ckzht).HasColumnName("ckzht");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.yyj).HasColumnName("yyj");
            this.Property(t => t.shenhe).HasColumnName("shenhe");
            this.Property(t => t.duifbsh).HasColumnName("duifbsh");
            this.Property(t => t.lastmodifytime).HasColumnName("lastmodifytime");
            this.Property(t => t.is_ykzdsj).HasColumnName("is_ykzdsj");
            this.Property(t => t.isfthw).HasColumnName("isfthw");
            this.Property(t => t.is_guizu).HasColumnName("is_guizu");
            this.Property(t => t.hw_quyu).HasColumnName("hw_quyu");
            this.Property(t => t.is_zb).HasColumnName("is_zb");
            this.Property(t => t.factory).HasColumnName("factory");
            this.Property(t => t.quyufl).HasColumnName("quyufl");
            this.Property(t => t.is_pdph).HasColumnName("is_pdph");
            this.Property(t => t.is_psck).HasColumnName("is_psck");
            this.Property(t => t.ghdw).HasColumnName("ghdw");
            this.Property(t => t.C_MASK_FROM_V2).HasColumnName("_MASK_FROM_V2");
            this.Property(t => t.ysy).HasColumnName("ysy");
            this.Property(t => t.yjjk_dwmch).HasColumnName("yjjk_dwmch");
            this.Property(t => t.stockCode).HasColumnName("stockCode");
            this.Property(t => t.stateId).HasColumnName("stateId");
        }
    }
}
