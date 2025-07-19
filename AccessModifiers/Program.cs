
namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        private int id; //Private sadece tanımlandığı sınıf içerisinde kullanılabilir.
        protected string name; //Protected tanımlandığı sınıf ve ondan türüyen sınıf içerisinde kullanılabilir.

        public void Save()
        {
            id = 1;
            name = "Utku";
        }
    }

    class Student : Customer
    {
        public void Save()
        {
            name = "Umut";
        }
    }

    public class Courses
    {
        public string Name { get; set; }
    }
}
