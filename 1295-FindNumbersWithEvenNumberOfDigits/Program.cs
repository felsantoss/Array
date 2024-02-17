// Given an array nums of integers, return how many of them contain an even number of digits.

static int FindNumbers(int[] nums) {
    int count = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        int digits = 0;

        while (nums[i] != 0)
        {
            nums[i] = nums[i] / 10;
            digits++;
        }

        if (digits % 2 == 0)
        {
            count++;
        }
    }

    return count;
}

int[] arr = {12, 345, 2, 6, 7896};

int newArr = FindNumbers(arr);

Console.WriteLine(newArr);