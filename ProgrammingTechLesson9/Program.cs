using ProgrammingTechLesson9;

// Задание 1
Console.WriteLine("Введите количество элементов массива(от 10 до 100)");
int size = int.Parse(Console.ReadLine());

RandomArray randomArray = new RandomArray(size);
randomArray.FillArray(size);

Console.WriteLine("Массив до попыток записать в него значения по индексу");
randomArray.PrintArray();
Console.WriteLine();

double res = randomArray.AmountOfDegrees();
Console.WriteLine("Массив после попыток записать в него значения по индексу");
randomArray[3] = 4;
randomArray[2.5] = 2;
//здесь будет ошибка записи, тк это не степень двойки
randomArray[4] = 3;

randomArray.PrintArray();
Console.WriteLine();
Console.WriteLine($"Отношение произведения степеней двойки на сумму основания степеней 2 = {res}");
Console.WriteLine($"Ошибка последней операции = {randomArray.GetErrors()}");


//Задание 2
NaturalNumber naturalNumber = new NaturalNumber(2,5);

Console.WriteLine($"Основание = {naturalNumber.Basis}");
Console.WriteLine($"Степень = {naturalNumber.Power}");
Console.WriteLine($"Результат = {naturalNumber.CalculatePower()}");