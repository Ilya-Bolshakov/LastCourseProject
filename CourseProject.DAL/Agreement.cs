namespace CourseProject.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Agreement")]
    public partial class Agreement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Agreement()
        {
            House = new HashSet<House>();
        }

        [Key]
        public int IDAgreement { get; set; }

        public int IDCustomer { get; set; }

        [Column(TypeName = "date")]
        public DateTime AgreementDate { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public virtual Users Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<House> House { get; set; }
    }
}
