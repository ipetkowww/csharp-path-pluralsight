using Decision_and_Iteration_Statements;

int amount = 1234;
int months = 12;

Utilities.CalculateYearlyWage(amount, months);

int yearlyWage = Utilities.GetYearlyWage(amount, months);
Console.WriteLine($"Yearly Wage: {yearlyWage}");

Console.WriteLine(Utilities.SumNumbers(10, 20));
Console.WriteLine(Utilities.SumNumbers(10, 20, 30));

// Named arguments
Console.WriteLine(Utilities.SumNumbers(third: 30, first: 10, second: 20));

// Expression bodied members
Utilities.PrintMessage("Hello, World!");