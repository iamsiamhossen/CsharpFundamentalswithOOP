CAR bmw = new CAR("BMW", "X5", 2022, 60000);  //Ekhane Object create korlam CAR class er jonno, and set korlam tar properties gula , and ekhane object hosse bmw, and tar properties gula hosse Brand, Model, Year, Price. Ekhane amra ekta method o call korlam DisplayInfo() method ta CAR class er vitor define kora ache, and seta call korlam bmw object er maddhome.
CAR toyota = new CAR("Toyota", "Camry", 2020, 40000);
CAR jaguar = new CAR("Jaguar", "F-Type", 2021, 80000);
CAR harley = new CAR("Harley-Davidson", "Street 750", 2019, 7500);

public class CAR
{
    public string Brand; //Property
    public string Model; //Property
    public int Year; //Property
    public double Price; //Property
    public void DisplayInfo() //Method always functional 
    {
        Console.WriteLine($"Brand:{Brand}, Model: {Model}, Year: {Year}, Price: {Price}");
    }
    public CAR(string brand, string model, int year, double price) //Constructor
    {
        // Console.WriteLine($"Brand: {brand}, Model: {model}, Year: {year}, Price: {price}");
        Brand = brand;
        Model = model;
        Year = year;
        Price = price;
        DisplayInfo(); //Ekhane amra constructor er vitor theke method call korlam, mane jodi amra CAR class er object create kori, tahole constructor call hobe, and tar sathe sathe DisplayInfo() method o call hobe, and seta console e print korbe car er information gula.
    }

}

