// See https://aka.ms/new-console-template for more information

// int age = 23;
//
// bool result = age == 23;
// Console.WriteLine("Age is 23: " + result);
//
// result = age > 23;
// Console.WriteLine("Age is greater than 23: " + result);
//
// result = (age >= 18) && (age <= 65);
// Console.WriteLine("Age is between 18 and 65: " + result);

Console.Write("Enter the age of the new candidate: ");
int age = int.Parse(Console.ReadLine()!);

// if (age < 18)
// {
//     Console.WriteLine("Candidate is too young.");
//     Console.WriteLine("Send email to the candidate.");
// }
// else if (age > 65)
// {
//     Console.WriteLine("Candidate is too old.");
// }
// else
// {
//     Console.WriteLine("Candidate is eligible.");
//     Console.WriteLine("Start with the application process.");
// }

switch (age)
{
    case < 18:
        Console.WriteLine("Candidate is too young.");
        Console.WriteLine("Send email to the candidate.");
        break;
    case > 65:
        Console.WriteLine("Candidate is too old.");
        break;
    case 23:
        Console.WriteLine("Wow, exactly what we are looking for!");
        break;
    default:
        Console.WriteLine("Candidate is eligible.");
        Console.WriteLine("Start with the application process.");
        break;
}