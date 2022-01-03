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

int [] ArrayOfEven (int [] array)
{
    int countEven = 0;
    int size = array.Length;
    for (int index = 0; index < size; index++)
    {
        if (array[index] % 2 ==0)
        {
            countEven++;
        }
    }
    int [] arrayEven = new int [countEven];
    int j = 0;
    for ( int i = 0; i < size; i++)
    {
         if (array[i] % 2 == 0)
        {
            arrayEven[j] = array[i];
            j ++;
         }
 
    }
    return arrayEven;
}
