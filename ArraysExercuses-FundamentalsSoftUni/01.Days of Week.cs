using System;

namespace ArraysExercuses_FundamentalsSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] daysOfWeek =
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };


            int input = int.Parse(Console.ReadLine());

            string day = string.Empty;

            switch (input)
            {
                case 1:

                    day = daysOfWeek[input - 1];
                    break;
                case 2:

                    day = daysOfWeek[input - 1];
                    break;
                case 3:

                    day = daysOfWeek[input - 1];
                    break;
                case 4:

                    day = daysOfWeek[input - 1];
                    break;
                case 5:

                    day = daysOfWeek[input - 1];
                    break;
                case 6:

                    day = daysOfWeek[input - 1];
                    break;
                case 7:

                    day = daysOfWeek[input - 1];
                    break;
                default:
                    day = "Invalid day!";

                    break;




            }

            Console.WriteLine(day);
        }
    }
}

