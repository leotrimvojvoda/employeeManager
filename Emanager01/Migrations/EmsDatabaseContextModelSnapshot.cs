﻿// <auto-generated />
using System;
using Emanager01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Emanager01.Migrations
{
    [DbContext(typeof(EmsDatabaseContext))]
    partial class EmsDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Emanager01.Models.Address", b =>
                {
                    b.Property<string>("AddressId")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("addressId")
                        .UseCollation("utf8mb4_0900_ai_ci")
                        .HasCharSet("utf8mb4");

                    b.Property<string>("City")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("city")
                        .UseCollation("utf8mb4_0900_ai_ci")
                        .HasCharSet("utf8mb4");

                    b.Property<int?>("HouseNumber")
                        .HasColumnType("int")
                        .HasColumnName("houseNumber");

                    b.Property<string>("State")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("state")
                        .UseCollation("utf8mb4_0900_ai_ci")
                        .HasCharSet("utf8mb4");

                    b.Property<string>("Street")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("street")
                        .UseCollation("utf8mb4_0900_ai_ci")
                        .HasCharSet("utf8mb4");

                    b.HasKey("AddressId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Emanager01.Models.Contract", b =>
                {
                    b.Property<string>("ContractId")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("contractId")
                        .UseCollation("utf8mb4_0900_ai_ci")
                        .HasCharSet("utf8mb4");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date")
                        .HasColumnName("endDate");

                    b.Property<decimal?>("Salary")
                        .HasPrecision(10)
                        .HasColumnType("decimal(10)")
                        .HasColumnName("salary");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date")
                        .HasColumnName("startDate");

                    b.HasKey("ContractId");

                    b.ToTable("Contract");
                });

            modelBuilder.Entity("Emanager01.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("employee_Id");

                    b.Property<string>("AddressId")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("addressId")
                        .UseCollation("utf8mb4_0900_ai_ci")
                        .HasCharSet("utf8mb4");

                    b.Property<string>("ContractId")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("contractId")
                        .UseCollation("utf8mb4_0900_ai_ci")
                        .HasCharSet("utf8mb4");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("dateOfBirth");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email")
                        .UseCollation("utf8mb4_0900_ai_ci")
                        .HasCharSet("utf8mb4");

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("firstName")
                        .UseCollation("utf8mb4_0900_ai_ci")
                        .HasCharSet("utf8mb4");

                    b.Property<string>("Gender")
                        .HasColumnType("char(1)")
                        .HasColumnName("gender")
                        .UseCollation("utf8mb4_0900_ai_ci")
                        .HasCharSet("utf8mb4");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("lastName")
                        .UseCollation("utf8mb4_0900_ai_ci")
                        .HasCharSet("utf8mb4");

                    b.Property<int?>("Phone")
                        .HasColumnType("int")
                        .HasColumnName("phone");

                    b.Property<string>("Position")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("position")
                        .UseCollation("utf8mb4_0900_ai_ci")
                        .HasCharSet("utf8mb4");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Emanager01.Models.Manager", b =>
                {
                    b.Property<int>("ManagerId")
                        .HasColumnType("int")
                        .HasColumnName("managerId");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("dateOfBirth");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email")
                        .UseCollation("utf8mb4_0900_ai_ci")
                        .HasCharSet("utf8mb4");

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("firstName")
                        .UseCollation("utf8mb4_0900_ai_ci")
                        .HasCharSet("utf8mb4");

                    b.Property<string>("Gender")
                        .HasColumnType("char(1)")
                        .HasColumnName("gender")
                        .UseCollation("utf8mb4_0900_ai_ci")
                        .HasCharSet("utf8mb4");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("lastName")
                        .UseCollation("utf8mb4_0900_ai_ci")
                        .HasCharSet("utf8mb4");

                    b.Property<int?>("Phone")
                        .HasColumnType("int")
                        .HasColumnName("phone");

                    b.HasKey("ManagerId");

                    b.ToTable("Manager");
                });

            modelBuilder.Entity("Emanager01.Models.Remark", b =>
                {
                    b.Property<int>("RemarksId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("remarksId");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("employeeId");

                    b.Property<string>("Remark1")
                        .HasColumnType("varchar(250)")
                        .HasColumnName("remark")
                        .UseCollation("utf8mb4_0900_ai_ci")
                        .HasCharSet("utf8mb4");

                    b.Property<DateTime?>("RemarkDate")
                        .HasColumnType("date")
                        .HasColumnName("remarkDate");

                    b.HasKey("RemarksId")
                        .HasName("PRIMARY");

                    b.ToTable("Remark");
                });
#pragma warning restore 612, 618
        }
    }
}
