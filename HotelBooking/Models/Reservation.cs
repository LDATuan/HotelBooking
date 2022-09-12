using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Models;

public class Reservation
{
    public string UserName { get; }
    public RoomId RoomId { get; }
    public DateTime StartTime { get; }
    public DateTime EndTime { get; }
    public TimeSpan Length => EndTime.Subtract(StartTime);

    public Reservation(string userName, RoomId roomId, DateTime startTime, DateTime endTime)
    {
        UserName = userName;
        RoomId = roomId;
        StartTime = startTime;
        EndTime = endTime;
    }

    public bool Conflicts(Reservation reservation)
    {
        if (reservation.RoomId != this.RoomId)
        {
            return false;
        }
        //
        return reservation.StartTime < this.EndTime && reservation.EndTime > this.StartTime;
    }
}
