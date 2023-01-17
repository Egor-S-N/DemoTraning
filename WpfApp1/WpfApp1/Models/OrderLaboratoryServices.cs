namespace WpfApp1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderLaboratoryServices
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdOrder { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdService { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool ServiceStatus { get; set; }

        public virtual LaboratoryServices LaboratoryServices { get; set; }

        public virtual Order Order { get; set; }
    }
}
