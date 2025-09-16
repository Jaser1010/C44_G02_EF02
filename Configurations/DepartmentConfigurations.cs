using C44_G02_EF02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EF02.Configurations
{
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            //D.ToTable("Departments", "Sales");

            D.HasKey(d => d.Id);

            D.Property(d => d.Id)
                                              .HasColumnName("DeptId")
                                             .UseIdentityColumn(10, 10);

            D.Property(e => e.Name)
                                           .IsRequired(false)
                                           .HasMaxLength(20)
                                           .HasColumnName("DeptName")
                                           .HasDefaultValue("HR")
                                           .HasColumnType("varchar");

            D.Property(e => e.CreationDate)
                                             .HasColumnType("datetime")
                                             .HasComputedColumnSql("GetDate()");

          
        }
    }
}
