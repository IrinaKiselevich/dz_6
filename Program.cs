// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.Write ("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
for (int i =0;i<array.Length;i++)
{
    array[i]=new Random().Next(1,100); 
    Console.Write(array[i] + " ");
}
Console.WriteLine();
int result = 0;
for (int i =0;i<array.Length;i++)
{
    if (i %2 !=0)
{
    result += array[i];
}
Console.WriteLine($"Сумма элементов на нечетных позициях = {result}");
}
