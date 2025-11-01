using Tyuiu.DunaizevAO.Sprint4.Task4.V12.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

int[,] array = { { 3,6,6,8,8 }, { 2,7,2,4,6 }, { 3,6,2,6,4 }, { 8,6,2,7,3 }, { 5, 2, 4, 2, 3 } };
Console.WriteLine(array);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(array));

Console.ReadLine();