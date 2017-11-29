namespace TouchpointDBWebService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UnderviserPåKursus
    {
        public int UnderviserPåKursusId { get; set; }

        public int UnderviserId { get; set; }

        public int KursusId { get; set; }

        public virtual Kursus Kursus { get; set; }

        public virtual Underviser Underviser { get; set; }
    }
}
