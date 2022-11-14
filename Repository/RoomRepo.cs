using HotelBooking_KristianJeremic_NETProgramutvecklare.Interfaces;
using HotelBooking_KristianJeremic_NETProgramutvecklare.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelBooking_KristianJeremic_NETProgramutvecklare.Repository
{
    internal class RoomRepo : IRepo<Room>
    {
        private HotelDBEntities _dbConnection;
        public RoomRepo()
        {
            _dbConnection = new HotelDBEntities();
        }
        public void Add(Room item)
        {
            try { _dbConnection.Rooms.Add(item); _dbConnection.SaveChanges(); }
            catch (Exception ex) { throw ex; }
        }

        public Room Get(int id)
        {
            try { return _dbConnection.Rooms.Find(id); }
            catch (Exception ex) { throw ex; }
        }

        public List<Room> GetAll()
        {
            try { return _dbConnection.Rooms.Include("RoomType").ToList(); }
            catch (Exception ex) { throw ex; }
        }

        public void Remove(Room item)
        {
            try { _dbConnection.Rooms.Remove(item); _dbConnection.SaveChanges(); }
            catch (Exception ex) { throw ex; }
        }
        public void Update(Room item)
        {
            try { _dbConnection.Entry(Get(item.ID)).CurrentValues.SetValues(item); _dbConnection.SaveChanges(); }
            catch (Exception ex) { throw ex; }
        }
    }
}
