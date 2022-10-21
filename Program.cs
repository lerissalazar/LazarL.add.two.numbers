//lerissa lazar
//10-19-22
//add numbers
//The user is asked to input 2 numbers and the computer will add them together.

Console.Clear();

string numberOne, numberTwo;
int numOne = 0, numTwo = 0;
bool validNumOne, validNumTwo;
bool loop = true;

Console.WriteLine("Hey, Lets add two numbers");

while (loop)
{
    validNumOne = false;
    Console.WriteLine("Enter your first number");
    while (!validNumOne)
    {
        numberOne = Console.ReadLine();

        validNumOne = int.TryParse(numberOne, out numOne);
        if (!validNumOne)
        {
            Console.WriteLine("Invalid input, enter a number");
        }
    }
    validNumTwo = false;
    Console.WriteLine("Enter your second number");
    while (!validNumTwo)
    {
        numberTwo = Console.ReadLine();

        validNumTwo = int.TryParse(numberTwo, out numTwo);
        if (!validNumTwo)
        {
            Console.WriteLine("Invalid input, enter your second number");
        }
    }

    if (validNumOne && validNumTwo)
    {
        Console.WriteLine("Your sum is " + (numOne + numTwo));
        Console.WriteLine("Would you like to play again? Yes or no?");

        bool validLoopInput = false;
        while (!validLoopInput)
        {
            string loopInput = Console.ReadLine().ToLower();

            if (loopInput == "yes")
            {
                validLoopInput = true;
            }
            else if (loopInput == "no")
            {
                validLoopInput = true;
                loop = false;
                Console.WriteLine("Okay bye now!");
            }
            else
            {
                Console.WriteLine("Invalid input. Enter Yes or No");
            }
        }
    }
    else
    {
        Console.WriteLine("Invalid response, try again");
        loop = true;
    }
}