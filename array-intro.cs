string[] days = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

// Check the legnth of an array
// how many items/elements the array contains
Console.WriteLine($"The days array is {days.Length} items long");

// Check the value of the first item in the array
// by specifying an index - the first item is at index 0 
Console.WriteLine($"The first element in the days array has the value: {days[0]}");
Console.WriteLine($"The second element in the days array has the value: {days[1]}");

// Quick way to see the values of an array
Console.WriteLine (days); // This doesn't really work -> System.String[]

// This works, you choose how you want to seperate the items with " "
Console.WriteLine (string.Join(" - ", days)); 

// This works too -> each item on a new line
// \n ->newLine
Console.WriteLine(string.Join("\n", days));

// You can not add or remove items in an array after it has been declared.
// However, you CAN change the values of the items
days [0] = "Lazy day";
Console.WriteLine(string.Join(", ", days));