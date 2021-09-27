# TTA-C-Sharp
This is a repository of C# and .NET projects. Most of these are basic console applications that demonstrate one or two C# fundamentals. The TwentyOne project is a functional Blackjack console game. CarInsurance is an ASP.NET site with an MVC structure and CRUD functions. It also has an admin page to view all insurees, and a quote calculator. NewsletterAppMVC is also an ASP.NET MVC site that allows users to sign up for a mock newsletter, and has an admin page to view signup information and unsubscribe users.

## TwentyOne
Blackjack console game. Built to handle different card games added in the future.

![screenshotTwentyOne](https://user-images.githubusercontent.com/84836870/134958084-724ee09e-6bf6-47ec-bb69-111813930fc8.png)


Deck shuffling function from Deck.cs:
```csharp
public void Shuffle(int times = 1)
{
    for (int i = 0; i < times; i++)
    {
        List<Card> TempList = new List<Card>();
        Random random = new Random();

        while (Cards.Count > 0)
        {
            int randomIndex = random.Next(0, Cards.Count);
            TempList.Add(Cards[randomIndex]);
            Cards.RemoveAt(randomIndex);
        }
        Cards = TempList;
    }
}
```

Function for getting all possible hand values from TwentyOneRules.cs:
```csharp
private static int[] GetAllPossibleHandValues(List<Card> Hand)
{
    int aceCount = Hand.Count(x => x.Face == Face.Ace);
    int[] result = new int[aceCount + 1];
    int value = Hand.Sum(x => _cardValues[x.Face]);
    result[0] = value;
    if (result.Length == 1) return result;
    for (int i = 1; i < result.Length; i++)
    {
        value += (i * 10);
        result[i] = value;
    }
    return result;
}
```

Compare hands to see if anyone won, from TwentyOneRules.cs:
```csharp
public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
{
    int[] playerResults = GetAllPossibleHandValues(PlayerHand);
    int[] dealerResults = GetAllPossibleHandValues(DealerHand);

    int playerScore = playerResults.Where(x => x < 22).Max();
    int dealerScore = dealerResults.Where(x => x < 22).Max();

    if (playerScore > dealerScore) return true;
    else if (playerScore < dealerScore) return false;
    else return null;
}
```

Log fraud attempts and other exceptions to database, from Program.cs:
```csharp
string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                        (@ExceptionType, @ExceptionMessage, @TimeStamp)";

using (SqlConnection connection = new SqlConnection(connectionString))
{
    SqlCommand command = new SqlCommand(queryString, connection);
    command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
    command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
    command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

    command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
    command.Parameters["@ExceptionMessage"].Value = ex.Message;
    command.Parameters["@TimeStamp"].Value = DateTime.Now;

    connection.Open();
    command.ExecuteNonQuery();
    connection.Close();
}
```

## AbstractClass
```csharp
//create abstract class Person
public abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //create virual method to print name
    public virtual void SayName()
    {
        Console.WriteLine("{0} {1}", FirstName, LastName);
    }
}
```

## AgeCheck
Take user input for age and throw errors if age is negative.

```csharp
Console.WriteLine("Enter your age:");

//try to take user input for age and set to int, then print to console.
try
{
    int age = Convert.ToInt32(Console.ReadLine());

    //if age is a negative number, throw error
    if (age < 0)
    {
        throw new ArgumentException();
    }
    Console.WriteLine("Your age is: {0}", age);
    Console.Read();
}

//catch exception for negative age and print error message
catch (ArgumentException)
{
    Console.WriteLine("Age cannot be negative.");
    Console.Read();
    return;
}
```

## AnonymousIncomeComparison
Compare the income of two different employees based on hourly rate and hours worked.

```csharp
 //print person 1 and person 2's annual salaries and which one makes more
Console.WriteLine("Person 1's annual salary: $" + person1salary);
Console.WriteLine("Person 2's annual salary: $" + person2salary);
Console.WriteLine("Does Person 1 make more money than Person 2?");
Console.WriteLine(person1salary > person2salary);
```

## CarInsurance
ASP.NET site that calculates an insurance quote based on information entered.

From Insuree.cs:
```csharp
public partial class Insuree
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public System.DateTime DateOfBirth { get; set; }
    public int CarYear { get; set; }
    public string CarMake { get; set; }
    public string CarModel { get; set; }
    public bool DUI { get; set; }
    public int SpeedingTickets { get; set; }
    public bool CoverageType { get; set; }
    public decimal Quote { get; set; }
}
```

From InsureeController.cs:
```csharp
public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
{

    if (ModelState.IsValid)
    {
        // CALCULATE QUOTE
        insuree.Quote = 50.00m;
        double currentAge = (DateTime.Now - insuree.DateOfBirth).TotalDays / 365;
        if (currentAge < 18)
        {
            insuree.Quote += 100;
        }
        else if (currentAge > 19 && currentAge < 25)
        {
            insuree.Quote += 50;
        }
        else if (currentAge > 25)
        {
            insuree.Quote += 25;
        }

        if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
        {
            insuree.Quote += 25;
        }

        if (insuree.CarMake.ToLower() == "porsche")
        {
            insuree.Quote += 25;
        }
        if (insuree.CarMake.ToLower() == "porsche" && insuree.CarModel.ToLower() == "911 carrera")
        {
            insuree.Quote += 25;
        }

        for (int i = 0; i < insuree.SpeedingTickets; i++)
        {
            insuree.Quote += 10;
        }

        if (insuree.DUI)
        {
            insuree.Quote += insuree.Quote * 0.25m;
        }

        if (insuree.CoverageType)
        {
            insuree.Quote += insuree.Quote * 0.5m;
        }

        db.Insurees.Add(insuree);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

    return View(insuree);
}
```

## ColorGuess
Demonstrates switches.

```csharp
//ask user to guess a color and save to color string. set correctColor to false
Console.WriteLine("Round 1. Guess a color.");
string color = Console.ReadLine();
bool correctColor = false;

//check if user's guessed color is green. if not, loop switch again, if so, set correctColor to true and break loop
while (!correctColor)
{
    switch (color)
    {
        case "green":
            Console.WriteLine("Green is correct!");
            correctColor = true;
            break;
        case "blue":
            Console.WriteLine("Blue is incorrect.");
            Console.WriteLine("Guess a color");
            color = Console.ReadLine();
            break;
        case "red":
            Console.WriteLine("Red is incorrect.");
            Console.WriteLine("Guess a color");
            color = Console.ReadLine();
            break;
        case "yellow":
            Console.WriteLine("Yellow is incorrect.");
            Console.WriteLine("Guess a color");
            color = Console.ReadLine();
            break;
        case "orange":
            Console.WriteLine("Orange is incorrect.");
            Console.WriteLine("Guess a color");
            color = Console.ReadLine();
            break;
        case "purple":
            Console.WriteLine("Purple is incorrect.");
            Console.WriteLine("Guess a color");
            color = Console.ReadLine();
            break;
        default:
            Console.WriteLine("Try again.");
            Console.WriteLine("Guess a color");
            color = Console.ReadLine();
            break;
    }
}
```

## ConstructorChain

```csharp
class Class1
{
    //create an object constructor that takes a shape string and a color string, and a chained constructor that takes only a shape string and defaults color to red
    public Class1(string shapeConst) : this(shapeConst, "red") { }
    public Class1(string shapeConst, string colorVar)
    {
        shape = shapeConst;
        color = colorVar;
    }

    public string shape { get; set; }
    public string color { get; set; }
}
```

## DaysOfTheWeek
Ask user to type in a day of the week and check against an enum.

```csharp
class Program
{
    static void Main()
    {
        //ask user to enter today's day and assign to variable
        Console.WriteLine("Enter today's current day of the week:");
        string dayInput = Console.ReadLine().ToLower();

        try
        {
            //parse through user's input to find that value in the enum, then assign it to currentDay variable
            Days currentDay = (Days)Enum.Parse(typeof(Days), dayInput);
            Console.WriteLine("Success!");
        }
        catch (Exception)
        {
            //print error message if user inputs anything other than a day of the week
            Console.WriteLine("Please enter an acutal day of the week.");
        }

        Console.Read();
    }

    //create enum of days of the week
    public enum Days { monday, tuesday, wednesday, thursday, friday, saturday, sunday };
}
```

## FinalChallenge
Enter an example student into a database and print student info to console. Uses a code-first Entity Framework database.

```csharp
class Program
{
  static void Main()
  {
      using (var db = new StudentContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Users\Kris\Documents\GitHub\TTA-C-Sharp\FinalChallenge\FinalChallenge\App_Data\FinalChallenge.mdf;Integrated Security=True"))
      {
          var student = new Student() { Id = 1, FirstName = "Test", LastName = "Student", Grade = 11, GPA = 3.24m };
          db.Students.Add(student);
          db.SaveChanges();

          var query = from s in db.Students
                      orderby s.FirstName
                      select s;
          foreach (Student s in query)
          {
              Console.WriteLine($"{s.FirstName} {s.LastName}\n" +
                  $"ID: {s.Id}\n" +
                  $"Grade: {s.Grade}\n" +
                  $"GPA: {s.GPA}");
              Console.Read();
          }
      }
  }

  public class Student
  {
      public int Id { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public int Grade { get; set; }
      public decimal GPA { get; set; }

      public virtual List<Student> Students { get; set; }
  }

  public class StudentContext : DbContext
  {
      public StudentContext(string connectionString)
          : base(connectionString) { }
      public DbSet<Student> Students { get; set; }
    }
}
```

## IndexPicker

```csharp
List<string> stringList = new List<string>();
stringList.Add("Monday");
stringList.Add("Tuesday");
stringList.Add("Wednesday");
stringList.Add("Thursday");
stringList.Add("Friday");
stringList.Add("Saturday");
stringList.Add("Sunday");
Console.WriteLine("Pick an index (0-6):");
int stringListIndex = Convert.ToInt32(Console.ReadLine());
if (stringListIndex < stringList.Count)
{
    Console.WriteLine(stringList[stringListIndex]);
}
else
{
    Console.WriteLine("Index does not exist.");
}
```

## InsuranceApproval
Demonstrates && statements. Checks if user prequalifies for insurance.

```csharp
bool qualified = age >= 18 && dui == false && tickets <= 3;
Console.WriteLine("Do you qualify for insurance? " + qualified);
```

## Lambdas

```csharp
// add each employee with first name "joe" to separate list with a lambda
List<Employee> joes = employees.Where(x => x.FirstName == "Joe").ToList();

// add each employee with id # greater than 5 to separate list with a lambda
List<Employee> overFive = employees.Where(x => x.ID > 5).ToList();
```

## NewsletterAppMVC
ASP.NET MVC site that allows users to sign up for a mock newsletter, and has an admin page to view signup information and unsubscribe users.

![screenshotNewsletter](https://user-images.githubusercontent.com/84836870/134954537-5ccc3fea-4dcb-47ff-8875-ef3154932ecc.png)

From SignUp.cs:
```csharp
public partial class SignUp
{
  public int Id { get; set; }
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string EmailAddress { get; set; }
  public Nullable<System.DateTime> Removed { get; set; }
}
```

From AdminController.cs:
```csharp
public ActionResult Index()
{
    using (Entities db = new Entities())
    {
        var signups = db.SignUps.Where(x => x.Removed == null).ToList();
        var signupVms = new List<SignUpVM>();
        foreach (var signup in signups)
        {
            var signupVm = new SignUpVM();
            signupVm.Id = signup.Id;
            signupVm.FirstName = signup.FirstName;
            signupVm.LastName = signup.LastName;
            signupVm.EmailAddress = signup.EmailAddress;
            signupVms.Add(signupVm);
        }

        return View(signupVms);
    }
}
```

## OperatorOverloading
```csharp
// override == operator to check if two employees have the same ID
public static bool operator== (Employee employee1, Employee employee2)
{
    bool employeeMatch = employee1.ID == employee2.ID;
    return employeeMatch;
}

// override != operator to check if two employees do not have the same ID
public static bool operator!= (Employee employee1, Employee employee2)
{
    bool employeeMatch = employee1.ID != employee2.ID;
    return employeeMatch;
}
```

## OptionalParameters
```csharp
//AddNumbers method adds user input numbers with AddNum. AddNum3 is optional.
public int AddNumbers(int AddNum2, int AddNum3 = 0)
{
    int addResult = AddNum + AddNum2 + AddNum3;
    return addResult;
}   
```

## PackageExpress
Take user input for package weight and dimensions to calculate a shipping quote.

```csharp
//if weight is under 50lbs, ask for dimensions
else
{
    Console.WriteLine("Please enter package width (in):");
    decimal width = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Please enter package height (in):");
    decimal height = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Please enter package length (in):");
    decimal length = Convert.ToDecimal(Console.ReadLine());

    decimal totalDimensions = width + height + length;

    //if total dimensions are too large, end program
    if (totalDimensions > 50)
    {
        Console.WriteLine("Package too big to be shipped via Package Express.");
    }

    //if total dimensions aren't too large, calculate shipping quote
    else
    {
        decimal quote = ((width * height * length) * weight) / 100;
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ". Thank you!");
    }
}
```

## People
Demonstrates class inheritance.

```csharp
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //print person's full name
    public void SayName()
    {
        Console.WriteLine("Name: {0} {1}", FirstName, LastName);
    }
}
```

```csharp
//inherit from Person class
class Employee : Person
{
    public int ID { get; set; }
}
```

## Scores
Get student test scores from .txt file and print to console, then calculate average score.

```csharp
string path = @"D:\Users\Kris\Documents\GitHub\TTA-C-Sharp\Scores\Scores\studentScores.txt";
string[] lines = System.IO.File.ReadAllLines(path);

double tScore = 0.0;

Console.WriteLine("\nStudent Scores: \n");
foreach (string line in lines)
{
    Console.Write("\n" + line);
    double score = Convert.ToDouble(line);
    tScore += score;
}

double avgScore = tScore / lines.Length;
Console.WriteLine("\n Total of " + lines.Length + " student scores. \tAverage score: " + avgScore);

```

## Structs
```csharp
//create Number struct with property "Amount"
public struct Number
{
    public decimal Amount { get; set; }
}
```

```csharp
//create object of Number data type and print to console
Number num = new Number();
num.Amount = 42.3m;
```
