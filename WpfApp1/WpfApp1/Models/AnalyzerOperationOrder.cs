namespace WpfApp1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AnalyzerOperationOrder")]
    public partial class AnalyzerOperationOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdOrder { get; set; }

        public int IdAnalyzerOperation { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateAndTimeOfReceipt { get; set; }

        public TimeSpan DateAndTimeOfExecution { get; set; }

        public virtual Order Order { get; set; }

        public virtual DataOnAnalyzerOperation DataOnAnalyzerOperation { get; set; }
    }
}
