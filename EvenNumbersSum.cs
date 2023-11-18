//This method encapsulates the logic for summing even numbers
static int EvenNumbersSum(int[] numbers)
{
    int sum = 0;

    foreach (int num in numbers)
    {
        if (num % 2 == 0)
        {
            sum += num;
        }
    }

    return sum;
}

//We iterate through each element in the array, 
//check if it is even, and add it to the sum. 
int[] numbers = { 2, 5, 8, 10, 15, 16, 20 };
int sum = EvenNumbersSum(numbers);
//The method then returns the calculated sum.
Console.WriteLine("Sum of even numbers: " + sum);