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

Console.WriteLine("Entered Array:");
foreach(int i in array)
{
    Console.WriteLine(i);
}

// sorted array
int[] result = ShellSort(array, array.Length, "Shell Sorted Array");

Console.WriteLine("Result: ");
foreach(int i in result)
{
    Console.WriteLine(i);
}


 