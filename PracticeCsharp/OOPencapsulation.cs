using System.Reflection.Metadata.Ecma335;

Student student1 = new Student("Siam", 1, 85.5, 90.0, 92.5);
// ekhane amra student er name ta read korlam, jodi amra student er name ta read korte chai, 
// tahole amra Getname() method call korbo, and seta return korbe student er name ta.
Console.WriteLine($"Previous Name: {student1.Getname()}"); 
student1.Setname("Siam Hossain");
Console.WriteLine($"Previous Id:{student1.Idproperty}");
student1.Idproperty = -1; // ekhane amra student er id ta modify korlam, jodi amra student er id ta modify korte chai, tahole amra Idproperty property te new value set korbo, and seta set korbe student er id ta.
student1.PrintResult();



public class Student
{
    private string Name;
    private int Id;
    private double BanglaMark;
    private double EnglishMark;
    private double MathMark;

    public Student(string name, int id, double banglaMark, double englishMark, double mathMark)
    {
        Name = name;
        Id = id;
        BanglaMark = banglaMark;
        EnglishMark = englishMark;
        MathMark = mathMark;
    }
    public void PrintResult()
    {
        Console.WriteLine($"Name: {Name}, Id: {Id}");
        Console.WriteLine($"Bangla: {BanglaMark}, English: {EnglishMark}, Math: {MathMark}");
        
    }
    // ekhane data read korar jonno getter method create korlam, 
    // mane jodi amra student er name ta read korte chai, tahole amra Getname() method call korbo, 
    // and seta return korbe student er name ta.
    
    public string Getname()
    {
        return Name;
    } 
    
    // ekhon data modify korar jonno setter method create korlam,
    // mane jodi amra student er name ta modify korte chai, tahole amra Setname() method call korbo,
    // and seta parameter hishebe new name ta nibe, and seta set korbe student er name ta.
    public void Setname(string Name)
    {
       // ekhane this keyword use korlam, mane jodi amra Setname() method er parameter name ta 
       // student class er property name er sathe same kori, tahole this keyword use kore amra 
       // student class er property name ta refer korte pari, and seta set korte pari.
       this.Name = Name; 
    }

    // csharp e amra getter and setter method create korar jonno property use korte pari,
    // jeta amader code ke aro clean and readable kore, and seta automatically getter and
    // setter method create kore, and seta amader code ke aro efficient kore.
    public int Idproperty { get { return this.Id; } 
       set
        {
           if(value > 0) // ekhane amra validation o add korlam, mane jodi amra student er id ta modify korte chai, tahole amra Idproperty property te new value set korbo, and seta set korbe student er id ta, but amra check korbo jodi new value ta 0 theke boro hoy, taholei seta set hobe, otherwise seta set hobe na, and amader code ke aro robust kore.
           {
               this.Id = value;
           }
           else
           {
               Console.WriteLine("Id must be greater than 0");
           }
        } }
    public double BanglaMarkproperty { get { return this.BanglaMark; } set { this.BanglaMark = value; } }
    public double EnglishMarkproperty { get { return this.EnglishMark; } set { this.EnglishMark = value; } }
    public double MathMarkproperty { get { return this.MathMark; } set { this.MathMark = value; } }
}    
