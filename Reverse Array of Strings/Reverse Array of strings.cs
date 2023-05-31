namespace Reverse_Array_of_Strings;
class Program
{
    static void Main(string[] args)
    {
        string[] characters = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for(int i =0;i<characters.Length/2;i++)
        {
            string frontCharacter = characters[i];
            string backCharacter = characters[(characters.Length - 1) - i];

            string tempCharacter = frontCharacter;
            characters[i] = backCharacter;
            characters[(characters.Length - 1) - i] = tempCharacter;


        }
        Console.WriteLine(String.Join(' ', characters));


       
    }
}

