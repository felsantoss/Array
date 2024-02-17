// Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.

static int[] SortedSquare(int[] nums)
{
    int[] sortedArray = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        sortedArray[i] = nums[i] * nums[i];
    }
    
    Array.Sort(sortedArray);

    return sortedArray;
}

int[] arr = {-7,-3,2,3,11};

Console.WriteLine(String.Join(",", SortedSquare(arr)));