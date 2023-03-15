string[] array = { "Hello", "Alexandr", "Perm", "GB", "27", "Text", "!", ")" };
string arr = string.Join(", ", array);
Console.Write($"[{arr}] -> ");
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        if (i != array.Length - 1)
        {
            Console.Write($"{array[i]}, " );           
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
}