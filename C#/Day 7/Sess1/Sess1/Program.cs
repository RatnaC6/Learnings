using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Sess1
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolDBContext context = new SchoolDBContext();
        Student s = new Student();
            //s.Name = "def";
            //s.Rollno = 10;
            //s.Class = "5";
            //context.Students.Add(s);

            //context.SaveChanges();

            //Score score = new Score();
            //score.Studentid = 7;
            //score.Subject1 = 85;
            //score.Subject2 = 90;

            //context.Scores.Add(score);

            //context.SaveChanges();

            //UPDATE
            var lmn = (from student in context.Students
                       where student.Name == "lmn"
                       select student).First();

        lmn.Name = "modified lmn";
            context.Entry<Student>(lmn).State = EntityState.Modified;
            context.SaveChanges();

            ////DELETE
            //var ghi = context.Students.Where(s => s.Name == "ghi")
            //    .FirstOrDefault();

            //var ghiScore = context.Scores.Where(s => s.Studentid == ghi.Id)
            //    .FirstOrDefault();

            //context.Scores.Remove(ghiScore);
            //context.Students.Remove(ghi);

            //context.SaveChanges();


            var allStudents = context.Students.ToList();

            foreach (var student in allStudents)
            {
                Console.WriteLine("Name : {0}",student.Name);
                Console.WriteLine("Rollno : {0}", student.Rollno);
                Console.WriteLine("Class : {0}", student.Class);
                Console.WriteLine("Scores : ");
                var studentScores = (from sc in context.Scores
                                    where sc.Studentid == student.Id
                                    select sc).FirstOrDefault();
                if(studentScores != null)
                {
                    Console.WriteLine("Subject 1 : {0} and Subject 2 : {1}",
                    studentScores.Subject1, studentScores.Subject2);
                }

                
                Console.WriteLine();
            }

        }
    }
}
