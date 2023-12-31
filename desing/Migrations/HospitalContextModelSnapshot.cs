﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using desing.Model;

#nullable disable

namespace desing.Migrations
{
    [DbContext(typeof(HospitalContext))]
    partial class HospitalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("desing.Model.Appointment", b =>
                {
                    b.Property<int>("appointment_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("appointment_id"));

                    b.Property<DateTime>("date")
                        .HasColumnType("date");

                    b.Property<string>("doctor_identity_no")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar");

                    b.Property<string>("patient_identity_no")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar");

                    b.Property<string>("time")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar");

                    b.HasKey("appointment_id");

                    b.ToTable("tbl_appointment", (string)null);
                });

            modelBuilder.Entity("desing.Model.AppointmentTime", b =>
                {
                    b.Property<int>("appointment_time_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("appointment_time_id"));

                    b.Property<string>("time")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar");

                    b.HasKey("appointment_time_id");

                    b.ToTable("tbl_appointment_time", (string)null);
                });

            modelBuilder.Entity("desing.Model.Clinic", b =>
                {
                    b.Property<int>("clinic_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("clinic_id"));

                    b.Property<string>("clinic_address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<byte>("clinic_hospital_id")
                        .HasColumnType("tinyint");

                    b.Property<string>("clinic_name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.Property<string>("clinic_phone_number")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar");

                    b.HasKey("clinic_id");

                    b.ToTable("tbl_clinic", (string)null);
                });

            modelBuilder.Entity("desing.Model.District", b =>
                {
                    b.Property<int>("district_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("district_id"));

                    b.Property<byte>("district_has_branch")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasDefaultValue((byte)0);

                    b.Property<string>("district_name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.Property<int>("district_parent_id")
                        .HasColumnType("int");

                    b.HasKey("district_id");

                    b.ToTable("tbl_districts", (string)null);
                });

            modelBuilder.Entity("desing.Model.Doctor", b =>
                {
                    b.Property<int>("doctor_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("doctor_id"));

                    b.Property<string>("doctor_blood_group")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar");

                    b.Property<byte>("doctor_clinic_id")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("doctor_date_of_birth")
                        .IsRequired()
                        .HasColumnType("date");

                    b.Property<string>("doctor_email")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar");

                    b.Property<string>("doctor_gender")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar");

                    b.Property<byte>("doctor_hospital_id")
                        .HasColumnType("tinyint");

                    b.Property<string>("doctor_identity_no")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar");

                    b.Property<string>("doctor_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<string>("doctor_password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.Property<string>("doctor_phone_number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar");

                    b.Property<string>("doctor_specialization_name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.Property<string>("doctor_surname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.HasKey("doctor_id");

                    b.HasIndex("doctor_email")
                        .IsUnique();

                    b.HasIndex("doctor_identity_no")
                        .IsUnique();

                    b.HasIndex("doctor_phone_number")
                        .IsUnique();

                    b.ToTable("tbl_doctors", (string)null);
                });

            modelBuilder.Entity("desing.Model.Employee", b =>
                {
                    b.Property<int>("employee_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("employee_id"));

                    b.Property<string>("employee_blood_group")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<DateTime>("employee_date_of_birth")
                        .HasColumnType("date");

                    b.Property<string>("employee_email")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("employee_gender")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("employee_hospital_id")
                        .HasColumnType("int");

                    b.Property<string>("employee_identity_no")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("employee_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("employee_password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("employee_phone_number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("employee_surname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("employee_id");

                    b.ToTable("tbl_employees", (string)null);
                });

            modelBuilder.Entity("desing.Model.Hospital", b =>
                {
                    b.Property<int>("hospital_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("hospital_id"));

                    b.Property<string>("hospital_address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<int>("hospital_district_id")
                        .HasColumnType("int");

                    b.Property<string>("hospital_name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar");

                    b.Property<string>("hospital_phone_number")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar");

                    b.Property<int>("hospital_province_id")
                        .HasColumnType("int");

                    b.HasKey("hospital_id");

                    b.ToTable("tbl_hospital", (string)null);
                });

            modelBuilder.Entity("desing.Model.Lab", b =>
                {
                    b.Property<int>("lab_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("lab_id"));

                    b.Property<string>("lab_blood_group")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<DateTime>("lab_date_of_birth")
                        .HasColumnType("date");

                    b.Property<string>("lab_email")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("lab_gender")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("lab_hospital_id")
                        .HasColumnType("int");

                    b.Property<string>("lab_identity_no")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("lab_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("lab_password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("lab_phone_number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("lab_surname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("lab_id");

                    b.ToTable("tbl_lab_technicians", (string)null);
                });

            modelBuilder.Entity("desing.Model.LabTest", b =>
                {
                    b.Property<int>("test_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("test_id"));

                    b.Property<DateTime>("date")
                        .HasColumnType("date");

                    b.Property<byte>("doctor_control")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasDefaultValue((byte)0);

                    b.Property<string>("patient_identity_no")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar");

                    b.Property<string>("remarks")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.Property<string>("result")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.Property<string>("test_name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.HasKey("test_id");

                    b.ToTable("tbl_labtest", (string)null);
                });

            modelBuilder.Entity("desing.Model.Nurse", b =>
                {
                    b.Property<int>("nurse_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("nurse_id"));

                    b.Property<string>("nurse_blood_group")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<int>("nurse_clinic_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("nurse_date_of_birth")
                        .HasColumnType("date");

                    b.Property<string>("nurse_email")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("nurse_gender")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("nurse_hospital_id")
                        .HasColumnType("int");

                    b.Property<string>("nurse_identity_no")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("nurse_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("nurse_password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("nurse_phone_number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("nurse_surname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("nurse_id");

                    b.ToTable("tbl_nurses", (string)null);
                });

            modelBuilder.Entity("desing.Model.Patient", b =>
                {
                    b.Property<int>("patient_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("patient_id"));

                    b.Property<string>("patient_blood_group")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar");

                    b.Property<DateTime?>("patient_date_of_birth")
                        .IsRequired()
                        .HasColumnType("date");

                    b.Property<string>("patient_email")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar");

                    b.Property<string>("patient_gender")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar");

                    b.Property<string>("patient_identity_no")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar");

                    b.Property<string>("patient_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<string>("patient_password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.Property<string>("patient_phone_number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar");

                    b.Property<string>("patient_surname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.HasKey("patient_id");

                    b.HasIndex("patient_email")
                        .IsUnique();

                    b.HasIndex("patient_identity_no")
                        .IsUnique();

                    b.HasIndex("patient_phone_number")
                        .IsUnique();

                    b.ToTable("tbl_patients", null, t =>
                        {
                            t.HasTrigger("[dbo].[trg_insert_user]");
                        });
                });

            modelBuilder.Entity("desing.Model.Province", b =>
                {
                    b.Property<int>("province_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("province_id"));

                    b.Property<byte>("province_has_branch")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasDefaultValue((byte)0);

                    b.Property<string>("province_name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar");

                    b.HasKey("province_id");

                    b.ToTable("tbl_provinces", (string)null);
                });

            modelBuilder.Entity("desing.Model.User", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("user_id"));

                    b.Property<string>("user_email")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar");

                    b.Property<byte>("user_group_id")
                        .HasColumnType("tinyint");

                    b.Property<string>("user_identity_no")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar");

                    b.Property<string>("user_password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.Property<string>("user_phone_number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar");

                    b.HasKey("user_id");

                    b.HasIndex("user_email")
                        .IsUnique();

                    b.HasIndex("user_identity_no")
                        .IsUnique();

                    b.HasIndex("user_phone_number")
                        .IsUnique();

                    b.ToTable("tbl_users", (string)null);
                });

            modelBuilder.Entity("desing.Model.UserGroup", b =>
                {
                    b.Property<int>("group_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("group_id"));

                    b.Property<string>("group_type")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.HasKey("group_id");

                    b.ToTable("tbl_user_group", (string)null);
                });

            modelBuilder.Entity("desing.Model.Visit", b =>
                {
                    b.Property<int>("visit_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("visit_id"));

                    b.Property<string>("diagnosis")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("medication")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("patient_identity_no")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("visit_date")
                        .HasColumnType("date");

                    b.HasKey("visit_id");

                    b.ToTable("tbl_visits", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
