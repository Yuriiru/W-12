﻿using System;

    class EventDelegateClass
    {
        private string name; // создание переменной

        public delegate void EventDelegate(string txt); // создание делегата + (для чего txt?)

        public EventDelegateClass(string name) // конструктор класса
        {
            this.name = name;
        }

        public event EventDelegate Event; // определение события
        public void RaiseMyEvent() // с помощью метода + (вызов события), да? - генерация обработчика -?
        {
            if (Event != null)
            {
                Event(name);
            }
        }
    }

class KakoyToClass
{
        private string text; //создание переменной
        public KakoyToClass(string metodtext) // конструктор класса
        {
            text = metodtext;
        }
        public void show(string objname) // метод консоль выводит название обекта, 
        {
            Console.WriteLine("Объект, сгенерировавший событие: " + objname);
            Console.WriteLine("Сообщение: " + text); // сообщение-строка-параметр
        }
}

class Program
{
        static void Main()
        {
            EventDelegateClass kakoyToOdject1 = new EventDelegateClass("KakoyToOdject1"); // создаем объекты первого класса
            EventDelegateClass kakoyToOdject2 = new EventDelegateClass("KakoyToOdject2");

            KakoyToClass KakoyToClassObject = new KakoyToClass("KakoyToClassObject"); // создание объекта второго класса

            kakoyToOdject1.Event += KakoyToClassObject.show; // методо добавлется в делегат через собтие
            kakoyToOdject2.Event += KakoyToClassObject.show;

            kakoyToOdject1.RaiseMyEvent();
            Console.WriteLine();

            kakoyToOdject2.RaiseMyEvent();
            Console.WriteLine();
        }
}

// где обработчик события


