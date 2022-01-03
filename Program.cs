void FillArray (int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i ++)
    {
        array[i] = new Random().Next(-10, 10); 
    }
}

void PrintArray (int [] array)
{
    int length = array.Length;
    for (int position = 0; position < length; position++)
    {
        Console.Write (array[position] + " ");
    }
}
