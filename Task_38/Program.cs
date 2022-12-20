Console.WriteLine("Введите размер массива: ");
int SIZE = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите левую границу массива: ");
int LEFT_RANGE = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите павую границу массива: ");
int RIGHT_RANGE = Convert.ToInt32(Console.ReadLine());

int[] NewArr (int SIZE, int LEFT_RANGE, int RIGHT_RANGE)
{
    int[] arr = new int[SIZE];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(LEFT_RANGE, RIGHT_RANGE + 1);
    
    }
    return arr;
}

void ShowArr (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i]);
    }
}

int GetNumber (int[] arr)
{
int result = 0;
int min = 0;
int max = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[min] > arr[i]){
        min = i;
    }
    else if (arr[max] < arr[i]){
        max = i;
    }
}
System.Console.WriteLine("min = " + arr[min]);
System.Console.WriteLine("max = " + arr[max]);
result = arr[max] - arr[min];
return result;
}

int[] Arr = NewArr (SIZE, LEFT_RANGE, RIGHT_RANGE);
//ShowArr(Arr);
int Number =  GetNumber(Arr);
System.Console.Write("Ответ: ");
System.Console.Write (Number);