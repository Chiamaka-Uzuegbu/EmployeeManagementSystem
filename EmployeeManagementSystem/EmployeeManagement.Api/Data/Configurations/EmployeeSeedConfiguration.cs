using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagement.Api.Data.Configurations
{
    public class EmployeeSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
            new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Casor",
                Email = "john.casor@company.com",
                PhoneNumber = "08012345678",
                DateOfBirth = new DateTime(1990, 5, 10),
                DateHired = new DateTime(2022, 1, 15),
                Salary = 350000m,
                Department = Department.InformationTechnology,
                IsActive = true
            },

            new Employee
            {
                Id = 2,
                FirstName = "Mary",
                LastName = "Johnson",
                Email = "mary.johnson@company.com",
                PhoneNumber = "08087654321",
                DateOfBirth = new DateTime(1993, 9, 18),
                DateHired = new DateTime(2021, 6, 3),
                Salary = 420000m,
                Department = Department.Finance,
                IsActive = true
            },

            new Employee
            {
                Id = 3,
                FirstName = "David",
                LastName = "Brown",
                Email = "david.brown@company.com",
                PhoneNumber = "08111222333",
                DateOfBirth = new DateTime(1988, 12, 5),
                DateHired = new DateTime(2020, 8, 1),
                Salary = 510000m,
                Department = Department.HumanResources,
                IsActive = true
            },

            new Employee
            {
                Id = 4,
                FirstName = "Sarah",
                LastName = "Uche",
                Email = "sarah.uche@company.com",
                PhoneNumber = "07099887766",
                DateOfBirth = new DateTime(1995, 2, 14),
                DateHired = new DateTime(2023, 4, 10),
                Salary = 290000m,
                Department = Department.Marketing,
                IsActive = true
            },

            new Employee
            {
                Id = 5,
                FirstName = "Obiageli",
                LastName = "Taylor",
                Email = "obiageli.taylor@company.com",
                PhoneNumber = "08155667788",
                DateOfBirth = new DateTime(1991, 11, 27),
                DateHired = new DateTime(2019, 9, 16),
                Salary = 600000m,
                Department = Department.Operations,
                IsActive = true
            });
        }
    }
}
