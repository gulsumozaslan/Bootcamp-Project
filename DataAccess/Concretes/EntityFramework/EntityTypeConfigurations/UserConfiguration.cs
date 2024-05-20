using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework.EntityTypeConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users").HasKey(u => u.Id);//1
            builder.Property(u => u.Id).HasColumnName("Id");
            builder.Property(u => u.UserName).HasColumnName("UserName");
            builder.Property(u => u.FirstName).HasColumnName("FirstName");
            builder.Property(u => u.LastName).HasColumnName("LastName");
            builder.Property(u => u.NationalIdentity).HasColumnName("NationalIdentity");
            builder.Property(u => u.Password).HasColumnName("Password");
            builder.Property(u => u.Email).HasColumnName("Email");
            builder.Property(u => u.DateOfBirth).HasColumnName("DateOfBirth");
            builder.Property(u => u.CreatedDate).HasColumnName("CreatedDate");
            builder.Property(u => u.UpdatedDate).HasColumnName("UpdatedDate");
            builder.Property(u => u.DeletedDate).HasColumnName("DeletedDate");

        
            
        }
    }
}
