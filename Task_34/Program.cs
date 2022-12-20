Console.WriteLine("Введите размер массива: ");
int SIZE = Convert.ToInt32(Console.ReadLine());
int LEFT_RANGE = 100;
int RIGHT_RANGE = 1000;

int[] NewArr (int SIZE, int LEFT_RANGE, int RIGHT_RANGE)
{
    int[] arr = new int[SIZE];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(LEFT_RANGE, RIGHT_RANGE);
    
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
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0){
            count = count +1;
        }
    return count; 
}

int[] Arr = NewArr(SIZE, LEFT_RANGE, RIGHT_RANGE);
//ShowArr(Arr);
int Number =  GetNumber(Arr);
System.Console.WriteLine("Ответ: ");
System.Console.Write(Number);