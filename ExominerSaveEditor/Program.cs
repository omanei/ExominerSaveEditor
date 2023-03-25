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
Console.WriteLine("Your currency:");
Console.WriteLine(exominer.ShowWallet());

int choice;
do
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. edit SoftCurrency");
    Console.WriteLine("2. edit HardCurrency");
    Console.WriteLine("3. edit SciencePoints");
    Console.WriteLine("4. Save");
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
                exominer.WriteFile();
                Console.WriteLine("File save.");
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
