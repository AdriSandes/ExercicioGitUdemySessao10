using Sessao11Exercicio1.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessao11Exercicio1.Entities;

internal class Reservation
{
   

    public int RoomNumber { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public Reservation()
    {
    }

    public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
    {
        DateTime now = DateTime.Now;
        if (checkIn < now || checkOut < now)
        {
            throw new DomainException("Reservation dates must be future dates");
        }
        else if (checkOut<checkIn)
        {
            throw new DomainException("Check-out date must be after check-in date");
        }
        RoomNumber = roomNumber;
        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public void UpdateDates(DateTime checkIn, DateTime checkOut)
    {
        DateTime now = DateTime.Now;
        if (checkIn < now || checkOut < now)
        {
            throw new DomainException("Reservation dates for update must be future dates");
        }
        else if (checkOut <= checkIn)
        {
            throw new DomainException("Check-out date must be after check-in date");
        }
        CheckIn = checkIn;
        CheckOut = checkOut;
    }
    public int Duration()
    {
            
        TimeSpan duration = CheckOut.Subtract(CheckIn);
        return (int)duration.TotalDays;
    }

    public override string ToString()
    {
        return $"Reservation: Room {RoomNumber}, Checkin: {CheckIn.ToString("dd/MM/yyyy")}, Checkout: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} dias";   
    }
    
}
