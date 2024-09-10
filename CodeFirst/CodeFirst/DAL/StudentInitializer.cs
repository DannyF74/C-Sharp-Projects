using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.DAL
{
    public class StudentInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StudentContext>
    {
        protected override void Seed(StudentContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstName="Danny", LastName="Firth", Age=27}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
        }
    }
}