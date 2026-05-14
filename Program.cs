
Calculator myCalculator = new Calculator();


Console.WriteLine("Please enter number A");
double a = double. Parse (Console.ReadLine());

Console.WriteLine("Please enter number B");
double b = double. Parse (Console.ReadLine());


bool validChoice = false;
while (validChoice == false)
{
Console.WriteLine("Selcted method between the following: \nA for Addition \nB for Substraction \nC for Multiplication \nD for Division");
string Choice = (Console.ReadLine());

if ( Choice == "A")
{
    Console.WriteLine(myCalculator.AddNumbers (a, b));
    validChoice = true;
}
else if ( Choice == "B")
{
    Console.WriteLine(myCalculator.SubtractNumbers (a, b));
    validChoice = true;
}
else if ( Choice == "C")
{
    Console.WriteLine(myCalculator.MultiplyNumbers (a, b));
    validChoice = true;
}
else if ( Choice == "D")
{
    Console.WriteLine(myCalculator.DivideNumbers (a, b));
    validChoice = true;
}
else
{
    Console.WriteLine(" Input a correct Method");
  }
}
public class Calculator
{
public double AddNumbers(double a, double b)
    {
        return a + b;
    }

public double SubtractNumbers(double a, double b)
    {
        return a - b;
    }

    public double MultiplyNumbers(double a, double b)
    {
        return a * b;
    }

    public double DivideNumbers(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }
        return a / b;
    }
}