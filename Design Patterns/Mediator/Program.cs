using System;
using System.Collections.Generic;

namespace Mediator
{
    internal class Program
    {
        // Nesneler arasındaki iletişimi merkezi bir aracı üzerinden yönetir.
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();
            
            Teacher teacher = new Teacher(mediator);
            teacher.Name = "Utku";

            mediator.Teacher = teacher;

            Student student = new Student(mediator);
            student.Name = "Umut";

            Student student1 = new Student(mediator);
            student.Name = "Nuray";

            mediator.Students = new List<Student> { student, student1 };

            teacher.SendNewImageUrl("slide1.jpg");

            Console.ReadLine();
        }
    }

    abstract class CourseMember
    {
        protected Mediator Mediator;

        public CourseMember(Mediator mediator)
        {
            Mediator = mediator;
        }
    }

    class Teacher : CourseMember
    {
        public Teacher(Mediator mediator) : base(mediator)
        {
        }

        internal void RecieveQuestion(string question, Student student)
        {
            Console.WriteLine("Teacher recieved question from {0}, {1}", student.Name, question);
        }

        public void SendNewImageUrl(string url)
        {
            Console.WriteLine("Teacher changed slide : {0}", url);
            Mediator.UpdateImage(url);
        }

        public void AnswerQuestion(string answer, Student student)
        {
            Console.WriteLine("Teacher answered question {0}, {1}", student.Name, answer);
        }

        public string Name { get; set; }
    }

    class Student : CourseMember
    {
        public Student(Mediator mediator) : base(mediator)
        {
        }

        internal void RecieveImage(string url)
        {
            Console.WriteLine("{1} recived Image : {0}", url, Name);
        }

        internal void RecieveAnswer(string answer)
        {
            Console.WriteLine("Student recieved answewr {0}", answer);
        }

        public string Name { get; set; }
    }

    class Mediator
    {
        public Teacher Teacher { get; set; }

        public List<Student> Students { get; set; }

        public void UpdateImage(string url)
        {
            foreach (var student in Students)
            {
                student.RecieveImage(url);
            }
        }

        public void SendQuestion(string question, Student student)
        {
            Teacher.RecieveQuestion(question, student);
        }

        public void SendAnswer(string answer, Student student)
        {
            student.RecieveAnswer(answer);
        }
    }
}
