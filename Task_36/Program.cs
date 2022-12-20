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
    int count = 0;
    for (int i = 1; i < arr.Length; i = i+2)
        {
            count = count + arr[i];
        }
    return count; 
}

int[] Arr = NewArr (SIZE, LEFT_RANGE, RIGHT_RANGE);
//ShowArr(Arr);
int Number =  GetNumber(Arr);
System.Console.WriteLine("Ответ: ");
System.Console.Write (Number);