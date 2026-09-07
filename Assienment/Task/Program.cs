namespace Task
{
    internal class Student
    {
        string Name;
        int Age;
        int Grade;

        public Student(string name, int age, int grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Grade: " + Grade);
        }

        public void IsPassed()
        {
            if (Grade >= 50)
                Console.WriteLine("Passed");
            else
                Console.WriteLine("Failed");
        }
        public void GetGradeStatus()
        {
            if (Grade >= 90 && Grade <= 100)
                Console.WriteLine("Excellent");
            else if (Grade >= 75 && Grade <= 89)
                Console.WriteLine("Very Good");
            else if (Grade >= 60 && Grade <= 74)
                Console.WriteLine("Good");
            else if (Grade >= 50 && Grade <= 59)
                Console.WriteLine("Pass");
            else
                Console.WriteLine("Failed");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Student student1 = new Student("Ahmed", 20, 85);
                Student student2 = new Student("Mohamed", 21, 45);
                Student student3 = new Student("Omar", 19, 70);

                student1.DisplayInfo();
                student1.IsPassed();
                student1.GetGradeStatus();

                student2.DisplayInfo();
                student2.IsPassed();
                student2.GetGradeStatus();

                student3.DisplayInfo();
                student3.IsPassed();
                student3.GetGradeStatus();
            }
        }
    }
}
