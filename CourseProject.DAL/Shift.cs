namespace CourseProject.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shift")]
    public partial class Shift
    {
        [Key]
        [Column(TypeName = "date")]
        public DateTime DateOfShift { get; set; }

        public int IDAdmin { get; set; }

        public int IDEmployeeOnReception { get; set; }

        public int IDFirstCleaner { get; set; }

        public int IDSecondCleaner { get; set; }

        public int IDThirdCleaner { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Employee Employee1 { get; set; }

        public virtual Employee Employee2 { get; set; }

        public virtual Employee Employee3 { get; set; }

        public virtual Employee Employee4 { get; set; }
    }
}
