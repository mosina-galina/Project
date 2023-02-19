Console.WriteLine("Введите длинну массива ");
int n = int.Parse(Console.ReadLine() ?? "");
string [] m = new string [n];
string [] m1 = new string [n];
NewArray(m);
WriteArray(m);
void NewArray (string [] arr)
{
    for (int i = 0; i < n; i++)
    {
        arr[i] = Console.ReadLine() ?? "";
    }
}
void WriteArray (string [] arr)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{arr[i]} ");

    }
}
