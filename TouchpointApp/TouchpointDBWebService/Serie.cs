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
        public int SerieID { get; set; }

        [Required]
        [StringLength(100)]
        public string KursusSerie { get; set; }

        [Required]
        [StringLength(255)]
        public string Beskrivelse { get; set; }
    }
}
