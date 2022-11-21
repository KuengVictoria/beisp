// Семинар6 Задача1 Пользователь вводит с клавиатуры М чисел.
// Посчитать сколько чисел больше нуля ввёл пользователь.

/*int [] CreateRandomArray (int size, int min, int max)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
    array[i] = new Random().Next(-10,10);
    return array;
}
void ShowArray(int []array)
{
    for(int i = 0; i < array.Length; i++)
    Console.WriteLine(array[i] + " ");
    
}

int CountNumbers (int []array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        count++;
        i++;
    }
    return count;
}

Console.WriteLine("Input the size of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the max: ");
int max = Convert.ToInt32(Console.ReadLine());

int []myArray = CreateRandomArray(m, min, max);
ShowArray(myArray);
int countNumbers = CountNumbers(myArray);
Console.WriteLine($"Positive numbers is" +  countNumbers);
*/

//Задача2 Написать программу, которая найдет точку пересечения двух прямых,
// заданых уравнениями у=к1*х+в1, у=к2*х+в2, значения к1, к2,в1, в2 
// задаются пользователем

/*int LineIntersection (int k1, int k2, int b1, int b2, int x, int y)
{
    if(k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Lines match"); //Прямые совпадают
    }
    else if(k1 == k2  &&  b1 /= b2  )
    // не знаю как написать знак неравенства /= ?
    {
        Console.WriteLine("Lines are parallel");
    }
    else 
    {
        x == (y - b1)/ k1;
        y ==k2 * ((y - b1)/k1) + b2;
        return x;
        return y;
    }
}
*/
