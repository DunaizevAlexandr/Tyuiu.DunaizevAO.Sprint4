using Tyuiu.DunaizevAO.Sprint4.Task1.V14.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

int[] array = new int[13];
for (int i = 0; i < 13; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(array));

Console.ReadLine();