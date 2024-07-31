using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int piopleInHospital;
            int timePerPersone = 10;
            int hoursBeforeAppointment;
            int minutesBeforAppointment;
            int minutesInHour = 60;

            Console.WriteLine("Введите количество человек в очереди");
            piopleInHospital = Convert.ToInt32(Console.ReadLine());
            int allPersonesTime = piopleInHospital * timePerPersone;
            hoursBeforeAppointment = allPersonesTime / minutesInHour;
            minutesBeforAppointment = allPersonesTime % minutesInHour;

            Console.WriteLine($"Вам осталось подождать {hoursBeforeAppointment} часов и {minutesBeforAppointment} минут");
            Console.ReadKey();
        }
    }
}
