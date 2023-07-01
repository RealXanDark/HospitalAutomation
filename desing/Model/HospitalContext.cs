using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desing.Model
{
    public class HospitalContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Province> Provinces { get; set; }

        public DbSet<District> Districts { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Hospital> Hospitals { get; set; }

        public DbSet<Clinic> Clinics { get; set; }

        public DbSet<UserGroup> Groups { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<LabTest> Tests { get; set; }

        public DbSet<AppointmentTime> Times { get; set; }

        public DbSet<Nurse> Nurses { get; set; }

        public DbSet<Lab> Labs { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Visit> Visits { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog =HospitalDB; Integrated Security = true; Encrypt=false;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("tbl_users");
            modelBuilder.Entity<User>().HasKey(u => u.user_id);
            modelBuilder.Entity<User>().HasIndex(o => o.user_identity_no).IsUnique(true);
            modelBuilder.Entity<User>().HasIndex(o => o.user_phone_number).IsUnique(true);
            modelBuilder.Entity<User>().HasIndex(o => o.user_email).IsUnique(true);
            modelBuilder.Entity<User>().Property(o => o.user_identity_no).HasColumnType("nvarchar").HasMaxLength(11).IsRequired();
            modelBuilder.Entity<User>().Property(o => o.user_email).HasColumnType("nvarchar").HasMaxLength(70).IsRequired();
            modelBuilder.Entity<User>().Property(o => o.user_phone_number).HasColumnType("nvarchar").HasMaxLength(10).IsRequired();
            modelBuilder.Entity<User>().Property(o => o.user_password).HasColumnType("nvarchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<User>().Property(o => o.user_group_id).HasColumnType("tinyint").IsRequired();
            modelBuilder.Entity<Patient>().ToTable("tbl_patients");
            modelBuilder.Entity<Patient>().ToTable(tb => tb.HasTrigger("[dbo].[trg_insert_user]"));
            modelBuilder.Entity<Patient>().HasKey(u => u.patient_id);
            modelBuilder.Entity<Patient>().HasIndex(o => o.patient_identity_no).IsUnique(true);
            modelBuilder.Entity<Patient>().HasIndex(o => o.patient_phone_number).IsUnique(true);
            modelBuilder.Entity<Patient>().HasIndex(o => o.patient_email).IsUnique(true);
            modelBuilder.Entity<Patient>().Property(o => o.patient_identity_no).HasColumnType("nvarchar").HasMaxLength(11).IsRequired();
            modelBuilder.Entity<Patient>().Property(o => o.patient_name).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Patient>().Property(o => o.patient_surname).HasColumnType("nvarchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Patient>().Property(o => o.patient_date_of_birth).HasColumnType("date").IsRequired();
            modelBuilder.Entity<Patient>().Property(o => o.patient_gender).HasColumnType("nvarchar").HasMaxLength(5).IsRequired();
            modelBuilder.Entity<Patient>().Property(o => o.patient_blood_group).HasColumnType("nvarchar").HasMaxLength(7).IsRequired();
            modelBuilder.Entity<Patient>().Property(o => o.patient_phone_number).HasColumnType("nvarchar").HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Patient>().Property(o => o.patient_email).HasColumnType("nvarchar").HasMaxLength(70).IsRequired();   
            modelBuilder.Entity<Patient>().Property(o => o.patient_password).HasColumnType("nvarchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Doctor>().ToTable("tbl_doctors");
            //modelBuilder.Entity<Patient>().ToTable(tb => tb.HasTrigger("[dbo].[trg_insert_user]"));
            modelBuilder.Entity<Doctor>().HasKey(u => u.doctor_id);
            modelBuilder.Entity<Doctor>().HasIndex(o => o.doctor_identity_no).IsUnique(true);
            modelBuilder.Entity<Doctor>().HasIndex(o => o.doctor_phone_number).IsUnique(true);
            modelBuilder.Entity<Doctor>().HasIndex(o => o.doctor_email).IsUnique(true);
            modelBuilder.Entity<Doctor>().Property(o => o.doctor_identity_no).HasColumnType("nvarchar").HasMaxLength(11).IsRequired();
            modelBuilder.Entity<Doctor>().Property(o => o.doctor_name).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Doctor>().Property(o => o.doctor_surname).HasColumnType("nvarchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Doctor>().Property(o => o.doctor_date_of_birth).HasColumnType("date").IsRequired();
            modelBuilder.Entity<Doctor>().Property(o => o.doctor_gender).HasColumnType("nvarchar").HasMaxLength(5).IsRequired();
            modelBuilder.Entity<Doctor>().Property(o => o.doctor_blood_group).HasColumnType("nvarchar").HasMaxLength(7).IsRequired();
            modelBuilder.Entity<Doctor>().Property(o => o.doctor_phone_number).HasColumnType("nvarchar").HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Doctor>().Property(o => o.doctor_email).HasColumnType("nvarchar").HasMaxLength(70).IsRequired();
            modelBuilder.Entity<Doctor>().Property(o => o.doctor_password).HasColumnType("nvarchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Doctor>().Property(o => o.doctor_hospital_id).HasColumnType("tinyint").IsRequired();
            modelBuilder.Entity<Doctor>().Property(o => o.doctor_clinic_id).HasColumnType("tinyint").IsRequired();
            modelBuilder.Entity<Doctor>().Property(o => o.doctor_specialization_name).HasColumnType("nvarchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Province>().ToTable("tbl_provinces");
            modelBuilder.Entity<Province>().HasKey(o => o.province_id);
            modelBuilder.Entity<Province>().Property(o => o.province_name).HasColumnType("nvarchar").HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Province>().Property(o => o.province_has_branch).HasColumnType("tinyint").IsRequired().HasDefaultValue(0);
            modelBuilder.Entity<District>().ToTable("tbl_districts");
            modelBuilder.Entity<District>().HasKey(u => u.district_id);
            modelBuilder.Entity<District>().Property(o => o.district_name).HasColumnType("nvarchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<District>().Property(o => o.district_parent_id).HasColumnType("int").IsRequired();
            modelBuilder.Entity<District>().Property(o => o.district_has_branch).HasColumnType("tinyint").IsRequired().HasDefaultValue(0);
            modelBuilder.Entity<Hospital>().ToTable("tbl_hospital");
            modelBuilder.Entity<Hospital>().HasKey(u => u.hospital_id);
            modelBuilder.Entity<Hospital>().Property(o => o.hospital_name).HasColumnType("nvarchar").HasMaxLength(70).IsRequired();
            modelBuilder.Entity<Hospital>().Property(o => o.hospital_phone_number).HasColumnType("nvarchar").HasMaxLength(11).IsRequired();
            modelBuilder.Entity<Hospital>().Property(o => o.hospital_address).HasColumnType("nvarchar").HasMaxLength(255).IsRequired();
            modelBuilder.Entity<Hospital>().Property(o => o.hospital_province_id).HasColumnType("int").IsRequired();
            modelBuilder.Entity<Hospital>().Property(o => o.hospital_district_id).HasColumnType("int").IsRequired();
            modelBuilder.Entity<Clinic>().ToTable("tbl_clinic");
            modelBuilder.Entity<Clinic>().HasKey(u => u.clinic_id);
            modelBuilder.Entity<Clinic>().Property(o => o.clinic_name).HasColumnType("nvarchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Clinic>().Property(o => o.clinic_phone_number).HasColumnType("nvarchar").HasMaxLength(11).IsRequired();
            modelBuilder.Entity<Clinic>().Property(o => o.clinic_address).HasColumnType("nvarchar").HasMaxLength(255).IsRequired();
            modelBuilder.Entity<Clinic>().Property(o => o.clinic_hospital_id).HasColumnType("tinyint").IsRequired();
            modelBuilder.Entity<UserGroup>().ToTable("tbl_user_group");
            modelBuilder.Entity<UserGroup>().HasKey(o => o.group_id);
            modelBuilder.Entity<UserGroup>().Property(o => o.group_type).HasColumnType("nvarchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Appointment>().ToTable("tbl_appointment");
            modelBuilder.Entity<Appointment>().HasKey(o => o.appointment_id);
            modelBuilder.Entity<Appointment>().Property(o => o.patient_identity_no).HasColumnType("nvarchar").HasMaxLength(11).IsRequired();
            modelBuilder.Entity<Appointment>().Property(o => o.doctor_identity_no).HasColumnType("nvarchar").HasMaxLength(11).IsRequired();
            modelBuilder.Entity<Appointment>().Property(o => o.date).HasColumnType("date").IsRequired();
            modelBuilder.Entity<Appointment>().Property(o => o.time).HasColumnType("nvarchar").HasMaxLength(5).IsRequired();
            modelBuilder.Entity<Appointment>().Property(o => o.status).HasColumnType("nvarchar").HasMaxLength(20).IsRequired();
            modelBuilder.Entity<LabTest>().ToTable("tbl_labtest");
            modelBuilder.Entity<LabTest>().HasKey(o => o.test_id);
            modelBuilder.Entity<LabTest>().Property(o => o.patient_identity_no).HasColumnType("nvarchar").HasMaxLength(11);
            modelBuilder.Entity<LabTest>().Property(o => o.test_name).HasColumnType("nvarchar").HasMaxLength(50);
            modelBuilder.Entity<LabTest>().Property(o => o.date).HasColumnType("date");
            modelBuilder.Entity<LabTest>().Property(o => o.result).HasColumnType("nvarchar").HasMaxLength(100);
            modelBuilder.Entity<LabTest>().Property(o => o.remarks).HasColumnType("nvarchar").HasMaxLength(100);
            modelBuilder.Entity<LabTest>().Property(o => o.doctor_control).IsRequired().HasDefaultValue(0);
            modelBuilder.Entity<AppointmentTime>().ToTable("tbl_appointment_time");
            modelBuilder.Entity<AppointmentTime>().HasKey(o => o.appointment_time_id);
            modelBuilder.Entity<AppointmentTime>().Property(o => o.time).HasColumnType("nvarchar").HasMaxLength(5).IsRequired();
            modelBuilder.Entity<Nurse>().ToTable("tbl_nurses");
            modelBuilder.Entity<Nurse>().HasKey(n => n.nurse_id);
            modelBuilder.Entity<Nurse>().Property(n => n.nurse_identity_no).IsRequired().HasMaxLength(11);
            modelBuilder.Entity<Nurse>().Property(n => n.nurse_name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Nurse>().Property(n => n.nurse_surname).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Nurse>().Property(n => n.nurse_date_of_birth).IsRequired().HasColumnType("date");
            modelBuilder.Entity<Nurse>().Property(n => n.nurse_gender).IsRequired().HasMaxLength(5);
            modelBuilder.Entity<Nurse>().Property(n => n.nurse_blood_group).IsRequired().HasMaxLength(7);
            modelBuilder.Entity<Nurse>().Property(n => n.nurse_email).IsRequired().HasMaxLength(70);
            modelBuilder.Entity<Nurse>().Property(n => n.nurse_phone_number).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Nurse>().Property(n => n.nurse_password).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Nurse>().Property(n => n.nurse_hospital_id).IsRequired();
            modelBuilder.Entity<Nurse>().Property(n => n.nurse_clinic_id).IsRequired();
            modelBuilder.Entity<Lab>().ToTable("tbl_lab_technicians");
            modelBuilder.Entity<Lab>().HasKey(t => t.lab_id);
            modelBuilder.Entity<Lab>().Property(t => t.lab_identity_no).IsRequired().HasMaxLength(11);
            modelBuilder.Entity<Lab>().Property(t => t.lab_name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Lab>().Property(t => t.lab_surname).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Lab>().Property(t => t.lab_date_of_birth).IsRequired().HasColumnType("date");
            modelBuilder.Entity<Lab>().Property(t => t.lab_gender).IsRequired().HasMaxLength(5);
            modelBuilder.Entity<Lab>().Property(t => t.lab_blood_group).IsRequired().HasMaxLength(7);
            modelBuilder.Entity<Lab>().Property(t => t.lab_email).IsRequired().HasMaxLength(70);
            modelBuilder.Entity<Lab>().Property(t => t.lab_phone_number).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Lab>().Property(t => t.lab_password).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Lab>().Property(t => t.lab_hospital_id).IsRequired();
            modelBuilder.Entity<Employee>().ToTable("tbl_employees");
            modelBuilder.Entity<Employee>().HasKey(e => e.employee_id);
            modelBuilder.Entity<Employee>().Property(e => e.employee_identity_no).IsRequired().HasMaxLength(11);
            modelBuilder.Entity<Employee>().Property(e => e.employee_name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Employee>().Property(e => e.employee_surname).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Employee>().Property(e => e.employee_date_of_birth).IsRequired().HasColumnType("date");
            modelBuilder.Entity<Employee>().Property(e => e.employee_gender).IsRequired().HasMaxLength(5);
            modelBuilder.Entity<Employee>().Property(e => e.employee_blood_group).IsRequired().HasMaxLength(7);
            modelBuilder.Entity<Employee>().Property(e => e.employee_email).IsRequired().HasMaxLength(70);
            modelBuilder.Entity<Employee>().Property(e => e.employee_phone_number).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Employee>().Property(e => e.employee_password).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Employee>().Property(e => e.employee_hospital_id).IsRequired();
            modelBuilder.Entity<Visit>().ToTable("tbl_visits");
            modelBuilder.Entity<Visit>().HasKey(v => v.visit_id);
            modelBuilder.Entity<Visit>().Property(v => v.patient_identity_no).IsRequired();
            modelBuilder.Entity<Visit>().Property(v => v.visit_date).IsRequired().HasColumnType("date");
            modelBuilder.Entity<Visit>().Property(v => v.diagnosis).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Visit>().Property(v => v.medication).HasMaxLength(100).IsRequired();




        }
    }
}
