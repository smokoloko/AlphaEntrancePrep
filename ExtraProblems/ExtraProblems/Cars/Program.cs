using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int currentColumnSpeed = int.Parse(Console.ReadLine());

            int maxColumn = 1;
            int currentColumn = 1;
            int maxSpeed = currentColumnSpeed;
            int currentSpeed = currentColumnSpeed;

            for (int i = 0; i < length - 1; i++)
            {
                // The speed of the current car
                int currentCar = int.Parse(Console.ReadLine());

                // The current car will be a part of the current column
                if (currentCar > currentColumnSpeed)
                {
                    currentSpeed += currentCar;
                    currentColumn++;
                }

                // Column ends - the current car is slower than the column
                else
                {
                    // Check if the column is bigger than the last
                    if (currentColumn > maxColumn)
                    {
                        maxColumn = currentColumn;
                        maxSpeed = currentSpeed;
                    }
                    else if (currentColumn == maxColumn)
                    {
                        maxSpeed = Math.Max(maxSpeed, currentSpeed);
                    }

                    // Reset the counters
                    currentColumn = 1;
                    currentColumnSpeed = currentCar;
                    currentSpeed = currentColumnSpeed;
                }
            }

            // This is needed in case the longest column includes the end of the array
            if (currentColumn > maxColumn)
            {
                maxSpeed = currentSpeed;
            }
            else if (currentColumn == maxColumn)
            {
                maxSpeed = Math.Max(maxSpeed, currentSpeed);
            }

            Console.WriteLine(maxSpeed);
        }
    }
}
