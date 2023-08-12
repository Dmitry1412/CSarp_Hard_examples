/*
задача 1 необязательная
на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.
1,45 -> 1,5
1 -> нет
567,123 -> 57,123

Решение через операции со строкой
*/

System.Console.WriteLine("Введите число ");
string userData = System.Console.ReadLine();
string zapyataya = ",";
string tochka = ".";
int indexOfZap = userData.IndexOf(zapyataya); /* присваивает целочисленной indexOfZap значение индекса переменной zapyataya
                                                иными словами ищем в строке запятую "," и запоминаем ее индекс */
int indexOfToch = userData.IndexOf(tochka);

if (indexOfZap == 1 | indexOfToch == 1) /* определям размер числа, т.е. 0,11111 или 12131,0054, т.е., у числа менее 10, ","
                                        всегда будет иметь значение 1 */
{
    if (indexOfZap > 0) // если indexOfZap > 0, то перед нами число менее 10
    {
        string[] strokiZap = userData.Split(new char [] {','}); /* разбиваем строку userData по символу ',', затем присваиваем массиву strokiZap
                                                                значение двух получившихся массивов */
        System.Console.WriteLine(strokiZap[0] + "," + strokiZap[1].Substring(1));
    }
    else
    {
        string[] strokiTochka = userData.Split(new char [] {'.'});
        System.Console.WriteLine(strokiTochka[0] + "." + strokiTochka[1].Substring(1));
    }
} 
else /* в противном случае, у нас число более 10    
        разбиваю строку на 2 части: firstPart - часть строки userData с индекса 0 длиной 1 элемент
                                    secondPart - часть строки userData с индекса 2 длиной до конца строки */
{
    string firstPart = userData.Substring(0,1);
    string secondPart = userData.Substring(2);
    System.Console.WriteLine(firstPart + secondPart);
}
