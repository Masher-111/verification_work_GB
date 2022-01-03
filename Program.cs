int [] FillArray (int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i ++)
    {
        array[i] = new Random().Next(-10, 10); 
    }
    return array;
}

void  PrintArray (int [] array)
{
    int length = array.Length;
    for (int position = 0; position < length; position++)
    {
        Console.Write (array[position] + " ");
    }
}
int [] arrayOfNumbers = new int [6];
FillArray(arrayOfNumbers);
PrintArray(arrayOfNumbers);
Console.WriteLine();

void OutputEven (int [] array)
{
    int size = array.Length;
    for (int index = 0; index < size; index ++)
    {
        if (array[index] % 2 == 0)
        {
            Console.Write(array[index] + " ");
        }
    }
}
OutputEven(arrayOfNumbers);