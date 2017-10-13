using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace stockAlarmSys.Models.Mapping
{
    public class alarm_mailaddrMap : EntityTypeConfiguration<alarm_mailaddr>
    {
        public alarm_mailaddrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID });//, t.mailAddress, t.sendFile

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.mailAddress)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.notice)
                .HasMaxLength(150);

            this.Property(t => t.senderAddr)
                .HasMaxLength(50);

            this.Property(t => t.senderName)
                .HasMaxLength(50);
            this.Property(t => t.mailBody)
                 .HasMaxLength(3000);

            this.Property(t => t.subject)
                .HasMaxLength(50);

            this.Property(t => t.fileBasePath)
                .HasMaxLength(150);

            this.Property(t => t.SMTPHost)
                .HasMaxLength(50);

            this.Property(t => t.SMTPPuser)
                .HasMaxLength(50);

            this.Property(t => t.SMTPPass)
                .HasMaxLength(50);
            this.Property(t => t.toer)
                .HasMaxLength(50);

            //deleted sendTimeSpan lastSendDate
            // Table & Column Mappings
            this.ToTable("alarm_mailaddr");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.mailAddress).HasColumnName("mailAddress");
            this.Property(t => t.notice).HasColumnName("notice");
            this.Property(t => t.senderAddr).HasColumnName("senderAddr");
            this.Property(t => t.senderName).HasColumnName("senderName");
            this.Property(t => t.subject).HasColumnName("subject");
            this.Property(t => t.fileBasePath).HasColumnName("fileBasePath");
            this.Property(t => t.sendFile).HasColumnName("sendFile");
            this.Property(t => t.SMTPHost).HasColumnName("SMTPHost");
            this.Property(t => t.SMTPPuser).HasColumnName("SMTPPuser");
            this.Property(t => t.SMTPPass).HasColumnName("SMTPPass");
            this.Property(t => t.mailBody).HasColumnName("mailBody");
            this.Property(t => t.toer).HasColumnName("toer");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.sendTimeSpan).HasColumnName("sendTimeSpan");
            this.Property(t => t.lastSendDate).HasColumnName("lastSendDate");
        }
    }
}
