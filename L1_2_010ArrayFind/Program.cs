Console.Clear();

int[] array = { 19, 28, 37,91, 64, 505, 46, 37, 82, 91 };

int n = array.Length;
int find = 91;

int index = 0;

while (index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}