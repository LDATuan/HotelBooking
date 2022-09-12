using HotelBooking.Exceptions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Models;

public class ReservationBook
{
    private readonly List<Reservation> _reservations;

    public ReservationBook()
    {
        _reservations = new List<Reservation>();
    }

    public IEnumerable<Reservation> GetReservationsForUser(string userName)
    {
        return _reservations.Where(r => r.UserName == userName);
    }

    public void AddReservation(Reservation reservation)
    {
        foreach (var existingReservation in _reservations)
        {
            if (existingReservation.Conflicts(reservation))
            {
                throw new ReservationConflictException(existingReservation, reservation);
            }
        }
        
        _reservations.Add(reservation); 
    }
}
