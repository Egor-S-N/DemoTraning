using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WpfApp1.Models
{
    public partial class Demo : DbContext
    {
        public Demo()
            : base("Demo")
        {
        }

        public virtual DbSet<Accountant> Accountant { get; set; }
        public virtual DbSet<Administrator> Administrator { get; set; }
        public virtual DbSet<AnalyzerOperationOrder> AnalyzerOperationOrder { get; set; }
        public virtual DbSet<BarcodePatient> BarcodePatient { get; set; }
        public virtual DbSet<DataOfLaboratoryAssistants> DataOfLaboratoryAssistants { get; set; }
        public virtual DbSet<DataOnAnalyzerOperation> DataOnAnalyzerOperation { get; set; }
        public virtual DbSet<InsuranceCompany> InsuranceCompany { get; set; }
        public virtual DbSet<LaboratoryServices> LaboratoryServices { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<PatientData> PatientData { get; set; }
        public virtual DbSet<ServiceRendered> ServiceRendered { get; set; }
        public virtual DbSet<InsuranceCompanyAccounts> InsuranceCompanyAccounts { get; set; }
        public virtual DbSet<OrderLaboratoryServices> OrderLaboratoryServices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accountant>()
                .HasMany(e => e.InsuranceCompanyAccounts)
                .WithRequired(e => e.Accountant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BarcodePatient>()
                .Property(e => e.Bracode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DataOfLaboratoryAssistants>()
                .HasMany(e => e.ServiceRendered)
                .WithRequired(e => e.DataOfLaboratoryAssistants)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DataOfLaboratoryAssistants>()
                .HasMany(e => e.LaboratoryServices)
                .WithMany(e => e.DataOfLaboratoryAssistants)
                .Map(m => m.ToTable("LaboratoryAssistantsServices").MapLeftKey("IdAssistant").MapRightKey("IdService"));

            modelBuilder.Entity<DataOnAnalyzerOperation>()
                .HasMany(e => e.AnalyzerOperationOrder)
                .WithRequired(e => e.DataOnAnalyzerOperation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DataOnAnalyzerOperation>()
                .HasMany(e => e.ServiceRendered)
                .WithRequired(e => e.DataOnAnalyzerOperation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InsuranceCompany>()
                .Property(e => e.INN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InsuranceCompany>()
                .Property(e => e.PaymentAccount)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InsuranceCompany>()
                .Property(e => e.BIC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InsuranceCompany>()
                .HasMany(e => e.InsuranceCompanyAccounts)
                .WithRequired(e => e.InsuranceCompany)
                .HasForeignKey(e => e.IdInsuranceCompany)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InsuranceCompany>()
                .HasMany(e => e.PatientData)
                .WithRequired(e => e.InsuranceCompany)
                .HasForeignKey(e => e.IdInsuranceCompany)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LaboratoryServices>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<LaboratoryServices>()
                .HasMany(e => e.OrderLaboratoryServices)
                .WithRequired(e => e.LaboratoryServices)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LaboratoryServices>()
                .HasMany(e => e.ServiceRendered)
                .WithRequired(e => e.LaboratoryServices)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasOptional(e => e.AnalyzerOperationOrder)
                .WithRequired(e => e.Order);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.InsuranceCompanyAccounts)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderLaboratoryServices)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.ServiceRendered)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PatientData>()
                .Property(e => e.InsurancePolicyNumber)
                .IsUnicode(false);

            modelBuilder.Entity<PatientData>()
                .Property(e => e.EIN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PatientData>()
                .Property(e => e.TypeOfInsurancePolicy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PatientData>()
                .Property(e => e.Telephone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PatientData>()
                .Property(e => e.PassportSeries)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PatientData>()
                .Property(e => e.PassportNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PatientData>()
                .HasMany(e => e.BarcodePatient)
                .WithRequired(e => e.PatientData)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PatientData>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.PatientData)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InsuranceCompanyAccounts>()
                .Property(e => e.InvoiceIssued)
                .HasPrecision(10, 2);
        }
    }
}
