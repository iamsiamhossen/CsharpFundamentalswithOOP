Student student1 = new Student("Alice", 1, 85.5, 90.0, 92.5);
student1.PrintResult();
public class Student
{
    private string Name;
    private int Roll;
    private double Bangla;
    private double English;
    private double Math;

    public Student(string name, int roll, double bangla, double english, double math)
    {
        Name = name;
        Roll = roll;
        Bangla = bangla;
        English = english;
        Math = math;
    }

    private double GetAverage()
    {
        return (Bangla + English + Math) / 3.0;
    }

    public void PrintResult()
    {
        Console.WriteLine($"Name: {Name}, Roll: {Roll}");
        Console.WriteLine($"Bangla: {Bangla}, English: {English}, Math: {Math}");
        Console.WriteLine($"Average: {GetAverage():F2}");
    }
}