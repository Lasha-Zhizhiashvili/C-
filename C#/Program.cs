// 1 davaleba-----------------------------------------
Console.WriteLine("davaleba 1 -------------------------------------------");
Console.WriteLine();

List<int> arr = new List<int> { 3, 1, 4, 2, 5 };

void SortArray(List<int> arr = null)
{
    if (arr == null)
    {
        arr = new List<int>();
    }

    int temp;
    for (int i = 0; i < arr.Count; i++)
    {
        for (int j = i + 1; j < arr.Count; j++)
        {
            if (arr[i] > arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    foreach (int num in arr)
    {
        Console.WriteLine(num);
    }
}

SortArray(arr);




Console.WriteLine();
// 2 davaleba-------------------------------------------
Console.WriteLine("davaleba 2 -------------------------------------------");
Console.WriteLine();

List<int> arrayy = new List<int> { 1, 2, 2, 3, 3, 4, 5, 5 };
List<int> uniqueElementss = new List<int>();

void FindUniqueElements(List<int> array, List<int> uniqueElements)
{
    foreach (int element in array)
    {
        if (!uniqueElements.Contains(element))
        {
            uniqueElements.Add(element);
        }
    }

    foreach (int element in uniqueElements)
    {
        Console.WriteLine(element);
    }
}

FindUniqueElements(arrayy, uniqueElementss);


Console.WriteLine();
// 3 davaleba-------------------------------------------
Console.WriteLine("davaleba 3 -------------------------------------------");
Console.WriteLine();

List<int> nums = new List<int> { -1, 2, -3, 4, -5, 6, 7, 8, -9, 10 };
int result = 0;

int SumOfNum(List<int> nums,int result) 
{
    foreach(int num in nums)
    {
        if(num > 0)
        {
            result += num;
        }
    }
    return result;
}

Console.WriteLine(SumOfNum(nums,result));


Console.WriteLine();
// 4 davaleba--------------------------------------------
Console.WriteLine("davaleba 4 -------------------------------------------");
Console.WriteLine();

List<int> ShvidisJeradiNum = new List<int> { 14, 62, 7456, 123, 6 };

void checksForSeven(List<int> ShvidisJeradiNum)
{
    foreach(int num in ShvidisJeradiNum)
    {
        if (num % 7 == 0)
        {
            Console.WriteLine("aqvs shvidis jeradi");
            return;
        }
        else
        {
            Console.WriteLine("ar aqvs shvidis jeradi");
            return;
        }
    }
}

checksForSeven(ShvidisJeradiNum);

Console.WriteLine();
// 5 davaleba--------------------------------------------
Console.WriteLine("davaleba 5 -------------------------------------------");
Console.WriteLine();

List<string> names = new List<string> { "giorgi", "daviti", "nika" };

void ReverseNames(List<string> names)
{
    foreach (string username in names)
    {
        char[] charArray = username.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine(new string(charArray));
    }
}

ReverseNames(names);


Console.WriteLine();
// 6 davaleba--------------------------------------------
Console.WriteLine("davaleba 6 -------------------------------------------");
Console.WriteLine();

List<int> numbers = new List<int> { 2, 4, 6, 8, 10 };
int sum = 0;

void AddNums(List<int> numbers, int sum)
{
    foreach (int number in numbers)
    {
        sum += number;
    }

    Console.WriteLine("The sum of the numbers is: " + sum);
}

AddNums(numbers, sum);


Console.WriteLine();
// 7 davaleba--------------------------------------------
Console.WriteLine("davaleba 7 -------------------------------------------");
Console.WriteLine();

int maxnum = numbers[0];

void MaxNum(List<int> numbers, int maxnum)
{
    foreach (int number in numbers)
    {
        if (number > maxnum)
        {
            maxnum = number;
        }
    }

    Console.WriteLine("The maximum number is: " + maxnum);
}

MaxNum(numbers, maxnum);


Console.WriteLine();
// 8 davaleba--------------------------------------------
Console.WriteLine("davaleba 8 -------------------------------------------");
Console.WriteLine();

int minnum = numbers[0];

void MinNum(List<int> numbers, int minnum)
{
    foreach (int number in numbers)
    {
        if (number < minnum)
        {
            minnum = number;
        }
    }

    Console.WriteLine("The minimum number is: " + minnum);
}

MinNum(numbers, minnum);


Console.WriteLine();
// 9 davaleba--------------------------------------------
Console.WriteLine("davaleba 9 -------------------------------------------");
Console.WriteLine();

List<int> numbs = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
List<int> evens = new List<int>();
List<int> odds = new List<int>();

void FindEvenOdd(List<int> numbs, List<int> evens, List<int> odds)
{
    foreach (int number in numbs)
    {
        if (number % 2 == 0)
        {
            evens.Add(number);
        }
        else
        {
            odds.Add(number);
        }
    }

    Console.WriteLine("Even numbers:");
    foreach (int even in evens)
    {
        Console.WriteLine(even);
    }

    Console.WriteLine("Odd numbers:");
    foreach (int odd in odds)
    {
        Console.WriteLine(odd);
    }
}

FindEvenOdd(numbs, evens, odds); 
