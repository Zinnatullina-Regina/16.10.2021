using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DatesFromCentre
{
    abstract class Structura
    {
        private decimal cost, expenses;
        private string services;


        private string name,  what;

        string[] servis = new string[4];
        string[] cena = new string[4];
        string[] krit = new string[4];
        string[] pasxod = new string[4];


        public Structura(string name, string what)
        {
            this.name = name;
            this.what = what;
        }

        public string Name
        {
            get { return name; }
            
        }
        public string What
        {
            get { return what; }

        }









        public void Filling()
        {


            using (StreamReader reader = new StreamReader(what))
            {
                int count0 = 0, count1 = 0, count2 = 0, count3 = 0;

                while (reader.ReadLine() != null)
                {

                    string[] stroki = reader.ReadLine().ToLower().Split(' ').ToArray();
                    for (int i = 0; i < stroki.Length; i++)
                    {

                        switch (i)
                        {
                            case 0:
                                servis[count0] = stroki[i] ;
                                count0++;
                                break;
                            case 1:
                                cena[count1] = stroki[i];
                                count1++;
                                break;
                            case 2:
                                krit[count2] = stroki[i];
                                count2++;
                                break;
                            case 3:
                                pasxod[count3] = stroki[i];
                                count3++;
                                break;

                        }

                    }

                }

            }
        }

    }
       








        class Cinema : Structura
        {
            public Cinema(string text1) : base("Imax", @"Кино.txt") { }
            

        }


        class Cafe : Structura
        {
            public Cafe(string text2) : base("Makdon", @"Кафе.txt") { }





        }




    class Program
    {
        static void Main(string[] args)
        {


           



            Console.WriteLine("Задание 1");
            Console.WriteLine("\nРазвлекательный центр. Прошрамма для анализа ");
            Console.WriteLine("\nИнформацию по какому отделу вы бы хотели увидеть? ");
            Console.WriteLine("\n Чтобы перейти к информации связанной с кафе, нажмите 1\n Чтобы перейти к информации связанной с кино, нажмите 2");

            int n;
            while ((!int.TryParse(Console.ReadLine(), out n) || n > 3 || n < 0))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }
            if (n == 1)
            {
                Cafe procesCaf = new Cafe("");
                procesCaf.Filling();

            }
            else
            {
                Cinema procesCin = new Cinema("");

                procesCin.Filling();


            }







        }
    }

    
}
