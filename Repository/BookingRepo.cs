using HotelBooking_KristianJeremic_NETProgramutvecklare.Interfaces;
using HotelBooking_KristianJeremic_NETProgramutvecklare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

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
        //Sets all bold letters on calender in the beginning
        public DateTime[] GetBookedDates
        {
            //This compares all the dates with all the bookings to show all free dates
            //So all dates that intersect get removed.
            get
            {
                //First check if there is any room without any bookings
                if (new RoomRepo().GetAll().Count()>GetAll().Select(x => x.RoomID).Count())
                {
                    return new DateTime[0];
                }

                var bookings = GetAll();
                var datesBookedFirstRoom = new List<DateTime>();
                var datesBookedSecondRoom = new List<DateTime>();

                var datesBooked = new List<DateTime>();

                int indexFirst = 0;
                int indexSecond = 0;

                foreach (var datesOne in bookings)
                {
                    for (var date = datesOne.StartDate; date <= datesOne.EndDate.AddDays(-1); date = date.AddDays(1))
                    {
                        datesBookedFirstRoom.Add(date);
                    }
                    foreach (var CompareDates in bookings)
                    {
                        if (indexFirst != indexSecond)
                        {
                            for (var date = CompareDates.StartDate; date <= CompareDates.EndDate.AddDays(-1); date = date.AddDays(1))
                            {
                                if (datesBookedFirstRoom.Contains(date))
                                {
                                    datesBookedFirstRoom.Remove(date);
                                }
                            }
                        }
                        indexSecond++;
                    }
                    indexFirst++;
                }


                return datesBookedFirstRoom.ToArray();
            }
        }
        public List<Room> GetAvailableRooms(DateTime startDate, DateTime endDate,int spots)
        {
            var datesToCheck = new List<DateTime>();

            
            var rooms = new RoomRepo().GetAll();

            for (var date = startDate; date <= endDate.AddDays(-1); date = date.AddDays(1))
            {
                datesToCheck.Add(FormatDateTime(date));
            }

            foreach (var item in GetAll())
            {
                for (var date = FormatDateTime(item.StartDate); date <= item.EndDate.AddDays(-1); date = date.AddDays(1))
                {
                    if (datesToCheck.Contains(date))
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
    }
}
