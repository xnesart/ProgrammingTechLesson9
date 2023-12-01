namespace ProgrammingTechLesson9;

public class RandomArray
{
    private int[] array;
    public int Length { get; private set; }

    private bool LastOperationSuccess;


    public RandomArray(int size)
    {
        if (size < 10 || size > 100)
        {
            Console.WriteLine("Неверный размер массива!");
            return;
        }
        array = new int[size];
        Length = array.Length;
        LastOperationSuccess = true;
    }

    public int this[int index]
    {
        get
        {
            LastOperationSuccess = true;
            return array[index];
        }
        set
        {
            if (value % 2 == 0 && index >= 0 && index < array.Length)
            {
                array[index] = value;
                LastOperationSuccess = true;
            }
            else
            {
                Console.WriteLine("Не удалось добавить элемент");
                LastOperationSuccess = false;
            }
        }
    }

    public double this[double index]
    {
        get
        {
            int truncatedIndex = (int)index;
            return this[truncatedIndex];
        }
        set
        {
            int truncatedIndex = (int)index;
            this[truncatedIndex] = (int)value;

        }
    }

    public void FillArray(int neededSizeOfArray)
    {
        if (neededSizeOfArray >= 10 && neededSizeOfArray <= 100)
        {
            Random random = new Random();

            for (int i = 0; i < neededSizeOfArray; i++)
            {
                int power = random.Next(1, 7);
                array[i] = (int)Math.Pow(2, power);
            }
        }
    }

    public double AmountOfDegrees()
    {
        double product = 1;
        double sum = 0;

        foreach (var value in array)
        {
            product *= value;
            sum += value;
        }

        LastOperationSuccess = true;
        return product / sum;
    }

    public bool GetErrors()
    {
        return LastOperationSuccess;
    }

    public void PrintArray()
    {
        for (int i = 0; i < this.array.Length; i++)
        {
            Console.Write(this.array[i] + " ");
        }
    }
}