using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RopeIntranetProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineNumber = 0;
            int caseNumber = 0;
            int numberOfRopes = 0;
            int numOfIntersects = 0;

            List<int> listRopeValues = new List<int>();
            List<int> checkedRopes = new List<int>();
            List<string> toFile = new List<string>();
            string toFileStr = "";

            foreach (string line in File.ReadLines(@"C:\\Users\\Adam\\Desktop\\\RopeProblem\\A-large-practice.in"))
            {
                // Execute after first line.
                if (lineNumber > 0)
                {

                    // Execute if line denotes number of ropes value.
                    if (!(line.Contains(' ')))
                    {
                        toFileStr = "";
                        numberOfRopes = int.Parse(line);
                        caseNumber++;
                        Console.Write("Case #{0}: ", caseNumber);
                        toFileStr += "Case #" + caseNumber.ToString() + ": ";

                    }

                    // Execute if line denotes actual rope values.
                    else 
                    {
                        string ropeValStr = "";
                        
                        foreach (char item in line)
                        {
                            if (item != ' ')
                            {
                                ropeValStr += item;
                            }
                            else 
                            {
                                listRopeValues.Add(int.Parse(ropeValStr));
                                ropeValStr = "";
                            }
                        }
                        listRopeValues.Add(int.Parse(ropeValStr));
                    }

                    // Execute to determine number of intersections.
                    if (listRopeValues.Count() == numberOfRopes * 2)
                    {
                        for (int i = 1; i < numberOfRopes + 1; i++)
                        {
                            for (int c = 1; c < numberOfRopes + 1; c++)
                            {
                                if(i != c )
                                {
                                    numOfIntersects += checkIntersects(listRopeValues, i, c);
                                }
                            }
                        }

                        Console.WriteLine(numOfIntersects / 2);
                        listRopeValues.Clear();
                        toFileStr += (numOfIntersects / 2).ToString();
                        toFile.Add(toFileStr);
                        numOfIntersects = 0;
                    }
                } 
                
                // Execute first line.
                else
                {
                    //Console.WriteLine("Number of Test cases: " + line);
                }

                lineNumber++;

            } // foreach end.

            File.WriteAllLines(@"C:\Users\Adam\Desktop\RopeProblem\output.txt", toFile);
        } // Main end.

        // Logic to check for intersections.
        private static int checkIntersects(List<int> listRopeValues,int i,int c)
        {
            int numOfIntersects = 0;

            if ((listRopeValues[((i) * 2) - 2] < listRopeValues[((c) * 2) - 2] &&
                listRopeValues[((i) * 2) - 1] > listRopeValues[((c) * 2) - 1]) ||
                (listRopeValues[((i) * 2) - 2] > listRopeValues[((c) * 2) - 2] &&
                listRopeValues[((i) * 2) - 1] < listRopeValues[((c) * 2) - 1]))
            {
                numOfIntersects++;
            }
            return numOfIntersects;
        }


    } // Class program end.
}
