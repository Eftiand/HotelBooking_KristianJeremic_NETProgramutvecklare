using HotelBooking_KristianJeremic_NETProgramutvecklare.Interfaces;
using HotelBooking_KristianJeremic_NETProgramutvecklare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            item.StartDate = new DateTime(item.StartDate.Year, item.StartDate.Month, item.StartDate.Day, 0, _checkInTime, 0);
            item.EndDate = new DateTime(item.EndDate.Year, item.EndDate.Month, item.EndDate.Day, 0, _checkOutTime, 0);
            try
            {
                if (item.CustomerID == GetAll().Where(x => x.StartDate >= item.StartDate && x.EndDate <= item.EndDate).Select(x => x.CustomerID).FirstOrDefault())
                {
                    throw new Exception("Customer already has a booking for this period");
                }
                _dbConnection.Bookings.Add(item);
                _dbConnection.SaveChanges();

                var invoiceRepo = new InvoiceRepo();

                invoiceRepo.Add(new Invoice()
                {
                    BookingID = item.ID,
                    Paid = false,
                    LastDayToPay = DateTime.Today.AddDays(10)
                });
            }
            catch (Exception ex) { throw ex; }
        }

        public Booking Get(int id)
        {
            try { return _dbConnection.Bookings.Find(id); }
            catch (Exception ex) { throw ex; }
        }

        public List<Booking> GetAll()
        {
            try { return _dbConnection.Bookings.ToList(); }
            catch (Exception ex) { throw ex; }
        }

        public void Remove(Booking item)
        {
            try { _dbConnection.Bookings.Remove(item); _dbConnection.SaveChanges(); }
            catch (Exception ex) { throw ex; }
        }
        public void Remove(int item)
        {
            try { _dbConnection.Bookings.Remove(GetAll().Where(x=>x.ID==item).FirstOrDefault()); _dbConnection.SaveChanges(); }
            catch (Exception ex) { throw ex; }
        }
        public void Update(Booking item)
        {
            item.StartDate.AddHours(_checkInTime);
            item.EndDate.AddHours(_checkOutTime);
            
            if (GetAll().Where(x => x.RoomID == item.RoomID && item.CustomerID != x.CustomerID && item.StartDate<=x.StartDate &&x.EndDate<=item.EndDate).Count() > 0)
            {
                throw new Exception("Room is already booked for this period");
            }

            try { _dbConnection.Entry(Get(item.ID)).CurrentValues.SetValues(item); }
            catch (Exception ex) { throw ex; }
        }
        //Sets all bold letters on calender in the beginning
        public DateTime[] GetBookedDates
        {
            //This compares all the dates with all the bookings to show all free dates
            //So all dates that intersect get removed.
            get
            {

                var bookings = GetAll();

                var minDate = bookings.OrderBy(x=>x.StartDate).Select(x => x.StartDate).FirstOrDefault();
                var maxDate = bookings.OrderByDescending(x => x.EndDate).Select(x => x.EndDate).FirstOrDefault();

                var listToSendBack = GetDates(minDate, maxDate);

                foreach (var item in GetDates(minDate, maxDate))
                {
                    int counter = 0;
                    
                    foreach (var booking in bookings)
                    {
                        var tempDates = GetDates(booking.StartDate, booking.EndDate);

                        if (!tempDates.Contains(item))
                            counter++;
                    }

                    var roomTemp = new RoomRepo().GetAll();

                    if(counter>=roomTemp.Count())
                        listToSendBack.Remove(item);

                }

                return listToSendBack.ToArray();
            }
        }
        public List<Room> GetAvailableRooms(DateTime startDate, DateTime endDate, int spots)
        {


            var rooms = new RoomRepo().GetAll();

            var spanDates = GetDates(startDate, endDate);

            foreach (var item in GetAll())
            {
                for (var date = FormatDateTime(item.StartDate); date <= item.EndDate.AddDays(-1); date = date.AddDays(1))
                {
                    if (spanDates.Contains(date))
                    {
                        //Deletes the first instance of room if any date overlaps
                        Room tempRoom = rooms.Where(x => x.ID == item.RoomID)
                            .FirstOrDefault();
                        rooms.Remove(tempRoom);
                        break;
                    }
                }
            }
            var result = rooms.Where(x => (x.RoomType.Spots + x.RoomType.AvailbleExtraBeds) >= spots).ToList();


            return result;
        }
        private DateTime FormatDateTime(DateTime item)
        {
            return new DateTime(item.Year, item.Month, item.Day, 0, 0, 0);
        }
        private List<DateTime> GetDates(DateTime startDate, DateTime endDate)
        {
            var dates = new List<DateTime>();
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                dates.Add(FormatDateTime(date));
            }
            return dates;
        }
    }
}
