int []array = {4, 35, 3, 5, 15, 5};
int n = array.Length;
int find = 35;
int index = 0;
while (index<n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

