namespace CourseProject.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Visit")]
    public partial class Visit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Visit()
        {
            ServiceList = new HashSet<ServiceList>();
        }

        [Key]
        public int IDVisit { get; set; }

        public int IDEmployeeOnReception { get; set; }

        public int UserId { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfVisit { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfVisitEnd { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceList> ServiceList { get; set; }

        public virtual Users Users { get; set; }
    }
}
