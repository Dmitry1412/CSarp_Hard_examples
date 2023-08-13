/*
задача 1 необязательная
на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.
1,45 -> 1,5
1 -> нет
567,123 -> 57,123

Решение через операции c массивами
Блок с разделением через "." добавлять не стал
*/

System.Console.WriteLine("Введите число "); 
string userData = System.Console.ReadLine(); //вводим число тип данных string
string zapyataya = ","; 
int indexOfZap = userData.IndexOf(zapyataya); // ищем порядковый индекс "," в переменной userData
char[] stroka = new char [userData.Length]; // определяем символьный массив длиной userData (исходный)

if (indexOfZap == 1)// определяем размер числа, если условие true число <10
{
    for (int j = 0; j < stroka.Length; j++)
    {
        if (j == 2)
            continue;
        stroka[j] = userData[j];//заполняем массив данными userData
    }
}
else// алгоритм действий для числа большего, чем 10
{
    for (int j = 0; j < stroka.Length; j++)
    {
        if (j == 1)
            continue;
        stroka[j] = userData[j];
    }
}
System.Console.WriteLine(stroka);