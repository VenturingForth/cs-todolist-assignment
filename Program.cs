List<string> toDoList = new List<string>();
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
            RemoveToDo();
            break;
        case "E":
        case "e":
            PrintSelectedOption("Exit");
            break;
        default:
            Console.WriteLine("Incorrect input.");
            break;
    }
} while (userChoice != "E" && userChoice != "e");

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine($"Selected option: {selectedOption}");
}

void SeeAllToDos()
{
    if (toDoList.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
    }
    else
    {
        foreach (string toDo in toDoList)
        {
            Console.WriteLine($"{toDoList.IndexOf(toDo) + 1}. {toDo}");
        };
    }
}

void AddToDo()
{
    bool toDoAdded = false;
    do
    {
        Console.WriteLine("Enter the TODO description:");
        string newToDo = Console.ReadLine();
        if (newToDo.Length == 0)
        {
            Console.WriteLine("The description cannot be empty.");
        }
        else if (toDoList.Contains(newToDo))
        {
            Console.WriteLine("The description must be unique.");
        }
        else
        {
            toDoList.Add(newToDo);
            Console.WriteLine($"TODO successfully added: {newToDo}");
            toDoAdded = true;
        }
    } while (!toDoAdded);
}

void RemoveToDo()
{
    bool toDoRemoved = false;
    do
    {
        Console.WriteLine("Select the index of the TODO you want to remove:");
        SeeAllToDos();
        if (toDoList.Count == 0)
        {
            break;
        }
        string indexToRemove = (Console.ReadLine());
        if (indexToRemove.Length == 0)
        {
            Console.WriteLine("Selected index cannot be empty");
            continue;
        }

        bool isParsingSuccessful = int.TryParse(indexToRemove, out int parsedIndexToRemove);
        if (isParsingSuccessful)
        {
            if(parsedIndexToRemove > toDoList.Count || parsedIndexToRemove <= 0)
            {
                Console.WriteLine("The given index is not valid.");
                continue;
            }
            Console.WriteLine($"TODO removed: {toDoList.ElementAt(parsedIndexToRemove - 1)}");
            toDoList.Remove(toDoList.ElementAt(parsedIndexToRemove - 1));
            toDoRemoved = true;
        } else
        {
            Console.WriteLine("The given index is not valid.");
        }

    } while (!toDoRemoved);
}