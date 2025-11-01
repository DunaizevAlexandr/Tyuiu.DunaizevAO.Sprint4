using Tyuiu.DunaizevAO.Sprint4.Task2.V11.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

int[] array = new int[15];

for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(array));

Console.ReadLine();