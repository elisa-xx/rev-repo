////basic program that calculates and displays the area and perimeter of a square.
//using System.Runtime.Intrinsics.X86;
//double len = -1;
//while (len <= 0)
//{
//    Console.WriteLine("Enter length of square");
//    len = double.Parse(Console.ReadLine());
//    if (len <= 0)
//    {
//        Console.WriteLine("You have entered an invalid length");
//    }
//}
//double area = Math.Pow(len, 2);
//double peri = 4 * len;
//Console.WriteLine($"For a square of length {len}, the area is {area} and perimeter is {peri}");

////Here is a program that reads in two assessment results and displays the average result (i.e. the total 
////of the two assessment results divided by two) and the assessment grade 

//int NumValidator(string input) 
//{
//    int numScore;
//    if (int.TryParse(input, out int score)){
//        numScore = score;
//    }
//    else
//    {
//        numScore = -1;
//    }
//    return numScore;
//}

//int score1 = -1;
//while (score1 < 0 || score1>100)
//{
//    Console.WriteLine("Enter your first score");
//    score1 = NumValidator(Console.ReadLine());
//    if (score1 < 0 || score1 > 100)
//    {
//        Console.WriteLine("Invalid score entered");
//    }
//    else
//    {
//        Console.WriteLine($"Your first score is {score1}");
//    }
//}

//int score2 = -1;
//while (score2 < 0 || score2 > 100)
//{
//    Console.WriteLine("Enter your second score");
//    score2 = NumValidator(Console.ReadLine());
//    if (score2 < 0 || score2 > 100)
//    {
//        Console.WriteLine("Invalid score entered");
//    }
//    else
//    {
//        Console.WriteLine($"Your first score is {score2}");
//    }
//}
    

//double avgScore = (score1 + score2) / 2d;
//Console.WriteLine($"The average of your scores is {avgScore}");
//if(avgScore >=0 && avgScore <= 49)
//{
//    Console.WriteLine("Grade: Fail");
//}
//else if (avgScore >=50 && avgScore <= 100)
//{
//    Console.WriteLine("Grade: Pass");
//}

////A program that prints 10 by 10 multiplication table. 
////Sample Output: 
////1 2 3 4 5 6 7 8 9 10
////2 4 6 8 10 12 14 16 18 20
////3 6 9 12 15 18 21 24 27 30
////4 8 12 16 20 24 28 32 36 40
////5 10 15 20 25 30 35 40 45 50
////6 12 18 24 30 36 42 48 54 60
////7 14 21 28 35 42 49 56 63 70
////8 16 24 32 40 48 56 64 72 80
////9 18 27 36 45 54 63 72 81 90
////10 20 30 40 50 60 70 80 90 100
////
//for (int j = 1; j <= 10; j++)
//{
//    for (int i = 1; i <= 10; i++)
//    {
//        if (i != 1)
//        {
//            Console.Write(" ");
//        }
//        Console.Write($"{i * j}");


//    }
//    Console.WriteLine();
//}

///*
//A program that reads in the name and hourly wage of an employee. Then ask how many hours 
//the employee worked in the past week. Be sure to accept fractional hours. Calculate the pay. Any 
//overtime work (over 40 hours per week) is paid at 150 percent of the regular wage.
//Sample Inputs: 
//Name: Harry Hourly Wage: 35 Hours worked: 32.5
//Sample Output: 
//Harry worked for 32.5 hours this week and the wage is 1137.5 dollars

// */

//Console.WriteLine("Please enter employee name");
//string name = Console.ReadLine();
//Console.WriteLine("Please enter hourly wage");
//double hourlyWage = double.Parse(Console.ReadLine());
//Console.WriteLine("Please enter hours worked");
//double hours = double.Parse(Console.ReadLine());
//double wage = (hourlyWage * Math.Min(hours, 40)) + (hourlyWage * 1.5 * Math.Max(hours - 40, 0));
//Console.WriteLine($"{name} worked for {hours} hours this week and the wage is {wage} Australian dollars");

////Write a program to print a four-digit number in words.

Console.WriteLine("Enter a 4 digit number");
//split string of numbers into int, store in an array of 4 int
//iterate through the array, and use switch to replace int with the word equivalent
string fourDigitStr = Console.ReadLine();
char[] singleDigits = fourDigitStr.ToCharArray();
//Console.WriteLine($"{singleDigits[0]}{singleDigits[1]}{singleDigits[2]}{singleDigits[3]}");
foreach (char number in singleDigits)
{
    switch (number)
    {
        case '1':
            Console.Write("one");
            break;
        case '2':
            Console.Write("two");
            break;
        case '3':
            Console.Write("three");
            break;
        case '4':
            Console.Write("four");
            break;
        case '5':
            Console.Write("five");
            break;
        case '6':
            Console.Write("six");
            break;
        case '7':
            Console.Write("seven");
            break;
        case '8':
            Console.Write("eight");
            break;
        case '9':
            Console.Write("nine");
            break;
      
    }
}