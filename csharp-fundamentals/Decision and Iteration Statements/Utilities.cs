namespace Decision_and_Iteration_Statements;

public static class Utilities
{
    public static void CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
    {
        Console.WriteLine($"Yearly Wage: {monthlyWage * numberOfMonthsWorked}");
    }

    public static int GetYearlyWage(int monthlyWage, int numberOfMonthsWorked)
    {
        return monthlyWage * numberOfMonthsWorked;
    }
    
    // Optional parameters
    public static int SumNumbers(int first, int second, int third = 100)
    {
        return first + second + third;
    }
    
    // Expression bodied members
    public static void PrintMessage(string message) => Console.WriteLine(message);
}