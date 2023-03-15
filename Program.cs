string[] array = { "Hello", "Alexandr", "Perm", "GB", "27", "Text", "!", ")" };
string arr = string.Join(", ", array);
Console.Write($"[{arr}] -> ");
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
            Console.Write(string.Join(", ", $"{array[i]}, "));          
    }
}