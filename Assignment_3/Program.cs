using Assignment_3;

static int[] GenerateNumbers ()
{
    return new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
}
static void Reverse(int[] numbers)
{
    int start = 0;
    int end = numbers.Length - 1;
    while (start < end)
    {
        int temp = numbers[start];
        numbers[start] = numbers[end];
        numbers[end] = temp;
        start++;
        end--;
    }

}
static void PrintNumbers(int[] numbers)
{
    foreach(int i in numbers)
    {
        Console.Write(i + " ");
    }
}

static int Fibonacci(int n)
{
    if (n <= 0)
    {
        return (-1);
    }
    else if (n == 1)
    {
        return 0;
    }
    else if (n == 2)
    {
        return 1;
    }
    else
    {
        int a = 0;
        int b = 1;
        for (int i = 3; i <= n; i++)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }
}
static void Main(string[] args)
{
    // Part 1
    int[] numbers = GenerateNumbers();
    Reverse(numbers);
    PrintNumbers(numbers);

    // Part 2
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine("The " + i + "th number in the Fibonacci sequence is " + Fibonacci(i));
    }

    // OOP Principles
    Student student = new Student("John Doe", new DateTime(1990, 1, 1));
    student.EnrollCourse("Math");
    Console.WriteLine($"Student {student.FullName} is {student.CalculateAge()} years old.");
    Console.WriteLine($"Student {student.FullName} salary is {student.CalculateSalary()}");

    Instructor instructor = new Instructor("Jane Doe", new DateTime(1990, 1, 1));
    instructor.AssignCourse("English");
    Console.WriteLine($"Instructor {instructor.FullName} is {instructor.CalculateAge()} years old.");
    Console.WriteLine($"Instructor {instructor.FullName} salary is {instructor.CalculateSalary()}");

    // Create new course instance
    Course course = new Course();
    course.AddCourse("Science");

    Department department = new Department();
    department.AddDepartment("Computer Science");

    // Create colors instances
    Color redColor = new Color(255, 0, 0);
    Color blueColor = new Color(0, 0, 255);

    Ball redBall = new Ball(10, redColor);
    Ball blueBall = new Ball(15, blueColor);

    redBall.Throw();
    redBall.Throw();
    blueBall.Throw();
    blueBall.Throw();
    blueBall.Throw();

    Console.WriteLine("Red ball has been thrown " + redBall.GetThrowCount() + " times.");
    Console.WriteLine("Blue ball has been thrown " + blueBall.GetThrowCount() + " times.");

    // remove red ball and blue ball
    redBall.Pop();
    blueBall.Pop();

    redBall.Throw();
    blueBall.Throw();

    Console.WriteLine("Red ball has been thrown " + redBall.GetThrowCount() + " times.");
    Console.WriteLine("Blue ball has been thrown " + blueBall.GetThrowCount() + " times.");
}

