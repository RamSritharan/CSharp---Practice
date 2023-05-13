//Console.WriteLine("Hello everybody");

//Console.WriteLine("Please enter your name: ");
//string firstName = Console.ReadLine();

//Console.WriteLine("Please enter your name: ");
//string lastName = Console.ReadLine();

//Console.WriteLine("Hello ");


//int a = 3;

//int b = 5;

//int c = a + b;

////Console.WriteLine(c);



////int a = 1;

////a+= 2;

////Console.WriteLine(a);


//DateTime hireDate = new DateTime(2022, 3, 28, 14, 30, 00);

//DateTime startDate = hireDate.AddDays(15);


//Console.WriteLine(hireDate);


//int numberOfHoursWorked = 165;

//long verLongMonth = numberOfHoursWorked;

//Console.WriteLine(verLongMonth);

//double d = 1234433.5332;

//int x = (int)d;

//Console.WriteLine(x);


//Console.WriteLine("Enter first value");
//string stringValue1 = Console.ReadLine();

//Console.WriteLine("Enter second value");
//string stringValue2 = Console.ReadLine();


//int intValue1 = int.Parse(stringValue1);
//int intValue2 = int.Parse(stringValue2);

//var sum = intValue1 + intValue2;



//Console.WriteLine("Enter a value: ");
//int max = int.Parse(Console.ReadLine());

//for (int i = 0; i < max; i++)
//{
//    if (i == 5)
//    {
//        Console.WriteLine("bingo!" + i);
//        continue;
//    }
//    Console.WriteLine(i);
//}



//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}


//if statements


//
//methods


int amount = 1234;
int months = 12;

CalculateYearlyWage(amount, months);

Console.ReadLine(); 

static void CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
{
    Console.Write($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
}









