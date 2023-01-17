namespace WpfApp1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceRendered")]
    public partial class ServiceRendered
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdOrder { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdService { get; set; }

        public int IdAnalyzerOperation { get; set; }

        public int IdAssistant { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateAndTimeOfCompletion { get; set; }

        public virtual DataOfLaboratoryAssistants DataOfLaboratoryAssistants { get; set; }

        public virtual DataOnAnalyzerOperation DataOnAnalyzerOperation { get; set; }

        public virtual LaboratoryServices LaboratoryServices { get; set; }

        public virtual Order Order { get; set; }
    }
}
