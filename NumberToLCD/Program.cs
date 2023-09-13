using NumberToLCD;

Console.WriteLine("=============================================" +
    "\nWelcome To My LCD Display Converter Doohicky!" +
    "\n=============================================" +
    "\n" +
    "\nBefore we begin. please select which version of the program you would like to use:" +
    "\n" +
    "\n1. Neat numbers, but they're not scaleable." +
    "\n2. Less-neat numbers, but you can choose how big they are.\n");

int choice;
if (int.TryParse(Console.ReadLine(), out choice))
{
    switch (choice)
    {
        case 1:
            NeatLcdDisplay();
            break;

        case 2:
            ScaleableLcdDisplay();
            break;

        default:
            Console.WriteLine("Please enter a valid input (1 or 2).");
            break;
    }
}
else
{
    Console.WriteLine("\nPlease enter a valid integer.\n");
}

int GetIntWithInputValidation()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("\nPlease enter a valid integer.\n");
    }
    return number;
}

void ScaleableLcdDisplay()
{
    Console.WriteLine("\nEnter a number, and the program will show you that number as a scaleable LCD display!\n");
    int numberToConvert = GetIntWithInputValidation();

    Console.WriteLine("\nPlease enter the width of your number:   (WARNING: a width of 3 or below may not form a full number)\n");
    int numberWidth = GetIntWithInputValidation();

    Console.WriteLine("\nPlease enter the height of your number:  (WARNING: a height of 4 or below may not form a full number)\n");
    int numberHeight = GetIntWithInputValidation();

    var getScaleableNumbers = new GetScaleableNumbers();

    string numberAsString = numberToConvert.ToString();

    string[] zero = getScaleableNumbers.GetScaledZero(numberHeight, numberWidth);
    string[] one = getScaleableNumbers.GetScaledOne(numberHeight, numberWidth);
    string[] two = getScaleableNumbers.GetScaledTwo(numberHeight, numberWidth);
    string[] three = getScaleableNumbers.GetScaledThree(numberHeight, numberWidth);
    string[] four = getScaleableNumbers.GetScaledFour(numberHeight, numberWidth);
    string[] five = getScaleableNumbers.GetScaledFive(numberHeight, numberWidth);
    string[] six = getScaleableNumbers.GetScaledSix(numberHeight, numberWidth);
    string[] seven = getScaleableNumbers.GetScaledSeven(numberHeight, numberWidth);
    string[] eight = getScaleableNumbers.GetScaledEight(numberHeight, numberWidth);
    string[] nine = getScaleableNumbers.GetScaledNine(numberHeight, numberWidth);

    for (int y = 0; y < numberHeight; y++)
    {
        for (int x = 0; x < numberAsString.Length; x++)
        {
            if (numberAsString[x].Equals('0'))
            {
                Console.Write(zero[y]);
            }
            if (numberAsString[x].Equals('1'))
            {
                Console.Write(one[y]);
            }
            if (numberAsString[x].Equals('2'))
            {
                Console.Write(two[y]);
            }
            if (numberAsString[x].Equals('3'))
            {
                Console.Write(three[y]);
            }
            if (numberAsString[x].Equals('4'))
            {
                Console.Write(four[y]);
            }
            if (numberAsString[x].Equals('5'))
            {
                Console.Write(five[y]);
            }
            if (numberAsString[x].Equals('6'))
            {
                Console.Write(six[y]);
            }
            if (numberAsString[x].Equals('7'))
            {
                Console.Write(seven[y]);
            }
            if (numberAsString[x].Equals('8'))
            {
                Console.Write(eight[y]);
            }
            if (numberAsString[x].Equals('9'))
            {
                Console.Write(nine[y]);
            }
        }
        Console.WriteLine("");
    }
}

void NeatLcdDisplay()
{
    Console.WriteLine("\nEnter a number, and the program will show you that number as an LCD display!\n");

    int number = GetIntWithInputValidation();

    string[] zero = { " _ ", "| |", "|_|" };
    string[] one = { "   ", " | ", " | " };
    string[] two = { " _ ", " _|", "|_ " };
    string[] three = { " _ ", " _|", " _|" };
    string[] four = { "   ", "|_|", "  |" };
    string[] five = { " _ ", "|_ ", " _|" };
    string[] six = { " _ ", "|_ ", "|_|" };
    string[] seven = { " _ ", "  |", "  |" };
    string[] eight = { " _ ", "|_|", "|_|" };
    string[] nine = { " _ ", "|_|", " _|" };

    string numberAsString = number.ToString();
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < numberAsString.Length; j++)
        {
            if (numberAsString[j].Equals('0'))
            {
                Console.Write(zero[i]);
            }
            if (numberAsString[j].Equals('1'))
            {
                Console.Write(one[i]);
            }
            if (numberAsString[j].Equals('2'))
            {
                Console.Write(two[i]);
            }
            if (numberAsString[j].Equals('3'))
            {
                Console.Write(three[i]);
            }
            if (numberAsString[j].Equals('4'))
            {
                Console.Write(four[i]);
            }
            if (numberAsString[j].Equals('5'))
            {
                Console.Write(five[i]);
            }
            if (numberAsString[j].Equals('6'))
            {
                Console.Write(six[i]);
            }
            if (numberAsString[j].Equals('7'))
            {
                Console.Write(seven[i]);
            }
            if (numberAsString[j].Equals('8'))
            {
                Console.Write(eight[i]);
            }
            if (numberAsString[j].Equals('9'))
            {
                Console.Write(nine[i]);
            }
        }
        Console.WriteLine("");
    }
}