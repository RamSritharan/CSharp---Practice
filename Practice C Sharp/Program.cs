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


//int amount = 1234;
//int months = 12;

//CalculateYearlyWage(amount, months);

//Console.ReadLine(); 

//static void CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
//{
//    Console.Write($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
//}


////mthods

//public class Utilities
//{
//    public static int MultiplyTwoNumbers(int a, int b)
//    {
//        return a * b
//    }
//}



//int 1 = myString.Length;

//string upper = myString.ToUpper();

//bool b = myString.Contains("Hello");

//string s = myString.Replace("a", "b");

//string sub myString.Substring(1,3);



//String interpolation

//string userNameWithINterpolation = $"{varialbleName1}-{variableName2}";

//Use a backslash \ as an escape string
//Verbatum string using @ will remove the requirement to use escape characters
// use .Equals method to compare strings. Does name2.Equals("Bethany") will return true or false


//parse and tryparse - tryparse will provide a run time exception


//Access modifiers
//Public, Private,Protected



//namespaces are grouping of classes
//you have to instantiate a class using constructors. Can have multiple constructors

//Invoking a constructor
//Employee bethany = new Employee();



//double represents decimal numbers

//namespace BethanysPieShopHRM
//{

//internal class Employee
//    {
//        public string firstName;
//        public string lastName;
//        public string email;

//        public int numberOfHoursWorked;
//        public double wage;
//        public double doubelhourlyRate;

//        public DateTime birthDay;

//        public void PerformWork()
//        {
//            numberOfHoursWorked++;
//            Console.WriteLine($"{firstName} {lastName}. ");

//        }


//    }
//}


//Employee emp1 = new Employee();
//emp1.firstName = "Bethany";

//Employee emp2 = emp1;
//emp2.firstName = "George";

//string check = emp1.firstName;


//Console.WriteLine("Hello World");



//You can make variables nullable by ading a ?
//Garbage collection takes unused items in memory and freess up space.
//GC.Collect() forcing garbage collection.


//int[] sampleArray1 = new int[5];

//var testId = sampleArray1[0]; //compile time error vs runtime error

//Declaring an array by instantiating it:
//int[] intValues = new int[] {5,15,25,35,45};

//Writing a loop
//

//int[] myValues = new int[] { 5, 15, 25, 35, 45 };


//for (int i = 0; i < myValues.Length; i++)
//{
//    Console.WriteLine(myValues[i]);
//}



//Vehicle v1 = new Vehicle(10, "BMW", "Red");
//Vehicle v2 = new Vehicle(45, "Toyota", "Blue");
//Vehicle v3 = new Vehicle(987, "Renault", "Black");
//Vehicle v4 = new Vehicle(45643, "Volkswagen", "Green");
//Vehicle v5 = new Vehicle(0, "Fiat", "Red");


//Vehicle[] vehicles = new Vehicle[5];

//vehicles[0] = v1;
//vehicles[1] = v2;
//vehicles[2] = v3;
//vehicles[3] = v4;
//vehicles[4] = v5;

//Value vs Reference Types
//Reference types are created on the heap.
//CopyTo() or Sort() method are built in methods
//Reverse(), Length is a property

//public class Utilities
//{
//    public static int CalculateSumOfArrayElements(int[] array)
//    {
//        int total = 0;
//        for (int i = 0; i < array.Length; i++)
//        {
//            total += array[i];
//        }
//        return total;
//    }

//}




