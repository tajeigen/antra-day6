namespace hw_day6;

class Program
{
    static int[] GenerateNumbers(int length = 10)
    {
        int [] numbers = new int[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = i+1;
        }
        return numbers;
    }

    static void Reverse(int[] numbers)
    {
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            int temp = numbers[i];
            int swapIndex = numbers.Length - i - 1;
            
            numbers[i] = numbers[swapIndex];
            numbers[swapIndex] = temp;
            
        }
    }

    static void PrintNumbers(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]+ " ");
        }
        // or 1 liner: 
        // Console.WriteLine(string.Join(" ", numbers));
    }

    static int RecursiveFibonacci(int n)
    {
        
        // F(5) = F(4) + F(3) 
        // F(4) = F(3) + F(2)  = F(3) + 1 
        //F(3) = F(2) + F(1) = 1 + 1 = 2 
        //Go back up: 
        // F(3) = 2 
        // F(4) = F(3) + F(2) = 2 +1 = 3 
        //F(5) = F(4) + F(3) = 3+ 2 = 5
        if (n <= 2) return 1;
        return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
    }
    static void PrintStudentInfo(Student student)
    {
        Console.WriteLine($"\nName: {student.Name}");
        Console.WriteLine($"Age: {student.CalculateAge()}");
        
        Console.WriteLine("Addresses:");
        foreach (var address in student.GetAddresses())
        {
            Console.WriteLine($"{address.Street}, {address.City}, {address.State} {address.Zipcode}");
        }
    }

    static void InstStudentInfo()
    {
          // EX 6 : Student-Instructor-Person Classes etc...
        // 1. Create and setup Department
        Department csDepartment = new Department();
        csDepartment.Budget = 1000000m;
        csDepartment.SetBudgetPeriod(
            new DateTime(2024, 1, 1),
            new DateTime(2024, 12, 31)
        );
        Console.WriteLine("Department created with budget: $" + csDepartment.Budget);

        // 2. Create Instructor
        Instructor instructor = new Instructor();
        instructor.Name = "Dr. Smith";
        instructor.DateOfBirth = new DateTime(1975, 5, 15);
        instructor.Salary = 95000m;
        
        // Add address for instructor
        Address instructorAddress = new Address
        {
            Street = "123 University Ave",
            City = "Boston",
            State = "MA",
            Zipcode = "02115"
        };
        instructor.AddAddress(instructorAddress);
        
        // Set as department head
        csDepartment.SetDepartmentHead(instructor);
        Console.WriteLine($"\nInstructor {instructor.Name} created");
        Console.WriteLine($"Instructor age: {instructor.CalculateAge()}");
        Console.WriteLine($"Instructor salary: ${instructor.CalculateSalary()}");

        // 3. Create Courses
        Course cs101 = new Course("cs101");
        Course cs201 = new Course("cs201");
        
        // Add courses to department
        csDepartment.AddCourse(cs101);
        csDepartment.AddCourse(cs201);
        
        // 4. Create Students
        Student student1 = new Student();
        student1.Name = "Alice Johnson";
        student1.DateOfBirth = new DateTime(2000, 8, 20);
        student1.Salary = 0; // Students typically don't have salary
        
        Student student2 = new Student();
        student2.Name = "Bob Wilson";
        student2.DateOfBirth = new DateTime(2001, 3, 15);
        student2.Salary = 0;

        // Add addresses for students
        Address studentAddress1 = new Address
        {
            Street = "456 Dorm Street",
            City = "Boston",
            State = "MA",
            Zipcode = "02116"
        };
        student1.AddAddress(studentAddress1);

        Address studentAddress2 = new Address
        {
            Street = "789 Student Ave",
            City = "Boston",
            State = "MA",
            Zipcode = "02117"
        };
        student2.AddAddress(studentAddress2);

        // Enroll students in courses
        student1.EnrollInCourse(cs101);
        student1.EnrollInCourse(cs201);
        student2.EnrollInCourse(cs101);

        // Print student information
        Console.WriteLine("\nStudent Information:");
        PrintStudentInfo(student1);
        PrintStudentInfo(student2);

        // Print department course information
        Console.WriteLine("\nDepartment Courses:");
        foreach (var course in csDepartment.GetCourses())
        {
            Console.WriteLine($"Course: {course}");
        }

        // Check if current date is within budget period
        bool isWithinBudget = csDepartment.IsWithinBudgetPeriod(DateTime.Now);
        Console.WriteLine($"\nCurrent date is within budget period: {isWithinBudget}");
        //END EX 6
    }

    static void BallCircle()
    {
        //START EX 7
        // Create some colors
        Color red = new Color(255, 0, 0);
        Color blue = new Color(0, 0, 255, 128);  // Semi-transparent blue

        // Create some balls
        Ball redBall = new Ball(10, red);
        Ball blueBall = new Ball(15, blue);

        // Throw the balls around
        Console.WriteLine("Throwing balls...");
        redBall.Throw();
        redBall.Throw();
        blueBall.Throw();

        Console.WriteLine($"Red ball thrown {redBall.GetThrowCount()} times");
        Console.WriteLine($"Blue ball thrown {blueBall.GetThrowCount()} times");

        // Pop the red ball and try to throw it
        Console.WriteLine("\nPopping red ball and trying to throw both...");
        redBall.Pop();
        redBall.Throw();  // This throw shouldn't count
        blueBall.Throw();

        // Check throw counts again
        Console.WriteLine($"Red ball thrown {redBall.GetThrowCount()} times");
        Console.WriteLine($"Blue ball thrown {blueBall.GetThrowCount()} times");

        // Demonstrate grayscale
        Console.WriteLine($"\nRed ball color grayscale value: {red.GetGrayscale()}");
        Console.WriteLine($"Blue ball color grayscale value: {blue.GetGrayscale()}");
        
        //END EX 7 
    }
    static void Main(string[] args)
    {
        // int [] numbers = GenerateNumbers();
        // Reverse(numbers);
        // PrintNumbers(numbers);
        
        //recursive Fib:
        // Console.WriteLine(RecursiveFibonacci(5));
        
        //START OOP
        // InstStudentInfo();//Ex 6
        BallCircle(); //Ex 7



    }
}