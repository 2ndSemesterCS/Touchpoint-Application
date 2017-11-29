namespace TouchpointDBWebService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Kursus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kursus()
        {
            DeltagerIKursus = new HashSet<DeltagerIKursus>();
            UnderviserPåKursus = new HashSet<UnderviserPåKursus>();
        }

        public int KursusID { get; set; }

        public int? SerieID { get; set; }

        public int UndervisningsStedID { get; set; }

        [Column(TypeName = "money")]
        public decimal Pris { get; set; }

        [Required]
        [StringLength(100)]
        public string Sprog { get; set; }

        [Column(TypeName = "money")]
        public decimal Depositum { get; set; }

        [Required]
        [StringLength(100)]
        public string Dato { get; set; }

        [Required]
        [StringLength(255)]
        public string Beskrivelse { get; set; }

        [Required]
        [StringLength(100)]
        public string Varighed { get; set; }

        [Required]
        [StringLength(100)]
        public string Tidspunkt { get; set; }

        [Required]
        [StringLength(100)]
        public string Titel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeltagerIKursus> DeltagerIKursus { get; set; }

        public virtual Serie Serie { get; set; }

        public virtual UndervisningsSted UndervisningsSted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnderviserPåKursus> UnderviserPåKursus { get; set; }
    }
}
