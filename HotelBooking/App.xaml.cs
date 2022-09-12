using HotelBooking.Exceptions;
using HotelBooking.Models;
using HotelBooking.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HotelBooking
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            //var hotel = new Hotel("LDATuan");

            //const string userName = "LDAT";

            //try
            //{
            //    hotel.MakeReservation(new Reservation(userName, new RoomId(1, 1), new DateTime(2022, 1,1 ), new DateTime(2022, 1, 2)));
            //    hotel.MakeReservation(new Reservation($"{userName} 1", new RoomId(1, 1), new DateTime(2022, 1, 1), new DateTime(2022, 1, 4)));
            //}
            //catch (ReservationConflictException ex)
            //{
            //    Debug.WriteLine(ex.ExistingReservation.UserName);
            //    //throw;
            //}
            //var reservations = hotel.GetReservationsForUser(userName);

            MainWindow = new MainWindow() { DataContext = new MainViewModel()};

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
