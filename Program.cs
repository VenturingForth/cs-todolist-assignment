List<string> toDoList = new List<string>()
{
    "Order a cake for the birthday party.",
    "Buy train tickets for the weekend.",
    "Take Lucky to the vet."
};

string userChoice;
Console.WriteLine("Hello!");

do
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
    userChoice = Console.ReadLine();

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
            AddToDo();
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
} while (userChoice != "E" && userChoice != "e");

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

void AddToDo()
{
    Console.WriteLine("Enter the TODO description:");
    string newToDo = Console.ReadLine();
    toDoList.Add(newToDo);
}