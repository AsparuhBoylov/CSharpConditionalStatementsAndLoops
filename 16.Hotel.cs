using System;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nightsCount = int.Parse(Console.ReadLine());

            double studioPrice = 0.00;
            double doublePrice = 0.00;
            double suitePrice = 0.00;

            double totalStudio = 0.00;
            double totalDouble = 0.00;
            double totalSuite = 0.00;

            switch (month)
            {
                case "may":
                case "october":
                    if (nightsCount <= 7)
                    {
                        studioPrice += 50.00;
                        doublePrice += 65.00;
                        suitePrice += 75.00;
                    }
                    else if (nightsCount > 7 )
                    {
                        studioPrice += 50.00 - (50.00 * 0.05);
                        doublePrice += 65.00;
                        suitePrice += 75.00;
                    }                                  
                    break;
                case "june":
                case "september":
                    if (nightsCount <= 14)
                    {
                        studioPrice += 60.00;
                        doublePrice += 72.00;
                        suitePrice += 82.00;
                    }
                    else if (nightsCount > 14)
                    {
                        studioPrice += 60.00;
                        doublePrice += 72.00 - (72.00 * 0.10);
                        suitePrice += 82.00;
                    }
                    break;
                case "july":
                case "august":
                case "december":
                    if (nightsCount <= 14)
                    {
                        studioPrice += 68.00;
                        doublePrice += 77.00;
                        suitePrice += 89.00;
                    }
                    else if(nightsCount > 14)
                    {
                        studioPrice += 68.00;
                        doublePrice += 77.00;
                        suitePrice += 89.00 - (89.00 * 0.15);
                    }
                    break;
            }
            totalStudio = nightsCount * studioPrice;
            totalDouble = nightsCount * doublePrice;
            totalSuite = nightsCount * suitePrice;
            if(month.Equals("september") && nightsCount > 7 )
            {
                totalStudio = 60.00 * (nightsCount - 1);
               
            }
            else if(month.Equals("october") && nightsCount > 7)
            {
                totalStudio = 50.00 * (nightsCount - 1);
                totalStudio -= (totalStudio * 0.05);
            }

            Console.WriteLine($"Studio: {totalStudio:F2} lv.");
            Console.WriteLine($"Double: {totalDouble:F2} lv.");
            Console.WriteLine($"Suite: {totalSuite:F2} lv.");
        }
    }
}
