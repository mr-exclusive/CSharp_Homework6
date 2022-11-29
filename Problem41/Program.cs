// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


string GetUserInputFromConsole()
{
    string line = string.Empty;
    bool cancelInput = false;

    do
    {
        Console.Write("Enter a number or type 'q' to finish input: ");
        string input = Console.ReadLine();

        if (input == "q")
        {
            cancelInput = true;
        }
        else
        {
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int n))
            {
                if (!string.IsNullOrEmpty(line))
                {
                    line += " ";
                }

                line += input;
            }
            else
            {
                Console.WriteLine("NOT a number!");
            }
        }
    } while (!cancelInput);

    return line;
}

int CountPositiveNumbers(string userInput)
{
    if (string.IsNullOrEmpty(userInput))
    {
        return 0;
    }
    else
    {
        return userInput.Split(" ")
                        .Select(e => int.Parse(e))
                        .Count(e => e > 0);
    }
    
}

Console.Clear();

string userInput = GetUserInputFromConsole();
Console.WriteLine(userInput);
Console.WriteLine($"Entered {CountPositiveNumbers(userInput)} number(s) greater 0");