namespace TouchpointDBWebService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Underviser")]
    public partial class Underviser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Underviser()
        {
            UnderviserPåKursus = new HashSet<UnderviserPåKursus>();
            
        }

        public int UnderviserID { get; set; }

        [Required]
        [StringLength(100)]
        public string Navn { get; set; }

        [Required]
        [StringLength(100)]
        public string Adresse { get; set; }

        [Required]
        [StringLength(100)]
        public string Telefon { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnderviserPåKursus> UnderviserPåKursus { get; set; }
    }
}
