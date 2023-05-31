
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] lenght = new int[numbers.Length];
int sumEven = 0;
int sumOdd = 0;

for (int i = 0; i < lenght.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        sumEven += numbers[i];
    }
    else
    {
        sumOdd += numbers[i];
    }

}

Console.WriteLine($"{sumEven - sumOdd}");








