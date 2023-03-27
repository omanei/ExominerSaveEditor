using ExominerSaveEditor;

string filePath;
do
{
    Console.WriteLine("Enter file path: ");
    filePath = Console.ReadLine().Trim();

    if (string.IsNullOrEmpty(filePath))
    {
        Console.WriteLine("Error: file path cannot be empty.");
    }
    else if (!File.Exists(filePath))
    {
        Console.WriteLine("Error: file does not exist.");
    }
} while (string.IsNullOrEmpty(filePath) || !File.Exists(filePath));

Exominer exominer = new(filePath);

int choice;
do
{
    Console.WriteLine("Your save:");
    Console.WriteLine(exominer.ShowInfo());
    Console.WriteLine();
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. edit SoftCurrency");
    Console.WriteLine("2. edit HardCurrency");
    Console.WriteLine("3. edit SciencePoints");
    Console.WriteLine("4. edit OreValues");
    Console.WriteLine("5. edit AlloyValue");
    Console.WriteLine("6. edit ItemsValue");
    Console.WriteLine("7. edit SmelterLevel");
    Console.WriteLine("8. edit CrafterLevel");
    Console.WriteLine("9. DisableAds");
    Console.WriteLine("10. Save File");
    Console.WriteLine("0. Exit");

    if (!int.TryParse(Console.ReadLine(), out choice))
    {
        Console.WriteLine("Invalid choice. Please enter a number.");
    }
    else
    {
        switch (choice)
        {
            case 1:
                exominer.SetSoftCurrency(ReadDoubleFromConsole("Enter a new SoftCurrency value: "));
                break;
            case 2:
                exominer.SetHardCurrency(ReadDoubleFromConsole("Enter a new HardCurrency value: "));
                break;
            case 3:
                exominer.SetSciencePoints(ReadDoubleFromConsole("Enter a new SciencePoints value: "));
                break;
            case 4:
                exominer.SetOreValue(ReadDoubleFromConsole("Enter a new OreValue: "));
                break;
            case 5:
                exominer.SetAlloyValue(ReadDoubleFromConsole("Enter a new AlloyValue: "));
                break;
            case 6:
                exominer.SetItemsValue(ReadDoubleFromConsole("Enter a new ItemsValue: "));
                break;
            case 7:
                exominer.SetSmelterLevel(ReadDoubleFromConsole("Enter a new SmelterLevel: "));
                break;
            case 8:
                exominer.SetCrafterLevel(ReadDoubleFromConsole("Enter a new CrafterLevel: "));
                break;
            case 9:
                exominer.DisableAds();
                Console.WriteLine("Ads Disable!");
                break;
            case 10:
                exominer.WriteFile();
                break;
            case 0:
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid choice. Please choose a valid option.");
                break;
        }
    }
    Console.WriteLine();
} while (choice != 0);

static double ReadDoubleFromConsole(string prompt)
{
    double result;
    bool validInput;

    do
    {
        Console.Write(prompt);
        validInput = double.TryParse(Console.ReadLine(), out result);

        if (!validInput)
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }

    } while (!validInput);

    return result;
}
