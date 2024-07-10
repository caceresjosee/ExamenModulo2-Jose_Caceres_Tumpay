using Ejercicio1_After;
using System;

class Program
{
    static void Main(string[] args)
    {
         DateTime checkInDate = DateTime.Now;
         DateTime checkOutDate = checkInDate.AddDays(2);

        var booking = new Booking
        {

            Usuario = new Usuario
            {
                Nombres = "Jose Caceres",
                Email = "Caceres@gmail.com"
            },
            checkIn = checkInDate,
            checkOut = checkOutDate            
         };
        Console.WriteLine(new BookingService().Create(booking));
        Console.ReadLine();
    }
}