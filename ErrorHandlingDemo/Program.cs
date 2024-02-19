//Calculator

using System.Reflection.Metadata;

Console.WriteLine("Welcome to our Calculator App");

while (true)
{
    try
    {
        Console.Write("Enter first number: ");
        var firstNum = double.Parse(Console.ReadLine()!);
        Console.Write("Enter second number: ");
        var secondNum = double.Parse(Console.ReadLine()!);

        Console.Write("Enter the operator ( +, -, * / ): ");
        var op = Console.ReadLine()!;

        double result = 0;
        switch (op)
        {
            case "+":
            {
                result = firstNum + secondNum;
                break;
            }
            case "-":
            {
                result = firstNum - secondNum;
                break;
            }
            case "*":
            {
                result = firstNum * secondNum;
                break;
            }
            case "/":
            {
                
                result = firstNum / secondNum;
                break;
            }
            default:
            {
                throw new InvalidOperationException("Invalid operator");
            }

        }
        Console.WriteLine($"Result: {result}");
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
    Console.WriteLine("Do you want to continue (Y/N):");
    var cont = Console.ReadLine();
    if(cont == "N" || cont == "n") 
    {
        break;
    }
}
Console.WriteLine("Thank you for using our calculator. See you again!");

