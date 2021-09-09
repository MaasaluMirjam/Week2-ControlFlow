using System;

namespace WhenWereYouBorn
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //programm kuvab kasutaja vanust

            Console.WriteLine("Mis aastal sa oled sündinud?");
            int YearOfBirth = Convert.ToInt16(Console.ReadLine());

            int Age = 2021 - YearOfBirth;

            Console.WriteLine($"Sa oled {Age} aastat vana");
            Console.ReadLine();
            
        }
    }
}
