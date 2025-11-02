using Tyuiu.DunaizevAO.Sprint4.Task6.V22.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

string[] array = { "Снег", "Дождь", "Туман", "Град", "Ветер", "Туча", "Засуха" };


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(array));

Console.ReadLine();