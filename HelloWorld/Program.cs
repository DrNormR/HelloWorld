using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;

//===============================================================================
///////////////////////////////////////////////////////////////////////////////
/// Python 👉🏻 C#
///////////////////////////////////////////////////////////////////////////////
//===============================================================================


///////////////////////////////////////////////////////////////////////////////
///Hello World
///

//Console.WriteLine("Hello!");
//Console.WriteLine("Hello again!");
//Console.WriteLine("Hello again!");
//Console.WriteLine("Hello from Jetbrains rider!");


///////////////////////////////////////////////////////////////////////////////
///Variables in C#

//// 1. Declaration and Initialization
//int age = 25; // 'int' is a type for whole numbers
//Console.WriteLine($"Example: int age = 25;  // age is {age}");

//// 2. Different Data Types
//double height = 1.75; // 'double' is for decimal numbers
//string name = "Alice"; // 'string' is for text
//bool isStudent = true; // 'bool' is for true/false values

//Console.WriteLine($"Example: double height = 1.75;  // height is {height}");
//Console.WriteLine($"Example: string name = \"Alice\";  // name is {name}");
//Console.WriteLine($"Example: bool isStudent = true;  // isStudent is {isStudent}");

//// 3. Changing Variable Values
//age = 30;
//Console.WriteLine($"You can change a variable's value: age = 30;  // age is now {age}");

//// 4. Using Variables in Expressions
//int nextYearAge = age + 1;
//Console.WriteLine($"Variables can be used in calculations: nextYearAge = age + 1;  // nextYearAge is {nextYearAge}");

//// 5. Constants
//const double Pi = 3.14159;
//Console.WriteLine($"Constants are values that cannot change: const double Pi = 3.14159;  // Pi is {Pi}");

//Console.WriteLine("That's a quick introduction to variables in C#!");


//////////////////////////////////////////////////////////////////
//// User Input in C#

//// See https://aka.ms/new-console-template for more information

//// 1. Reading a string from the user
//Console.Write("What is your name? ");
//string name = Console.ReadLine();
//Console.WriteLine($"Hello, {name}!");

//// 2. Reading an integer from the user
//Console.Write("How old are you? ");
//string ageInput = Console.ReadLine();
//int age = int.Parse(ageInput); // Converts the string to an int
//Console.WriteLine($"You are {age} years old.");

//// 3. Reading a double from the user
//Console.Write("What is your height in inches? ");
//string heightInput = Console.ReadLine();
//double height = double.Parse(heightInput); // Converts the string to a double
//Console.WriteLine($"Your height is {height} inches.");

//// 4. Using the input in an expression
//int nextYearAge = age + 1;
//Console.WriteLine($"Next year, you will be {nextYearAge} years old.");

//// 5. Input summary
//Console.WriteLine($"Summary: Name = {name}, Age = {age}, Height = {height} inches");

//Console.WriteLine("That's a quick introduction to user input in C#!");


//////////////////////////////////////////////////////////////////////////
/////// If Else Statements in C#
/////// 

//public class AgeChecker
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("--- Age Checker ---");
//        Console.WriteLine("Enter an age to check. Type 'exit' to quit.");

//        while (true)
//        {
//            Console.WriteLine("\nEnter an age (or 'exit' to quit):");
//            string input = Console.ReadLine();

//            // Check if user wants to exit
//            if (input.ToLower() == "exit")
//            {
//                Console.WriteLine("Thank you for using the Age Checker!");
//                break;
//            }

//            // Try to parse the input string to an integer
//            float age;
//            bool isValidAge = float.TryParse(input, out age);

//            // Check if the input was a valid number
//            if (!isValidAge)
//            {
//                Console.WriteLine("That's not a valid age. Please enter a whole number.");
//                continue;
//            }

//            // Process the age through our conditions
//            if (age < 1)
//            {
//                Console.WriteLine("You are a baby");
//            }
//            else if (age < 5)
//            {
//                Console.WriteLine("You are a toddler");
//            }
//            else if (age < 13)
//            {
//                Console.WriteLine("You are a child");
//            }
//            else if (age >= 13 && age <= 17)
//            {
//                Console.WriteLine("You are a teenager");
//            }
//            else if (age >= 18 && age < 65)
//            {
//                Console.WriteLine("You are an adult");
//            }
//            else
//            {
//                Console.WriteLine("You are a senior citizen");
//            }
//        }
//    }
//}

///////////////////////////////////////////////////////////////////////////////////////////
/////// Loops in C# - While Loop Example
/////// 

//////public class LoopDemonstrator
//////{
//////    public static void Main(string[] args)
//////    {
//////        Console.WriteLine("--- C# Loop Demonstrations ---");

//////        // --- 1. The 'for' loop ---
//////        // Best for situations where you know exactly how many times you want to loop.
//////        // Structure: for (initialization; condition; iterator)
//////        Console.WriteLine("\n=== 1. 'for' Loop Example (Counting from 0 to 4) ===");
//////        for (int i = 0; i < 5; i++)
//////        {
//////            Console.WriteLine($"Current 'for' loop iteration: {i}");
//////        }
//////        Console.WriteLine("End of 'for' loop.");

//////        // --- 2. The 'while' loop ---
//////        // Best for situations where you want to loop as long as a condition is true,
//////        // and the condition might become false inside the loop body.
//////        // The condition is checked *before* each iteration.
//////        Console.WriteLine("\n=== 2. 'while' Loop Example (Counting down from 3) ===");
//////        int countdown = 3;
//////        while (countdown > 0)
//////        {
//////            Console.WriteLine($"Current 'while' loop countdown: {countdown}");
//////            countdown--; // Decrement the counter to eventually make the condition false
//////        }
//////        Console.WriteLine("End of 'while' loop.");


//////        // --- 3. The 'do-while' loop ---
//////        // Similar to 'while', but guarantees the loop body executes *at least once*,
//////        // because the condition is checked *after* the first iteration.
//////        Console.WriteLine("\n=== 3. 'do-while' Loop Example (Guaranteed first run) ===");
//////        int inputNumber;
//////        do
//////        {
//////            Console.Write("Enter a number greater than 5 to exit this loop: ");
//////            // int.TryParse safely converts string to int, avoiding errors for non-numeric input
//////            int.TryParse(Console.ReadLine(), out inputNumber);

//////            if (inputNumber <= 5)
//////            {
//////                Console.WriteLine("Number is 5 or less. Try again.");
//////            }

//////        } while (inputNumber <= 5); // Condition checked after the block

//////        Console.WriteLine($"You entered {inputNumber}. Exiting 'do-while' loop.");


//////        // --- 4. The 'foreach' loop ---
//////        // Best for iterating over collections (like arrays, lists, etc.) without needing
//////        // to manage an index. It processes each item in the collection.
//////        Console.WriteLine("\n=== 4. 'foreach' Loop Example (Iterating over a list of names) ===");
//////        // Updated names for the foreach loop demonstration
//////        List<string> names = new List<string> { "Scooby", "Fred", "Shaggy", "Velma", "Daphne" };

//////        foreach (string name in names)
//////        {
//////            Console.WriteLine($"Hello, {name}!");
//////        }
//////        Console.WriteLine("End of 'foreach' loop.");

//////        Console.WriteLine("\n--- End of Loop Demonstrations ---");
//////        Console.WriteLine("Press any key to exit.");
//////        Console.ReadKey();
//////    }
//////}

///////////////////////////////////////////////////////////////////////////////////////////////


////using System.Collections;

/////// If Else Statements in C#
/////// 
/////// Loops in C# - While Loop Example
/////// 


////using System.Collections.Concurrent;

/////// If Else Statements in C#
/////// 
/////// Loops in C# - While Loop Example
/////// 


////using System.Collections.ObjectModel;

/////// If Else Statements in C#
/////// 
/////// Loops in C# - While Loop Example
/////// 
///////Functions in C#
///////


////public class FunctionDemonstrator
////{
////    public static void Main(string[] args)
////    {
////        Console.WriteLine("--- Welcome to the C# Functions Lesson! ---");
////        Console.WriteLine("Functions (also known as methods) are blocks of code designed to perform a specific task.");
////        Console.WriteLine("They help organize your code, make it reusable, and easier to understand.\n");

////        // --- Demonstration 1: Function with No Parameters and No Return Value (void) ---
////        Console.WriteLine("=== 1. Function with No Parameters & No Return Value (void) ===");
////        Console.WriteLine("   - This type of function performs an action but doesn't send any data back.");
////        Console.WriteLine("   - It's like pressing a button that makes something happen without telling you a result.\n");

////        // Calling the function
////        DisplayWelcomeMessage(); // This function simply executes the code inside it.
////        Console.WriteLine("   (The DisplayWelcomeMessage function was called and completed.)\n");

////        // --- Demonstration 2: Function with Parameters & No Return Value (void) ---
////        Console.WriteLine("=== 2. Function with Parameters & No Return Value (void) ===");
////        Console.WriteLine("   - This function accepts input values (parameters) to customize its behavior.");
////        Console.WriteLine("   - It still performs an action but doesn't send data back.\n");

////        string userName = "Selene";
////        int userAge = 28;

////        // Calling the function with arguments
////        GreetUser(userName, userAge);
////        Console.WriteLine($"   (The GreetUser function was called with Name='{userName}' and Age={userAge}.)\n");

////        // --- Demonstration 3: Function with Parameters and a Return Value ---
////        Console.WriteLine("=== 3. Function with Parameters and a Return Value ===");
////        Console.WriteLine("   - This function accepts input and calculates/produces a result.");
////        Console.WriteLine("   - It 'returns' this result back to where it was called.\n");

////        int num1 = 10;
////        int num2 = 5;

////        // Calling the function and storing its returned value
////        int sum = AddNumbers(num1, num2);
////        Console.WriteLine($"   The sum of {num1} and {num2} is: {sum}");
////        Console.WriteLine($"   (The AddNumbers function calculated and returned the sum.)\n");

////        // --- Demonstration 4: Function Overloading (Optional, but good to know) ---
////        Console.WriteLine("=== 4. Function Overloading Example ===");
////        Console.WriteLine("   - C# allows you to define multiple functions with the SAME NAME");
////        Console.WriteLine("     as long as they have different parameter lists (number, type, or order of parameters).");
////        Console.WriteLine("   - This is called 'function overloading' and makes code more intuitive.\n");

////        double doubleNum1 = 10.5;
////        double doubleNum2 = 20.3;

////        // Calling the overloaded AddNumbers function (it uses the double version)
////        double doubleSum = AddNumbers(doubleNum1, doubleNum2);
////        Console.WriteLine($"   The sum of {doubleNum1} and {doubleNum2} (using overloaded function) is: {doubleSum}");
////        Console.WriteLine("   (The correct AddNumbers function was chosen automatically based on argument types.)\n");


////        Console.WriteLine("--- Lesson Complete! ---");
////        Console.WriteLine("Functions are powerful tools for building organized and efficient C# applications.");
////        Console.WriteLine("Press any key to exit.");
////        Console.ReadKey();
////    }

////    // Function definitions
////    // Function 1: No parameters, no return value (void)
////    public static void DisplayWelcomeMessage()
////    {
////        Console.WriteLine("   Hello, welcome to this demonstration of C# functions!");
////    }

////    // Function 2: With parameters, no return value (void)
////    public static void GreetUser(string name, int age)
////    {
////        Console.WriteLine($"   Greetings, {name}! You are {age} years old.");
////        if (age < 18)
////        {
////            Console.WriteLine("   (You're still growing up!)");
////        }
////        else
////        {
////            Console.WriteLine("   (You're an adult!)");
////        }
////    }

////    // Function 3: With parameters, and a return value (int)
////    public static int AddNumbers(int a, int b)
////    {
////        // This function performs the addition and then 'returns' the result.
////        return a + b;
////    }

////    // Overloaded Function for Demonstration 4: Same name, different parameter types (double)
////    public static double AddNumbers(double a, double b)
////    {
////        // This version handles double numbers.
////        return a + b;
////    }
////}

///////////////////////////////////////////////////////////////////////////////
/////Data Structures in C#
/////

//namespace DataStructuresDemo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // 1. Array - A fixed-size, strongly-typed collection of elements stored in contiguous memory.
//            int[] array = { 1, 2, 3 };
//            Console.WriteLine("Array:");
//            foreach (int item in array)
//                Console.WriteLine(item);

//            // 2. List<T> - A dynamic array that resizes automatically as elements are added or removed.
//            List<string> list = new List<string> { "apple", "banana" };
//            Console.WriteLine("\nList:");
//            list.ForEach(Console.WriteLine);

//            // 3. LinkedList<T> - A doubly linked list allowing efficient insertions and deletions.
//            LinkedList<int> linkedList = new LinkedList<int>();
//            linkedList.AddLast(10);
//            linkedList.AddLast(20);
//            Console.WriteLine("\nLinkedList:");
//            foreach (int item in linkedList)
//                Console.WriteLine(item);

//            // 4. Stack<T> - A Last-In-First-Out (LIFO) collection.
//            Stack<double> stack = new Stack<double>();
//            stack.Push(1.1);
//            stack.Push(2.2);
//            Console.WriteLine("\nStack:");
//            while (stack.Count > 0)
//                Console.WriteLine(stack.Pop());

//            // 5. Queue<T> - A First-In-First-Out (FIFO) collection.
//            Queue<string> queue = new Queue<string>();
//            queue.Enqueue("first");
//            queue.Enqueue("second");
//            Console.WriteLine("\nQueue:");
//            while (queue.Count > 0)
//                Console.WriteLine(queue.Dequeue());

//            // 6. Dictionary<TKey, TValue> - A collection of key/value pairs with fast lookups.
//            Dictionary<string, int> dictionary = new Dictionary<string, int> { { "a", 1 }, { "b", 2 } };
//            Console.WriteLine("\nDictionary:");
//            foreach (var kvp in dictionary)
//                Console.WriteLine($"{kvp.Key}: {kvp.Value}");

//            // 7. SortedDictionary<TKey, TValue> - A dictionary that maintains keys in sorted order.
//            SortedDictionary<int, string> sortedDict = new SortedDictionary<int, string> { { 2, "two" }, { 1, "one" } };
//            Console.WriteLine("\nSortedDictionary:");
//            foreach (var kvp in sortedDict)
//                Console.WriteLine($"{kvp.Key}: {kvp.Value}");

//            // 8. SortedList<TKey, TValue> - A sorted dictionary backed by arrays for fast lookups.
//            SortedList<string, string> sortedList = new SortedList<string, string> { { "b", "B" }, { "a", "A" } };
//            Console.WriteLine("\nSortedList:");
//            foreach (var kvp in sortedList)
//                Console.WriteLine($"{kvp.Key}: {kvp.Value}");

//            // 9. Hashtable - A non-generic collection of key/value pairs allowing any object type.
//            Hashtable hashtable = new Hashtable { { "key1", 100 }, { "key2", 200 } };
//            Console.WriteLine("\nHashtable:");
//            foreach (DictionaryEntry entry in hashtable)
//                Console.WriteLine($"{entry.Key}: {entry.Value}");

//            // 10. HashSet<T> - An unordered collection of unique elements.
//            HashSet<int> hashSet = new HashSet<int> { 1, 2, 2, 3 };
//            Console.WriteLine("\nHashSet:");
//            foreach (var val in hashSet)
//                Console.WriteLine(val);

//            // 11. SortedSet<T> - A sorted collection of unique elements.
//            SortedSet<int> sortedSet = new SortedSet<int> { 3, 1, 2 };
//            Console.WriteLine("\nSortedSet:");
//            foreach (var val in sortedSet)
//                Console.WriteLine(val);

//            // 12. ConcurrentQueue<T> - A thread-safe FIFO collection.
//            ConcurrentQueue<int> concurrentQueue = new ConcurrentQueue<int>();
//            concurrentQueue.Enqueue(1);
//            concurrentQueue.Enqueue(2);
//            Console.WriteLine("\nConcurrentQueue:");
//            while (concurrentQueue.TryDequeue(out int result))
//                Console.WriteLine(result);

//            // 13. ConcurrentDictionary<TKey, TValue> - A thread-safe dictionary allowing concurrent access.
//            ConcurrentDictionary<string, int> concurrentDict = new ConcurrentDictionary<string, int>();
//            concurrentDict.TryAdd("A", 10);
//            concurrentDict.TryAdd("B", 20);
//            Console.WriteLine("\nConcurrentDictionary:");
//            foreach (var kvp in concurrentDict)
//                Console.WriteLine($"{kvp.Key}: {kvp.Value}");

//            // 14. ObservableCollection<T> - A dynamic collection that provides notifications when items change.
//            ObservableCollection<string> observable = new ObservableCollection<string> { "hello", "world" };
//            Console.WriteLine("\nObservableCollection:");
//            foreach (var item in observable)
//                Console.WriteLine(item);

//            // 15. BitArray - A collection representing an array of binary values (bits).
//            BitArray bits = new BitArray(new bool[] { true, false, true });
//            Console.WriteLine("\nBitArray:");
//            foreach (bool bit in bits)
//                Console.WriteLine(bit);
//        }
//    }
//}

////////////////////////////////////////////////////////////////////////
///Classes and Objects
///


//namespace OOPDemo
//{
//    // The 'Car' class defines a blueprint for car objects
//    class Car
//    {
//        // 'public' means this field can be accessed from outside the class
//        public string Make;
//        public string Model;
//        public int Year;

//        // 'private' means this field can only be accessed within this class
//        private bool isRunning;

//        // Constructor method - called when a new object is created
//        // It has no return type, not even 'void'
//        public Car(string make, string model, int year)
//        {
//            Make = make;
//            Model = model;
//            Year = year;
//            isRunning = false; // car starts off (not running)
//        }

//        // 'public' - this method can be called from outside the class
//        // 'void' - this method returns nothing
//        public void Start()
//        {
//            isRunning = true;
//            Console.WriteLine($"{Year} {Make} {Model} is now running.");
//        }

//        // Another 'public void' method: accessible and returns nothing
//        public void Stop()
//        {
//            isRunning = false;
//            Console.WriteLine($"{Year} {Make} {Model} has been turned off.");
//        }

//        // Method to print info about the car
//        public void DisplayInfo()
//        {
//            string status = isRunning ? "running" : "not running";
//            Console.WriteLine($"This car is a {Year} {Make} {Model} and it is currently {status}.");
//        }
//    }

//    // This is the class containing the 'Main' method, which is the program entry point
//    class Program
//    {
//        // 'static' means this method belongs to the class itself, not to an object
//        // 'void' means it does not return any value
//        // 'Main' is the entry point of the program
//        static void Main(string[] args)
//        {
//            // Create a new instance (object) of the Car class
//            Car car1 = new Car("Toyota", "Camry", 2020);

//            // Create another car object
//            Car car2 = new Car("Ford", "Mustang", 2023);

//            // Call methods on the first car object
//            car1.DisplayInfo();  // Show details
//            car1.Start();        // Start the engine
//            car1.DisplayInfo();  // Show updated status
//            car1.Stop();         // Turn off the engine
//            car1.DisplayInfo();  // Final status

//            Console.WriteLine(); // Blank line for readability

//            // Call methods on the second car
//            car2.DisplayInfo();
//            car2.Start();
//            car2.DisplayInfo();
//        }
//    }
//}
