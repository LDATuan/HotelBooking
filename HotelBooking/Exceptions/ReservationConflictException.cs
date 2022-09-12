using HotelBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Exceptions;

public class ReservationConflictException : Exception
{
    public Reservation ExistingReservation { get; }
    public Reservation ImCommingReservation { get; }

    public ReservationConflictException(Reservation existingReservation, Reservation imCommingReservation)
    {
        ExistingReservation = existingReservation;
        ImCommingReservation = imCommingReservation;
    }

    public ReservationConflictException(string? message, Reservation existingReservation, Reservation imCommingReservation) : base(message)
    {
        ExistingReservation = existingReservation;
        ImCommingReservation = imCommingReservation;
    }

    public ReservationConflictException(string? message, Exception? innerException, Reservation existingReservation, Reservation imCommingReservation) : base(message, innerException)
    {
        ExistingReservation = existingReservation;
        ImCommingReservation = imCommingReservation;
    }
}
