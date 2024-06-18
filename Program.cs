Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

string userChoice = Console.ReadLine();
List<string> toDoList = new List<string>()
{
    "Order a cake for the birthday party.",
    "Buy train tickets for the weekend.",
    "Take Lucky to the vet."
};

switch (userChoice)
{
    case "S":
    case "s":
        PrintSelectedOption("See all TODOs");
        SeeAllToDos();
        break;
    case "A":
    case "a":
        PrintSelectedOption("Add a TODO");
        break;
    case "R":
    case "r":
        PrintSelectedOption("Remove a TODO");
        break;
    case "E":
    case "e":
        PrintSelectedOption("Exit");
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;
}

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine($"Selected option: {selectedOption}");
}

void SeeAllToDos()
{
    foreach (string toDo in toDoList)
    {
        Console.WriteLine($"{toDoList.IndexOf(toDo) + 1}. {toDo}");
    };
}

Console.ReadKey();