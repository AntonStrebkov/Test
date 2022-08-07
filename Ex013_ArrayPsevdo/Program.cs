void FillArray(int[] collection) 
//
{
    int length = collection.Length; // Задана длина массива
    int index = 0;                  // Счетчик индекса
    while(index < length)
    {
        collection[index] = new Random().Next(1, 40); // Элемент массива заполняется случацным числом
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
            
        }
        index++;
    }
    return position;
}

int[] array = new int [30]; // В массиве 10 элементов

FillArray(array);  // Создает массив
array[4] = 19;
array[10] = 19;
PrintArray(array); // Печатает массив
Console.WriteLine();
int pos = IndexOf(array, 444);
//   ИЗ---МЕТОДА--МАССИВ-ЧИСЛО
Console.WriteLine(pos);
