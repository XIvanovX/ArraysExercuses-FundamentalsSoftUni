namespace Equal_Arrays;
class Program
{
    static void Main(string[] args)
    {
        int[] arrayOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int [] arrayTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] lenght = new int[arrayOne.Length];

        int sum = 0;
        bool isIdentical = false;

        for (int i = 0; i < arrayOne.Length; i++)
        {
            if (arrayOne[i] == arrayTwo[i])
            {
                sum += arrayOne[i];
                isIdentical = true;
            }

            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                break;
                isIdentical = false;
            }
        }

        if(isIdentical)
        {
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}

