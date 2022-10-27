namespace TestSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentsTest")]
    public partial class StudentsTest
    {
        public int Id { get; set; }

        public int? TestID { get; set; }

        public int StudentId { get; set; }

        public int? result { get; set; }

        public int attemtsLeft { get; set; }

        public DateTime? time { get; set; }

        public virtual Student Student { get; set; }

        public virtual Test Test { get; set; }
    }
}
