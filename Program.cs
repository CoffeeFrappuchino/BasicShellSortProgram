/*
    Simple Shell Sort Algorithm program in C#, algorithm provided by [https://code-maze.com/shell-sort-csharp/]
 */

// Method sorts the provided array using the Shell Sort Algorithm
int[] ShellSort(int[] array, int size, string arrayName)
{
    for (int interval = size / 2; interval > 0; interval /= 2)
    {
        for (int i = interval; i < size; i++)
        {
            var current = array[i];
            var k = i;

            while (k >= interval && array[k - interval] > current)
            {
                array[k] = array[k - interval];
                k -= interval;
            }

            array[k] = current;
        }
    }

    return array;
}

// entered array
var array = new int[] { 73, 57, 49, 99, 133, 20, 1 };
//var expected = new int[] { 1, 20, 49, 57, 73, 99, 133 };
var SI = new int[] { 8, 3, -2, 9 - 10, -10, -7, 26, 123, 78 };
var FI = new int[] { -8, -3, 2, -9, 10, 10, 7, -26, -123, -78 };
var SI1 = new int[] { 363, 356, -180, -111, -471, 450 };
var FI1 = new int[] { -180, -111, 356, -471, 450, 363 };

// unsorted MRs
Console.Write("SI unsorted: \n");
foreach(int i in SI)
{
    Console.Write(i + ", ");
}

Console.Write("\n FI unsorted: \n");
foreach (int i in FI)
{
    Console.Write(i + ", ");
}

Console.Write("\n SI-1 unsorted: \n");
foreach (int i in SI1)
{
    Console.Write(i + ", ");
}

Console.Write("\n FI-1 unsorted: \n");
foreach (int i in FI1)
{
    Console.Write(i + ", ");
}

// sorted array
int[] resultSI = ShellSort(SI, SI.Length, "SI Sorted");
int[] resultsFI = ShellSort(FI, FI.Length, "FI Sorted");
int[] resultsSI1 = ShellSort(SI1, SI1.Length, "SI-1 Sorted");
int[] resultsFI1 = ShellSort(FI1, FI1.Length, "FI-1 Sorted");

Console.Write("\n Result for SI: \n");
foreach(int i in resultSI)
{
    Console.Write(i + ", ");
}

Console.Write("\n Result for FI: \n");
foreach (int i in resultsFI)
{
    Console.Write(i + ", ");
}

Console.Write("\n Result for SI-1: \n");
foreach(int i in resultsSI1)
{
    Console.Write(i + ", ");
}

Console.Write("\n Result for FI-1: \n");
foreach (int i in resultsFI1)
{
    Console.Write(i + ", ");
}


