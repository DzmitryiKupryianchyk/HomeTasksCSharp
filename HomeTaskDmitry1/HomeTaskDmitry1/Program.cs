using System.ComponentModel.Design;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

string answer;
string gender;
string firstName;
string lastName;
string ageString;
string heightString;
string weightString;
double weightOnMoonSurface;
string maritalStatus;
string educationalDegree;
string occupation;
string UtilityBillsString;
string foodExpensesString;
string rentString;
string smokingExpensesString;
string entertaimentExpensesString;
int wholeMounthlyExpenses;
int annualQuittingSmokinBenefit;
int smokeMonthExpense;
int smokeYes;



Console.WriteLine("Hi there! Woud you like to take some questionnaire?(y|n)");
do
{
    answer = Console.ReadLine();
    if (answer != "y")
    {
        Console.WriteLine("Don't make me sad!:(");
    }
    else
    {
        Console.WriteLine("Let's kick off!");
    }
} while (answer != "y");

Console.WriteLine("what's your age?");
do
{
    ageString = (Console.ReadLine());
    if (!string.IsNullOrEmpty(ageString))
    {
        Console.WriteLine("Thank you! Next one!");
    }
    else
    {
        Console.WriteLine("Fill in the gap!");
    }
} while (string.IsNullOrEmpty(ageString));

Console.WriteLine("Your gender?");
do
{
    gender = Console.ReadLine();
    if (!string.IsNullOrEmpty(gender))
    {
        Console.WriteLine("Thanks a lot!");
    }
    else
    {
        Console.WriteLine("Fill in the gap!");
    }
} while (string.IsNullOrEmpty(gender));

Console.WriteLine("Now, type your first name, please!");
do
{
    firstName = Console.ReadLine();
    if (!string.IsNullOrEmpty(firstName))
    {
        Console.WriteLine("I appreciate it!");
    }
    else
    {
        Console.WriteLine("Fill in the gap!");
    }
} while (string.IsNullOrEmpty(firstName));

Console.WriteLine("Now, your last name, please!");
do
{
    lastName = Console.ReadLine();
    if (!string.IsNullOrEmpty(lastName))
    {
        Console.WriteLine("Thanks!");
    }
    else
    {
        Console.WriteLine("Fill in the gap!");
    }
} while (string.IsNullOrEmpty(lastName));

Console.WriteLine("Now weight, please?");
do
{
    weightString = Console.ReadLine();
    if (!string.IsNullOrEmpty(weightString))
    {
        Console.WriteLine("There are no so much questions left");
        Thread.Sleep(3000);
        Console.WriteLine(":)");

    }
    else
    {
        Console.WriteLine("Fill in the gap!");
    }
} while (string.IsNullOrEmpty(weightString));

Console.WriteLine("What is your height?");
do
{
    heightString = Console.ReadLine();
    if (!string.IsNullOrEmpty(heightString))
    {
        Console.WriteLine("Got it!");
    }
    else
    {
        Console.WriteLine("Fill in the gap!");
    }
} while (string.IsNullOrEmpty(heightString));

Console.WriteLine("Much obliged! You did it!");

int age = Int32.Parse(ageString);
int weight = Int32.Parse(weightString);
int height = Int32.Parse(heightString);


weightOnMoonSurface = weight / 7;

Thread.Sleep(2000);

Console.WriteLine("There is one curious fact :)");
Thread.Sleep(3000);
Console.WriteLine("Do you know that gravity on the moon surface 7 times weaker?");
Thread.Sleep(3000);
Console.WriteLine("Therefore, your weight on the moon would be");
Thread.Sleep(3000);
Console.WriteLine(weightOnMoonSurface + "kilogramms");
Thread.Sleep(3000);
Console.WriteLine("Now, let me ask you a couple more questions");
Thread.Sleep(2000);
Console.WriteLine("It won't take so long");
Thread.Sleep(2000);

Console.WriteLine("your marital status?");
do
{
    maritalStatus = Console.ReadLine();
    if (!string.IsNullOrEmpty(maritalStatus))
    {
        Console.WriteLine("The following question");
    }
    else
    {
        Console.WriteLine("Fill in the gap!");
    }
} while (string.IsNullOrEmpty(maritalStatus));

Console.WriteLine("your educational degree?");
do
{
    educationalDegree = Console.ReadLine();
    if (!string.IsNullOrEmpty(educationalDegree))
    {
        Console.WriteLine("Next question!");
    }
    else
    {
        Console.WriteLine("Fill in the gap!");
    }
} while (string.IsNullOrEmpty(educationalDegree));

Console.WriteLine("your occupation?");
do
{
    occupation = Console.ReadLine();
    if (!string.IsNullOrEmpty(occupation))
    {
        Console.WriteLine("Thanks a lot!");
    }
    else
    {
        Console.WriteLine("Fill in the gap!");
    }
} while (string.IsNullOrEmpty(occupation));

Thread.Sleep(2000);
Console.WriteLine("Now, let's talk about money:)");
Thread.Sleep(3000);

Console.WriteLine("How much do you spend to cover your utility bills mounthly?");
do
{
    UtilityBillsString = Console.ReadLine();
    if (!string.IsNullOrEmpty(UtilityBillsString))
    {
        Console.WriteLine("Thanks a lot!");
    }
    else
    {
        Console.WriteLine("Fill in the gap!");
    }
} while (string.IsNullOrEmpty(UtilityBillsString));

Console.WriteLine("How much do you spend for food mounthly?");
do
{
    foodExpensesString = Console.ReadLine();
    if (!string.IsNullOrEmpty(foodExpensesString))
    {
        Console.WriteLine("Thanks a lot!");
    }
    else
    {
        Console.WriteLine("Fill in the gap!");
    }
} while (string.IsNullOrEmpty(foodExpensesString));

Console.WriteLine("How much for renting an appartment?");
do
{
    rentString = Console.ReadLine();
    if (!string.IsNullOrEmpty(rentString))
    {
        Console.WriteLine("Thanks a lot!");
    }
    else
    {
        Console.WriteLine("Fill in the gap!");
    }
} while (string.IsNullOrEmpty(rentString));

Console.WriteLine("How much for entertaiments?");
do
{
    entertaimentExpensesString = Console.ReadLine();
    if (!string.IsNullOrEmpty(entertaimentExpensesString))
    {
        Console.WriteLine("Thanks a lot!");
    }
    else
    {
        Console.WriteLine("Fill in the gap!");
    }
} while (string.IsNullOrEmpty(entertaimentExpensesString));

Console.WriteLine("Do you smoke? y|n");
do
{
    
    smokingExpensesString = Console.ReadLine();
    if (!string.IsNullOrEmpty(smokingExpensesString) && (smokingExpensesString == "y" || smokingExpensesString == "n"))
    {
        Console.WriteLine("Thanks");
    } 
    if (smokingExpensesString == "y")
    {
        Console.WriteLine("How much money you spend on it daily?");
        smokeYes = Convert.ToInt32(Console.ReadLine());
    }
    if (smokingExpensesString == "n")
    {
        Console.WriteLine("You're awsome!");
        smokeYes = 0;
    }
    else
    {
        Console.WriteLine("Fill in the gap properly!");
        smokeYes = 0;
    }
} while (string.IsNullOrEmpty(smokingExpensesString) && (smokingExpensesString != "y" || smokingExpensesString != "n") | true);

int UtilityBills = Int32.Parse(UtilityBillsString);
int foodExpenses = Int32.Parse(foodExpensesString);
int rent = Int32.Parse(rentString);
int entertaimentExpenses = Int32.Parse(entertaimentExpensesString);
smokeMonthExpense = smokeYes * 30;
wholeMounthlyExpenses = UtilityBills + foodExpenses + rent + smokeMonthExpense + entertaimentExpenses;



Console.WriteLine("Thank you for taking this questionaire!");
Thread.Sleep(3000);
Console.WriteLine("We collected some information about you");
Thread.Sleep(3000);
Console.WriteLine("Wait for 5 seconds for the results");
Console.WriteLine("5");
Thread.Sleep(1000);
Console.WriteLine("4");
Thread.Sleep(1000);
Console.WriteLine("3");
Thread.Sleep(1000);
Console.WriteLine("2");
Thread.Sleep(1000);
Console.WriteLine("1");
Thread.Sleep(1000);
Console.WriteLine("0");
Thread.Sleep(1000);
Console.WriteLine("Here we are!");
Console.WriteLine("Name: " + firstName);
Console.WriteLine("Last Name: " + lastName);
Console.WriteLine("Age: " + age);
Console.WriteLine("Height: " + height);
Console.WriteLine("Weight: " + weight);
Console.WriteLine("Weight on Moon surface: " + weightOnMoonSurface);
Console.WriteLine("Marital status: " + maritalStatus);
Console.WriteLine("Educational degree: " + educationalDegree);
Console.WriteLine("Occupation: " + occupation);
Console.WriteLine("Mounthly Expenses: ");
Console.WriteLine("Utility bills " + UtilityBills);
Console.WriteLine("Food " + foodExpenses);
Console.WriteLine("Rent an appartment " + rent);
Console.WriteLine("smoking " + smokeMonthExpense);
Console.WriteLine("Whole monthly expenses " + wholeMounthlyExpenses);








































































