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
            //Student s = new Student();

            //-------------INSERTING RECORD---------------------------

            //s.Name = "lmn";
            //s.Rollno = 5;
            //s.Class = "5";
            //context.Students.Add(s);

            //context.SaveChanges();

            //Score score = new Score();
            //score.Studentid = 5;
            //score.Subject1 = 45;
            //score.Subject2 = 75;

            //context.Scores.Add(score);

            //context.SaveChanges();

            //-------------UPDATING RECORD--------------------------

            //var lmn = (from s in context.Students
            //           where s.Name == "lmn"
            //           select s).First();

            //lmn.Name = "modified lmn";
            //context.Entry<Student>(lmn).State = EntityState.Modified;
            //context.SaveChanges();


            //--------------DELETING RECORD BY NAME----------------------------

            //var def = context.Students.Where(s => s.Name == "def").FirstOrDefault();                ;

            //var defScore = context.Scores.Where(s => s.Studentid == def.Id)
            //    .FirstOrDefault();

            //context.Scores.Remove(defScore);
            //context.SaveChanges();
            //context.Students.Remove(def);
            //context.SaveChanges();


            //--------------GETTING ALL STUDENTS WITH SCORES USING WHERE CLAUSE--------------------------

            //var allStudents = context.Students.ToList();

            //foreach (var student in allStudents)
            //{
            //    Console.WriteLine("Name : {0}", student.Name);
            //    Console.WriteLine("Rollno : {0}", student.Rollno);
            //    Console.WriteLine("Class : {0}", student.Class);
            //    Console.WriteLine("Scores : ");
            //    var studentScores = (from sc in context.Scores
            //                         where sc.Studentid == student.Id
            //                         select sc).FirstOrDefault();

            //    Console.WriteLine("Subject 1 : {0} and Subject 2 : {1}",
            //        studentScores.Subject1, studentScores.Subject2);
            //    Console.WriteLine();
            //}


            //------------GET NUMBER OF STUDENTS PER CLASS---------------

            var classWiseStudents = from student in context.Students.AsEnumerable<Student>()
                                    group student by student.Class into classgroup
                                    orderby classgroup.Key
                                    select classgroup;

            foreach (var group in classWiseStudents)
            {
                Console.WriteLine("Class  : {0}, has {1} students",
                    group.Key, group.Count());
            }


            //------------TOPPER IN SUBJECT 1------------------------ -

            //var subject1Topper = (from student in context.Students
            //                      where student.Id == (from score in context.Scores
            //                                           where score.Subject1 ==
            //                                           (context.Scores.Max(s => s.Subject1))
            //                                           select score.Studentid).First()
            //                      select student).First();
            //Console.WriteLine(subject1Topper.Rollno);


            ////----------------TOPPER IN SUBJECT 2--------------------------------

            //var subject2Topper = (from student in context.Students
            //                      where student.Id == (from score in context.Scores
            //                                           where score.Subject2 ==
            //                                           (context.Scores.Max(s => s.Subject2))
            //                                           select score.Studentid).First()
            //                      select student).First();
            //Console.WriteLine(subject2Topper.Rollno);


            //---------GETTING DETAILS OF PARTICULAR STUDENT BY NAME WITH SCORES------------

            //Console.Write("Name of student : ");
            //var name = Console.ReadLine().ToLower();

            //var selectedStudent = context.Students.Where(s => s.Name == name).FirstOrDefault();

            //Console.WriteLine("Name : {0}", selectedStudent.Name);
            //Console.WriteLine("Rollno : {0}", selectedStudent.Rollno);
            //Console.WriteLine("Class : {0}", selectedStudent.Class);

            //var selectedStudentScores = (from score in context.Scores
            //                             where score.Studentid == selectedStudent.Id
            //                             select score).FirstOrDefault();

            //if (selectedStudentScores != null)
            //{
            //    Console.WriteLine("Scores : Subject 1 {0}, Subject 2 {1}",
            //        selectedStudentScores.Subject1, selectedStudentScores.Subject2);
            //}


            //--------------GETTING TOTAL SCORE OF A PARTICULAR STUDENT BY NAME------------------

            //var selectedStudent = (from student in context.Students
            //                       join score in context.Scores
            //                       on student.Id equals score.Studentid
            //                       where student.Name == name
            //                       select new
            //                       {
            //                           Id = student.Id,
            //                           Name = student.Name,
            //                           Rollno = student.Rollno,
            //                           Subject1 = score.Subject1,
            //                           Subject2 = score.Subject2,
            //                           Class = student.Class,
            //                           TotalScore = score.Subject1 + score.Subject2
            //                       }).First();

            //Console.WriteLine(selectedStudent.Name + ": " + selectedStudent.TotalScore);

            //--------------GETTING TOTAL SCORE OF ALL STUDENTS----------------

            //var meritList = from student in context.Students
            //                join score in context.Scores
            //                on student.Id equals score.Studentid
            //                select new
            //                {
            //                    Id = student.Id,
            //                    Name = student.Name,
            //                    Rollno = student.Rollno,
            //                    Subject1 = score.Subject1,
            //                    Subject2 = score.Subject2,
            //                    Class = student.Class,
            //                    TotalScore = score.Subject1 + score.Subject2
            //                };

            //foreach (var item in meritList)
            //{
            //    Console.WriteLine(item.Id + ": " + item.Name + ": " + item.TotalScore);
            //}


        }
    }
}
