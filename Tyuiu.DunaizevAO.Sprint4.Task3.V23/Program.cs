using Tyuiu.DunaizevAO.Sprint4.Task3.V23.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

int[,] array = { { 7, 5, 5, 6, 7 }, { 8, 7, 8, 4, 3 }, { 5, 6, 7, 8, 3 }, { 4, 2, 3, 6, 4 }, { 5, 2, 4, 2, 3 } };
Console.WriteLine(array);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(array));

Console.ReadLine();