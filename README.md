# MinimumSumNumberArray
Напишите функцию, на вход которой приходит массив чисел. Функция возвращает сумму двух минимальных элементов массива.
Например, если дан массив [4, 0, 3, 19, 492, -10, 1], то результатом будет -10, потому что два минимальных числа -10 и 0, а их сумма -10.

В проекте представленно два решения задачи:
1) Первый это - ImplementationWithLinq, изначально сортируется весь массив по возрастанию и суммируется необходимое количество элементов
2) Второй и основной это - OwnImplementationMathOperation реализован с помощью самописного алгоритма, который берет необходимое количество значений, записывает во вспомогательный массив
далее сортирует по возрастанию. Как только при переборе основного массива встречается значение меньше, происходит замена значений и сортировка.

Перывый вариант был реализован, чтобы показать разницу в скорости при тестах.
При одинаковых тестах
Второй вариант показывает 2 мс, а первый в свою очередь при полной сортировки массива 1,7 с

![alt tag](https://i.imgur.com/NeG3dwS.png "Описание будет тут")​
