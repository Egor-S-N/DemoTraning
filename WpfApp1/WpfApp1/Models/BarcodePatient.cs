namespace WpfApp1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BarcodePatient")]
    public partial class BarcodePatient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(7)]
        public string Bracode { get; set; }

        public int IdPatient { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public virtual PatientData PatientData { get; set; }
    }
}
