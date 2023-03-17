# Итоговая работа. Этап 1. Основной блок

## Методика решения задачи.

* Задача решена посредством поэлементного анализа количества символов в строковых переменных массива (в цикле), с одновременным заполнением результирующего массива искомых элементов (с количеством символов - меньше 3х).

* Исходный массив формируется из символов, вводимых с клавиатуры. При этом, разделителем вводимых строковых элементов, является символ пробела.

* Т.к. искомый массив инициализируется до момента его заполнения, первоначально,  количество элементов в нем принимается равным исходному массиву.
* По результатам заполнения искомого массива применяется метод Resize c сокращением количества элементов до их реального количества.


*Конечно, данный метод решения задачи не является оптимальным!, т.к. фактически резервирует при своем исполнении память для 2х исходных массивов. Наверное было бы правильнее создать 2й массив размерности на 1 элемент, а далее расширять его по мере нахождения соответствующих элементов в исходном массиве. Но, так-как задача является учебной и алгоритм работает, то ...*


Блок-схему алгоритма - прилагаю.
Решение задачи выполнено на языке программирования С#.