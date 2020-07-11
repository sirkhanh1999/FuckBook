using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        // primary key
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        // foreign key (many entities)
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

