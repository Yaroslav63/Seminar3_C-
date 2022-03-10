Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    int ind = i * i * i;
    Console.WriteLine(ind + " ");
}
