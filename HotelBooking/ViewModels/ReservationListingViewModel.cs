using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotelBooking.ViewModels;

public class ReservationListingViewModel: ViewModelBase
{
	private ObservableCollection<ReservationViewModel> _reservations;

	public IEnumerable<ReservationViewModel> Reservations => _reservations;

	public ICommand  MakeReservationCommand { get; set; }

	public ReservationListingViewModel()
	{
		_reservations = new ObservableCollection<ReservationViewModel>();
		_reservations.Add(new ReservationViewModel(new Models.Reservation("a", new Models.RoomId(1, 1), new DateTime(2022, 1, 1), new DateTime(2022, 1, 6))));
		_reservations.Add(new ReservationViewModel(new Models.Reservation("b", new Models.RoomId(1, 2), new DateTime(2022, 1, 2), new DateTime(2022, 1, 7))));
		_reservations.Add(new ReservationViewModel(new Models.Reservation("c", new Models.RoomId(1, 4), new DateTime(2022, 1, 3), new DateTime(2022, 1, 8))));

    }
}
