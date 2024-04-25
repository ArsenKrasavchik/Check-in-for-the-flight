using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace urok5
{
    internal class FileName
    {
        static void Main(string[] args) 
        {
            /*
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.SetCursorPosition(5,10);
            Console.WriteLine("Я хакер");
            Console.WindowHeight = 10;
            Console.WindowWidth = 35;
            */

            int[] sectors = {12, 14, 65, 15, 11 };
            bool isOpen = true;
            while (isOpen)
            {
                    Console.SetCursorPosition(1, 18);

                for (int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($" в секторе {i + 1} свободных мест {sectors[i]} ");
                
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Регистрация рейса");
                Console.WriteLine("Выберите варианты, \n \n 1 - Забронировать место.\n \n 2 - закрыть приложение");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSector, userPlaceAmount;
                        Console.WriteLine("В каком секторе вы хотите лететь");
                        userSector = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (sectors.Length <= userSector || 0 > userSector)
                        {
                            Console.WriteLine("Такого сектора не существует");
                            break;
                        }
                        Console.WriteLine("Сколько мест вы хотите забронирвать");
                        userPlaceAmount = Convert.ToInt32(Console.ReadLine());

                        if(userPlaceAmount < 0)
                        {
                            Console.WriteLine("Неверно количесто мест");
                            break;
                        }
                        if (sectors[userSector] < userPlaceAmount )
                        {
                            Console.WriteLine($"В секторе {userSector} недостаточно мест \n" + 
                                $"Остаток {sectors[userSector]}" );
                        break;
                        }
                        sectors[userSector] -= userPlaceAmount;
                        Console.WriteLine("успешно загиристривано");
                        break;


                    case 2:
                        isOpen = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
           

          
            

        }
    }
}
