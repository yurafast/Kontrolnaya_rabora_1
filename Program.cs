
void Print(string[] array)
{
    int size= array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
}


int size = 5;
string[] arr = new string[size];
string[] res = new string[size];

    for (int i = 0; i < size; i++) // Заполняем массив arr элементами
    {
        Console.WriteLine($"Введите {i}-й элемент");
        arr[i] = Console.ReadLine();
    }

    int check; // переменная для проверки длинны элемента

    for (int i = 0; i < size; i++) // заполняем массив res по условию задачи
    {
        check=(arr[i].Length);
        if (check<4)
        {
            res[i]=arr[i];
        }   
    }

Print(res);

