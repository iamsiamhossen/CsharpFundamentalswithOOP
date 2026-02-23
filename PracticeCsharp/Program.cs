Student Siam = new Student()
{
    Name = "Siam",
    Age = 20,
    MobileNo = 1234567890,
    BanglaMarks = 85.5,
    EnglishMarks = 90.0,
    MathMarks = 95.0,


};
Console.WriteLine($"Name: {Siam.Name}");
Console.WriteLine($"Age: {Siam.Age}");
public class Student
{
    public string Name { get; set; }
    public int Age;
    public int MobileNo;
    public double BanglaMarks;
    public double EnglishMarks;
    public double MathMarks;

}

