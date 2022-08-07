int[] array = {31, 4, 13, 19, 45, 59, 26, 77, 86, 19};

int n = array.Length; // Длина массива
int find = 19;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // Остановить работу программы
    }

    //index = index = 1;
    index++;
}