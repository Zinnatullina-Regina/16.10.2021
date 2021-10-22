using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class BuildingAndOterTauntsOfFate
    {


        private Guid building;
        private int heihgt, flors, flats, enterances;


        public void Filling()
        {

            Console.WriteLine("Какова высота здания?");
            while ((!int.TryParse(Console.ReadLine(), out heihgt) || heihgt < 0))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }

            Console.WriteLine("Введите кол-во этажей");
            while ((!int.TryParse(Console.ReadLine(), out flors) || flors < 0))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }
            Console.WriteLine("Введите количество подъездов");
            while ((!int.TryParse(Console.ReadLine(), out enterances) || enterances < 0))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }
            Console.WriteLine("Введите кол-во квартир");
            while ((!int.TryParse(Console.ReadLine(), out flats) || flats < 0 || flats % enterances != 0 || flats % flats != 0))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }





            building = Guid.NewGuid();


        }

        public void ShowInformation()
        {
            Console.WriteLine($"Номер = {building} Высота = {heihgt}  Кол-во этажей = {flors} Кол-во квартир = {flats}  Кол-во подъездов = {enterances}");


        }


        public double GetHightOfFlor()
        {
            return heihgt / flors;
        }
        public int GetFlatsInEntarance()
        {
            return flats / enterances;
        }

        public int GetFlatsInFlor()
        {
            return GetFlatsInEntarance() / flors;
        }
       

    }




    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Задание 1");

            BuildingAndOterTauntsOfFate proces = new BuildingAndOterTauntsOfFate();
            
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nКакую операцию хотите произвести? \n Чтобы заполнить данные нажмите 1 \n Чтобы вывести данные нажмите 2 \n Чтобы узнать высоту этажа нажмите 3 \n Чтобы узать сколько квартир в одном подъезде нажмите 4   \n Чтобы узать сколько квартир на одном этаже нажмите 5   \n Чтобы закрыть программу нажмите 6");  

                int vvod;

                while ((!int.TryParse(Console.ReadLine(), out vvod) || vvod > 6 || vvod < 0))
                {
                    Console.WriteLine("Ошибка ввода! Введите нужное число");
                }
                switch (vvod)
                {
                    case 1:
                        proces.Filling();
                        break;
                    case 2:
                        proces.ShowInformation();
                        break;
                    case 3:
                      Console.WriteLine(proces.GetHightOfFlor());
                        break;
                    case 4:
                       Console.WriteLine(proces.GetFlatsInEntarance());
                        break;
                    case 5:
                       Console.WriteLine(proces.GetFlatsInFlor());
                        break;
                    case 6:
                        flag = false;
                        break;
                   
                }
            }
        }
    }
}


