using HotelBooking_KristianJeremic_NETProgramutvecklare.Interfaces;
using HotelBooking_KristianJeremic_NETProgramutvecklare.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelBooking_KristianJeremic_NETProgramutvecklare.Repository
{
    internal class BookingRepo : IRepo<Booking>
    {
        private HotelDBEntities _dbConnection;
        private int _checkInTime;
        private int _checkOutTime;
        public BookingRepo()
        {
            _dbConnection = new HotelDBEntities();
            _checkInTime = 14;
            _checkOutTime = 11;
        }
        public void Add(Booking item)
        {
            item.StartDate.AddHours(_checkInTime);
            item.EndDate.AddHours(_checkOutTime);
            try { _dbConnection.Bookings.Add(item); _dbConnection.SaveChanges(); }
            catch (Exception ex) { throw ex; }
        }

        public Booking Get(int id)
        {
            try { return _dbConnection.Bookings.Find(id); }
            catch (Exception ex) { throw ex; }
        }

        public List<Booking> GetAll()
        {
            try { return _dbConnection.Bookings.Include("Room").ToList(); }
            catch (Exception ex) { throw ex; }
        }

        public void Remove(Booking item)
        {
            try { _dbConnection.Bookings.Remove(item); _dbConnection.SaveChanges(); }
            catch (Exception ex) { throw ex; }
        }

        public void Update(Booking item)
        {
            item.StartDate.AddHours(_checkInTime);
            item.EndDate.AddHours(_checkOutTime);
            try { _dbConnection.Entry(Get(item.ID)).CurrentValues.SetValues(item); }
            catch (Exception ex) { throw ex; }
        }
        public DateTime[] GetBookedDates
        {
            get
            {
                var bookings = GetAll();
                var datesBookedFirstRoom = new List<DateTime>();
                var datesBookedSecondRoom = new List<DateTime>();

                var dateBooked = new List<DateTime>();

                foreach (var booking in bookings)
                {
                    for (var date = booking.StartDate; date <= booking.EndDate; date = date.AddDays(1))
                    {
                        datesBookedFirstRoom.Add(date);
                    }
                    foreach (var bookingInt in bookings)
                    {
                        
                    }
                }

                return datesBooked.ToArray();
            }
        }
        public DateTime[] GetAvailbleDates(DateTime startDate, DateTime Endate)
        {

            var bookings = GetAll();
            var datesBooked = new List<DateTime>();
            foreach (var booking in bookings)
            {
                for (var date = booking.StartDate; date <= booking.EndDate.AddDays(-1); date = date.AddDays(1))
                {
                    datesBooked.Add(date);
                }
            }
            var datesAvailable = new List<DateTime>();
            for (var date = startDate; date <= Endate.AddDays(-1); date = date.AddDays(1))
            {
                if (!datesBooked.Contains(date))
                {
                    datesAvailable.Add(date);
                }
            }
            return datesAvailable.ToArray();

        }
        public DateTime[] CheckRoomAvailability
        {
            get
            {
                foreach (var item in GetBookedDates)
                {

                }






                return new DateTime[1];
            }
        }
    }
}
