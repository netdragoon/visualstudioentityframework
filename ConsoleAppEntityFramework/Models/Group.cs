using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace ConsoleAppEntityFramework.Models
{
    public class Group
    {
        public Group()
        {
            Items = new HashSet<Group>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public long? GroupId { get; set; }
        public virtual ICollection<Group> Items { get; set; }

        public bool IsFather
        {
            get
            {
                return !GroupId.HasValue;
            }
        }
    }

    public class GroupMap: EntityTypeConfiguration<Group>
    {
        public GroupMap()
        {
            ToTable("Group");

            HasKey(c => c.Id)
                .Property(c => c.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.GroupId)
                .IsOptional();

            HasMany(c => c.Items)
                .WithOptional()
                .HasForeignKey(c => c.GroupId);

            Ignore(c => c.IsFather);
                
        }
        public static GroupMap Create()
        {
            return new GroupMap();
        }
    }

}
