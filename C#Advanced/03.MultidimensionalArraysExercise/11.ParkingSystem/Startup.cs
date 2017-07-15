using System;
using System.Linq;

namespace _11.ParkingSystem
{
    public class Startup
    {
        public static void Main()
        {
            int[] sizes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(i => int.Parse(i)).ToArray();

            int r = sizes[0];
            int c = sizes[1];

            int[,] parkingLot = new int[r, c];

            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    parkingLot[i, j] = int.MinValue;
                }
            }

            string commandInput = Console.ReadLine();

            while (!commandInput.Equals("stop"))
            {

                string[] commandArgs = commandInput
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int entryRow = int.Parse(commandArgs[0]);
                int desiredRow = int.Parse(commandArgs[1]);
                int desiredCol = int.Parse(commandArgs[2]);

                int rowDiff = Math.Abs(desiredRow - entryRow);

                int travelDistance = -1;

                bool foundSpot = false;

                if (parkingLot[desiredRow, desiredCol] != 0)
                {
                    parkingLot[desiredRow, desiredCol] = 0;

                    if (entryRow != desiredRow)
                    {
                        travelDistance = rowDiff + desiredCol + 1;
                    }
                    else
                    {
                        travelDistance = rowDiff + desiredCol;
                    }
                    foundSpot = true;
                }


                else
                {

                    int leftDistance = 0;

                    for (int i = desiredCol - 1; i >= 1; i--)
                    {

                        if (parkingLot[desiredRow, i] != 0)
                        {
                            parkingLot[desiredRow, i] = 0;
                            travelDistance = rowDiff + desiredCol + leftDistance;
                            foundSpot = true;
                        }
                        leftDistance++;
                    }


                    if (!foundSpot)
                    {
                        int rightDistance = 0;
                        for (int i = desiredCol; i < parkingLot.GetLength(1); i++)
                        {
                            if (parkingLot[desiredRow, i] != 0)
                            {
                                parkingLot[desiredRow, i] = 0;
                                travelDistance = rowDiff + desiredCol + rightDistance + leftDistance;
                                foundSpot = true;
                            }
                            rightDistance++;
                        }
                    }

                }

                if (foundSpot)
                {
                    Console.WriteLine(travelDistance);
                }
                else
                {
                    Console.WriteLine($"Row {desiredRow} full");
                }

                commandInput = Console.ReadLine();
            }
        }
    }
}
