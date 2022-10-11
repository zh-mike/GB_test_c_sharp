// Контрольная работа по первой четверти

// Считаем сколько элементов подходит под условие, что бы создать новый массив нужной длинны
int CountArrey(string[] arrey, int num)
{
    int count = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        if(arrey[i].Length <= num) count++; 
    }
    return count;
}

// Зпролняем новый массив и выводим ответ
void CheckArrey(string[] arrey, string[] newArrey, int num)
{
    int j = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        if(arrey[i].Length <= num)
        {
            newArrey[j] = arrey[i];
            j++;
        }      
    }
    Console.WriteLine("[" + string.Join(", ", newArrey) + "]");
}

string [] arrey = {"hello", "2", "world", ":-)"};
int num = 3; // Максимальная длинна выводимой строки
Console.WriteLine("[" + string.Join(", ", arrey) + "]");
string[] newArrey = new string[CountArrey(arrey, num)];
CheckArrey(arrey, newArrey, num);



