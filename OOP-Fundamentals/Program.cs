using OOP_Fundamentals.Procedural_Approach;

namespace OOP_Fundamentals
{
    internal class Program
    {
        static List<Dictionary<string, object>> classes = new List<Dictionary<string, object>>();

        static void AddClass(string className)
        {
            var newClass = new Dictionary<string, object>
        {
            { "Name", className },
            { "Students", new List<Dictionary<string, string>>() },
            { "Teachers", new List<Dictionary<string, List<string>>>() }
        };
            classes.Add(newClass);
        }

        static void AddStudent(string className, string studentName, int id)
        {
            foreach (var schoolClass in classes)
            {
                if ((string)schoolClass["Name"] == className)
                {
                    var students = (List<Dictionary<string, string>>)schoolClass["Students"];
                    students.Add(new Dictionary<string, string>
                {
                    { "Name", studentName },
                    { "ID", id.ToString() }
                });
                }
            }
        }

        static void AddTeacher(string className, string teacherName, List<string> courses)
        {
            foreach (var schoolClass in classes)
            {
                if ((string)schoolClass["Name"] == className)
                {
                    var teachers = (List<Dictionary<string, List<string>>>)schoolClass["Teachers"];
                    teachers.Add(new Dictionary<string, List<string>>
                {
                    { teacherName, courses }
                });
                }
            }
        }

        static void DisplaySchool()
        {
            foreach (var schoolClass in classes)
            {
                Console.WriteLine($"Class: {schoolClass["Name"]}");
                Console.WriteLine("Students:");
                foreach (var student in (List<Dictionary<string, string>>)schoolClass["Students"])
                {
                    Console.WriteLine($" - {student["Name"]} (ID: {student["ID"]})");
                }
                Console.WriteLine("Teachers:");
                foreach (var teacher in (List<Dictionary<string, List<string>>>)schoolClass["Teachers"])
                {
                    foreach (var item in teacher)
                    {
                        Console.WriteLine($" - {item.Key} teaches: {string.Join(", ", item.Value)}");
                    }
                }
            }
        }

        static void Main()
        {
            //AddClass("Math101");
            //AddStudent("Math101", "Alice", 1);
            //AddStudent("Math101", "Bob", 2);
            //AddTeacher("Math101", "Mr. Smith", new List<string> { "Algebra", "Geometry" });

            //DisplaySchool();

            // LibraryProcedural.CallProcedure();
        }
    }
}
