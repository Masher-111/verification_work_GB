int [] FillArray (int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i ++)
    {
        array[i] = new Random().Next(-100, 100); 
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
int [] arrayOfNumbers = new int [10];
FillArray(arrayOfNumbers);
PrintArray(arrayOfNumbers);
Console.WriteLine();
PrintArray(ArrayOfEven(arrayOfNumbers));