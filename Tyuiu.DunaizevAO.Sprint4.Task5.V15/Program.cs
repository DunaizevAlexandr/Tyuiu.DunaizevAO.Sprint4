using Tyuiu.DunaizevAO.Sprint4.Task5.V15.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

int[,] array = new int[5, 5];
for (int i = 0; i < 5; i++)
{
	for (int j = 0; j < 5; j++)
	{
		array[i, j] = int.Parse(Console.ReadLine());	
	}
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(array));

Console.ReadLine();