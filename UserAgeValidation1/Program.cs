// See https://aka.ms/new-console-template for more information

// Rakendus küsib kasutajal sisestada tema vanust
// Kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
// "You are too young to use Instagram"
// Muul juhul
// Konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Please Enter Your Age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

// Boolean - true/false (1/0)

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

//int userAge = Int32.Parse(Console.ReadLine()); // "13" - heap, 13 - stack

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (isAgeNumber)
{
   if(userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram");
    }
} 
else
{
    Console.WriteLine("Could not read your age");
}

