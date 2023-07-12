//ht1
Console.WriteLine("name:");
string? name = Console.ReadLine();
Console.WriteLine("surname:");
string? surname = Console.ReadLine();
Console.WriteLine("age:");
byte age = byte.Parse(Console.ReadLine());
Console.WriteLine($"name: {name}\nsurname: {surname}\nage: {age}");

///ht2
DateTime dateTime = DateTime.Now;
Console.WriteLine(dateTime.Day);
Console.WriteLine($"{dateTime.Year - 53} year {dateTime.Month - 6}-yanvar");
byte agee = 75;
Console.WriteLine($"{agee} yosh");
float dollor = 35.5F;
Console.WriteLine(dollor);
string nickname = "Max developer";
Console.WriteLine(nickname);

//ht-3

//Primitive types
int? sm = 10;
Console.WriteLine(sm);  
float? salary = 425.5F;
Console.WriteLine(salary);

//Complax
DateTime? date = DateTime.Now;  
Console.WriteLine(date);

Dictionary<int, string> numberNames = new Dictionary<int, string>();
numberNames.Add(1, "bir");
numberNames.Add(2, "ikki");
foreach (var kvp in numberNames)
    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

// value type
int dm = 25;
Console.WriteLine(dm);
float? sum = 34.5F;
Console.WriteLine(sum);

// reference type
string namee = "Asadbek";
Console.WriteLine(namee);
object obj = 2;
Console.WriteLine(obj);





