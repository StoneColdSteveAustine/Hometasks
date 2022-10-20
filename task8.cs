Console.WriteLine("Введите длинну: ");
int n = int.Parse(Console.ReadLine());
    
for (int index = 1; index <= n; index++)
    if (index % 2 == 0)
        Console.WriteLine(index);