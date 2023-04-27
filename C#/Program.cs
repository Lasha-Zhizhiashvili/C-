Console.WriteLine("enter two number:");

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("choose what to do with number?");
Console.WriteLine("------------------------------");
Console.WriteLine("press 1 for Addition");
Console.WriteLine("press 2 for Subtraction");
Console.WriteLine("press 3 for Multiplication");
Console.WriteLine("press 4 for Division");

string sub = Console.ReadLine();
int og = 4689853;

switch (sub)
{
    case "1":
        Console.WriteLine(num1 + num2);
        break;

    case "2":
        Console.WriteLine(num1 - num2);
        break;

    case "3":
        Console.WriteLine(num1 * num2);
        break;

    case "4":
        Console.WriteLine(num1 / num2);
        break;

    default:
        Console.WriteLine("you didnt enter a valid number");
        break;
}