int arrSize = 0;

//закидываем в try, так как в случае неуспешной конвертации, процесс не завершается
try
{
    arrSize = Convert.ToInt32((Console.ReadLine()));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//просто рандом для генерации
Random random = new Random();

// тот самый массив интов
int[] ints = new int[arrSize];

// заполнение и вывод
for (int i = 0; i < arrSize; i++)
{
    ints[i] = random.Next(0, arrSize);

    Console.WriteLine(ints[i]);
}

// вызов
Console.WriteLine($"Median is {Median(ints)}");


float Median(int[] ints)
{
    // сортируем
    var sortedInts = ints;
    Array.Sort(sortedInts);

    // выводим элемент с нужным индексом или среднее между двумя(для нечетного кол-ва элементов)
    if (sortedInts.Length % 2 == 0)
        return (sortedInts[sortedInts.Length / 2] + sortedInts[sortedInts.Length / 2 - 1]) / 2.0f;
    else return (sortedInts[sortedInts.Length / 2]);
}