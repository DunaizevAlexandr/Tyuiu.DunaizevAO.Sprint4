using Tyuiu.DunaizevAO.Sprint4.Task0.V8.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

int[] array = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };
Console.WriteLine("Массив:" + array);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.GetMultEvenArrEl(array));

Console.ReadLine();