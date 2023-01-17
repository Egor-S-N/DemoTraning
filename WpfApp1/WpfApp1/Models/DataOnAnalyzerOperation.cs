namespace WpfApp1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataOnAnalyzerOperation")]
    public partial class DataOnAnalyzerOperation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DataOnAnalyzerOperation()
        {
            AnalyzerOperationOrder = new HashSet<AnalyzerOperationOrder>();
            ServiceRendered = new HashSet<ServiceRendered>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAnalyzerOperation { get; set; }

        [Required]
        [StringLength(20)]
        public string NameAnalyzer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnalyzerOperationOrder> AnalyzerOperationOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceRendered> ServiceRendered { get; set; }
    }
}
