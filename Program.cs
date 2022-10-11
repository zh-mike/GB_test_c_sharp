// Конторльная кабота по первой четверти
void CheckArrey(string[] arrey, int num)
{
    for (int i = 0; i < arrey.Length; i++)
    {
        if(arrey[i].Length <= num)
            Console.Write($"{arrey[i]} ");
    }

}

string [] arrey = {"hello", "2", "world", ":-)"};
int num = 3; // Максимальная длинна выводимой строки
Console.WriteLine("[" + string.Join(", ", arrey) + "]");
CheckArrey(arrey, num);


