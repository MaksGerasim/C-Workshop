// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


// int Metod ()
// {
// Console.WriteLine("введите значение");
// string? stopstatus = Console.ReadLine();
// int number = 0;
// int count = 0;
// if (stopstatus != "stop")
// {
// number = Convert.ToInt32(stopstatus);
// // Console.WriteLine(number);
// Metod();
// count++;
// }
// return number;
// }


void CountNumber ()
{
string? stopstatus = "";
int count = 0;
 while (stopstatus != "stop")
 {
    Console.WriteLine("введите значение");
    stopstatus = Console.ReadLine();
    bool res = int.TryParse(stopstatus, out int result);
    if (res == true)
    {
        if (result > 0)
        count++;
    }
    if (res == false && stopstatus == "stop")
    {

    }
    else if (res == false)
    {
        Console.WriteLine("введенная команда неверна");
    }
 }
Console.WriteLine($"количество введенных значений > 0 = {count}");
}

CountNumber ();








































