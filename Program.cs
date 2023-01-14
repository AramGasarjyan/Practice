int n;


//Declaration of array
Console.Write("Enter the n: ");
int.TryParse(Console.ReadLine(), out n);
int[] array = new int[n];

FillArray(array);
PrintArray(array);
//int[] array = { 5, 22, 10, 97, 22 }; FOR TEST


//հաշվել այն տարրերի արտադրյալը, որոնք 5-ի բաժանելիս կմնա 2 մնացորդ

double product = 1;
int count = 0;

for (int i = 0; i < n; i++)
{
    if ((array[i] - 2) % 5 == 0 && array[i] >= 5)
    {
        Console.WriteLine($"{array[i]} divided by 5 remains 2 ");
        product *= array[i];
        count++;
    }
}
if (count == 0)
    Console.WriteLine("When divided by 5 there weren't remainder of 2");
else
    Console.WriteLine("The product is: " + product);
count = 0;

//հաշվել այն տարրերի քառակուսիների գումարը, որոնց արժեքների և ինդեքսների գումարը առանց մնացորդի բաժանվում է 3-ի

double sum = 0;
for (int i = 0; i < n; i++)
{
    if ((array[i] + i) % 3 == 0)
    {
        Console.WriteLine($"{array[i]} + {i} divided by 3 remains 0 ");
        sum += Math.Sqrt(array[i]);
    }
}
Console.WriteLine("The sum is " + sum);



//գտնել և հեռացնել այն տարրերը որոնք փոքր են տրված k թվից և վերաձևավորել զանգվածը

int k;
Console.Write("Enter the K: ");
int.TryParse(Console.ReadLine(), out k);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < k)
    {
        for (int j = i; j < array.Length - 1; j++)
        {
            array[j] = array[j + 1];
        }
        Array.Resize(ref array, array.Length - 1);
        i = -1;
    }
}
PrintArray(array);



//Բոնուս : Տրված է n տարրեր պարունակող միաչափ զանգված, դասավորել ըստ աճման կարգի
Console.WriteLine("Bonus");
Console.Write("Enter the n: ");
int.TryParse(Console.ReadLine(), out n);
int[] arr = new int[n];

FillArray(arr);
PrintArray(arr);

int temp;
for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[i] < arr[j])
        {
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

        }
    }
}
PrintArray(arr);




void FillArray(int[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(0, 100);
    }
}

void PrintArray(int[] arr)
{
    Console.WriteLine(String.Join(",", arr));
    Console.WriteLine();
}

//Factorial
#region Factorial
int result = 1;
Console.Write("Enter the n: ");
int.TryParse(Console.ReadLine(), out n);
result = FactorialWithRecursion(n);
Console.WriteLine(result);
result = 1;

result = FactorialWithLoop(n);
Console.WriteLine(result);

int FactorialWithRecursion(int n)
{
    if (n == 1 || n == 0)
    {
        return 1;
    }
    return n * FactorialWithRecursion(n - 1);
}

int FactorialWithLoop(int n)
{
    for (int i = 1; i <= n; i++)
    {
        result = result * i;
    }
    return result;
}
#endregion



//Fibonacci
#region Fibonacci
Console.Write("Enter the n: ");
int.TryParse(Console.ReadLine(), out n);
Console.WriteLine(FibonacciWithRecursion(n));
Console.WriteLine(FibonacciWithLoop(n));

int FibonacciWithRecursion(int n)
{
    if (n <= 2)
    {
        return 1;
    }
    else
    {
        return FibonacciWithRecursion(n - 1) + FibonacciWithRecursion(n - 2);
    }
}

int FibonacciWithLoop(int n)
{
    int result = 0;
    int temp1 = 0, temp2 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = temp1 + temp2;
        temp1 = temp2;
        temp2 = result;
    }
    return result;
}
#endregion 
