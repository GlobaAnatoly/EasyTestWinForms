namespace TestSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            StudentsTest = new HashSet<StudentsTest>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string studentName { get; set; }

        [Required]
        [StringLength(50)]
        public string studentLogin { get; set; }

        [Required]
        public byte[] studentPassword { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentsTest> StudentsTest { get; set; }
    }
}
