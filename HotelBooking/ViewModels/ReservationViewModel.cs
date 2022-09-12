using HotelBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.ViewModels;

public class ReservationViewModel : ViewModelBase
{
    private readonly Reservation _reservation;

    public string UserName => _reservation.UserName;
    public string RoomId => _reservation.RoomId.ToString();
    public string StartDate => _reservation.StartTime.Date.ToString("d");
    public string EndDate => _reservation.EndTime.Date.ToString("d");

    public ReservationViewModel(Reservation reservation)
    {
        _reservation = reservation;
    }
}
