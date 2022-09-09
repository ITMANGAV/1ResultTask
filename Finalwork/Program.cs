Console.WriteLine("Введите элементы массива через запятую:");
string data = Console.ReadLine() ?? "";
string[] array = data.Split(new string[] { "," }, StringSplitOptions.None);
int FindCountArray(string[] arr)
{
    int k = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            k++;
        }
    }
    return k;
}
string[] FillSmallWords(string[] arr, int j)
{
    string[] smallWords = new string[j--];
    int k = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            smallWords[k] = arr[i];
            k++;
        }
    }
    return smallWords;
}

void PrintArray(string[] arr)
{
    int d = arr.Length - 1;

    for (int i = 0; i < d; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[d]);
}
int count = FindCountArray(array);
if (count > 0)
{
    string[] words = FillSmallWords(array, count);
    PrintArray(words);
}
