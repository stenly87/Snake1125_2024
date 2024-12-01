﻿namespace Snake1125
{
    internal class Program
    {
        /// <summary>
        /// Стартовый метод приложения. Игра стартует с помощью инициализации класса SnakeGame и запуска его метода Start
        /// </summary>
        /// <param name="args">Аргументы, переданные приложению при запуске</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Нажми Enter для запуска");
            Console.ReadLine();
            SnakeGame game = new SnakeGame();
            game.Start();
        }
    }
}


/*
Задания:
1) - изучить работу змейки, в целом она работает, но нужно допилить напильником. Задания ниже предполагают, что вы будете редактировать и добавлять новые методы у разных классов (а где-то и новые классы лучше сделать). Подумайте, в чьем классе будет зона ответственности за добавляемый код.
2) - сейчас змейка свободно пересекает себя, уходит за рамки консоли, может двигаться в противоположном направлении. Попробуйте это исправить:
2.1) - нужно запретить разворачивать змейку в противоположном направлении, если ее длина > 1. Разворот на 180 = конец игры
2.2) - нужно добавить проверку на пересечение головы змеи с одной из частей ее тела, при пересечении - конец игры
2.3) - нужно ограничить игровое поле. Для этого нужно определить координаты сторон и добавить проверку на выход головы за пределы поля. Выберите для себя поведение змеи:
    а) при пересечении границы игрового поля змея появляется с противоположной стороны
    б) при пересечении границы игрового поля - конец игры
    было бы неплохо визуально оформить границы - нарисуйте стены для поля (стены надо нарисовать один раз при старте змеи, постоянно перерисовывать их не надо
2.4) - что за игра без подсчета очков? добавьте подсчет очков при поедании яблока, штраф при попадании на ловушку. Вывод очков можно сделать через рисование текста справа или снизу от игрового поля. Можно вывести очки в заголовок консоли.
2.5) - что за подсчет очков без соревнования? добавьте запрос имени перед стартом, запоминайте очки, набранные игроком. Сделайте вывод таблицы рекордов.
3) - создайте комментарии к методам и к классам - например, над методом ставим три слеша /// Появляется конструкция, как над методом Main. Заполняем блоки по примеру. Теперь, при наведении мышкой на метод, мы увидим описание работы и аргументов

Подсказки:
2) - удобно проверку на направление змейки сделать в классе SnakeGame в методе SendNewSnakeDirection. Там доступна змейка, доступно старое направление и новое направление. В змейке можно создать свойство, возвращающее ее длину
2.3) - удобно в GameField добавить свойства с указанием сторон - Отступ по X слева и до правого края, отступ по Y сверху и до нижнего края. В методе CheckIntersect можно проверить, что змейка после движения пересекает край. Если хотим, чтобы змейка появлялась с противоположной стороны - можно добавить в нее метод назначения новых координат, например SetNewHeadCoordinate(x,y). Рисовать рамки игрового поля удобно в классе GameFieldDraw
2.4) - создайте новый класс Scores, новый класс ScoresDraw. ScoresDraw реализовать по примеру AppleDraw, зарегистрировать в классе Draw. Объект Scores можно создать в классе SnakeGame. Узнать о изменении длины змеи можно разными путями. Один из них - создать в змейке событие, например public event EventHandler OnLengthChanged. Событие можно вызывать в методах Increase и Decrease. Тогда в классе SnakeGame при создании змейки можно создать подписку на это событие и внутри этой подписки вызывать через draw рисование объекта Scores (передаем в него длину змейки перед этим, дает или отнимаем очки)
2.5) - Если вы создали класс Scores, в нем можно создать и хранение рекордов. Вывод таблицы рекордов можно вызвать из класса Program с помощью отдельного экземпляра класса Scores.
*/
/*
Еще задания:
0) ускорение змейки при подборе яблока
1) пауза/снятие с паузы на пробел
2) рестарт игры на букву R
3) покраска головы змеи одним цветом, а остального тела - другим
4) инвертирование управления после попадания на ловушку - в течение 5 секунд нажатие на кнопки должно посылать змейку в противоположном направлении
*) добавьте еще одну змейку в игру, которая управляется самостоятельно - сравнивает координаты яблока со своими координатами и принимает решение о своем направлении каждый ход.

*/

