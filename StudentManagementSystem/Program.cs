using static System.Net.WebRequestMethods;
using static System.Reflection.Metadata.BlobBuilder;

namespace StudentManagementSystem
{
    class StudentManager 
    {
        List<Student> students = new List<Student>();
        List<Course> courses = new List<Course>();
        List<Instructor> instructors = new List<Instructor>();
        
        public bool AddStudent(Student student)
        {  
                students.Add(student);
                
            
            return true;
        } 
        public void ShowStudent()
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"StudentId : {students[i].StudentId}");
                Console.WriteLine($"StudentName : {students[i].Name} ");
                Console.WriteLine($"StudentAge : {students[i].Age} ");
                Console.WriteLine("////////////////////////");
            }
        }

        public bool AddCourse(Course course)
        {
            courses.Add(course);

            return true;
        }

        public void ShowCourse()
        {
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"CourseId : {courses[i].CourseId}");
                Console.WriteLine($"CourseTitle : {courses[i].Title} ");
                Console.WriteLine("////////////////////////");
            }
        }

        public bool AddInstructor(Instructor instructor)
        {
            instructors.Add(instructor);

            return true;
        }

        public void ShowInstructor()
        {
            for (int i = 0; i < instructors.Count; i++)
            {
                Console.WriteLine($"InstructorId : {instructors[i].InstructorId}");
                Console.WriteLine($"Instructor Name : {instructors[i].Name} ");
                Console.WriteLine($"Specialization : {instructors[i].Specilization} "); 
               Console.WriteLine("////////////////////////");
            }
        }

        public Student FindStudent(int  value )
        {
            for (int i = 0; i < students.Count; i++) 
            {
                
                if(students[i].StudentId == value) 
                {
                    Console.WriteLine($"StudentId : {students[i].StudentId}");
                    Console.WriteLine($"StudentName : {students[i].Name} ");
                    Console.WriteLine($"StudentAge : {students[i].Age} ");
                    Console.WriteLine("////////////////////////");
                }
               
                
            }
            return null ;
        }

        public Course FindCourse(int id)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].CourseId == id)
                {
                    Console.WriteLine($"CourseId : {courses[i].CourseId}");
                    Console.WriteLine($"CourseTitle : {courses[i].Title} ");
                    Console.WriteLine("////////////////////////");
                }
            }
                return null;
        }

        public virtual bool Enroll(Course course)
        {
            

            return true;
        }

        public virtual string PrintDetials()
        {
            return "Hello in the schoool";
        }

    }
     class Course : StudentManager
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        Instructor Instructor;

        public Course(int courseId, string title)
        {
            CourseId = courseId;
            Title = title;
        }

        public override string PrintDetials()
        {
            //CourseId = Convert.ToInt32(Console.ReadLine());
            //title = Console.ReadLine();
            return $"Course ID is : {CourseId} ... its Title : {Title} " +
                $"and its instructor details :   {Instructor.PrintDetials()}";
            
        }

    }
    class Instructor : StudentManager
    {
        public Instructor(int instructorId, string name, string specilization)
        {
            InstructorId = instructorId;
            Name = name;
            Specilization = specilization;
        }

        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string Specilization { get; set; }

        
        public override string PrintDetials()
        {
            //CourseId = Convert.ToInt32(Console.ReadLine());
            //title = Console.ReadLine();
            return 
             $"Instructor ID is {InstructorId} ... its Name {Name} and Spectialization is {Specilization} ";
        }



    }
    class Student :StudentManager
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

       public List<Course> courses = new List<Course>();

        public Student(int studentId, string name, int age)
        {
           StudentId = studentId;
           Name = name;
           Age = age;
        }
        public Student() { }

        public override bool Enroll(Course course)
        { 
          courses.Add(course);
            
            return true;
        }
        public override string PrintDetials()
        {
            //CourseId = Convert.ToInt32(Console.ReadLine());
            //title = Console.ReadLine();
            return
             $"Student ID is {StudentId} ... its Name {Name} and it's age:  {Age} ";
        }



    }

    internal class Program
    {
        static void Main(string[] args)
        {
           
            StudentManager manager = new StudentManager();
            Student student = new Student();
            for (int a = 0; a >= 0; a++)
            {
                Console.WriteLine("WELCOME ON THE SCHOOL SITE");
                Console.WriteLine("MENU :");
                Console.WriteLine("1- Add Student");
                Console.WriteLine("2- Add Instructor");
                Console.WriteLine("3- Add Course");
                Console.WriteLine("4- Enroll student in course");
                Console.WriteLine("5- Show all students");
                Console.WriteLine("6- Show all courses");
                Console.WriteLine("7- Show all Instructors");
                Console.WriteLine("8- Find the student by (Id OR Name)");
                Console.WriteLine("9- Find the Course by (Id OR Name)");
                Console.WriteLine("10- Check if the student enrolled in course");
                Console.WriteLine("11- Return the instructor name by course name");
                Console.WriteLine("12- Exit");
                
                Console.Write("Enter your choice : ");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)

                {
                    case 1:
                        Console.Write("Enter StudentId : ");
                        int StudentId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter StudentName : ");
                        string Name = (Console.ReadLine());
                        Console.Write("Enter StudentAge : ");
                        int Age = Convert.ToInt32(Console.ReadLine());
                        manager.AddStudent(new Student(StudentId, Name, Age));
                        Console.WriteLine("Student is added");
                        break;
                    
                    case 2:
                        Console.Write("Enter InstructorId : ");
                        int InstructorId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter InstructorName : ");
                        string InstructorName = (Console.ReadLine());
                        Console.Write("Enter Specialization : ");
                        string Specialization = (Console.ReadLine());
                        manager.AddInstructor(new Instructor(InstructorId,InstructorName,Specialization));
                        Console.WriteLine("Instructor is added");
                        break;
                    
                    
                    case 3:
                        Console.Write("Enter CoursetId : ");
                        int CourseId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Title : ");
                        string Title = (Console.ReadLine());
                        manager.AddCourse(new Course(CourseId, Title));
                        Console.WriteLine("Course is added");
                        break;


                    case 4:
                        Console.WriteLine("Enter Course you want to Enroll");
                        Console.Write("Enter CoursetId : ");
                        CourseId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Title : ");
                         Title = (Console.ReadLine());
                        manager.Enroll(new Course(CourseId, Title));
                        Console.WriteLine("Course is enrolled");
                    break;


                    case 5:
                        manager.ShowStudent();
                        break;
                    case 6:
                        manager.ShowCourse();
                        break;
                    case 7:
                        manager.ShowInstructor();
                        break;
                    case 8:
                        Console.Write("Enter StudentId : ");
                         StudentId = Convert.ToInt32(Console.ReadLine());
                       // Console.Write("Enter StudentName : ");
                        //Name = (Console.ReadLine());
                        //Console.Write("Enter StudentAge : ");
                        manager.FindStudent( StudentId);
                        break;
                    case 9:
                        Console.Write("Enter CoursetId : ");
                        CourseId = Convert.ToInt32(Console.ReadLine());
                        manager.FindCourse( CourseId);
                        break;

                    case 12:
                        Console.WriteLine("Bye bye");
                        return;
                        break;
                }



            }

        }
    }
}
