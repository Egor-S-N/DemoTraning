namespace WpfApp1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            InsuranceCompanyAccounts = new HashSet<InsuranceCompanyAccounts>();
            OrderLaboratoryServices = new HashSet<OrderLaboratoryServices>();
            ServiceRendered = new HashSet<ServiceRendered>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdOrder { get; set; }

        public int IdPatient { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfCreation { get; set; }

        public bool OrderStatus { get; set; }

        public int ExecutionTime { get; set; }

        public virtual AnalyzerOperationOrder AnalyzerOperationOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InsuranceCompanyAccounts> InsuranceCompanyAccounts { get; set; }

        public virtual PatientData PatientData { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderLaboratoryServices> OrderLaboratoryServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceRendered> ServiceRendered { get; set; }
    }
}
