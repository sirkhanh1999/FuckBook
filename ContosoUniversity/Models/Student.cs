using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
   // this class is called 'entity class' (as the DB table) written by C# OOP
   public class Student
   {
      // primary key
      public int ID { get; set; }
      public string LastName { get; set; }
      public string FirstMidName { get; set; }
      public DateTime EnrollmentDate { get; set; }
      // foreign key (many entities)
      public ICollection<Enrollment> Enrollments { get; set; }
   }
}