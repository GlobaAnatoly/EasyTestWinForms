namespace TestSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Question")]
    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            AnswerVariant = new HashSet<AnswerVariant>();
        }

        public int Id { get; set; }

        public int? TestID { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public byte[] picture { get; set; }

        public int QuestionTypeId { get; set; }

        public int value { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnswerVariant> AnswerVariant { get; set; }

        public virtual QuestionType QuestionType { get; set; }

        public virtual Test Test { get; set; }
    }
}
