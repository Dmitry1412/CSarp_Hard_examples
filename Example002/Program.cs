﻿/*
Задача 2 НЕОБЯЗАТЕЛЬНАЯ.
Напишите программу для проверки истинности утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z (Теорема Де Моргана).
Но теперь количество предикатов не три, а генерируется случайным образом от 5 до 25,
сами значения предикатов случайные, проверяем это утверждение 100 раз, выводим на экран,
сколько времени отработала программа. В конце вывести результат проверки истинности этого утверждения.
*/
for (int i = 0; i < 100; i++)
{
int num1 = new Random().Next(0,26);
int num2 = new Random().Next(0,26);
int num3 = new Random().Next(0,26);
System.Console.WriteLine($"{i+1}) {num1} {num2} {num3}");
System.Console.WriteLine((~(num1|num2|num3)) == ((~num1)&(~num2)&(~num3)));
}