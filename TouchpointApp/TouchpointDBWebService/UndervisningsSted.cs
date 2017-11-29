namespace TouchpointDBWebService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UndervisningsSted")]
    public partial class UndervisningsSted
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UndervisningsSted()
        {
            Kursus = new HashSet<Kursus>();
        }

        public int UndervisningsStedID { get; set; }

        [Required]
        [StringLength(100)]
        public string Lokale { get; set; }

        [Required]
        [StringLength(100)]
        public string Adresse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kursus> Kursus { get; set; }
    }
}
