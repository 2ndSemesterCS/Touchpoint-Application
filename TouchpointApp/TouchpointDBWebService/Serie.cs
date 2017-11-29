namespace TouchpointDBWebService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Serie")]
    public partial class Serie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Serie()
        {
            Kursus = new HashSet<Kursus>();
        }

        public int SerieID { get; set; }

        [Required]
        [StringLength(100)]
        public string SerieTitel { get; set; }

        [Required]
        [StringLength(255)]
        public string Beskrivelse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kursus> Kursus { get; set; }
    }
}
