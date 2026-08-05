void CalculateNumbers(int var1, int var2)
{
    int result = var1 + var2;
    Console.WriteLine($"The result of adding {var1} and {var2} is: {result}");
}

Console.WriteLine("Enter the first number:");
var num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number:");
var num2 = Convert.ToInt32(Console.ReadLine());
CalculateNumbers(num1, num2);
