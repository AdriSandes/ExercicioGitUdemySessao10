
using System;
using System.Collections.Generic;
using Sessao11Exercicio1.Entities;
using Sessao11Exercicio1.Entities.Exceptions;

try
{
    Console.Write("Room number:");
    int roomNumber = int.Parse(Console.ReadLine());
    Console.Write("Check-in date (dd/MM/yyyy):");
    DateTime checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/MM/yyyy):");
    DateTime checkOut = DateTime.Parse(Console.ReadLine());
    Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
    Console.WriteLine(reservation);

    Console.WriteLine();
    Console.WriteLine("Enter data to update the reservation:");
    Console.Write("Check-in date (dd/MM/yyyy):");
    checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/MM/yyyy):");
    checkOut = DateTime.Parse(Console.ReadLine());
    reservation.UpdateDates(checkIn, checkOut);
    reservation = new Reservation(roomNumber, checkIn, checkOut);
    Console.WriteLine(reservation);

}
catch (FormatException e)
{
    Console.WriteLine("Error in format: " + e.Message);
}
catch (DomainException e)
{
    Console.WriteLine("Error in reservation: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Unexpected error: " + e.Message);
}


