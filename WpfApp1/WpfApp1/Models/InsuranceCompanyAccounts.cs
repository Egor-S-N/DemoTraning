namespace WpfApp1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InsuranceCompanyAccounts
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAccountant { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdOrder { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdInsuranceCompany { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal InvoiceIssued { get; set; }

        public virtual Accountant Accountant { get; set; }

        public virtual InsuranceCompany InsuranceCompany { get; set; }

        public virtual Order Order { get; set; }
    }
}
