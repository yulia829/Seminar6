Console.Write("Введите количество элементов массива: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
FillArray(M);

void FillArray(int M)
{
for (int i = 0; i < M; i++)
{
Console.WriteLine($"Введите {i+1} элемент массива ");
array[i] = Convert.ToInt32(Console.ReadLine());
}

}

int count(int[] array)
{
int i=0;
int sum = 0;
while (i < array.Length)
{
if(array[i]>0)
sum = sum + 1;
i = i + 1;
}
return sum;
}
Console.Write($"Чисел больше нуля: {count(array)}");
