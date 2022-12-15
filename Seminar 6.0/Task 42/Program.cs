// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10




void ReversArray (int [] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array [i];
        array[i] = array[array.Length -i - 1];
        array[array.Length -i - 1] = temp;
    }

}



int [] Convert10num (int number)
{
int size = 0;
int countnuber = number;
while (countnuber > 0)
{
    countnuber = countnuber / 2;
    size++;
}

int ind = 0;
int i = 0;
int[] newmass = new int [size];
while (number > 0)
{
    ind = number-((number/2)*2);
    number = number / 2;
    newmass[i] = ind;
    i++;
}
return newmass;
}


Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int[] Num10code = Convert10num (number);
Console.WriteLine(string.Join(",", Num10code));
ReversArray (Num10code);
Console.WriteLine(string.Join(",", Num10code));