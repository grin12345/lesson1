int Max (int arg1, int arg2, int arg3)
{
    int resoult = arg1;
    if(arg2>resoult) resoult = arg2;
    if(arg3>resoult) resoult = arg3;
    return resoult;
}

int [] array = {12, 77, 99, 32, 10, 56, 4, 74, 1};

int max = Max(
 Max(array[0], array[1], array[2]),
 Max(array[0], array[1], array[2]), 
 Max(array[0], array[1], array[2]));
Console.WriteLine(max);