namespace LINQBasic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var students = GetStudents();

            //Print(students.Where(s => s.Age == 24 ));

            //foreach (var student in students.Where(s => s.Age == 24))
            //{
            //    Console.WriteLine(student);
            //}

            var hs = GetStudents().Where(s => s.Age == 24).Skip(1).Take(2);
            foreach (var student in hs)
            {
                Console.WriteLine(student);
            }
        }

        static IEnumerable<Student> GetStudents() 
        {
            return new Student[]
            {
                new Student { Name = "Thong", Address = "123 Main St", Age = 24 },
                new Student { Name = "Thong 1", Address = "123 Main St", Age = 24 },
                new Student { Name = "Thong 2", Address = "123 Main St", Age = 24 },
                new Student { Name = "Thong 3", Address = "123 Main St", Age = 24 },
                new Student { Name = "Jane", Address = "345 Elm St", Age = 22 },
                new Student { Name = "Joe", Address = "567 Maple St", Age = 23 }
            };
        }

        //static void Print(Student student)
        //{
        //    Console.WriteLine($"Name:{student.Name}, Address: {student.Address}, Age:{student.Age} ");
        //}

        static void Print(IEnumerable<Student> list)
        {
            Console.WriteLine();
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
