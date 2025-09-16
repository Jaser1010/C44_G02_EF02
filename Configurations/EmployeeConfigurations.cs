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
    public class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> E)
        {
            E.HasKey(e => e.EmpId);

            E.Property(e => e.EmpId)
                                          .UseIdentityColumn(1, 1);

            E.Property(e => e.Name)
                                           .IsRequired(true)
                                           .HasMaxLength(50)
                                           .HasColumnName("EmpName")
                                           .HasColumnType("varchar");

            E.Ignore(E => E.Age);
            E.HasOne(e => e.ManagedDepartment)
             .WithOne(d => d.Manager)
             .HasForeignKey<Department>(e => e.ManagerId)
             .OnDelete(DeleteBehavior.SetNull);

            E.OwnsOne(e => e.Address);
        }
    }
}
