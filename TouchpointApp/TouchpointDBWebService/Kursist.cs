namespace TouchpointDBWebService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kursist")]
    public partial class Kursist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kursist()
        {
            DeltagerIKursus = new HashSet<DeltagerIKursus>();
        }

        public int kursistID { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Adresse { get; set; }

        [Required]
        [StringLength(100)]
        public string Land { get; set; }

        [Required]
        [StringLength(100)]
        public string By { get; set; }

        [StringLength(100)]
        public string tlf { get; set; }

        [Required]
        [StringLength(100)]
        public string Navn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeltagerIKursus> DeltagerIKursus { get; set; }
    }
}
