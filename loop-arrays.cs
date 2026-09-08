string[] days = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

// You can loop through an array using a traditional for loop
// The trick is that highest index is one less than the length
// hence our condition i < days.length
// (This give the advantage that can create a numbered list)
for(int i = 0; i < days.Length; i++)
{
    Console.WriteLine($"{i + 1}.{days [i]} ");
}

// A good practice is to ALWAYS choose a variable name in plural
// for arrays and lists

// A foreach loop is much simpler if you need to create
// a list in the output

foreach (string day in days)
{
    Console.WriteLine($"*{day}");
}

// A third alternative if you need numbering with foreach
int counter = 1;
foreach (string day in days)
{
    Console.WriteLine($"{counter}. {day}");
    counter++;
}