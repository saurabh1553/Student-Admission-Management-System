using System;

class Student
{
    private static int nextId = 1001;

    private int studentId;
    private string name;
    private int age;
    private string gender;
    private string email;
    private string mobile;
    private double percentage;
    private string grade;
    private string branch;
    private string scholarship;
    private string facilities;
    private string admissionStatus;

    public Student(string n, int a, string g, string e, string m, double p)
    {
        studentId = nextId++;
        name = n;
        age = a;
        gender = g;
        email = e;
        mobile = m;
        percentage = p;

        if (percentage >= 90)
            grade = "A+";
        else if (percentage >= 80)
            grade = "A";
        else if (percentage >= 70)
            grade = "B";
        else if (percentage >= 60)
            grade = "C";
        else
            grade = "D";

        if (percentage >= 95)
        {
            scholarship = "100% Scholarship";
            branch = "Computer Science";
            facilities = "Hostel, Bus, Laptop, Books, Wi-Fi, Placement Training";
        }
        else if (percentage >= 85)
        {
            scholarship = "80% Scholarship";
            branch = "Artificial Intelligence";
            facilities = "Hostel, Bus, Books, Wi-Fi";
        }
        else if (percentage >= 75)
        {
            scholarship = "60% Scholarship";
            branch = "Cyber Security";
            facilities = "Bus, Books, Library, Skill Course";
        }
        else if (percentage >= 65)
        {
            scholarship = "40% Scholarship";
            branch = "Information Technology";
            facilities = "Bus, Library";
        }
        else
        {
            scholarship = "20% Scholarship";
            branch = "Electronics";
            facilities = "Bus";
        }

        admissionStatus = "Confirmed";
    }

    public void Display()
    {
        Console.WriteLine("\n=========================================");
        Console.WriteLine("        STUDENT ADMISSION REPORT");
        Console.WriteLine("=========================================");
        Console.WriteLine("Student ID       : " + studentId);
        Console.WriteLine("Name             : " + name);
        Console.WriteLine("Age              : " + age);
        Console.WriteLine("Gender           : " + gender);
        Console.WriteLine("Email            : " + email);
        Console.WriteLine("Mobile           : " + mobile);
        Console.WriteLine("Percentage       : " + percentage + "%");
        Console.WriteLine("Grade            : " + grade);
        Console.WriteLine("Branch           : " + branch);
        Console.WriteLine("Scholarship      : " + scholarship);
        Console.WriteLine("Facilities       : " + facilities);
        Console.WriteLine("Admission Status : " + admissionStatus);
        Console.WriteLine("=========================================");
        Console.WriteLine("Congratulations! Welcome to Our College.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========== STUDENT ADMISSION SYSTEM ==========\n");

        Console.Write("Enter Total Marks: ");
        double total = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Obtained Marks: ");
        double obtained = Convert.ToDouble(Console.ReadLine());

        double percentage = (obtained / total) * 100;

        Console.WriteLine("\nPercentage = " + percentage + "%");

        if (percentage < 60)
        {
            Console.WriteLine("\nSorry! You are not eligible for admission and scholarship.");
            Console.WriteLine("Minimum 60% marks are required.");
            Console.WriteLine("Better luck next time!");
            return;
        }

        Console.WriteLine("\nEligible for Admission & Scholarship");

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Gender: ");
        string gender = Console.ReadLine();

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        Console.Write("Enter Mobile Number: ");
        string mobile = Console.ReadLine();

        Student s1 = new Student(name, age, gender, email, mobile, percentage);

        s1.Display();

        Console.WriteLine("\nThank You!");
        Console.ReadKey();
    }
}
