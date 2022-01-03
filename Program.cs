void FillArray (int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i ++)
    {
        array[i] = new Random().Next(-10, 10); 
    }
}
