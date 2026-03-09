Student student1 = new Student("Siam", 1, 85.5, 90.0, 92.5);
Console.WriteLine($"Previous Name: {student1.Name}");
student1.changeName("Siam Hossain");
student1.PrintResult();
public class Student
{
    // eta holo auto-implemented property, 
    // jeta amader code ke aro clean and readable kore, 
    // and seta automatically getter and setter method create kore,
    // and seta amader code ke aro efficient kore.
    // eta hiddenly private field create kore auto.
    // validation dorkar hole full property create korte hobe, 
    // otherwise auto-implemented property use kora jete pare.
    public String Name {get; private set;}
    public int Id{get;}
    public double BanglaMark { get; set; }
    public double EnglishMark { get; set; }
    public double MathMark { get; set; }
    public Student(string name, int id, double banglaMark, double englishMark, double mathMark)
    {
        Name = name;
        Id = id;
        BanglaMark = banglaMark;
        EnglishMark = englishMark;
        MathMark = mathMark;
    }
    public void changeName(string newName)
    {
        Name = newName;
    }
    public void PrintResult()
    {
        Console.WriteLine($"Name: {Name}, Id: {Id}");
        Console.WriteLine($"Bangla: {BanglaMark}, English: {EnglishMark}, Math: {MathMark}");
        
    }
}