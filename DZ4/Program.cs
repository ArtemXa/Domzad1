Console.WriteLine("Введите число :");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
int i = m;
while (i <= n)
{
    i++;
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}