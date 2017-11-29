namespace TouchpointDBWebService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DeltagerIKursus
    {
        public int DeltagerIKursusID { get; set; }

        public int KursistID { get; set; }

        public int KursusID { get; set; }

        public virtual Kursist Kursist { get; set; }

        public virtual Kursus Kursus { get; set; }
    }
}
