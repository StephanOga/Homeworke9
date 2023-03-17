// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
using static Library3Darrays;

int myRows = GetValueFromUser("Создаю массив. Введите, пожалуйста, количество строк: ");
int myColumns = GetValueFromUser("Теперь введите, пожалуйста, количество столбцов: ");
int myDepth = GetValueFromUser("Укажите длину массива в глубину: ");
int[,,] myArray = Create3Darray(myRows, myColumns, myDepth);
Fill3DArrayWithRandomNumbers(myArray);
Console.WriteLine("Готов массив с индексами элементов!");
string s = Print3D(myArray);
Console.WriteLine(s);

